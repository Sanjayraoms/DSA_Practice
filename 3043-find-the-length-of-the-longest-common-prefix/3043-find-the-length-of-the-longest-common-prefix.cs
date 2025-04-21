public class Solution {
    public int LongestCommonPrefix(int[] arr1, int[] arr2) {
        var t = new Trie();
        var res = 0;
        foreach(int num in arr2){
            t.Insert(num.ToString());
        }
        foreach(int num in arr1){
            var curr = num.ToString();
            res = Math.Max(res,t.countPrefix(curr));
        }
        return res;
    }
}

public class TrieNode{
    public TrieNode[] children;
    public TrieNode(){
        children = new TrieNode[10];
    }
}

public class Trie{
    public TrieNode root;
    public Trie(){
        root = new TrieNode();
    }

    public void Insert(string num){
        var curr = root;
        foreach(char c in num){
            if(curr.children[c-'0'] == null)
                curr.children[c-'0'] = new TrieNode();
            curr = curr.children[c-'0'];
        }
    }

    public int countPrefix(string num){
        var curr = root;
        var pre = 0;
        foreach(char c in num){
            if(curr.children[c-'0'] == null)
                return pre;
            curr = curr.children[c-'0'];
            pre++;
        }
        return pre;
    }
}