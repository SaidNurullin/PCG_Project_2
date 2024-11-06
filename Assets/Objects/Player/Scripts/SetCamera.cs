using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCamera : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        Camera camera = Camera.main;
        camera.transform.SetParent(parent);
        camera.transform.localPosition = offset;
        camera.GetComponent<CameraLook>().SetPreset(GetComponent<PlayerMovement>());
    }


}
