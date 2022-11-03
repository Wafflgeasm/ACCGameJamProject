using UnityEngine;

[CreateAssetMenu(fileName = "LanguageAsset", menuName = "Labirynth Arcade/LanguageAsset", order = 0)]
public class LanguageAsset : ScriptableObject {
    public static LanguageAsset instance;
    public static void Init(){
        switch(Application.systemLanguage){
            default:
            instance = AssetSource.instance.languageAssets.english;
            break;
        }
    }
    public SystemLanguage language;
    public string ectoplasm = "Ectoplasm";
    public Pickupables pickupables;
    [System.Serializable]
    public class Pickupables{
        public string vile = "Vile";
        public string treasureKey= "Treasure Key";
    }
    public Items items;
    [System.Serializable]
    public class Items{
        public Names names;
        [System.Serializable]
        public class Names{
            public string tarotCard = "Tarot Card";
            public string blackCrystal = "Black Flower Crystal";
            public string ballerinaBox = "Ballerina Box";
            public string strawDoll = "Small Straw Doll";
            public string weddingRing = "Wedding Ring";
            public string littleGhostGuy = "Little Ghost Guy";
            public string hauntedCandle = "Haunted Candle";
            public string ghostlyChessboard = "Ghostly Chessboard";
            public string spellBook = "Spell Book";
        }
        public Descriptions descriptions;
        [System.Serializable]
        public class Descriptions{
            public string tarotCard = "There should be a description here but somebody forgot to put it here";
            public string blackCrystal = "There should be a description here but somebody forgot to put it here";
            public string ballerinaBox = "There should be a description here but somebody forgot to put it here";
            public string strawDoll = "There should be a description here but somebody forgot to put it here";
            public string weddingRing = "There should be a description here but somebody forgot to put it here";
            public string littleGhostGuy = "There should be a description here but somebody forgot to put it here";
            public string hauntedCandle = "There should be a description here but somebody forgot to put it here";
            public string ghostlyChessboard = "There should be a description here but somebody forgot to put it here";
            public string spellBook = "There should be a description here but somebody forgot to put it here";

        }
    }
}