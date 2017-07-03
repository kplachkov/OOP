﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main()
        {
            var list = new MyCustomData<int>();
            list.Add(50);
            list.Add(5);
            list.Add(80);
            list.Add(9);

            Console.WriteLine(list[0]);
            Console.WriteLine(list.Count);

            var numbers = CreateList(10, 5);
            var text = CreateList("Ivan", 3);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            foreach (var str in text)
            {
                Console.WriteLine(str);
            }
            
        }

        public static List<T> CreateList<T>(T value, int amount)
        {
            var list = new List<T>();

            for (int i = 0; i < amount; i++)
            {
                list.Add(value);
            }
            return list;
        }

        public static T CreateInstance<T>()
            where T : class, new()
        {
            
            return new T();
            
        }

        public static void DogMethod<T>(T dog)
            where T : Dog

        {

            var name = dog.Name;

        }
    }
}
