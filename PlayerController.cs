using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    float v;
    float h;
    float hv;
    float lhv;
    float brhv;
    float blhv;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");
        hv = h+v;
        lhv = -(h-v);
        brhv = -(v-h);
        blhv = (h*v);
        anim.SetFloat("runF", v);
        anim.SetFloat("runR", h);
        anim.SetFloat("runFS", hv);
        anim.SetFloat("runFSL", lhv);
        anim.SetFloat("runBS", brhv);
        anim.SetFloat("runBSL", blhv);
        if(Input.GetKeyDown("space"))
        {
            anim.SetTrigger("attack");
        }
    }

    public void Poluchatel(float arg) 
    {
        transform.rotation = Quaternion.Euler(0,arg,0);
    }
}
