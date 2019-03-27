using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;


namespace TestAutomation_Unit2
{
    class Serialization
    {

        private readonly Random rnd = new Random(DateTime.Now.Millisecond);

        public static void SerializeModelToJson()
        {
            var RegisteredUsers = new List<Human>();
            RegisteredUsers.Add(new Human() { PersonID = 1, Name = "Bryon Hetrick", Registered = true });
            RegisteredUsers.Add(new Human() { PersonID = 2, Name = "Nicole Wilcox", Registered = true });
            RegisteredUsers.Add(new Human() { PersonID = 3, Name = "Adrian Martinson", Registered = false });
            RegisteredUsers.Add(new Human() { PersonID = 4, Name = "Nora Osborn", Registered = false });

            var serializer = new JavaScriptSerializer();
            var serializedResult = serializer.Serialize(RegisteredUsers).Replace("}", "}" + System.Environment.NewLine); ;

            Console.WriteLine("Serialized result: \r\n");
            Console.WriteLine(serializedResult);

            var deserializedResult = serializer.Deserialize<List<Human>>(serializedResult);

            Console.WriteLine("Deserialized: ");
            foreach (object human in deserializedResult)
            {
                Console.WriteLine(human);
            }

            Console.ReadKey();

        }
    }
}
