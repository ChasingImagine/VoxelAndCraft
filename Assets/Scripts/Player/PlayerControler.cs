using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    CharacterController CC;
    public float speed  = 12.0f;
    public float gravity = -9.81f;
    public Vector3 velocity;
    public float jumpHeight = 5f;

    public float mass = 10f;
    public Transform graundCheck;
    public float graundDistance = 0.4f;
    public LayerMask Gaound;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        CC= GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(graundCheck.position, graundDistance, Gaound);
        if(velocity.y <0 && isGrounded)
        {
            velocity.y = -1;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right* x +transform.forward *z ;
        CC.Move(move* speed * mass * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        CC.Move(velocity * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) {

            velocity.y = Mathf.Sqrt(gravity * -2 * jumpHeight);
        
        }


    }
}
