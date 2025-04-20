public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var sb = new StringBuilder("");
        var t = new Trie();
        sb = t.InsertFirst(strs[0]);
        for(int i = 1; i < strs.Length; i++){
            sb = t.Insert(strs[i]);
        }
        return sb.ToString();
    }
}

public class TrieNode{
    public TrieNode[] children;
    public int cnt;
    public TrieNode(){
        children = new TrieNode[26];
        cnt = 0;
    }
}

public class Trie{
    public TrieNode root;
    StringBuilder longest = new StringBuilder("");
    public Trie(){
        root = new TrieNode();
    }

    public StringBuilder InsertFirst(string word){
        var curr = root;
        foreach(char c in word){
            if(curr.children[c-'a'] == null){
                curr.children[c-'a'] = new TrieNode();
            }
            longest.Append(c);
            curr.cnt++;
            curr = curr.children[c-'a'];
        }
        return longest;
    }

    public StringBuilder Insert(string word){
        var curr = root;
        var sb = new StringBuilder("");
        foreach(char c in word){
            if(curr.children[c-'a'] == null){
                break;
            }
            sb.Append(c);
            curr.cnt++;
            curr = curr.children[c-'a'];
        }
        if(sb.Length < longest.Length){
            longest = sb;
        }
        return longest;
    }
}