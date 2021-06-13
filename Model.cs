using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4SOSAPR
{
    class Model
    {
        List<Item> items = new List<Item>();
        decimal totalCost = 0;
        //метод формирования списка товаров в аптеке
        //входной параметр - номер недели 
        public void SetItemsData(int weekNumber, decimal capital)
        {
            //формирование базового набора лекарств в аптеке на первую неделю
            if (weekNumber==1)
            {
                for (int i =1; i<=10; i++)
                {
                    int amount = i * 25;
                    decimal price = (amount * 10) / (i * 2);
                    Item item = new Item();
                    item.Number = i;
                    item.Amount = amount;
                    item.Price = price;
                    items.Add(item);
                    //проверка на возможности оплаты по бюджету
                    totalCost += (item.Price * item.Amount);
                    if (totalCost >= capital)
                    {
                        items.Remove(item);
                        break;
                    }
                }
            }
            //формирование последующих наборов лекарств в аптеке с учетом популярности товара и минимума поставки
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    //что делать с этим количеством? оно формируется от популярности товара с прошлой недели
                    // todo: изменить количество позиции товара по параметру популярности товара на прошлой неделе
                    int amount = i * 25; //вот это выражение заменить на популярность товара
                    items[i].Amount = amount;
                }
            }
        }

        //метод формирования заказа от "заказчика"
        public void SetOrder (int dayOfTheWeek, int numberOftheWeeks, int orderNumber)
        {
            //общий список товаров с повторами
            List<int> itemsInOrder = new List<int>();
            //TODO ДОБАВИТЬ ПРОВЕРКУ НА НАЛИЧИЕ ТОВАРА В АПТЕКЕ
            //TODO ДОБАВИТЬ СЧЕТЧИК ЗАКАЗОВ КАЖДОГО ТОВАРА ДЛЯ ПРОВЕРКИ В КОНЦЕ НЕДЕЛИ ЕГО ПОПУЛЯРНОСТИ И ФОРМИРОВАНИЯ ЗАКУПОК
            for (int i=0; i<orderNumber; i++)
            {
                if (dayOfTheWeek >= numberOftheWeeks)
                    itemsInOrder.Add((dayOfTheWeek / numberOftheWeeks) + i);
                else
                    itemsInOrder.Add((numberOftheWeeks/ dayOfTheWeek) + i);
            }

            //дополнительный список для сравнения элементов при подсчете одинаковых товаров в корзине
            List<int> itemsInOrder2 = new List<int>();
            itemsInOrder2 = itemsInOrder;

            //словарь: номер товара - количество товара в заказе(корзине)
            Dictionary<int, int> bucketOrder = new Dictionary<int, int>();
            bucketOrder.Clear();//предварительная очистка корзины от предыдущих элементов
            foreach(int i in itemsInOrder)
            {
                int amountOfItem = 0;
                foreach(int j in itemsInOrder2)
                {
                    if (i == j)
                        amountOfItem++;
                    itemsInOrder2.Remove(j);
                }
                bucketOrder.Add(i, amountOfItem);
            }
        }

       
    }
}
 