using System.Linq;
using System;
using System.Collections.Generic;

namespace _005_Add_and_Search_Word_Data_structure_design
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Design a data structure that supports the following two operations:
                    void addWord(word)
                    bool search(word)

                search(word) can search a literal word or a regular expression string containing only letters a-z or .. A . 
                means it can represent any one letter.

                Example:
                addWord("bad")
                addWord("dad")
                addWord("mad")
                search("pad") -> false
                search("bad") -> true
                search(".ad") -> true
                search("b..") -> true

                Note:
                    You may assume that all words are consist of lowercase letters a-z.
            */

        }
    }

    public class WordDictionary
    {

        /** Initialize your data structure here. */
        public WordDictionary()
        {

        }

        /** Adds a word into the data structure. */
        public void AddWord(string word)
        {

        }

        /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
        public bool Search(string word)
        {
            throw new NotImplementedException();
        }
    }

    /**
     * Your WordDictionary object will be instantiated and called as such:
     * WordDictionary obj = new WordDictionary();
     * obj.AddWord(word);
     * bool param_2 = obj.Search(word);
     */
}
