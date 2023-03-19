using LooseCoupling_LooseDependency;
using LooseCoupling_TightDependency;


namespace LooseCoupling
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Tight-Coupling
            LooseCoupling_TightDependency.MailSender mailSender = new();
            mailSender.Send();


            //Loose-Coupling
            LooseCoupling_LooseDependency.MailSender mailSender2 = new();
            mailSender2.Send(new LooseCoupling_LooseDependency.Gmail());
            //Görüldüğü üzere service değişikliği burada kolaylıkla yapılabilmektedir.
            mailSender2.Send(new LooseCoupling_LooseDependency.Hotmail());

        }
    }
}