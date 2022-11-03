using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pickupables
{
    public class Vile : Pickupable
    {
        private int amount;
        public Vile(int amount){
            this.amount = amount;
        }
        public override string Name => LanguageAsset.instance.pickupables.vile;
        public override Sprite sprite => AssetSource.instance.sprites.pickupables.vile;
        public override void OnPickup()
        {
            
        }
    }
}
