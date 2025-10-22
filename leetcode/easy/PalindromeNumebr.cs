public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) return false;
        int orignal = x;
        int reversed = 0;
        while (x>0){
            int num = x % 10;
            reversed = reversed * 10 + num;
            x = x / 10;
        }
        return reversed == orignal;
    }
}