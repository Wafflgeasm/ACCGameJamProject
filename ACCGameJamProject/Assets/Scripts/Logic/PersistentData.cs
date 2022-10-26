using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData
{
    #region Logic
    private const string SAVE_STRING = "s";
    public static void Load(){
        if (!PlayerPrefs.HasKey(SAVE_STRING)){
            instance = Default;
            Save();
            return;
        }
        string jsonString = PlayerPrefs.GetString(SAVE_STRING);
        Debug.Log(jsonString);
        if (!Deserialize(jsonString)){
            instance = Default;
            Save();
        }
    }
    public static void Save(){
        PlayerPrefs.SetString(SAVE_STRING, instance.Serialize());
    }
    public static PersistentData instance;
    private static bool Deserialize(string serialized){
        try{
            instance = JsonUtility.FromJson<PersistentData>(serialized);
            return true;
        }
        catch{
            return false;
        }
    }
    private string Serialize(){
        return JsonUtility.ToJson(this);
    }
    private static PersistentData Default => new PersistentData();
    #endregion
    //Put data to save below in format: public <type> <name> = <default value>
    public int ectoplasm = 0;
}
