public class LongestCommonPrefix {
    class Trie {
        public Trie[] Children { get;}
       
        public Trie() {
            Children = new Trie[10];
        }
    }

    public int LongestCommonPrefixs(int[] arr1, int[] arr2) {
        var trie = new Trie();

        foreach (var num in arr1) {
            var node = trie;
            //iterate through digits
            foreach (var digit in num.ToString()) {
                //remove '0' from digits
                var index = digit - '0';
                //create new trie node if no children present
                if (node.Children[index] == null) {
                    node.Children[index] = new Trie();
                }
                node = node.Children[index];
            }
        }

        var max = 0;
        foreach (var num in arr2) {
            var node = trie;
            var localMax = 0;
            foreach (var digit in num.ToString()) {
                var index = digit - '0';
                if (node.Children[index] != null) {
                    //find max value between localmax and max
                    //set max to var max
                    max = Math.Max(max, ++localMax);
                    node = node.Children[index];
                } else {
                    //if no children are found, break
                    break;
                }
            }
        }

        return max;
    }
}