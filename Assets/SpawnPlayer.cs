using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviourPunCallbacks
{

    public GameObject prefabPlayer;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;


    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();

        Vector2 randomPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        PhotonNetwork.Instantiate(prefabPlayer.name, randomPosition, Quaternion.identity);
    }

    public override void OnLeftRoom()
    {
        base.OnLeftRoom();

        PhotonNetwork.Destroy(prefabPlayer);
    }
}
