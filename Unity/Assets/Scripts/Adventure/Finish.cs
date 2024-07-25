using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Finish : MonoBehaviour,IInteractable
{
    [SerializeField] private UnityEvent finishEvent;

    public void Interact(GameObject target)
    {
        if (target.TryGetComponent<IPlayerFinishAble>(out var player))
        {
            player.ActivateFinish(finishEvent);
        }  
    }
}
