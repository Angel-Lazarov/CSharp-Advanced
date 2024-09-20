using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class Constants
    {

        static Constants()
        {
            //трябва поне веднъж да е извикан статичния клас, за да се активира статичния конструктор!
            NumberOfPlayers = 33;
        }

        // static readonly == const

        public static readonly int NumberOfPlayers = 4;
        public const string GameName = "Need for speed";
        public static void PrintMessage()
        {
            Console.WriteLine("Global message");
        }

    }
}
