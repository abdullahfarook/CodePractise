// See https://aka.ms/new-console-template for more information
using ConsoleDump;
using System.Collections;
using System.Collections.Generic;

var sums = new int[] { 1, 3, 4, 8, 9 };
var result = TwoSum(sums, 11);
result.Dump();


var hash = new Hashtable();

hash.Add("hello", "world");
hash.Add("hello", "hello");
int[] TwoSum(int[] nums, int target)
{
    int i = 0;int j = nums.Length-1;
    while (i < j)
    {
        new { i, j }.Dump();
        var find = nums[i] + nums[j];
        if(find == target)
        {
            return new int[]{ nums[i] , nums[j] };
        }
        if (find < target)
        {
            i++;
        }
        else
        {
            j--;
        }
    }

    return null;
}