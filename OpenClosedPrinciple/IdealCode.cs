using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple_IdealCode
{
    //Open/Closed Principle OOP tasarımlarında bir sınıfın gereksinimler doğrultusunda değiştirmeye gerek duyulmaksızın,
    //genişletilebilir bir şekilde tasarlanmasını savunan bir prensiptir. 

    //Burada sınıfımızın değişime gerek duyulmadan interface aracılığı ile genişletilebilir bir şekildedir.
    class TransferService
    {
        public void Send(IBank bank, int amount, string accountNo)
        {
            bank.MoneyTransfer(amount, accountNo);
        }
    }

    interface IBank
    {
        void MoneyTransfer(int amount, string accountNo);
    }
    class Ziraat : IBank
    {
        public void MoneyTransfer(int amount, string accountNo)
        {
            Console.WriteLine($"{amount}TL Ziraat bankası aracılığı ile {accountNo} Nolu hesaba aktarılmıştır.");
        }
    }
    class Garanti : IBank
    {
        public void MoneyTransfer(int amount, string accountNo)
        {
            Console.WriteLine($"{amount}TL Garanti bankası aracılığı ile {accountNo} Nolu hesaba aktarılmıştır.");
        }
    }
    class Halkbank : IBank
    {
        public void MoneyTransfer(int amount, string accountNo)
        {
            Console.WriteLine($"{amount}TL Halkbank aracılığı ile {accountNo} Nolu hesaba aktarılmıştır.");
        }
    }
}
