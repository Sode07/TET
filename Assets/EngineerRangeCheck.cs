using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineerRangeCheck : MonoBehaviour
{
    public GameObject BuildButton;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter!");
        if (other.CompareTag("Unit"))
        {
            Debug.Log("Active!");
            BuildButton.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Enter!");
        if (other.CompareTag("Unit"))
        {
            Debug.Log("Active!");
            BuildButton.SetActive(true);
        }
    }
}
