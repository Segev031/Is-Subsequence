def isSubsequence(s, t):
    """
    :type s: str
    :type t: str
    :rtype: bool
    """
    if len(s) == 0:
        return True
    count = 0
    for c in t:
        if c == s[count]:
            count += 1
        if count == len(s):
            return True
    return False