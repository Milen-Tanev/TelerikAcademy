namespace GSM_Classes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using GSM_Classes;
    using Gsm_Classes;

    class GSMCallHistoryTest
    {
        public static void CallHistoryTest()
        {
            Gsm test2 = new Gsm("3310", "Nokia", 50.5M, "Gosho", new Battery("12345EN", 50, 30, BatteryType.Nickel_Cadmium), new Display(2.2, 16));
            test2.AddCall("13.03.2010", "16:10", "15429580239", 582);
            test2.AddCall("12.04.2011", "11:22", "31235513132", 1318);
            test2.AddCall("09.11.2012", "20:55", "65426527474", 310);

            Console.WriteLine(test2.CallHistory);
            Console.WriteLine(test2.GetTotalPrice());

            test2.DeleteLongestCall();
            Console.WriteLine(test2.GetTotalPrice());
            test2.DeleteAllCalls();
            Console.WriteLine(test2.GetTotalPrice());
        }
    }
}