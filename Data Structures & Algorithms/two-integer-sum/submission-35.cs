public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int, int> numbers = new ();

        for(int i = 0; i < nums.Length; i ++){

            if(numbers.TryGetValue(nums[i], out var indexWanted))
            {
                return [indexWanted, i];
            }
            
            numbers.TryAdd(target - nums[i], i);
        }

        return [];
        
    

        
    }
}
