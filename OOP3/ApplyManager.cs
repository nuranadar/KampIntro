using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplyManager
    {
        // Method  injection
        public void Apply(ICreditManager creditManager, ILoggerService loggerService) 
        {
            //başvuran bilgilerini değerlendirme
            //
            // aşağıdaki gibi yazılırsa bütün başvurular mortgage için çalışır
            //MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();
            //mortgageCreditManager.Calculate();


            creditManager.Calculate();
            loggerService.Log();

        }
        public void CreditPreInformation(List<ICreditManager> credits) 
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
