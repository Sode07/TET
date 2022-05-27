using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public float MoveRange;
    public float AttackRange;
    public float AttackDmg;
    public float SightRange;
    public float HP;

    private void Update()
    {
        if(HP <= 0)
        {
            if (this.gameObject.CompareTag("Base"))
            {
                this.gameObject.SetActive(false);
            }
            else Destroy(this.gameObject);
        }
    }
}

