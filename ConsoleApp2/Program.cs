using System;
using System.Collections.Generic;
using System.Linq;
using EnableNullable;
using NonNullable;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var ttt = new SuperClass();

            ttt.SuggestedTimes.Any();

            Enumerable.Any(ttt.SuggestedTimes);
            ttt.SuggestedTimes.First();
            ttt.SuggestedTimes.Any();

            ttt.SuggestedTimes.TestNonNullable();
            ttt.SuggestedTimes.TestNullable();
            Console.WriteLine("Hello World!");
        }
    }
    public class SuperClass
    {
        public ICollection<string> SuggestedTimes { get; }
    }
}
