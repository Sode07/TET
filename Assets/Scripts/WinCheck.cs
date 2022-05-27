using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCheck : MonoBehaviour
{
    public GameObject base1;
    public GameObject base2;
    public GameObject Win1;
    public GameObject Win2;

    // Update is called once per frame
    void Update()
    {
        if (!base1.activeInHierarchy)
        {
            Win1.SetActive(true);
        }
        if (!base2.activeInHierarchy)
        {
            Win2.SetActive(true);
        }
    }
}
