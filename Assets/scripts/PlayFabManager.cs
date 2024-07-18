using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;

public class PlayFabManager : MonoBehaviour
{
    [Header("UI")]
    public Text messageText;
    public InputField emailInput;
    public InputField passwordInput;

    public void RegisterButton()
    {
        var request = new RegisterPlayFabUserRequest()
        {
            Email = emailInput.text,
            Password = passwordInput.text,
            RequireBothUsernameAndEmail = false
        };
       // PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess);
    }

    void OnRegisterSuccess(RegisterPlayFabUserRequest result)
    {
        messageText.text = "registered and logged in";

    }
}
