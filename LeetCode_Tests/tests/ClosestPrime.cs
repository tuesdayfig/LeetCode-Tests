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