using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items{
    public class GhostlyChessboard : Item
    {
        public override Sprite Sprite => AssetSource.instance.sprites.items.tarotCard;
        public override string Name => LanguageAsset.instance.items.names.tarotCard;
        public override void OnPickup()
        {
            Player.instance.vacuumSuckDuration+=5;
        }
    }
}
