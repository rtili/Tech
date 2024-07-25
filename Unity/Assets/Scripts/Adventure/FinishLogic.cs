using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;

public class FinishLogic : AbleToCloudData
{
    [SerializeField]
    private Text _bestTimeText, _currentTimeText;
    [SerializeField] private Timer _timer;
    [SerializeField] private GameObject _winScreen;
    private float _bestTime;
    private LocalSave _localSave;

    public override object DataToSave { get { return _bestTime; } }

    public override object DataToLoad { set { _bestTime = Convert.ToSingle(value, CultureInfo.InvariantCulture); } }

    private void Start()
    {
        _localSave = new();
        if (PlayerPrefs.HasKey("BestTime"))
            _bestTime = _localSave.Load(_bestTime, "BestTime");
        else
            _bestTime = float.MaxValue;
    }

    public void SetFinishData()
    {
        _winScreen.SetActive(true);
        if (_bestTime > _timer.CurrentTime)
        {
            _bestTime = _timer.CurrentTime;
        }        
        _currentTimeText.text = _timer.CurrentTime.ToString("0.00");
        _bestTimeText.text = _bestTime.ToString("0.00");
        _localSave.Save("BestTime", _bestTime);
        Time.timeScale = 0;
    }
}
