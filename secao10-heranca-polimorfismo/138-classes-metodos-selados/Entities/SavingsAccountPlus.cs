using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _138_classes_metodos_selados.Entities
{
    internal class SavingsAccountPlus : SavingsAccount
    {
        public override void Withdraw(double amount)
        {
            
        }

        // O método sobreposto WithDraw foi selado em SavingsAccount
    }
}
