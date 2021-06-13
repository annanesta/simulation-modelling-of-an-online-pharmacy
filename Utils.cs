using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4SOSAPR
{
    static class Utils
    {
        //всего недель на моделирование
        static public int GetNumberOfWeeks (int days)
        {
            float fWeeks = days / 7;
            int iWeeks = days / 7;
            if (fWeeks > iWeeks)
                return iWeeks + 1;
            else
                return iWeeks;
        }
    }
}
