using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbleToCloudData : MonoBehaviour
{
    public abstract object DataToSave { get; }
    public abstract object DataToLoad { set; }
}
