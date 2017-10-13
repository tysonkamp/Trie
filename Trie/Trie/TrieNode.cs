using System;
using System.Collections.Generic;

namespace Trie
{
    public class TrieNode
    {
        public String word { get; set; }

        public Dictionary<string, TrieNode> Children { get; set; }

        public TrieNode(string key = null)
        {
            word = key;
            Children = new Dictionary<string, TrieNode>();
        }
    }
}
