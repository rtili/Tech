using System.Collections;
using System.Collections.Generic;
using Unity.Services.Authentication;
using Unity.Services.Core;
using UnityEngine;

public class ServicesAuth : MonoBehaviour
{
    private async void Start()
    {
        await UnityServices.InitializeAsync();
        if (AuthenticationService.Instance.IsAuthorized == false)
        {
            await AuthenticationService.Instance.SignInAnonymouslyAsync();
            print("Success Auth");
        }        
        else if (AuthenticationService.Instance.IsAuthorized == true && AuthenticationService.Instance.IsSignedIn == true)
            print("Already Auth");
        else
            print("Failed Auth");
    }
}
