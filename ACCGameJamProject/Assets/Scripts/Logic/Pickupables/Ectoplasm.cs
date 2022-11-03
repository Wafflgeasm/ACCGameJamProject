using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pickupables
{
    public class Ectoplasm : Pickupable
    {
        private int amount;
        public Ectoplasm(int amount){
            this.amount = amount;
        }
        public override string Name => LanguageAsset.instance.ectoplasm;
        public override Sprite sprite => AssetSource.instance.sprites.pickupables.ectoplasm;
        public override void OnPickup()
        {
            ShopManager.GainEctoplasm(amount);
        }
    }
}
