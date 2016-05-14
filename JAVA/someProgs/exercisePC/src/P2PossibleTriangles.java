import java.util.Arrays;
import java.util.DoubleSummaryStatistics;
import java.util.Scanner;

/**
 * Created by Al on 30.4.2016 г..
 */
public class P2PossibleTriangles {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String command = sc.nextLine();

        boolean noTriangle = true;

        while (!command.equals("End")){

            String[] input = command.split("\\s+");
            double[] sortNums = new double[3];

            for (int i = 0; i < 3; i++) {

                sortNums[i] = Double.parseDouble(input[i]);
            }

            Arrays.sort(sortNums);

            double a = sortNums[0];
            double b = sortNums[1];
            double c = sortNums[2];

            if (a < c && b < c){

                if ( a + b > c){

                    noTriangle = false;

                    System.out.printf("%.2f+%.2f>%.2f", a, b, c);
                    System.out.println();
                }
            }


            command = sc.nextLine();
        }

        if (noTriangle){
            System.out.println("No");
        }
    }
}
