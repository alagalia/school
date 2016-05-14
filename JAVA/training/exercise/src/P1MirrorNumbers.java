import java.util.Scanner;

/**
 * Created by Al on 30.4.2016 г..
 */
public class P1MirrorNumbers {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int nNumbers = Integer.parseInt(sc.nextLine());

        String[] numbers = sc.nextLine().split("\\s+");

        boolean thereIsNoMirroredNum = true;

        for (int i = 0; i < numbers.length - 1; i++) {

            StringBuilder sb = new StringBuilder(numbers[i]);

            for (int j = i + 1; j < numbers.length; j++) {

                if (i == j) {
                    continue;
                }

                StringBuilder sbb = new StringBuilder(numbers[j]);

                int fNum = Integer.parseInt(sb.toString());
                int sNum = Integer.parseInt(sbb.toString());

                if (fNum != sNum){

                    sb.reverse();
                    fNum = Integer.parseInt(sb.toString());

                    if (fNum == sNum){

                        System.out.printf("%s<!>%s", sb.reverse().toString(), sbb.toString());
                        System.out.println();

                        thereIsNoMirroredNum = false;
                    }
                }
                sb.reverse();
            }
        }

        if (thereIsNoMirroredNum){

            System.out.println("No");
        }
    }
}
