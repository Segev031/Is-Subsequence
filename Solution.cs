public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (s.Length == 0) 
            return true;
        int count = 0;
        foreach(char c in t) {
            if (c == s[count]) 
                count++;
            if (count == s.Length)
                return true;
        }
        return false;
    }
}