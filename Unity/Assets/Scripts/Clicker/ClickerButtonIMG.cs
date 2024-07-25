using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using static System.Net.WebRequestMethods;

public class ClickerButtonIMG : MonoBehaviour
{
    [SerializeField] private string _url;
    [SerializeField] private Button _clickButton;

    void Start()
    {
        StartCoroutine(DownloadImage(_url));
    }
    IEnumerator DownloadImage(string MediaUrl)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return request.SendWebRequest();
        if (request.error != null)
            print("Fail to download img");
        else
        {
            Texture2D texture2D = ((DownloadHandlerTexture)request.downloadHandler).texture;
            _clickButton.image.sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0,0), 100);

        }
    }
}
