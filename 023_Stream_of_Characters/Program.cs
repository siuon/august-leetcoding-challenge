using System;
using System.Collections.Generic;

namespace _023_Stream_of_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Implement the StreamChecker class as follows:

                StreamChecker(words): Constructor, init the data structure with the given words.
                query(letter): returns true if and only if for some k >= 1, 
                the last k characters queried (in order from oldest to newest, 
                including this letter just queried) spell one of the words in the given list.
                
                Example:

                StreamChecker streamChecker = new StreamChecker(["cd","f","kl"]); // init the dictionary.
                streamChecker.query('a');          // return false
                streamChecker.query('b');          // return false
                streamChecker.query('c');          // return false
                streamChecker.query('d');          // return true, because 'cd' is in the wordlist
                streamChecker.query('e');          // return false
                streamChecker.query('f');          // return true, because 'f' is in the wordlist
                streamChecker.query('g');          // return false
                streamChecker.query('h');          // return false
                streamChecker.query('i');          // return false
                streamChecker.query('j');          // return false
                streamChecker.query('k');          // return false
                streamChecker.query('l');          // return true, because 'kl' is in the wordlist

                Note:
                    1 <= words.length <= 2000
                    1 <= words[i].length <= 2000
                    Words will only consist of lowercase English letters.
                    Queries will only consist of lowercase English letters.
                    The number of queries is at most 40000.
            */

            var words = new string[] { "cd", "f", "kl" };

            var streamChecker = new StreamChecker(words);

            Console.WriteLine(streamChecker.Query('a') == false); // return false
            Console.WriteLine(streamChecker.Query('b') == false); // return false
            Console.WriteLine(streamChecker.Query('c') == false); // return false
            Console.WriteLine(streamChecker.Query('d') == true);  // return true,
            Console.WriteLine(streamChecker.Query('e') == false); // return false
            Console.WriteLine(streamChecker.Query('f') == true);  // return true,
            Console.WriteLine(streamChecker.Query('g') == false); // return false
            Console.WriteLine(streamChecker.Query('h') == false); // return false
            Console.WriteLine(streamChecker.Query('i') == false); // return false
            Console.WriteLine(streamChecker.Query('j') == false); // return false
            Console.WriteLine(streamChecker.Query('k') == false); // return false
            Console.WriteLine(streamChecker.Query('l') == true);  // return true,
        }
    }

    public class StreamChecker
    {
        public StreamChecker(string[] words)
        {

        }

        public bool Query(char letter)
        {
            return false;
        }
    }

    /**
     * Your StreamChecker object will be instantiated and called as such:
     * StreamChecker obj = new StreamChecker(words);
     * bool param_1 = obj.Query(letter);
     */
}
