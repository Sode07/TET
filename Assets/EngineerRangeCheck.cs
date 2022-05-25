using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineerRangeCheck : MonoBehaviour
{
    public GameObject BuildButton;
    public GameObject BuildButton1;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter!");
        if (other.CompareTag("Unit"))
        {
            Debug.Log("Active!");
            if(other.gameObject.layer == 6)
            {
                BuildButton.SetActive(true);
            }
            if (other.gameObject.layer == 8)
            {
                BuildButton1.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit!");
        if (other.CompareTag("Unit"))
        {
            Debug.Log("Active!");
            BuildButton.SetActive(false);
            BuildButton1.SetActive(false);
        }
    }
}
