﻿using System;

namespace time_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double dth = ConvertDaysToHours(4);                    //конвертировать дни в часы
            Console.WriteLine("4 days in hours is " + dth);          //результат: 96

            double htm = ConvertHoursToMinutes(3);                 //конвертировать часы в минуты
            Console.WriteLine("3 hours in minutes is " + htm);      //результат: 180

            double mts = ConvertMinutesToSeconds(2);               //конвертировать минуты в секунды
            Console.WriteLine("2 minutes in seconds is " + mts);    //результат: 120

            double stm = ConvertSecondsToMinutes(42);           //конвертировать секунды в минуты
            Console.WriteLine("42 minutes in seconds is " + stm);   //результат: 0.7

            double mth = ConvertMinutesToHours(108);            //конвертировать минуты в часы
            Console.WriteLine("108 minutes in hours is " + mth);    //результат: 1.8

            double htd = ConvertHoursToDays(90);                //конвертировать часы в дни
            Console.WriteLine("90 hours in days is " + htd);         //результат: 3.75

            double dts = ConvertMinutesToSeconds(
                            ConvertHoursToMinutes(
                                ConvertDaysToHours(0.451)));    //конвертировать дни в секунды
            Console.WriteLine("0.451 days in seconds is " + dts);   //результат: 38966.4

            Console.ReadKey();
        }
        static double ConvertDaysToHours(double a)
        {
            return a * 24;
        }
        static double ConvertHoursToMinutes(double b)
        {
            return b * 60;
        }
        static double ConvertMinutesToSeconds(double c)
        {
            return c * 60;
        }
        static double ConvertSecondsToMinutes(double d)
        {
            return d / 60;
        }
        static double ConvertMinutesToHours(double e)
        {
            return e / 60;
        }
        static double ConvertHoursToDays(double f)
        {
            return f / 24;
        }










    }
}
