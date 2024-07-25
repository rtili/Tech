using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface IPlayerFinishAble
{
    public void ActivateFinish(UnityEvent finishEvent);
}
