class MainReturnValTest
{
    static int Main()
    {
        ClosestPrime closest = new ClosestPrime();
        closest.ClosestPrimes(10, 19);
        RotateArray rotate = new RotateArray();
        rotate.Rotate([1,2,3,4,5,6,7], 3);
        LongestPrefix longestPrefix = new LongestPrefix();
        longestPrefix.LongestCommonPrefix(["flower", "flow", "flight"]);
        SpiralArray spiralArray = new SpiralArray();
        spiralArray.SpiralOrder([[1,2,3],[4,5,6],[7,8,9]]);
        LongestCommonPrefix longestCommonPrefix = new LongestCommonPrefix();
        longestCommonPrefix.LongestCommonPrefixs([1,10,100], [1000]);
        return 0;
    }

}