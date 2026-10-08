
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }

        int[] words= new int[26];

        for(int i = 0; i < s.Length; i++){
            words[s[i] - 'a']++;
            words[t[i] - 'a']--;
        }

        foreach(int i in words){
            if(i != 0){
                return false;
            }
        }

        return true;
    }
}
