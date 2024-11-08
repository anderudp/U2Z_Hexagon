using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    float rotSpeed = 30f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotSpeed * Time.deltaTime);
    }
}
