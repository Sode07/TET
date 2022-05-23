using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelection : MonoBehaviour
{
    private Transform MovePos;
    public GameObject Selection;

    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("hiiri alas");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, 1000))
            {
                Debug.Log("säde ulos");
                if (hit.transform.tag == "Unit")
                {
                    Selection = hit.transform.gameObject;
                    Debug.Log("Osui ja upposi");
                }
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("hiiri 1 alas");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000))
            {
                Debug.Log("säde 1 ulos");
                if (hit.transform.tag == "Tile")
                {
                    Selection.transform.position = hit.transform.position;
                    Debug.Log("Osui ja liikkui");
                }
            }
        }

    }
}
