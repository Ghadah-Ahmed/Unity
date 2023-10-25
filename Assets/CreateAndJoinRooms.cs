using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{

    public InputField join;
    public InputField create;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(create.text);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(join.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
