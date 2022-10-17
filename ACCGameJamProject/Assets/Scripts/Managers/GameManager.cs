using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager
{
    public static int ectoplasm;
    public static Actor player;
    public static void Pause(){

    }
    public static void Unpause(){

    }
    public static void GainEctoplasm(int ectoplasm){
        GameManager.ectoplasm += ectoplasm;
    }
    public static void SpendEctoplasm(int ectoplasm){
        if (GameManager.ectoplasm < ectoplasm) return;
        GameManager.ectoplasm -= ectoplasm;
    }
}
