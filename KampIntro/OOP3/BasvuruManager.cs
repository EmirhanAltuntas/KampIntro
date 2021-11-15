using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public  void BasvuruYap(ICreditManager creditManager, List<IloggerService> loggerServices)
        {
            creditManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        public void KrediOnbilgilendirmesiYap(List<ICreditManager> credits) 
        {
            foreach (var credit in credits)
            {
                credit.Hesapla();
            }
        }
    }
}
