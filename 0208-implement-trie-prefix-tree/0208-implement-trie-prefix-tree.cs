public class TrieNode{
    public TrieNode[] children;
    public int word;
    public TrieNode() {
        children = new TrieNode[26];
        word = 0;
    }
}

public class Trie {
    public TrieNode root;
    public Trie() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        var curr = root;
        foreach(char c in word){
            if(curr.children[c-'a'] == null)
                curr.children[c-'a'] = new TrieNode();
            curr = curr.children[c-'a'];
        }
        curr.word++;
    }
    
    public bool Search(string word) {
        var curr = root;
        foreach(char c in word){
            if(curr.children[c-'a'] == null)
                return false;
            curr = curr.children[c-'a'];
        }
        return curr.word > 0;
    }
    
    public bool StartsWith(string prefix) {
        var curr = root;
        foreach(char c in prefix){
            if(curr.children[c-'a'] == null)
                return false;
            curr = curr.children[c-'a'];
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */