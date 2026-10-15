public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int, int> numbers = new();
        //var numbers = nums
        //    .Select((v,i) =>  i).ToDictionary(i => i,  i => target - nums[i]);

        for(int i = 0; i < nums.Length; i ++){

            if(numbers.TryGetValue((target - nums[i]), out var index)){   
                if( (target - nums[i]) * 2 == target){
                    if(index == i){
                        continue;
                    }
                    return [index, i];
                } 
            }else{
                numbers.Add(target - nums[i],i);
                index = i;
            }

            if(numbers.TryGetValue(target - (target - nums[i]), out var indexTwo))
            {
                if(index == indexTwo){
                    continue;
                }
                if(index > indexTwo){
                    return [indexTwo, index];
                }

                else{
                    return [index,indexTwo];
                }
            }
        }

        return [0,0];
        
    

        
    }
}
