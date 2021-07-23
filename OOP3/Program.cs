using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();           
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService(); //basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService());Bu şekilde de yapılabilir.
            ILoggerService fileLogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() }); //buraya hangi kredi ve hangi log istiyorsak onu yazabiliriz.

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }
}
