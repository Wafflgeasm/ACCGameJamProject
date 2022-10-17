using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.UI;



public enum eUpgradeType {none, passive, weapon}

[CreateAssetMenu(fileName = "NewItem")]
public class ShopItemSO : ScriptableObject
{
    public eUpgradeType itemUpgradeType;
    public Sprite itemSprite;
    public float statModifier;
    public int itemCost;
}
