﻿namespace _11.Party_Reservation_Filter_Module
{
    using System;
    using System.Linq;

    public class Filter
    {
        public string Command { get; set; }

        public string Arg { get; set; }

        public static string[] FilterCollection(string[] collection, Func<string, bool> func)
        {
            return collection.Where(n => func(n)).ToArray();
        }
    }
}
