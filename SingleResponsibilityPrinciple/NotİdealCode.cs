using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple_NotİdealCode
{
    class ArithmeticOperations
    {
        // SRP sınıflarımızın veyahut methodlarımızın iyi tanımlanmış tek bir sorumluluğu olması gerektiğini söyler. 
        // Bir sınıf ne kadar fazla sorumluluk alırsa, o kadar fazla değişime uğramak zorunda kalır!

        //Bu method toplama ve çıkarma işlemi olmak üzere iki farklı sorumluluk üstlenmiştir.
        //Herhangi bir sorumluluktaki değişiklik diğer sorumluluğu bozabilir - engelleyebilir.
        public void AdditionAndSubtraction(int number1,int number2)
        {
            int additionResult = number1 + number2;
            Console.WriteLine($"Toplama işlemi sonucu : {additionResult}");

            int subtractionResult = number1 - number2;
            Console.WriteLine($"Çıkarma işlemi sonucu : {subtractionResult}");
        }

        
        //Bu method bu sınıfa aritmetik işlemlerin dışında string işlem sorumluluğu da yüklemiştir.
        public void StringConvertToLower(string text)
        {
            Console.WriteLine("Metnin küçük harf dönüşmüş hali : ", text.ToLower());
        }
    }
}
