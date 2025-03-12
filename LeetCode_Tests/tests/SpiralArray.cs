internal class SpiralArray {
public IList<int> SpiralOrder(int[][] matrix) {

        //dict to define where to go next
        var nextDirection = new Dictionary<string, string> {
            {"top", "right"},
            {"right", "bottom"},
            {"bottom", "left"},
            {"left", "top"}
        };
        //define how long the top row is
        int m = matrix.Length;
        //define how long the side column is
        int n = matrix[0].Length;
        //define result
        var res = new List<int>();

         int rtop = 0;
         int rbottom = m - 1;
         int cleft = 0;
         int cright = n - 1;

         //starting direction
         string direction = "top";

         while (res.Count != m * n) {
            if (direction == "top") {
                //move right across top
                for (int j = cleft; j <= cright; j++) {
                    res.Add(matrix[rtop][j]);
                }
                rtop++;
            } else if (direction == "right") {
                //if right, move down
                for (int i = rtop; i <= rbottom; i++) {
                    res.Add(matrix[i][cright]);
                }
                cright--;
            } else if (direction == "bottom") {
                //if bottom, move left
                for (int j = cright; j >= cleft; j--) {
                    res.Add(matrix[rbottom][j]);
                }
                rbottom--;
            } else if (direction == "left") {
                //if left, move back up
                for (int i = rbottom; i >= rtop; i--) {
                    res.Add(matrix[i][cleft]);
                }
                cleft++;
            }
            direction = nextDirection[direction];
         }

         return res;
    }
}