using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    void Start()
    {
        ConnectToServer2();
    }

    void ConnectToServer2()
    {
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Try to connect...");
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to server.");

        base.OnConnectedToMaster();
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 10;       
        roomOptions.IsVisible = true;      
        roomOptions.IsOpen = true;          

        PhotonNetwork.JoinOrCreateRoom("Room 1", roomOptions, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined a Room");

        base.OnJoinedRoom();
    }


    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log("A new Player joined the room.");
        base.OnPlayerEnteredRoom(newPlayer);
    }


}
