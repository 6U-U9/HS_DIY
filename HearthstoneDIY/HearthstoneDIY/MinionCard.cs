using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneDIY
{
    public class MinionCard:Card
    {
        public override void PlayedFromHand()
        {
            //need position
            player.board.Insert(0,this);
            player.hand.Remove(this);
            base.PlayedFromHand();
        }
    }
}
