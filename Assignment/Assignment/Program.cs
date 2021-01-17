using System;

namespace Assignment {
    class Program {
        static void Main(string[] args) {
           
            var allNumbersLooping = new AllNumbersLooping(1, 4);
            allNumbersLooping.AlsoLoopTo(0);
            allNumbersLooping.AlsoLoopTo(10);

            foreach (var number in allNumbersLooping) {
                Console.WriteLine(number);   
            }
        }
    }
}