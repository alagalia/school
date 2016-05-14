import java.util.Scanner;

/**
 * Created by Al on 18.4.2016 г..
 */
public class PythagoreanNums {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int line = Integer.parseInt(sc.nextLine());

        int[] nums = new int[line];

        for (int i = 0; i < line; i++) {

            nums[i] = Integer.parseInt(sc.nextLine());
        }

        boolean hasPythagorean = false;

        for (int i = 0; i < line; i++) {

            for (int j = 0; j < line; j++) {

                for (int k = 0; k < line; k++) {

                    int a = nums[i];
                    int b = nums[j];
                    int c = nums[k];

                    if (a <= b ){

                        if (a*a + b*b == c*c){

                            System.out.printf("%d*%d + %d*%d = %d*%d", a, a, b, b, c, c);
                            System.out.println();

                            hasPythagorean = true;
                        }
                    }
                }
            }
        }

        if (!hasPythagorean){
            System.out.println("No");
        }
    }
}
