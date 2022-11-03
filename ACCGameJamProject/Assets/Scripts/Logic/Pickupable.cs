using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickupable
{
    public abstract Sprite sprite{get;}
    public abstract string Name{get;}
    public abstract void OnPickup();
}
