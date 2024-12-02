using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhotonManager : MonoPunSingletonManager<PhotonManager>
{
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
}
