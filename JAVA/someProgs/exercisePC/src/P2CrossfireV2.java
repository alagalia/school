import java.util.Collections;
import java.util.LinkedList;
import java.util.Scanner;

/**
 * Created by Al on 27.4.2016 г..
 */
public class P2CrossfireV2 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String [] dimensions = sc.nextLine().split("\\s+");

        int row = Integer.parseInt(dimensions[0]);
        int col = Integer.parseInt(dimensions[1]);

        LinkedList<LinkedList<Integer>> matrix = new LinkedList<>();

        fillTheMatrix(row, col, matrix);

        String input = sc.nextLine();

        while (!input.equals("Nuke it from orbit")){

            String [] bomb = input.split("\\s+");

            long bombRow = Long.parseLong(bomb[0]);
            long bombCol = Long.parseLong(bomb[1]);
            long radius = Long.parseLong(bomb[2]);

            long startRow = bombRow - radius;
            if (startRow < 0){

                startRow = 0;

            }

            long endRow = bombRow + radius;
            if (endRow >= matrix.size()){

                endRow = matrix.size() - 1;
            }

            long startCol = bombCol - radius;
            if (startCol < 0){

                startCol = 0;
            }

            long endCol = bombCol + radius;
            if (endCol >= col){

                endCol = col - 1;
            }


            for (long i = bombRow; i <=bombRow ; i++) {

                for (long j = startCol; j <= endCol ; j++) {

                    if (i >= 0 && i < matrix.size()) {

                        if (j < matrix.get((int) i).size()) {

                            matrix.get((int) i).set((int) j, -1);
                        }
                    }
                }

            }

            for (long i = bombCol; i <= bombCol ; i++) {

                for (long j = startRow; j <= endRow ; j++) {

                    if (j >= 0 && j < matrix.size()) {
                        if (i >= 0 && i < matrix.get((int)j).size()) {

                            matrix.get((int)j).set((int) i, -1);
                        }
                    }
                }
            }

            cleanTheList(matrix);



            input = sc.nextLine();
        }

        matrix.stream().forEach(x -> {
            x.forEach(y -> System.out.printf("%d ", y));
            System.out.println();
        } );

    }

    private static void cleanTheList(LinkedList<LinkedList<Integer>> matrix) {
        matrix.stream().forEach(x -> x.removeAll(Collections.singleton(-1)));
        matrix.removeIf(x -> x.size() == 0);
    }

    private static void fillTheMatrix(int row, int col, LinkedList<LinkedList<Integer>> matrix) {
        int counter = 1;

        for (int i = 0; i < row; i++) {

            matrix.add(i, new LinkedList<>());

            for (int j = 0; j < col; j++) {

                matrix.get(i).add(counter);

                counter++;
            }
        }
    }
}
