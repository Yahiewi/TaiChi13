using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    float inputX, inputZ;

    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");

        if (inputX != 0)
            moveSideways();

        if (inputZ != 0)
            moveForward();
    }

    private void moveForward()
    {
        transform.position += 5*transform.forward * inputZ * Time.deltaTime;
    }

    private void moveSideways()
    {
        transform.position += 5*transform.right * inputX * Time.deltaTime;
    }
}