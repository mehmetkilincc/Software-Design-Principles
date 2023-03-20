using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple_NotIdealCode
{
    class TransferService
    {
        //Open/Closed Principle sınıfların gelişime açık lakin değişime kapalı olması gerektiğini savunan bir prensiptir.

        public void Send(int amount)
        {
            //Burada banka değiştiği için kodun değiştirilmesi gerekmektedir. Bu durum prensibimize aykırıdır.

            //Garanti garanti = new();
            //garanti.MoneyTransfer(amount);

            Halkban halkbank = new();
            halkbank.TransferAccountNo("123");
            halkbank.Send(amount);
        }
    }

    class Garanti
    {
        public string AccountNo { get; set; }
        public void SendMoney(int amount)
        {
            //...
        }
    }
    class Halkban
    {
        string _accountNo;
        public void TransferAccountNo(string accountNo)
        {
            //...
        }
        public void Send(int amount)
        {
            //...
        }
    }
}
