using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item
{
    public abstract string Name{get;}
    public abstract Sprite Sprite{get;}
    public virtual string Description => "There should be a description here but somebody did not override the \"Description\" variable in the item's script";// MUST BE ABSTRACT
    public virtual int Price => 0;
    public virtual void ProjectileChange(Projectile projectile){}
    public virtual void VelocityChange(ref Vector2 baseVelocity){}
    public virtual void OnPickup(){}
    #region Convenience Overrides
    public sealed override bool Equals(object obj)
    {
        return base.Equals(obj);
    }
    public sealed override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public sealed override string ToString()
    {
        return base.ToString();
    }
    #endregion
}
