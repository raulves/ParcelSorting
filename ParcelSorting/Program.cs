using System;
using System.Collections.Generic;

namespace ParcelSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var parcelSorting = new ParcelSorting();
            Console.WriteLine(parcelSorting.CanSortTheParcel(new List<int>(){100, 35, 90, 35}));
        }
    }
}