import java.util.Scanner;
import java.util.StringJoiner;

/**
 * Created by Al on 16.4.2016 г..
 */
public class LegoBlocks {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int rows = Integer.parseInt(sc.nextLine());

        String [] matrixFirst = new String[rows];
        String [] matrixSecond = new String[rows];

        int allLenght = 0;

        for (int i = 0; i < rows; i++) {

            matrixFirst[i] = sc.nextLine().replaceAll("\\s+", " ").trim();
            allLenght += matrixFirst[i].split(" ").length;
        }

        for (int i = 0; i < rows; i++) {

            matrixSecond[i] = sc.nextLine().replaceAll("\\s+", " ").trim();

            allLenght += matrixSecond[i].split(" ").length;
        }

        boolean hasBlock = false;
        int blockLenght = matrixFirst[0].length() + matrixSecond[0].length();

        for (int i = 0; i < rows; i++) {

            int first = matrixFirst[i].length();
            int second = matrixSecond[i].length();

            if ((first + second) != blockLenght){

                hasBlock = false;
                break;
            } else {

                hasBlock = true;
            }

        }

        if (hasBlock){

            for (int i = 0; i < rows; i++) {

                String a = matrixFirst[i];
                String b = matrixSecond[i];
                a = a.replaceAll("\\s+", ", ");
                StringBuilder sb = new StringBuilder(b);

                sb = sb.reverse();
                b = sb.toString();
                b = b.replaceAll("\\s+", ", ");

                System.out.println("["+ a + ", " + b + "]");

            }

        } else {

            System.out.printf("The total number of cells is: %d", allLenght);
        }
    }
}
