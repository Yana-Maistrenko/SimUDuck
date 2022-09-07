using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
   class Duck
    {
        public bool c_swim;
        public string c_display;
        public string[] ducks;
        public Duck(bool swim, string display)
        {
            c_swim = swim;
            c_display = display;
        }

        private static bool Get_swim()
        {
            return swim();
        }

        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;

        //public static Duck AddNewDuck()
        //{
            //var ducks = new Duck();
            //ducks.Push();
        //}

        public static T[] Append<T>(this T[] array, T item)
        {
            List<T> ducks = new List<T>(array);
            ducks.Add(item);
            return ducks.ToArray();
        }
        public string Display()
        {
            return ("I'm a real ");
        }
        public static bool swim()
        {
            //return 
        }
    }
}
