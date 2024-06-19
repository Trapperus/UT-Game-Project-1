using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class MouseLook : MonoBehaviour
{
    [Range(0f, 1000f)] public float mouseSensitivityX;
    [Range(0f, 1000f)] public float mouseSensitivityY;

    public Transform playerBody;

    float xRotation = 0f;

    public float maxXRotationDown;
    public float maxXRotationUp;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivityX * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivityY * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, maxXRotationDown, maxXRotationUp);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
