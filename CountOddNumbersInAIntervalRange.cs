public class Solution {
    public int CountOdds(int low, int high) {
        int cnt = 0;
        if(high-low+1%2 == 0)
        {
            return (high-low+1)/2;
        }
        else
        {
            if(high %  2 == 1)
            {cnt++;}
            if(low %  2 == 1)
            {cnt++;}
            
            return (high-low+1+cnt)/2;
        }
        
    }
}
