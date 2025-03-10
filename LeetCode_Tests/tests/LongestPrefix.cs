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