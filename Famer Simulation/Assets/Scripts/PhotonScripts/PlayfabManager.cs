using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using PlayFab.ClientModels;
using PlayFab;

public class PlayfabManager : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_InputField emailInput;
    [SerializeField] TMP_InputField passwordInput;
    [SerializeField] TextMeshProUGUI AlarmText;

    public void Success(LoginResult result)
    {
        PhotonNetwork.AutomaticallySyncScene = false;

        PhotonNetwork.GameVersion = "1.0f";

        //PhotonNetwork.LoadLevel("Photon Lobby");

        AsyncSceneLoadManager.Instance.AsyncSceneLoad("Photon Lobby");
    }

    public void Success(RegisterPlayFabUserResult result)
    {
        AlarmText.text = "(Dummy) Register Success!";
    }

    public void SignUp()
    {
        var request = new RegisterPlayFabUserRequest
        {
            Email = emailInput.text,
            Password = passwordInput.text,
            RequireBothUsernameAndEmail = false,
            
        };

        PlayFabClientAPI.RegisterPlayFabUser
        (
            request,
            Success,
            Failure
        );
    }

    public void LogIn()
    {
        var request = new LoginWithEmailAddressRequest
        {
            Email = emailInput.text,
            Password = passwordInput.text,
        };

        PlayFabClientAPI.LoginWithEmailAddress
        (
            request, Success, Failure
        );
    }

    public void Failure(PlayFabError error)
    {
        AlarmText.text = error.ErrorMessage;
    }
}
