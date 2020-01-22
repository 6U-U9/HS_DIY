using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneDIY
{
    public class Card //: IEquatable<Card>
    {
        public string id;
        //private string inGameID;
        public bool is_collectable;
        public string cardclass;
        public string name="";
        public string rarity;
        public int bringLimit=5;

        public int hp;
        public int attack;
        public int cost;
        
        //in game parameters
        public int attackChances;
        public bool is_dead;
        public Player player;
        public virtual T GetCopy<T>()where T:Card, new()
        {
            T card = new T();
            card.is_collectable = this.is_collectable;
            card.cardclass = this.cardclass;
            card.rarity = this.rarity;
            card.bringLimit = this.bringLimit;
            card.hp = this.hp;
            card.attack = this.attack;
            card.cost = this.cost;
            return card;
        }
        public int Get_bringLimit()
        { return bringLimit; }

        public virtual void PlayedFromHand()
        {
            
        }
        public ref int GetResourceNeed()
        {
            return ref player.crystal;
        }
        public bool IsAbleToPlay()
        {
            return player.HasEnoughResource(GetResourceNeed(), cost);
        }
        public virtual void Attack(Card target)
        {
            if (!IsAbleToAttack())
                return;
            if (!target.IsLegalTarget(this))
            { Console.WriteLine("Not A Legal Target"); 
                return; 
            }
            this.attackChances--;
            this.GetDamaged(target);
            target.AttackBy(this);
        }
        public virtual void AttackBy(Card actor)
        {
            if (!this.IsLegalTarget(actor))
            {
                Console.WriteLine("Not A Legal Target");
                return;
            }
            this.GetDamaged(actor);
        }
        public virtual void GetDamaged(Card other)
        {
            HpChange(GetDamageValue(other)); 
        }
        public virtual int GetDamageValue(Card other)
        {
            int damageValue = GetAttackValue(other);
            if (damageValue > 0)
                return -(damageValue);
            else
                return 0;
        }
        public virtual int GetAttackValue(Card other)
        {
                return this.attack;
        }
        public virtual void HpChange(int delta)
        {   //will not trigger anything
            hp += delta;
        }
        public virtual bool IsAbleToAttack()
        {
            if (attack <= 0)
            {
                Console.WriteLine("Unable To Attack: ATK no more than zero");
                return false;
            }
            if (attackChances <= 0)
            {
                Console.WriteLine("Unable To Attack: no attack chance this turn"); 
                return false;
            }
            return true;
        }
        public virtual void NewTurnStarted()
        {
            FreshAttackChance();
        }
        public virtual void FreshAttackChance()
        {
            attackChances = GetAttackChanceValue();
        }
        public virtual int GetAttackChanceValue()
        {
            int attackChances = 1;
            return attackChances;
        }
        public virtual bool IsLegalTarget(Card actor)
        {
            return true;
        }
        public virtual void IsDead()
        { 
            if (hp <= 0)
                is_dead = true;
            else
                is_dead = false;
        }
        /*public bool Equals(Card other)
        {
            return other.GetType()==this.GetType();
        }*/
        
        public virtual void AddToDeck(Deck deck)
        { }
        public virtual void RemoveFromDeck(Deck deck)
        { }
    }
    public class DeckSortComparer : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            if (x.cost.Equals(y.cost))
                return x.name.CompareTo(y.name);
            return x.cost.CompareTo(y.cost);
        }
    }
    public class NewCard1 : MinionCard
    { }
    public class NewCard2 : MinionCard
    { }
    public class NewCard3 : MinionCard
    { }
    public class NewCard4 : MinionCard
    { }
}
