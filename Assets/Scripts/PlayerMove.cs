using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speedMove;
    public float speedUsual;
    public float speedFast;
    float xMove;
    float zMove;
    CharacterController player;
    Vector3 moveDirection;

    private void Start()
    {
        player = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Move();
    }

    void Move()
    {
        xMove = Input.GetAxis("Horizontal");
        zMove = Input.GetAxis("Vertical");
        if(player.isGrounded)
        {
            moveDirection = new Vector3(xMove, 0f, zMove);
            moveDirection = transform.TransformDirection(moveDirection);

            if (Input.GetKey(KeyCode.Space))
            {

            }
        }
        moveDirection.y -= 0.1f;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speedMove = speedFast;
        }
        else
        {
            speedMove = speedUsual;
        }

        player.Move(moveDirection * speedMove * Time.deltaTime);
    }
}
