using System;

namespace _013_Iterator_for_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Design an Iterator class, which has:
                    A constructor that takes a string characters of sorted distinct lowercase English letters and a number combinationLength as arguments.
                    A function next() that returns the next combination of length combinationLength in lexicographical order.
                    A function hasNext() that returns True if and only if there exists a next combination.
                

                Example:

                CombinationIterator iterator = new CombinationIterator("abc", 2); // creates the iterator.

                iterator.next(); // returns "ab"
                iterator.hasNext(); // returns true
                iterator.next(); // returns "ac"
                iterator.hasNext(); // returns true
                iterator.next(); // returns "bc"
                iterator.hasNext(); // returns false
                
                Constraints:
                    1 <= combinationLength <= characters.length <= 15
                    There will be at most 10^4 function calls per test.
                    It's guaranteed that all calls of the function next are valid.
            */

            var iterator = new CombinationIterator("abc", 2);

            Console.WriteLine(iterator.Next() == "ab");     // returns "ab"
            Console.WriteLine(iterator.HasNext() == true);  // returns true
            Console.WriteLine(iterator.Next() == "ac");     // returns "ac"
            Console.WriteLine(iterator.HasNext() == true);  // returns true
            Console.WriteLine(iterator.Next() == "bc");     // returns "bc"
            Console.WriteLine(iterator.HasNext() == false); // returns false
        }
    }

    public class CombinationIterator
    {

        public CombinationIterator(string characters, int combinationLength)
        {

        }

        public string Next()
        {
            throw new NotImplementedException();
        }

        public bool HasNext()
        {
            throw new NotImplementedException();
        }
    }

    /**
     * Your CombinationIterator object will be instantiated and called as such:
     * CombinationIterator obj = new CombinationIterator(characters, combinationLength);
     * string param_1 = obj.Next();
     * bool param_2 = obj.HasNext();
     */
}
