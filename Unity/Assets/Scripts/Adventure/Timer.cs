using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text _timerText;
    private float _currentTime;
    public float CurrentTime { get { return _currentTime; } }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        _timerText.text = _currentTime.ToString("0.00");
    }
}
