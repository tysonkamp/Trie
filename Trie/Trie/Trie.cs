using System;
using System.Collections.Generic;

namespace Trie
{
    public class Trie
    {
        TrieNode _Head;

        /** Initialize your data structure here. */
        public Trie()
        {
            _Head = new TrieNode();
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            if (null == word || 0 == word.Length) return;

            TrieNode Current = _Head;
            foreach (char c in word)
            {
                if (false == Current.Children.ContainsKey(c))
                {
                    Current.Children.Add(c, new TrieNode());
                }

                Current = Current.Children[c];
            }
            Current.IsWord = true;
        }

        private TrieNode _Search(string word)
        {
			TrieNode Current = _Head;
			foreach (char c in word)
			{
				if (false == Current.Children.ContainsKey(c)) return null;
				Current = Current.Children[c];
			}

			return Current;
        }
        /** Returns true if the word is in the trie. */
        public bool Search(string word)
        {
            TrieNode tn = _Search(word);

            if (null == tn) return false;

            return tn.IsWord;
        }

        /** Returns true if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            TrieNode tn = _Search(prefix);

			if (null == tn) return false;

            return true;
		}
    }

	public class TrieNode
	{
        public bool IsWord { get; set; } // Can contain partial words, so need to indicate if this is a fragment or a word

        public Dictionary<char, TrieNode> Children { get; set; }

		public TrieNode()
		{
            Children = new Dictionary<char, TrieNode>();
		}
	}
}
