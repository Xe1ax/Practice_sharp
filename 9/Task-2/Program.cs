using System;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Parking park = new Parking(100);
            park.AddCar("A111AB", "Красный", "Вася");
            park.AddCar("B234CK", "Зеленый", "Петя");
            park.AddCar("B493MX", "Синий", "Коля");
            park.AddCar("Y393AA", "Серый", "Дима");
            park.PrintAllCar();

            Console.WriteLine("--------------------------------------");
            Console.Write("Введите номер авто для замены - ");
            string numberRem = Console.ReadLine();
            park.RemCar(numberRem);
            Console.WriteLine("Введите данные на замену");
            Console.Write("Номер машины - ");
            string numberRemm = Console.ReadLine();
            Console.Write("Цвет - ");
            string colorRem = Console.ReadLine();
            Console.Write("Имя - ");
            string nameRem = Console.ReadLine();
            park.AddCar(numberRemm, colorRem, nameRem);
            park.PrintAllCar();

            Console.WriteLine("--------------------------------------");
            Console.Write("Введите цвет для поиска - ");
            string colorFin = Console.ReadLine();
            park.Find(colorFin);

            Console.WriteLine("--------------------------------------");
            Console.Write("Введите номер для поиска - ");
            string numberFin = Console.ReadLine();
            park.Find(numberFin);
        }
    }

    class Parking
    {
        private bool[] place;
        private List<Car> list = new List<Car>(); 
        public Parking(int count)
        {
            place = new bool[count];
        }
        public void AddCar(string number, string color, string owner) 
        {
            for (int i = 0; i < place.Length; i++)
            {
                if (place[i] == false)
                {
                    place[i] = true;
                    list.Add(new Car(number, color, owner, i));
                    return;
                }
            }
            Console.WriteLine("Нет свободных мест");
        }
        public void RemCar(string number) 
        {
            foreach (Car car in list)
            {
                if (car.number == number)
                {
                    list.Remove(car);
                    place[car.order] = false;
                    return;
                }
            }
            Console.WriteLine("Нет такой машины: [{0}]", number);
        }
        public void RemCar(int n) 
        {
            foreach (Car car in list)
            {
                if (car.order == n)
                {
                    list.Remove(car);
                    place[car.order] = false;
                    return;
                }
            }
            Console.WriteLine("Нет такой машины: [{0}]", n);
        }
        public void PrintAllCar() 
        {
            foreach (Car car in list)
            {
                Console.WriteLine(car);
            }
        }
        public void Find(string param) 
        {
            Console.WriteLine("Поиск с параметром: [{0}]", param);
            foreach (Car car in list)
            {
                if (car.color == param || car.number == param || car.owner == param)
                {
                    Console.WriteLine(car);
                }
            }
        }
        public void Find(int place) 
        {
            Console.WriteLine("Поиск с параметром: [{0}]", place);
            foreach (Car car in list)
            {
                if (car.order == place)
                {
                    Console.WriteLine(car);
                }
            }
        }

        private struct Car
        {
            public string number; 
            public string color; 
            public string owner; 
            public int order; 
            public Car(string num, string col, string own, int ord)
            {
                number = num;
                color = col;
                owner = own;
                order = ord;
            }
            public override string ToString()
            {
                return string.Format("Номер:[{0}], Цвет:[{1}], Владелец:[{2}], Место:[{3}]", number, color, owner, order);
            }
        }
    }
}