using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitScript : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;
    public GameObject playerGameObject;
    private void Awake() {
<<<<<<< Updated upstream
        Player.instance = new Player(playerGameObject, new BFLWeapon());
=======
        PersistentData.Load();
        //SHOULD BE REMOVED
        List<Weapon> weapons = new List<Weapon>{
            new Weapons.BFLWeapon(),
            new Weapons.CandleWeapon(),
        };
        Weapon.playerWeapon = weapons[Random.Range(0,weapons.Count)];
        //END OF SHOULD BE REMOVED
>>>>>>> Stashed changes
        AssetSource.Init();
        LanguageAsset.Init();
        AudioManager.Init();
        GameManager.NewGame();
    }
    private void Update() {
    }
}
