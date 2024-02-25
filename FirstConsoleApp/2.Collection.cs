class Coll {
    public void Learn(){
        // One dimensional array
        byte[] ages = [78, 23, 45, 60, 24];
        string[] names = ["prashuva", "prena"];
        // Multi dimentional array
        int[,] studentInClassRoom = new int[7,6];
        studentInClassRoom[0,0]= 1;
        studentInClassRoom[0,1]= 6;
        studentInClassRoom[0,2]= 8;
        studentInClassRoom[0,3]= 13;

        // jagged array
        int[][] studentInClassRoom2 = new int[7][];
        int[][] studentInClassRoom3= [[1, 2, 3], [7, 5, 8, 10],[8, 13]];
    }
}