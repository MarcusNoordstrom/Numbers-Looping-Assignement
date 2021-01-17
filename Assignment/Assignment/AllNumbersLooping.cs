using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Assignment {
    public class AllNumbersLooping : IEnumerable<int> {
        readonly List<int> _givenNumbers = new List<int>();
        
        public AllNumbersLooping(int from, int to)
        {
            if (from > to) {
                var a = from;
                var b = to;
                to = a;
                from = b;
                foreach (var n in Enumerable.Range(from, to - from + 1).Reverse()) {
                    _givenNumbers.Add(n);
                }
            }
            else if(from < to){
                foreach (var n in Enumerable.Range(from, to - from + 1)) {
                    _givenNumbers.Add(n);
                }
            }
        }

        public void AlsoLoopTo(int number)
        {
            var last = _givenNumbers.Last();
            if (last < number) {
                foreach (var n in Enumerable.Range(last + 1, number - last)) {
                    _givenNumbers.Add(n);
                }
            }
            else if (last > number) {
                var a = last;
                var b = number;
                number = a;
                last = b;
                foreach (var n in Enumerable.Range(last, number - last).Reverse()) {
                    _givenNumbers.Add(n);
                }
            }
        }
        
        public IEnumerator<int> GetEnumerator()
        {
            return _givenNumbers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
        
        #region Old, overcomplicated way
        // public IEnumerator<int> GetEnumerator() {
        //     //Checks to count up or down
        //     if (_givenNumbers.First() > _givenNumbers.Last()) {
        //         //Counts down
        //         for (var n = 0; n < Math.Abs(_givenNumbers.First() - _givenNumbers.Last()) - 1; n++) {
        //             _givenNumbers.Insert(n + 1,_givenNumbers.First() - n - 1);
        //         }
        //     }
        //     else if (_givenNumbers.First() < _givenNumbers.Last()) {
        //         //Counts up
        //         for (var n = 0; n < Math.Abs(_givenNumbers.First() - _givenNumbers.Last()) - 1; n++) {
        //             _givenNumbers.Insert(n + 1,_givenNumbers.First() + n + 1);
        //         }
        //     }
        //     return _givenNumbers.GetEnumerator();
        // }
        #endregion
    }
}