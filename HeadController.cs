using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadController : MonoBehaviour
{
    Transform head_tr;
    float MouseX;
    float MouseY;
    public float sens = 3f;
    int check = 0;
    public GameObject FirstCamera;
    public GameObject ThirdCamera;
    void Start()
    {
        head_tr = GetComponent<Transform>();
    }

    void Update()
    {
        MouseX = MouseX + Input.GetAxis("Mouse X") * sens;
        MouseY = MouseY - Input.GetAxis("Mouse Y") * sens;

        MouseY = Mathf.Clamp(MouseY, -90, 90);

        head_tr.rotation = Quaternion.Euler(MouseY, MouseX, 0);
        FindObjectOfType<PlayerController>().Poluchatel(MouseX);

        if(Input.GetKeyDown("c"))
        {
            if(check==0)
            {
                check=1;
                ThirdCamera.SetActive(true);
                FirstCamera.SetActive(false);
            } else {
                check=0;
                FirstCamera.SetActive(true);
                ThirdCamera.SetActive(false);
            }
        }
    }
}
