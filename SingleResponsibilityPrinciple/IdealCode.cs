using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple_IdealCode
{
    class ArithmeticOperations
    {
        //SRP sınıflarımızın veyahut methodlarımızın iyi tanımlanmış tek bir sorumluluğu olması gerektiğini anlatmaktadır. 
        //Bu sınıf sadece aritmetik işlemleri gerçekleştirme sorumluluğu almıştır.

        //Toplama ve çıkarma işlemi ayrı fonksiyonlar içerisinde yazılarak SRP'ye uyulmuştur.
        public void Addition(int number1, int number2)
        {
            int additionResult = number1 + number2;
            Console.WriteLine($"Toplama işlemi sonucu : {additionResult}");
        }

        public void subtraction(int number1, int number2)
        {
            int subtractionResult = number1 - number2;
            Console.WriteLine($"Çıkarma işlemi sonucu : {subtractionResult}");
        }
    }

    class StringOperations
    {
        //Bu sınıf sadece metin işlemleri gerçekleştirme sorumluluğu almıştır.
        public void StringConvertToLower(string text)
        {
            Console.WriteLine("Metnin küçük harf dönüşmüş hali : ", text.ToLower());
        }
    }
}
