using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.UI;



public class NamedArrayAttribute : PropertyAttribute
{
    public Type TargetEnum;
    public NamedArrayAttribute(Type TargetEnum)
    {
        this.TargetEnum = TargetEnum;
    }
}
public enum eUpgradeType {none, passive, weapon}
public enum eItemPool { none, OldLady }

[CreateAssetMenu(fileName = "NewItem")]
public class ShopItemSO : ScriptableObject
{
    public eUpgradeType itemUpgradeType;
    [NamedArray(typeof(eItemPool))] public bool[] itemPool;
    public Sprite itemSprite;
    public int itemCost;
}
