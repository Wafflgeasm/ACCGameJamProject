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
        public GameObject ectoplasm;
        public Menus menus;
        [System.Serializable]
        public struct Menus{
            public GameObject mainMenu;
        }
        public Projectiles projectiles;
        [System.Serializable]
        public struct Projectiles{
            public GameObject BFL;
        }
        public Enemies enemies;
        [System.Serializable]
        public struct Enemies{
            public GameObject ghost;
            public GameObject sampleEnemy;
        }
    }
    public LanguageAssets languageAssets;
    [System.Serializable]
    public struct LanguageAssets{
        public LanguageAsset English;
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
}
