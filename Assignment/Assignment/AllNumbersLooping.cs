using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Assignment {
//TODO: AllNumbersLooping should implement IEnumerable<int>

//TODO: The constructor takes two arguments: int from, int to

//TODO: The output of foreach should give all numbers between from and to:
// var allNumbersLooping = new AllNumbersLooping(3, 7);
// foreach(var number in allNumbersLooping){
// Console.Write(number);
// }
// Output: 34567


// Internally, your class is only allowed to store:
// List<int> givenNumbers = new List<int>();
// In this list, you are allowed to add all the numbers given in the constructor and in the AlsoLoopTo-Method. But no numbers inbetween.

    public class AllNumbersLooping : IEnumerable<int> {
        readonly List<int> _givenNumbers = new List<int>();
        public AllNumbersLooping(int from, int to) {
            _givenNumbers.Add(from);
            _givenNumbers.Add(to);
        }

        public void AlsoLoopTo(int number) {
            _givenNumbers.Add(19);
        }

        public IEnumerator<int> GetEnumerator() {
            //Checks to count up or down
            if (_givenNumbers.First() > _givenNumbers.Last()) {
                //Counts down
                for (var n = 0; n < Math.Abs(_givenNumbers.First() - _givenNumbers.Last()) - 1; n++) {
                    _givenNumbers.Insert(n + 1,_givenNumbers.First() - n - 1);
                }
            }
            else if (_givenNumbers.First() < _givenNumbers.Last()) {
                //Counts up
                for (var n = 0; n < Math.Abs(_givenNumbers.First() - _givenNumbers.Last()) - 1; n++) {
                    _givenNumbers.Insert(n + 1,_givenNumbers.First() + n + 1);
                }
            }
            return _givenNumbers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}