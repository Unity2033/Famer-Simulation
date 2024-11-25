using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonManager : MonoPunSingletonManager<PhotonManager>
{
    public void SetPlayerName(string playerName)
    {
        PhotonNetwork.NickName = playerName;
    }
}
