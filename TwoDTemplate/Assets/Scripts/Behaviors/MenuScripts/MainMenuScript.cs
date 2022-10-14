using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MenuScript
{
    public ButtonScript playButton;
    public ButtonScript settingsButton;
    public ButtonScript exitButton;
    public ButtonScript shopButton;
    public override void OnCreated(){
        print("Initting");
        playButton.Init(()=>{}, LanguageAsset.instance.play);
        settingsButton.Init(()=>{}, LanguageAsset.instance.settings);
        exitButton.Init(()=>{}, LanguageAsset.instance.exit);
        shopButton.Init(()=>{}, LanguageAsset.instance.shop);
    }
}
