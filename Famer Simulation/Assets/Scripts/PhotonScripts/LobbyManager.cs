using UnityEngine;
using Photon.Realtime;
using Photon.Pun;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    [SerializeField] string lobbyName;

    private void Awake()
    {
        lobbyName = "Service";

        Connect();
    }

    public void Connect()
    {
        // ������ �����ϴ� �Լ�
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        // JoinLobby : Ư�� �κ� �����Ͽ� �����ϴ� �Լ�
        PhotonNetwork.JoinLobby
        (
           new TypedLobby
           (
               lobbyName,
               LobbyType.Default
           )
        );
    }
}