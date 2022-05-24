using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionPoints : MonoBehaviour
{
    public float actionPoints = 1;
    public float MaxActionPoints = 1;

    public GameObject Melee;
    public GameObject Ranged;
    public GameObject Engineer;
    public GameObject RadioTower;

    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public GameObject Text6;
    public GameObject Text7;
    public GameObject Text8;
    public GameObject Text9;

    public Transform spawnPos;
    public Transform BuildPos1;
    public Transform BuildPos2;
    public Transform BuildPos3;
    public Transform BuildPos4;
    public Transform BuildPos5;
    public Transform BuildPos6;
    public Transform BuildPos7;
    public Transform BuildPos8;
    public Transform BuildPos9;

    public Text ApTXT;

    public UnitSelection US;

    private GameObject x;

    private void FixedUpdate()
    {
        ApTXT.text = "AP" + actionPoints.ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            actionPoints = MaxActionPoints;
            US.isWhiteTurn = true;
        }
    }

    public void SummonMelee()
    {
        if (actionPoints >= 1)
        {
            Instantiate(Melee, spawnPos.position, spawnPos.rotation);
            actionPoints -= 1;
        }
    }
    public void SummonRanged()
    {
        if (actionPoints >= 1)
        {
            Instantiate(Ranged, spawnPos.position, spawnPos.rotation);
            actionPoints -= 1;
        }
    }
    public void SummonEngineer()
    {
        if (actionPoints >= 1)
        {
            Instantiate(Engineer, spawnPos.position, spawnPos.rotation);
            actionPoints -= 1;
        }
    }
    public void BuildRadioTower1()
    {
        if (actionPoints == MaxActionPoints)
        {
            x = Instantiate(RadioTower, BuildPos1.position, BuildPos1.rotation);
            actionPoints -= MaxActionPoints;
            MaxActionPoints += 1;
            Destroy(BuildPos1.gameObject);
            Destroy(Text1);
        }
    }
    public void BuildRadioTower2()
    {
        if (actionPoints == MaxActionPoints)
        {
            x = Instantiate(RadioTower, BuildPos2.position, BuildPos2.rotation);
            actionPoints -= MaxActionPoints;
            MaxActionPoints += 1;
            Destroy(Text2);
        }
    }
    public void BuildRadioTower3()
    {
        if (actionPoints == MaxActionPoints)
        {
            x = Instantiate(RadioTower, BuildPos3.position, BuildPos3.rotation);
            actionPoints -= MaxActionPoints;
            MaxActionPoints += 1;
            Destroy(Text3);
        }
    }
    public void BuildRadioTower4()
    {
        if (actionPoints == MaxActionPoints)
        {
            x = Instantiate(RadioTower, BuildPos4.position, BuildPos4.rotation);
            actionPoints -= MaxActionPoints;
            MaxActionPoints += 1;
            Destroy(Text4);
        }
    }
    public void BuildRadioTower5()
    {
        if (actionPoints == MaxActionPoints)
        {
            x = Instantiate(RadioTower, BuildPos5.position, BuildPos5.rotation);
            actionPoints -= MaxActionPoints;
            MaxActionPoints += 1;
            Destroy(Text5);
        }
    }    
    public void BuildRadioTower6()
    {
        if (actionPoints == MaxActionPoints)
        {
            x = Instantiate(RadioTower, BuildPos6.position, BuildPos6.rotation);
            actionPoints -= MaxActionPoints;
            MaxActionPoints += 1;
            Destroy(Text6);
        }
    }
    public void BuildRadioTower7()
    {
        if (actionPoints == MaxActionPoints)
        {
            x = Instantiate(RadioTower, BuildPos7.position, BuildPos7.rotation);
            actionPoints -= MaxActionPoints;
            MaxActionPoints += 1;
            Destroy(Text7);
        }
    }
    public void BuildRadioTower8()
    {
        if (actionPoints == MaxActionPoints)
        {
            x = Instantiate(RadioTower, BuildPos8.position, BuildPos8.rotation);
            actionPoints -= MaxActionPoints;
            MaxActionPoints += 1;
            Destroy(Text8);
        }
    }
    public void BuildRadioTower9()
    {
        if (actionPoints == MaxActionPoints)
        {
            x = Instantiate(RadioTower, BuildPos9.position, BuildPos9.rotation);
            actionPoints -= MaxActionPoints;
            MaxActionPoints += 1;
            Destroy(Text9);
        }
    }
}
