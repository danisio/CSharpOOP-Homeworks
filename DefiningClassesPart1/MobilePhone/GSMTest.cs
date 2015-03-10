namespace GSM
{
    using System;
    using System.Collections.Generic;

    public class GSMTest
    {
        public static void TestAddingNewPhones()
        {
            // create a list of type GSM
            List<GSM> testPhones = new List<GSM>();
            
            // add first phone
            testPhones.Add(new GSM("Xperia Z1", "Sony", new Battery(BatteryType.Li_Ion, 880, 14), new Display(5.0, 16000000)));
            testPhones[0].Price = 800;
            
            // add second phone
            GSM test = new GSM("Galaxy S6", "Samsung", new Battery(BatteryType.Li_Ion, 500, 10));
            testPhones.Add(test);
            
            // add third phone
            test = new GSM("Vibe Shot", "Lenovo", new Battery(BatteryType.Li_Poly));
            testPhones.Add(test);
            testPhones[2].Owner = Environment.UserName;

            // print all elements in the list
            foreach (var phones in testPhones)
            {
                Console.WriteLine(phones.ToString());
            }

            // print the static field
            Console.WriteLine(GSM.IPhone_4s);
        }
    }
}
