using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items{
    public class HauntedCandle : Item
    {
        public override Sprite Sprite => AssetSource.instance.sprites.items.hauntedCandle;
        public override string Name => LanguageAsset.instance.items.names.hauntedCandle;
        public override void OnPickup()
        {
            Player.instance.vacuumSuckSize+=2;
        }
    }
}
