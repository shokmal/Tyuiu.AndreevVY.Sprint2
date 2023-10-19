﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.AndreevVY.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V3

    {
        public string FindDayName(int value)
        {
            string res = "";
            switch (value % 7)
            {
                case 1:
                    res = "Понедельник";
                    break;
                case 2:
                    res = "Вторник";
                    break;
                case 3:
                    res = "Среда";
                    break;
                case 4:
                    res = "Четверг";
                    break;
                case 5:
                    res = "Пятница";
                    break;
                case 6:
                    res = "Суббота";
                    break;
                case 0:
                    res = "Воскресенье";
                    break;
                default:
                    throw new Exception("Вы ввели не число");

            }
            return res;
        }
    }
}
