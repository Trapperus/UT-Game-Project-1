using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairFollower : MonoBehaviour
{
    public Transform crosshairTarget;
    public float sensitivity;

    void Update()
    {
        float cameraMoveHorizontal = Input.GetAxis("Mouse X");
        float cameraMoveVertical = Input.GetAxis("Mouse Y");

        // Calculate the movement amount based on camera movement
        Vector3 moveAmount = new Vector3(-cameraMoveHorizontal, -cameraMoveVertical, 0) * sensitivity;

        // Apply the movement to the crosshair
        transform.Translate(moveAmount, Space.Self);

        // Smoothly move the crosshair back to the crosshair target
        transform.position = Vector3.Lerp(transform.position, crosshairTarget.position, 5.0f * Time.deltaTime);
    }
}
