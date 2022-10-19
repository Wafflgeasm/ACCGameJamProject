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
<<<<<<< Updated upstream
    public LanguageAssets languageAssets;
    [System.Serializable]
    public struct LanguageAssets{
        public LanguageAsset English;
    }
    public AudioClips audioClips;
    [System.Serializable]
    public struct AudioClips{
        public AudioClip sampleClip;
=======

    [System.Serializable]
    public struct AudioClips
    {
>>>>>>> Stashed changes
        public Music music;
        public SFX sfx;
        [System.Serializable]
        public struct Music{

        }
        [System.Serializable]
        public struct SFX{
            public Ghost ghost;
            public Player player;
            public NPC npc;
            public OldLady oldLady;
            [System.Serializable]
            public struct Ghost{
                public AudioClip[] ghostHurtSFX;
                public AudioClip[] ghostDeadSFX;
                public AudioClip[] ghostIdleSFX;
            }
            [System.Serializable]
            public struct Player{
                public AudioClip[] playerHurtSFX;
                public AudioClip playerDeadSFX;
            }
            [System.Serializable]
            public struct NPC{
                public AudioClip[] npcDisagreeSFX;
                public AudioClip[] npcGrumbleSFX;
                public AudioClip[] npcAgreeSFX;
            }
            [System.Serializable]
            public struct OldLady{
                public AudioClip oldLadyLaughSFX;
                public AudioClip oldLadyAgreeSFX;
                public AudioClip oldLadyDisagreeSFX;
                public AudioClip oldLadyQuestionSFX;
                public AudioClip oldLadyPurchasedSFX;
            }
        }
    }

    [System.Serializable]
    public struct LanguageAssets{
        public LanguageAsset English;
    }
}
