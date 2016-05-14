import java.util.Scanner;

/**
 * Created by Al on 18.4.2016 г..
 */
public class AddingAngles {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int someNum = Integer.parseInt(sc.nextLine());

        String [] nums = sc.nextLine().split("\\s+");

        boolean noCircle = true;

        if (someNum > 2) {
            for (int i = 0; i < someNum; i++) {

                for (int j = i + 1; j < someNum; j++) {

                    for (int k = j + 1; k < someNum; k++) {

                        if (i != j && j != k && i != k) {

                            int a = Integer.parseInt(nums[i]);
                            int b = Integer.parseInt(nums[j]);
                            int c = Integer.parseInt(nums[k]);

                            int sum = a + b + c;

                            if (sum % 360 == 0) {

                                System.out.println(a + " + " + b + " + " + c + " = " + sum + " degrees");

                                noCircle = false;
                            }
                        }
                    }
                }
            }
        } else {

            noCircle = false;
        }

        if (noCircle){

            System.out.println("No");
        }
    }
}
