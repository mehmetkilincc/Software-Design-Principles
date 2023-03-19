using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCoupling
{
    class MailSender
    {
        /*Mailsender sınıfı ile gmail sınıfı arasında sıkı bir bağ vardır.
         * Gmail sınıfında yapılacak bir değişiklik veya
         * mail service'inin değişmesi mailsender sınıfında da büyük değişikliklere neden olacak ve
         * zaman ve maliyet açısından kötü bir durum gerçekleşecektir.
         * Yazılımlarımızı geliştirirken bağımlılıkları mümkün olduğu kadar en aza indirmeliyiz.
         */
        public void Send()
        {
            //Gmail gmail = new Gmail();
            //gmail.Send("mehmetkilinc2734@gmail.com");

            /*Mail gönderme işlemini hotmail üzerinden gerçekleştirmek istediğim zaman
             * gmail sınıfıyla ilgili yukarıdaki işlemleri silmek ve
             * aynı işlemi tekrar hotmail sınıfı ile yapmak zorunda kaldık.
             */
            Hotmail hotmail = new Hotmail();
            hotmail.Send("mehmetkilinc@hotmail.com");
        }
    }

    class Gmail
    {
        public void Send(string to)
        {
            Console.WriteLine($" Bu mesaj gmail ile {to} alıcısına gönderilmiştir.");
        }
    }
    class Hotmail
    {
        public void Send(string to)
        {
            Console.WriteLine($" Bu mesaj hotmail ile {to} alıcısına gönderilmiştir.");
        }
    }
    class Outlook
    {
        public void Send(string to)
        {
            Console.WriteLine($" Bu mesaj outlook ile {to} alıcısına gönderilmiştir.");
        }
    }
}
