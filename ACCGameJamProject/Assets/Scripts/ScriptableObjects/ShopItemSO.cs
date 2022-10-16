using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public enum eUpgradeType {none, currentHealth, maxHealth, movementSpeed, suckSize, suckDuration, weapon}

[CreateAssetMenu(fileName = "NewItem")]
public class ShopItemSO : ScriptableObject
{
    public string ItemName;
    public string ItemDescription;
    public eUpgradeType itemUpgradeType;
    public Sprite itemSprite;
    public int itemCost;
}
