public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int, int> numbers = new();
        //var numbers = nums
        //    .Select((v,i) =>  i).ToDictionary(i => i,  i => target - nums[i]);

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
