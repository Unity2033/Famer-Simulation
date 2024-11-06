using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;

public class SignUp : PopUp
{
    [SerializeField] InputField emailInputField;
    [SerializeField] InputField nickNameInputField;
    [SerializeField] InputField passwordInputField;

    public void Success(RegisterPlayFabUserResult registerPlayFabUserResult)
    {
        Debug.Log(registerPlayFabUserResult.ToString());
    }

    public void Failure(PlayFabError playFabError)
    {
        PopUpManager.Instance.Show(PopupType.TEXT, playFabError.GenerateErrorReport());
    }


    public override void OnConfirm()
    {
        var request = new RegisterPlayFabUserRequest
        {
            Email = emailInputField.text,
            Password = passwordInputField.text,
            Username = nickNameInputField.text,
        };

        PlayFabClientAPI.RegisterPlayFabUser
        (
            request,
            Success,
            Failure
        );

        gameObject.SetActive(false);
    }
}
