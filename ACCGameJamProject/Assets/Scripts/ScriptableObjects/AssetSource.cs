using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[CreateAssetMenu(fileName = "AssetSource", menuName = "Labirynth Arcade/AssetSource", order = 0)]
public class AssetSource : ScriptableObject {
    public static void Init(){
        instance = Resources.Load<AssetSource>("AssetSource");
    }
    public static AssetSource instance;
    public static GameObjects.Menus Menus => AssetSource.instance.gameObjects.menus;
    public GameObjects gameObjects;
    [System.Serializable]
    public struct GameObjects{
        public GameObject player;
        public GameObject ectoplasm;
        public Menus menus;
        [System.Serializable]
        public struct Menus{
            public GameObject mainMenu;
        }
        public Projectiles projectiles;
        [System.Serializable]
        public struct Projectiles{
            public GameObject bfl;
            public GameObject candle;
            public GameObject ghost;
        }
        public Enemies enemies;
        [System.Serializable]
        public struct Enemies{
            public GameObject ghost;
        }
    }
    public LanguageAssets languageAssets;
    [System.Serializable]
    public struct LanguageAssets{
        public LanguageAsset english;
    }
    public AudioClips audioClips;
    [System.Serializable]
    public struct AudioClips{
        public Music music;
        [System.Serializable]
        public struct Music {

        }
        public SFX sfx;
        [System.Serializable]
        public struct SFX {

            [Header("Ghost Sound Effects:")]
            public AudioClip[] GhostHurtSFX;
            public AudioClip[] GhostDeadSFX;
            public AudioClip[] GhostIdleSFX;

            [Header("Player Sound Effects:")]
            public AudioClip[] PlayerHurtSFX;
            public AudioClip PlayerDeadSFX;

            [Header("General NPC Sound Effects:")]
            public AudioClip[] NPCGrumbleSFX;
            public AudioClip[] NPCDisagreeSFX;
            public AudioClip[] NPCAgreeSFX;

            [Header("Old Lady Sound Effects:")]
            public AudioClip OldLadyLaughSFX;
            public AudioClip OldLadyAgreeSFX;
            public AudioClip OldLadyDisagreeSFX;
            public AudioClip OldLadyQuestionSFX;
            public AudioClip OldLadyPurchasedSFX;

            [Header("Menu Sound Effects:")]
            public AudioClip menuSelectSFX;
            public AudioClip menuConfirmSFX;
            public AudioClip menuBackSFX;
        }
    }
    public Sprites sprites;
    [System.Serializable]
    public struct Sprites{
        public Pickupables pickupables;
        [System.Serializable]
        public struct Pickupables{
            public Sprite vile;
            public Sprite ectoplasm;
            public Sprite treasureKey;
        }
        public Items items;
        [System.Serializable]
        public struct Items{
            public Sprite tarotCard;
            public Sprite blackCrystal;
            public Sprite ballerinaBox;
            public Sprite strawDoll;
            public Sprite littleGhostGuy;
            public Sprite hauntedCandle;
            public Sprite ghostlyChessboard;
            public Sprite spellBook;
        }
    }
}
