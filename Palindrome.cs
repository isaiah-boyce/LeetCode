public class Solution {
    public bool IsPalindrome(int x) {
        string fwdString = x.ToString();
        string revString = Reverse(fwdString);
        if(fwdString == revString){
            return true;
        }
        return false;
    }
    
    public string Reverse(string x){
        char[] charArray = x.ToCharArray();
        Array.Reverse(charArray);
        return new String(charArray);
    }
}
