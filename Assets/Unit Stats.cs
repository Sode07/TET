using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitStats : MonoBehaviour
{
    public float MoveRange;
    public float AttackRange;
    public float AttackDmg;
    public float SightRange;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tile"))
        {
            MeshCollider collider = other.GetComponent<MeshCollider>();
        }
    }
}
