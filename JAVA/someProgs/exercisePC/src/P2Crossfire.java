import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

/**
 * Created by Al on 27.4.2016 г..
 */
public class P2Crossfire {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String [] dimensions = sc.nextLine().split("\\s+");

        int row = Integer.parseInt(dimensions[0]);
        int col = Integer.parseInt(dimensions[1]);

        int [][] matrix = new int[row][col];

        fillTheMatrix(row, col, matrix);

        String input = sc.nextLine();

        while (!input.equals("Nuke it from orbit")){

            String [] bombCenter = input.split("\\s+");

            long bombRow = Long.parseLong(bombCenter[0]);
            long bombCol = Long.parseLong(bombCenter[1]);
            long radius = Long.parseLong(bombCenter[2]);

            long startRow = bombRow - radius;
            if (startRow < 0){
                startRow = 0;
            }

            long endRow = bombRow + radius;
            if (endRow >= matrix.length){
                endRow = matrix.length - 1;
            }

            long startCol = bombCol - radius;
            if (startCol < 0){
                startCol = 0;
            }

            long endCol = bombCol + radius;
            if (endCol >= col){
                endCol = col - 1;
            }

            if (bombCol >= 0 && bombCol < col){

                for (long i = bombCol; i <= bombCol ; i++) {

                    for (long j = startRow; j <= endRow ; j++) {

                        matrix[(int)j][(int)i] = 0;
                    }

                }

            }

            if (bombRow >= 0 && bombRow < matrix.length){

                for (long i = bombRow; i <= bombRow ; i++) {

                    for (long j = startCol; j <= endCol; j++) {

                        matrix[(int)i][(int)j] = 0;
                    }
                }

            }

            if ((bombRow >= 0 && bombRow < matrix.length) || (bombCol >= 0 && bombCol < col)){

                LinkedList<Integer> rowList = new LinkedList<>();

                List<Integer> emptyRow = new ArrayList<>();

                long sum = 0;

                for (long i = startRow; i <= endRow ; i++) {

                    if (i >= 0 && i < matrix.length) {

                        sum = 0;
                        rowList.clear();
                        for (int j = 0; j < col; j++) {

                            int num = matrix[(int) i][j];

                            sum += num;

                            if (num != 0) {

                                rowList.add(num);
                            }


                        }
                        if (sum == 0) {

                            emptyRow.add((int) i);
                        }

                        for (int j = 0; j < col; j++) {

                            if (j < rowList.size()) {

                                matrix[(int) i][j] = rowList.get(j);
                            } else {
                                matrix[(int) i][j] = 0;
                            }
                        }
                    }
                }

                if (emptyRow.size() != 0){


                    int [][] support = new int[matrix.length - emptyRow.size() ][col];


                    int k = 0;
                    for (int i = 0; i < matrix.length; i++) {

                        if (emptyRow.contains(i)){
                            k++;
                        }

                        for (int j = 0; j < col; j++) {

                            if (!emptyRow.contains(i)){

                                support[i - k][j] = matrix [i][j];
                            }
                        }
                    }

                    matrix = support;
                }
            }



            input = sc.nextLine();
        }


        for (int i = 0; i < matrix.length; i++) {

            for (int j = 0; j < col; j++) {

                if (matrix[i][j] != 0) {

                    System.out.printf("%d ", matrix[i][j]);
                }
            }
            System.out.println();
        }

    }

    private static void fillTheMatrix(int row, int col, int[][] matrix) {
        int counter = 1;

        for (int i = 0; i < row; i++) {

            for (int j = 0; j < col; j++) {

                matrix[i][j] = counter;
                counter++;
            }
        }
    }
}
