using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour, IPlayerFinishAble
{
    public void ActivateFinish(UnityEvent finishEvent)
    {
        finishEvent.Invoke();
    }
}
