using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StabilizeRotation : MonoBehaviour
{

    void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0);
    }
}