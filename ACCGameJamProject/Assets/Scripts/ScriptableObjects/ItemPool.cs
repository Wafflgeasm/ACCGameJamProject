using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class NamedArrayAttribute : PropertyAttribute
{
    public Type TargetEnum;
    public NamedArrayAttribute(Type TargetEnum)
    {
        this.TargetEnum = TargetEnum;
    }
}


public enum eItemPool { none, oldLady, all }
[CreateAssetMenu(fileName = "ItemPool")]
public class ItemPool : ScriptableObject
{
    public AllMerchantPools itemPool = new AllMerchantPools();
}


[System.Serializable]
public class AllMerchantPools
{
    [NamedArray(typeof(eItemPool))] public List<MerchantPool> MerchantType;
}
[System.Serializable]
public class MerchantPool
{
    public List<ShopItemSO> Items;
}
