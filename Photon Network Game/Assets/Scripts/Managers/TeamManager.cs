using Photon.Pun;
using Photon.Realtime;
using Photon.Pun.UtilityScripts;
using UnityEngine;

public class TeamManager : MonoBehaviourPunCallbacks
{
    void Start()
    {
        PhotonNetwork.LocalPlayer.AddScore(10);
    }

 
}
