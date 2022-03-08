public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //Declare
        int len = nums.Length;
        Dictionary <int, int> resDict = new();
        //Validate
        if(nums == null || len < 2){
            return Array.Empty<int>();
        }
        //Logic
        for(int i = 0; i < len; i++){
            int firstnum = nums[i];
            int secondnum = target - firstnum;
            if(resDict.TryGetValue(secondnum, out int index)){
                return new [] {i, index}; 
            }
            resDict[firstnum]=i;
        }
        return Array.Empty<int>();
    }
}