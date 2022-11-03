using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShopManager : MonoBehaviour
{
    public static void GainEctoplasm(int ectoplasm){
        PersistentData.instance.ectoplasm += ectoplasm;
    }
    public static void SpendEctoplasm(int ectoplasm){
        if (PersistentData.instance.ectoplasm < ectoplasm) return;
        PersistentData.instance.ectoplasm -= ectoplasm;
    }
    public bool Buy(int required, Action onPurchaseSuccessful = null, Action onPurchaseUnsuccessful = null){
        if (PersistentData.instance.ectoplasm > required){
            onPurchaseUnsuccessful();
            return false;
        }
        PersistentData.instance.ectoplasm =- required;
        onPurchaseUnsuccessful();
        return true;
    }
}
