using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class ActionPoints : MonoBehaviour
{
    public float actionPoints = 1;
    public float MaxActionPoints = 1;

    public bool ColourIsGreen;
    private bool GavePoints;

    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public GameObject Text6;
    public GameObject Text7;
    public GameObject Text8;
    public GameObject Text9;
    public GameObject TurnTurner;

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
        if (ColourIsGreen && US.isWhiteTurn == 1)
        {
            TurnTurner.gameObject.SetActive(true);
            if (!GavePoints)
            {
                actionPoints = MaxActionPoints;
            }
        }
        if (ColourIsGreen && US.isWhiteTurn == -1)
        {
            TurnTurner.gameObject.SetActive(false);
        }
        if (!ColourIsGreen && US.isWhiteTurn == 1)
        {
            TurnTurner.gameObject.SetActive(false);
        }
        if (!ColourIsGreen && US.isWhiteTurn == -1)
        {
            TurnTurner.gameObject.SetActive(true);
        }
    }
    [PunRPC]
    public void EndTurn()
    {
        US.isWhiteTurn *= -1;
    }

    public void BuildSchool()
    {
        if (actionPoints >= 1)
        {
            PhotonNetwork.Instantiate("Melee Green", US.Selection.transform.position, US.Selection.transform.rotation);
            actionPoints -= 1;
        }
    }
    
    public void SummonMelee()
    {
        if (ColourIsGreen) {
            Debug.Log("AAAAAA");
            if (actionPoints >= 1)
            {
                PhotonNetwork.Instantiate("Melee", spawnPos.position, spawnPos.rotation);
                actionPoints -= 1;
            }
        }
        else
        {
            Debug.Log("AAAAAA");
            if (actionPoints >= 1)
            {
                PhotonNetwork.Instantiate("Melee Green", spawnPos.position, spawnPos.rotation);
                actionPoints -= 1;
            }
        }
    }
    public void SummonRanged()
    {
        if (ColourIsGreen)
        {
            if (actionPoints >= 1)
            {
                PhotonNetwork.Instantiate("Ranged", spawnPos.position, spawnPos.rotation);
                actionPoints -= 1;
            }
        }
        else
        {
            if (actionPoints >= 1)
            {
                PhotonNetwork.Instantiate("Ranged Green", spawnPos.position, spawnPos.rotation);
                actionPoints -= 1;
            }
        }
    }
    public void SummonEngineer()
    {
        if (ColourIsGreen)
        {
            if (actionPoints >= 1)
            {
                PhotonNetwork.Instantiate("Engineer", spawnPos.position, spawnPos.rotation);
                actionPoints -= 1;
            }
        }
        else
        {
            if (actionPoints >= 1)
            {
                PhotonNetwork.Instantiate("Engineer Green", spawnPos.position, spawnPos.rotation);
                actionPoints -= 1;
            }
        }
    }
    public void BuildRadioTower1()
    {
        if (ColourIsGreen)
        {
            if (actionPoints == MaxActionPoints)
            {
                x = PhotonNetwork.Instantiate("RadioTower", BuildPos1.position, BuildPos1.rotation);
                actionPoints -= MaxActionPoints;
                MaxActionPoints += 1;
                Destroy(BuildPos1.gameObject);
                Destroy(Text1);
            }
        }
        else
        {
            if (actionPoints == MaxActionPoints)
            {
                x = PhotonNetwork.Instantiate("RadioTower Green", BuildPos1.position, BuildPos1.rotation);
                actionPoints -= MaxActionPoints;
                MaxActionPoints += 1;
                Destroy(BuildPos1.gameObject);
                Destroy(Text1);
            }
        }
    }
    public void BuildRadioTower2()
    {
        if (ColourIsGreen)
        {
            if (actionPoints == MaxActionPoints)
            {
                x = PhotonNetwork.Instantiate("RadioTower", BuildPos2.position, BuildPos2.rotation);
                actionPoints -= MaxActionPoints;
                MaxActionPoints += 1;
                Destroy(Text2);
            }
        }
        else
        {
            if (actionPoints == MaxActionPoints)
            {
                x = PhotonNetwork.Instantiate("RadioTower Green", BuildPos2.position, BuildPos2.rotation);
                actionPoints -= MaxActionPoints;
                MaxActionPoints += 1;
                Destroy(BuildPos2.gameObject);
                Destroy(Text2);
            }
        }
    }
    public void BuildRadioTower3()
    {
        if (ColourIsGreen)
        {
            if (actionPoints == MaxActionPoints)
            {
                x = PhotonNetwork.Instantiate("RadioTower", BuildPos3.position, BuildPos3.rotation);
                actionPoints -= MaxActionPoints;
                MaxActionPoints += 1;
                Destroy(Text3);
            }
        }
        else
        {
            if (actionPoints == MaxActionPoints)
            {
                x = PhotonNetwork.Instantiate("RadioTower Green", BuildPos3.position, BuildPos3.rotation);
                actionPoints -= MaxActionPoints;
                MaxActionPoints += 1;
                Destroy(BuildPos3.gameObject);
                Destroy(Text3);
            }
        }
    }
    public void BuildRadioTower4()
    {
        if (ColourIsGreen)
        {
            if (actionPoints == MaxActionPoints)
            {
                x = PhotonNetwork.Instantiate("RadioTower", BuildPos4.position, BuildPos4.rotation);
                actionPoints -= MaxActionPoints;
                MaxActionPoints += 1;
                Destroy(Text4);
            }
        }
        else
        {
            if (actionPoints == MaxActionPoints)
            {
                x = PhotonNetwork.Instantiate("RadioTower Green", BuildPos4.position, BuildPos4.rotation);
                actionPoints -= MaxActionPoints;
                MaxActionPoints += 1;
                Destroy(BuildPos1.gameObject);
                Destroy(Text4);
            }
        }
    }
    public void BuildRadioTower5()
    {
        if (ColourIsGreen)
        {
            if (actionPoints == MaxActionPoints)
            {
                x = PhotonNetwork.Instantiate("RadioTower", BuildPos5.position, BuildPos5.rotation);
                actionPoints -= MaxActionPoints;
                MaxActionPoints += 1;
                Destroy(Text5);
            }
        }
        else
        {
            if (actionPoints == MaxActionPoints)
            {
                x = PhotonNetwork.Instantiate("RadioTower Green", BuildPos5.position, BuildPos5.rotation);
                actionPoints -= MaxActionPoints;
                MaxActionPoints += 1;
                Destroy(BuildPos1.gameObject);
                Destroy(Text5);
            }
        }
    }    
    public void BuildRadioTower6()
    {
        if (ColourIsGreen)
        {
            if (actionPoints == MaxActionPoints)
            {
                x = PhotonNetwork.Instantiate("RadioTower", BuildPos6.position, BuildPos6.rotation);
                actionPoints -= MaxActionPoints;
                MaxActionPoints += 1;
                Destroy(Text6);
            }
        }
        else
        {
            if (actionPoints == MaxActionPoints)
            {
                x = PhotonNetwork.Instantiate("RadioTower Green", BuildPos6.position, BuildPos6.rotation);
                actionPoints -= MaxActionPoints;
                MaxActionPoints += 1;
                Destroy(BuildPos1.gameObject);
                Destroy(Text6);
            }
        }
    }
    public void BuildRadioTower7()
    {
        if (ColourIsGreen)
        {
            if (actionPoints == MaxActionPoints)
            {
                x = PhotonNetwork.Instantiate("RadioTower", BuildPos7.position, BuildPos7.rotation);
                actionPoints -= MaxActionPoints;
                MaxActionPoints += 1;
                Destroy(Text7);
            }
        }
        else
        {
            if (actionPoints == MaxActionPoints)
            {
                x = PhotonNetwork.Instantiate("RadioTower Green", BuildPos7.position, BuildPos7.rotation);
                actionPoints -= MaxActionPoints;
                MaxActionPoints += 1;
                Destroy(BuildPos1.gameObject);
                Destroy(Text7);
            }

        }
    }
    public void BuildRadioTower8()
    {
        if (ColourIsGreen)
        {
            if (actionPoints == MaxActionPoints)
            {
                x = PhotonNetwork.Instantiate("RadioTower", BuildPos8.position, BuildPos8.rotation);
                actionPoints -= MaxActionPoints;
                MaxActionPoints += 1;
                Destroy(Text8);
            }
        }
        else
        {
            if (actionPoints == MaxActionPoints)
            {
                x = PhotonNetwork.Instantiate("RadioTower Green", BuildPos8.position, BuildPos8.rotation);
                actionPoints -= MaxActionPoints;
                MaxActionPoints += 1;
                Destroy(BuildPos8.gameObject);
                Destroy(Text1);
            }
        }
    }
    public void BuildRadioTower9()
    {
        if (ColourIsGreen)
        {
            if (actionPoints == MaxActionPoints)
            {
                x = PhotonNetwork.Instantiate("RadioTower", BuildPos9.position, BuildPos9.rotation);
                actionPoints -= MaxActionPoints;
                MaxActionPoints += 1;
                Destroy(Text9);
            }
        }
        else
        {
            if (actionPoints == MaxActionPoints)
            {
                x = PhotonNetwork.Instantiate("RadioTower Green", BuildPos9.position, BuildPos9.rotation);
                actionPoints -= MaxActionPoints;
                MaxActionPoints += 1;
                Destroy(BuildPos1.gameObject);
                Destroy(Text9);
            }
        }
    }
}
