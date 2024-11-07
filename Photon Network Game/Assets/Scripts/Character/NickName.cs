using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class NickName : MonoBehaviourPunCallbacks
{
    private Camera remoteCamera;
    [SerializeField] Text nickNameText;

    private void Awake()
    {
        PhotonNetwork.NickName = PlayerPrefs.GetString("NickName");
    }

    void Start()
    {
        remoteCamera = Camera.main;

        nickNameText.text = photonView.Owner.NickName;
    }

    private void Update()
    {
        transform.forward = remoteCamera.transform.forward;
    }

}
