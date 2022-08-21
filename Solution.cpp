class Solution {
public:
    bool isSubsequence(string s, string t) {
        if (s.length() == 0)
            return true;
        int count = 0;
        for (char c : t) {
            if (c == s.at(count))
                count++;
            if (count == s.length())
                return true;
        }
        return false;
    }
};