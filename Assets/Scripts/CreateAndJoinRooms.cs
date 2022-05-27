using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField CreateInput;
    public InputField JoinInput;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(CreateInput.text);
    }

    public void joinRoom()
    {
        PhotonNetwork.JoinRoom(JoinInput.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel(2);
    }
}
