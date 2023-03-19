using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCoupling_LooseDependency
{
    class MailSender
    {
        /*
         * Burada mailsender sınıfı ile gmail,hotmail gibi mail servisleri birbirlerine gevşek bağlıdır.
         * Burada mail servisleri üzerinde değişiklik yapmak istediğimizde IMailServices interface'ini implemente eden
         * herhangi bir sınıfı send metodumuza parametre oarak göndererek kolaylıkla service değişikiliği yapabiliriz.
         * Bu durum yazdığımız kodları kolaylıkla yönetebilmemizi sağlar.
         * Yönetilebilir kodlar zaman ve maliyet açısından tasarruf sağlar.
         * */
         
        public void Send(IMailServices mailServices)
        {
            mailServices.Send("mehmetkilinc2734@gmail.com");
        }
    }

    interface IMailServices
    {
        void Send(string to);
    }
    class Gmail:IMailServices
    {
        public void Send(string to)
        {
            Console.WriteLine($" Bu mesaj gmail ile {to} alıcısına gönderilmiştir.");
        }
    }
    class Hotmail : IMailServices
    {
        public void Send(string to)
        {
            Console.WriteLine($" Bu mesaj hotmail ile {to} alıcısına gönderilmiştir.");
        }
    }
    class Outlook : IMailServices
    {
        public void Send(string to)
        {
            Console.WriteLine($" Bu mesaj outlook ile {to} alıcısına gönderilmiştir.");
        }
    }

}
