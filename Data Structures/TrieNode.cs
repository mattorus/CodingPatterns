using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.DataStructures
{
    public class TrieNode
    {
        public char Value { get; }
        public Dictionary<char, TrieNode> Children { get; }
        public bool IsWord { get; set; }

        public TrieNode(char val)
        {
            this.Value = val;
            Children = new Dictionary<char, TrieNode>();
        }

        public void Add(string word)
        {
            TrieNode curNode = this;

            if (String.IsNullOrEmpty(word))
            {
                return;
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (!curNode.Children.ContainsKey(word[i]))
                {
                    curNode.Children[word[i]] = new TrieNode(word[i]);
                }

                curNode = curNode.Children[word[i]];
                Console.WriteLine($"Added child: {curNode.Value}");
            }

            curNode.IsWord = true;
        }

        public string GetRoot(string word)
        {
            TrieNode curNode = this;
            StringBuilder sb = new StringBuilder();

            if (String.IsNullOrEmpty(word) || !Children.ContainsKey(word[0]))
            {
                return null;
            }

            for (int i = 0; i < word.Length && curNode.Children.ContainsKey(word[i]) && !curNode.IsWord; i++)
            {   
                curNode = curNode.Children[word[i]];
                Console.Write($"Found char: {curNode.Value}");
                sb.Append(curNode.Value);
            }

            Console.WriteLine();

            if (curNode.IsWord)
            {
                return sb.ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
