namespace TestAutomation_Unit2
{
    public class Person
    {
        private string bDay;
        private int age;
        private string gender;
        private int height;
        private string info;

        public Person(string birthDay)
        {
            bDay = birthDay;
        }

        private int getAge()
        {
            return age = 20;
        }

        private string getGender()
        {
            return gender = "male";
        }

        private int getHeight()
        {
            return height = 170;
        }

        public string GetInfo()
        {
             return  info = "Birth day: "+bDay+"\nAge: "+getAge()+"\nGender: "+getGender()+"\nHeight: "+getHeight();
        }



    }
}
