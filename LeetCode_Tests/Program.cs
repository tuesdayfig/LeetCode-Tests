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
        return 0;
    }

}

internal class LongestPrefix
{
    public string LongestCommonPrefix(string[] strs) {
        string s = "";

        //iterate through each char in first string
        for (int i = 0; i < strs[0].Length; i++) {
            //iterate through other strings starting from index 1
            for (int j = 0 ; j < strs.Length; j++) {
                //check if current index is out of bounds
                //or if chars at position i is different than strs[j] and strs[0]
                if (i >= strs[j].Length || strs[j][i] != strs[0][i]) {
                    return s;
                }
            }
            //append the current char to the common prefix
            s += strs[0][i];
        }

        return s;

    }
}

internal class RotateArray
{
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k = k % n;
        int[] result = new int[n];
        for (int i = 0; i < n; i++) {
            result[(i + k) % n] = nums[i];
            Console.WriteLine(((i + k) % n));
        }
    }
}

internal class ClosestPrime
{
    public int[] ClosestPrimes(int left, int right)
    {
        bool[] sieves = new bool[right + 1];
        Array.Fill(sieves, true);
        sieves[0] = sieves[1] = false;


        for (int i = 2; i * i <= right; i++) {
            //if i is marked as a prime
            if (sieves[i]) {
                //marks all multiples of i false because they cannot be prime
                for (int j = i * i; j <= right; j += i) {
                    sieves[j] = false;
                }
            }
        }

        List<int> primes = new List<int>();
        for (int i = left; i <= right; i++)
        {
            if (sieves[i])
            {
                //stores only primes within range of left to right
                primes.Add(i);
            }
        }

        //base case
        if (primes.Count < 2)
        {
            return new int[] { -1, -1 };
        }

        int minGap = int.MaxValue;
        //stores closest prime pair
        int[] result = new int[2] { -1, -1 };

        for (int i = 1; i < primes.Count; i++)
        {
            int gap = primes[i] - primes[i - 1];
            if (gap < minGap)
            {
                minGap = gap;
                result[0] = primes[i - 1];
                result[1] = primes[i];
            }
        }
        return result;
    }
}