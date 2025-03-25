public class RotateBox {
    public char[][] RotateTheBox(char[][] boxGrid) {
            //loop though each row 
            for (var i = 0; i < boxGrid.Length; i++)
            {
                //apply gravity to each row 
                ApplyGravity(boxGrid[i]);
            }
            //once we applied the gravity then we should be rotating 90deg and return it 
            return Rotate90Degrees(boxGrid);
        }
    
    //apply gravity and move objects to the left
    private void ApplyGravity(char[] row) {
        int pos = row.Length - 1;
        for (var i = row.Length - 1; i >= 0; i--) {
            //stones cannot fall on or after this
            if (row[i] == '*') {
                //update position to before the stone
                pos = i - 1;
            } else if (row[i] == '#') {
                if (pos != i) { //if there is a free space, let it fall
                    row[pos] = row[i];
                    row[i] = '.';
                }
                //otherwise stones won't fall
                pos--;
            }
        }
    }

    //rotate the given matric by 90 degree
    private char[][] Rotate90Degrees(char[][] box) {
        //new box that has been rotated with length and rows
        char[][] rotated = new char[box[0].Length][];
        for (var row = 0; row < box[0].Length; row++) {
            rotated[row] = new char[box.Length];

            for (var col = 0; col < box.Length; col++) {
                rotated[row][col] = box[box.Length - col - 1][row];
            }
        }
        return rotated;
    }
}