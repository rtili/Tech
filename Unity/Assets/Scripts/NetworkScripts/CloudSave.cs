using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using UnityEngine;
using UnityEngine.Events;

public class CloudSave : MonoBehaviour
{
    [SerializeField] private string _dataName;
    [SerializeField] private AbleToCloudData _cloudData;

    public async void SaveData()
    {
        Dictionary<string, object> data = new Dictionary<string, object>() { { _dataName, _cloudData.DataToSave } };
        await CloudSaveService.Instance.Data.Player.SaveAsync(data);
    }
    public async void LoadData()
    {
        var data = await CloudSaveService.Instance.Data.Player.LoadAsync(new HashSet<string> { _dataName });
        if (data.TryGetValue(_dataName, out var keyName))
        {
            _cloudData.DataToLoad = keyName.Value.GetAs<string>();
        }
    }
}