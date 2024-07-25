using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickButton : AbleToCloudData
{
    [SerializeField] private Text _clickCountText;
    private int _clicks;
    private LocalSave localSave;

    public override object DataToSave { get { return _clicks; } }
    public override object DataToLoad { set { _clicks = Convert.ToInt32(value); } }

    private void Start()
    {
        localSave = new();
        _clicks = localSave.Load(_clicks, "Clicks");
    }

    private void Update()
    {
        _clickCountText.text = _clicks.ToString();
    }

    public void Click()
    {
        _clicks++;
        localSave.Save("Clicks", _clicks);
    }
}
