using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{

    public float mouseSesetivity;
    private Transform _body;

    private float xRotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (_body == null)
            return;

        horizontalRotation();
        verticalRotation();
    }


    void verticalRotation()
    {
        float mouseY = InputManager.Instance.GetControls().Camera.Y_axis.ReadValue<float>() * mouseSesetivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        transform.localRotation = Quaternion.Euler(xRotation, _body.localRotation.y, 0);
        //transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(xRotation, _body.localEulerAngles.y, 0), 10f * Time.deltaTime);
    }

    void horizontalRotation()
    {
        float mouseX = InputManager.Instance.GetControls().Camera.X_axis.ReadValue<float>() * mouseSesetivity * Time.deltaTime;
        _body.Rotate(Vector3.up * mouseX);
    }

    public void SetPreset(PlayerMovement player)
    {
        _body = player.transform;

    }

    public void ResetBody()
    {
        _body = null;
        transform.parent = null;
    }
}