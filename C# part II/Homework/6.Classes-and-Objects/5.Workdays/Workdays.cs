//using System;

//    class Workdays
//    {

//        static void WorkDaysOf2013(DateTime endDay)
//        {
//            DateTime[] holidays ={
//                                    new DateTime(2013,03,03),
//                                    new DateTime(2013,05,01),
//                                    new DateTime(2013,05,02),
//                                    new DateTime(2013,05,03),
//                                    new DateTime(2013,05,06),
//                                    new DateTime(2013,05,24),
//                                    new DateTime(2013,09,06),
//                                    new DateTime(2013,09,22),
//                                    new DateTime(2013,12,24),
//                                    new DateTime(2013,12,25),
//                                    new DateTime(2013,12,26),
//                                    new DateTime(2013,12,31),

//                                };

//            DateTime[] workSaturdays ={
//                                          new DateTime(2013,05,11),
//                                          new DateTime(2013,12,14),

//                                     };
            
            
//            DateTime today = DateTime.Today;
//            int allDays = (endDay - today).Days;
//            int workDays = allDays;
//            DateTime day = today;
//            while (day <= endDay)
//            {
//                if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
//                {
//                    workDays--;
//                }
              
//                else 
//                {
//                    for (int i = 0; i < holidays.Length; i++)
//                    {
//                        if (day == holidays[i])
//                        {
//                            workDays--;
//                        }
                        
//                    }
//                    for (int i = 0; i < workSaturdays.Length; i++)
//                    {                       
//                         if (day == workSaturdays[i])
//                        {
//                            workDays++;
//                        }
//                    }
//                }
                
//                day = day.AddDays(1);
//            }
//            Console.WriteLine(workDays);
//        }

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Моля въведете крайна дата(год.месец.ден)");
//            DateTime endDay = DateTime.Parse(Console.ReadLine());
//            WorkDaysOf2013(endDay);
//        }
//    }
using System;
class NumberOfWorkDatesBetweenDates
{
    static bool IsHoliday(DateTime day, DateTime[] holidays)
    {
        foreach (DateTime holiday in holidays)
        {
            if (day == holiday)
            {
                return true;
            }
        }
        return false;
    }

    static void Main()
    {
        DateTime endDate = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Today;
        int days = 0;
        DateTime[] holidays = new DateTime[]
        {
            new DateTime(today.Year, 1, 1),
            new DateTime(today.Year, 3, 3),
            new DateTime(today.Year, 5, 1),
            new DateTime(today.Year, 5, 2),
            new DateTime(today.Year, 5, 6),
            new DateTime(today.Year, 5, 24),
            new DateTime(today.Year, 9, 22),
            new DateTime(today.Year, 12, 24),
            new DateTime(today.Year, 12, 25),
            new DateTime(today.Year, 12, 26),
            new DateTime(today.Year, 12, 31)
        };

        while (today < endDate)
        {
            if (today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday && !IsHoliday(today, holidays))
            {
                days++;
            }
            today = today.AddDays(1);
        }
        Console.WriteLine(days);
    }
}