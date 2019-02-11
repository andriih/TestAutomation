using System;


namespace TestAutomation_Unit2
{
    public class Person
    {
        private string bDay;
        private int age;
        private string gender;
        private int height;
        private string info;

        public Person()
        {
            Console.Write("Enter a birh date in MM/DD/YYYY fromat: ");
            bDay = Console.ReadLine();

            Console.Write("Enter your gender: ");
            gender = Console.ReadLine();

            Console.Write("Enter a height: ");
            height = Convert.ToInt32(Console.ReadLine());
        }

        private int getAge()
        {
            string Year = DateTime.Now.Year.ToString();
            int currentYear = Int32.Parse(Year);

            string Month = DateTime.Now.Month.ToString();
            int currentMonth = Int32.Parse(Month);

            string Day = DateTime.Now.Day.ToString();
            int currentDay = Int32.Parse(Day);

            DateTime birthDate = Convert.ToDateTime(bDay);

            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            {
                age = currentYear - birthDate.Year - 1;
            }
            else
            {
                age = currentYear - birthDate.Year;
            }
               
            return (int)age;
        }

        private string getGender()
        {
            return gender;
        }

        private int getHeight()
        {
            return height;
        }

        public string GetInfo()
        {
             return  info = "Birth day: "+bDay+"\nAge: "+getAge()+"\nGender: "+getGender()+"\nHeight: "+getHeight();
        }



    }
}
