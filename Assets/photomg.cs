using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class photomg : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions { MaxPlayers = 4 }, TypedLobby.Default );
    }
    public override void OnJoinedRoom()
    {
        Debug.Log("Join");
        PhotonNetwork.Instantiate("player", new Vector2(Random.Range(-8f, 11f), transform.position.y), Quaternion.identity);
    }
}
