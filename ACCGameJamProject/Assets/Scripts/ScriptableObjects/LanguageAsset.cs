using UnityEngine;

[CreateAssetMenu(fileName = "LanguageAsset", menuName = "Labirynth Arcade/LanguageAsset", order = 0)]
public class LanguageAsset : ScriptableObject {
    public static LanguageAsset instance;
    public static void Init(){
        Debug.Log(AssetSource.instance.languageAssets.English);
        switch(Application.systemLanguage){
            default:
            instance = AssetSource.instance.languageAssets.English;
            break;
        }
    }
    public SystemLanguage language;
    public string play  = "Play";
    public string exit = "Exit";
    public string settings = "Settings";
    public string shop = "Shop";
}