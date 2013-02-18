using System;

class BankAccount
{
    static void Main()
        {
            string firstName="Мария";
            string secondName="Иванова";
            string lastName = "Иванова";
            decimal sumBalance=250.60M;
            string bankName= "DSK Bank";
            string IBAN = "BG16011012500000000445";
            string BICcode = "STSABGSFXXX";
            ulong CreditCardNumVisa = 4234567891234567;
            ulong CreditCardNumSolo = 6334567891234567;
            ulong CreditCardNumVisaElectron = 4026456789123456;
            Console.WriteLine("Вашият акаунт:\nИме:{0}\nПрезиме:{1}\nФамилия;{2}\nБаланс по сметка:{3}\nИме на банка:{4}\nIBAN: {5}\nBIC:{6}\nVisa:{7}\nSolo:{8}\nVIsaElektron{9}\n",
                firstName,secondName,lastName,sumBalance,bankName,IBAN,BICcode,CreditCardNumVisa,CreditCardNumSolo,CreditCardNumVisaElectron);
        }
}