public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        if(nums.Length == 0){
            return [];
        }
        Dictionary<int, int> numbers = [];

        for(int i = 0; i < nums.Length; i ++){

            if(numbers.TryGetValue(target - (target - nums[i]), out var indexWanted))
            {
                if(nums[i] + (target - nums[i]) == target){
                    if(indexWanted == i){
                        continue;
                    }

                    return [indexWanted, i];
                }   
            }
            else{
                numbers.Add(target - nums[i],i);
            }
        }

        return [];
        
    

        
    }
}
