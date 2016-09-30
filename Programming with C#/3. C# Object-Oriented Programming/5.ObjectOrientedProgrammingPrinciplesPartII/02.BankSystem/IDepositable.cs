using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    public interface IDepositable
    {
        void Deposit(decimal depositMoney);
    }
}
