public class Solution {
    public bool hasDuplicate(int[] nums) {
        var elements = new HashSet<int>();

        foreach(var num in nums){
            if(!elements.Add(num)){
                return true;
            }
        }
        return false;
    }
}