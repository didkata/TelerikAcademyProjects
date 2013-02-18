using System;

    class HexToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter hexadecimal number:");
            string hexNumber = Console.ReadLine();
            int result = 0;
            int decimalNum = 0;
            for (int i = 0; i < hexNumber.Length; i++)
            {
                switch (hexNumber[hexNumber.Length-1-i])
                {
                    case 'A': decimalNum=10 ; break;
                    case 'B': decimalNum = 11; break;
                    case 'C': decimalNum = 12; break;
                    case 'D': decimalNum = 13; break;
                    case 'E': decimalNum = 14; break;
                    case 'F': decimalNum = 15; break;
                    default: decimalNum = int.Parse(Convert.ToString(hexNumber[hexNumber.Length - 1 - i]));
                        break;
                }                       
                
                 result+=decimalNum * (int)Math.Pow(16, i);
            }
            Console.WriteLine(result);
        }
    }

