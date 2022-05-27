using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Input.GetAxis("Mouse ScrollWheel") * 10);
    }
}
