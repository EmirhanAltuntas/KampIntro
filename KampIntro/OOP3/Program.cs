using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        // interface'leri birbirinin alternatifi olan ancak kod içerikleri farklı olan durumlar için kullanırız.

        static void Main(string[] args)
        {
            ICreditManager ihtiyacCreditManager = new IhtiyacCreditManager();
            ICreditManager tasitCreditManager = new TasitCreditManager();
            ICreditManager konutCreditManager = new KonutCreditManager();
            ICreditManager esnafCreditManager = new EsnafCreditManager();

            IloggerService smsLoggerService = new SmsLoggerService();
            IloggerService databaseLoggerService = new DatabaseLoggerService();
            IloggerService fileLoggerService = new FileLoggerService();

            List<IloggerService> loggers = new List<IloggerService> { new SmsLoggerService(), new DatabaseLoggerService(), new FileLoggerService() };


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafCreditManager,loggers);


            List<ICreditManager> credits = new List<ICreditManager>()
            {ihtiyacCreditManager,tasitCreditManager};
            
               // basvuruManager.KrediOnbilgilendirmesiYap(credits);
        

        }

    }
}
