using System;

namespace Assignment {
    class Program {
        static void Main(string[] args) {
           
            var allNumbersLooping = new AllNumbersLooping(5, 1);
            allNumbersLooping.AlsoLoopTo(7);
            
            foreach (var number in allNumbersLooping) {
                Console.WriteLine(number);   
            }
        }
    }
}


// Furthermore, I can use the method void AlsoLoopTo(int number) to make it loop to another number:
//
// var allNumbersLooping = new AllNumbersLooping(3, 7);
// alllNumbersLooping.AlsoLoopTo(5);
// alllNumbersLooping.AlsoLoopTo(9);
// foreach(var number in allNumbersLooping){
// Console.Write(number);
// }
//
//
// Output: 34567656789
//

//
// var allNumbersLooping = new AllNumbersLooping(3, 7);
// alllNumbersLooping.AlsoLoopTo(5);
// alllNumbersLooping.AlsoLoopTo(9);
// foreach(var number in allNumbersLooping){
// Console.Write(number);
// }
//
//
// givenNumbers should contain: 3,7,5,9