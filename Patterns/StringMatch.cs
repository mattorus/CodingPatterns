using System;
using System.Collections.Generic;
using System.Text;

using CodingPatterns.DataStructures;

namespace CodingPatterns.Patterns
{
    class StringMatch
    {
        public static void RunTests()
        {
            IList<string> dict;
            string testPattern, name;

            testPattern = "STRINGMATCH";
            Helpers.PrintStartTests(testPattern);

            name = "ReplaceWords";
            Helpers.PrintStartFunctionTest(name);

            dict = new List<string> { "cat", "bat", "rat" };
            string sentence = "the cattle was rattled by the battery";
            Console.WriteLine(ReplaceWords(dict, sentence));

            Helpers.PrintEndTests(testPattern);
        }
        public static string ReplaceWords(IList<string> dict, string sentence)
        {
            TrieNode root;
            List<string> words = new List<string>();
            StringBuilder sb = new StringBuilder();
            string delimiter = " ";

            if (dict == null || String.IsNullOrEmpty(sentence))
            {
                return "";
            }

            root = new TrieNode(char.MinValue);

            foreach (string word in dict)
            {
                root.Add(word);
            }

            var tokens = sentence.Split(delimiter);

            foreach (var token in tokens)
            {
                Console.WriteLine($"Searching for {token}");
                var word = root.GetRoot(token);

                if (!String.IsNullOrEmpty(word))
                {
                    words.Add(word);
                    Console.WriteLine($"Adding root: {word}");
                }
                else
                {
                    words.Add(token);
                    Console.WriteLine($"Adding original word: {token}");
                }
            }

            return String.Join(delimiter, words.ToArray());
        }
    }    
}
