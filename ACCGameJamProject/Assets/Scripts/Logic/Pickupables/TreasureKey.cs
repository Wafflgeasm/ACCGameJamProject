using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pickupables
{
    public class TreasureKey : Pickupable
    {
        private int amount;
        public TreasureKey(int amount){
            this.amount = amount;
        }
        public override string Name => LanguageAsset.instance.pickupables.treasureKey;
        public override Sprite sprite => AssetSource.instance.sprites.pickupables.treasureKey;
        public override void OnPickup()
        {
            
        }
    }
}
