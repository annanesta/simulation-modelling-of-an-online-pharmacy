using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4SOSAPR
{
    static class Config
    {
        //заполение списка частоты создания заказов
        static public List<int> GetFrequency()
        {
            List<int> frequency = new List<int>();
            for (int i = 1; i <= 10; i++)
                frequency.Add(i * 10);
            return frequency;
        }

        //заполнение списка по кличеству дней моделирования
        static public List<int> GetTheAmountOfTheDays()
        {
            List<int> amountOfTheDays = new List<int>();
            for (int i = 1; i <= 99; i++)
                amountOfTheDays.Add(i);
            return amountOfTheDays;
        }

        //заполнение списка, определяющего начало моделирования
        static public List<string> GetTheDayOfTheStart()
        {
            List<string> Days =
                new List<string> { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            return Days;
        }

        //заполнение списка, определяющего стартовый капитал
        static public List<decimal> GetStartUpCapital()
        {
            List<decimal> startUpCapital = new List<decimal>();
            for (int i = 1; i <= 99; i++)
                startUpCapital.Add(i * 100000);
            return startUpCapital;
        }
    }
}
