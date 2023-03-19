namespace LooseCoupling
{
    public class Program
    {
        static void Main(string[] args)
        {
            MailSender mailSender = new MailSender();
            mailSender.Send();
        }
    }
}