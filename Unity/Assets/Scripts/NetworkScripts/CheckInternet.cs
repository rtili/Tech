using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CheckInternet : MonoBehaviour
{
    [SerializeField] private GameObject[] _unavailableWithNoConnection;
    [SerializeField] private GameObject _connectionError;

    private void Awake()
    {
        StartCoroutine("CheckConnection");
    }
    
    IEnumerator CheckConnection()
    {
        UnityWebRequest request = new UnityWebRequest("http://google.com");
        yield return request.SendWebRequest();
        if (request.error != null)
        {
            _connectionError.SetActive(true);
            foreach (var item in _unavailableWithNoConnection)
            {
                item.SetActive(false);
            }
            print("Error. Check internet connection!");
        }
        else
        {
            print("Connection is fine");
        }
    }
}
