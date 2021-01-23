using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        // Interface ; olusturulurken basına "I" harfi eklenerek yazılır.
        // interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
        // yaptığımız örnekte bütün kredi türlerinde hesaplama yapılıyor fakat kredinin türüne göre değişkenlik göstereceğinden
        // farklı türlerde kodlar yazılır.

        static void Main(string[] args)
        {
            ICreditManager personelFinanceCreditManager = new PersonelFinanceCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();
            
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplyManager applyManager = new ApplyManager();
            applyManager.Apply(vehicleCreditManager, fileLoggerService);


            List<ICreditManager> credits = new List<ICreditManager>() {personelFinanceCreditManager,vehicleCreditManager };
            //applyManager.CreditPreInformation(credits);
        }

    }
}
