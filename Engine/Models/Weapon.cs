using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Engine.Models
{
    public class Weapon: GameItem
    {
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }
        public Weapon(int itemTypeID, string name, int price, int maxDamage, int minDamage)
            : base(itemTypeID, name, price)
        {
            
            MaxDamage = maxDamage;
            MinDamage = minDamage;
        }
        public new Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, MaxDamage, MinDamage);
        }

    }
}
