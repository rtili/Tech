using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalSave
{
    public void Save(string name, int intToSave)
    {
        PlayerPrefs.SetInt(name, intToSave);
        PlayerPrefs.Save();
    }
    public void Save(string name, float floatToSave)
    {
        PlayerPrefs.SetFloat(name, floatToSave);
        PlayerPrefs.Save();
    }
    public void Save(string name, string stringToSave)
    {
        PlayerPrefs.SetString(name, stringToSave);
        PlayerPrefs.Save();
    }

    public int Load(int intToLoad, string name)
    {
        if (PlayerPrefs.HasKey(name))
        {
            intToLoad = PlayerPrefs.GetInt(name);
            return intToLoad;
        }
        else
        {
            Debug.Log("No save data!");
            return 0;
        }
    }
    public float Load(float floatToLoad, string name)
    {
        if (PlayerPrefs.HasKey(name))
        {
            floatToLoad = PlayerPrefs.GetFloat(name);
            return floatToLoad;
        }
        else
        {
            Debug.Log("No save data!");
            return 0;
        }
    }
    public string Load(string stringToLoad, string name)
    {
        if (PlayerPrefs.HasKey(name))
        {
            stringToLoad = PlayerPrefs.GetString(name);
            return stringToLoad;
        }
        else
        {
            Debug.Log("No save data!");
            return string.Empty;
        }
    }
}
