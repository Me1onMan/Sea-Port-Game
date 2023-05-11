using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseMove : MonoBehaviour
{
    float xRotation;
    float yRotation;
    float xRotationCurrent;
    float yRotationCurrent;
    public Camera player;
    public GameObject playerGameObject;
    public float sensivity = 7f;
    public float smoothTime = 0.1f;
    float currentVelocityX;
    float currentVelocityY;

    private void Update()
    {
        MouseMove();
    }

    void MouseMove()
    {
        xRotation += Input.GetAxis("Mouse X") * sensivity * Time.fixedDeltaTime;
        yRotation += Input.GetAxis("Mouse Y") * sensivity * Time.fixedDeltaTime;
        yRotation = Mathf.Clamp(yRotation, -90, 90);

        //xRotationCurrent = Mathf.SmoothDamp(xRotationCurrent, xRotation, ref currentVelocityX, smoothTime);
        //yRotationCurrent = Mathf.SmoothDamp(yRotationCurrent, yRotation, ref currentVelocityY, smoothTime);

        playerGameObject.transform.rotation = Quaternion.Euler(0f, xRotation, 0f);
        player.transform.rotation = Quaternion.Euler(-yRotation, xRotation, 0f);
    }
}
