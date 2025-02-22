# You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. 
# The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.
# Increment the large integer by one and return the resulting array of digits.


  public class Solution {
    public int[] PlusOne(int[] digits) {
       for(int i = digits.Length-1; i>=0; i--) {
        digits[i] = digits[i]+1;
        if(digits[i] !=10)
        return digits;
        digits[i]=0;
       }

       int[] result = new int[digits.Length +1];
       result[0]= 1;
       return result;
    }
}
