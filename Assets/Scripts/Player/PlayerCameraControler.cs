using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraControler : MonoBehaviour
{

    public float mouseSens = 100f;
    Transform player;
    float xRotation;




    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        player = transform.parent;
        //float xRotation;

    }

    // Update is called once per frame
    void Update()
    {
        float Mousex = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float Mousey = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;
        player.Rotate(Vector3.up, Mousex);

        xRotation -= Mousey;
        xRotation = Mathf.Clamp(xRotation, -75, 75);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);






    }
}
