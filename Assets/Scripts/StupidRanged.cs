using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class StupidRanged : MonoBehaviour
{
    public UnitSelection US;
    public ActionPoints AP;

    public Transform spawnPos;

    public void SummonRanged()
    {
        Debug.Log("Nyt ei mee hyvin");
        if (AP.ColourIsGreen)
        {
            Debug.Log("BBBBBB");
            if (AP.actionPoints >= 1)
            {
                PhotonNetwork.Instantiate("Ranged", spawnPos.position, spawnPos.rotation);
                AP.actionPoints -= 1;
            }
        }
        else
        {
            Debug.Log("BBBBBB");
            if (AP.actionPoints >= 1)
            {
                PhotonNetwork.Instantiate("Ranged Green", spawnPos.position, spawnPos.rotation);
                AP.actionPoints -= 1;
            }
        }
    }
}
