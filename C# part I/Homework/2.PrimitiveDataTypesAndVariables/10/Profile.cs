using System;

class Profile

    {
        static void Main()
        {
            string firstName;
            string familyName;
            int age;
            char gender;
            ulong ID;
            uint employeeNum;

            firstName = "Strahil";
            familyName = "Ivanov";
            age = 38;
            gender = 'm';
            ID = 7405168554;
            employeeNum = 27560052;
            Console.WriteLine("Номер {0} е работник:\n Име: {1}\n Фамилия: {2}\n Години: {3}\n Пол: {4}\n ЕГН {5}",employeeNum,firstName, familyName,age,gender,ID);
        }
    }

