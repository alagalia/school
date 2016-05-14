import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Al on 18.4.2016 г..
 */
public class Largest3Rectangles {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        Pattern pattern = Pattern.compile("\\s*\\[\\s*(\\d+)\\s*x\\s*(\\d+)\\s*\\]");

        Matcher matcher = pattern.matcher(input);

        LinkedList<String> rectangles = new LinkedList<>();

        while (matcher.find()){

            String firstNum = matcher.group(1);

            String secondNum = matcher.group(2);

            String multiplication = firstNum + "," + secondNum;

            rectangles.add(multiplication);
        }

        int currentSum = 0;
        int maxSum = -1;

        //String result = "";

        for (int i = 0; i < rectangles.size() - 2; i++) {

            currentSum = 0;
            String[] a = rectangles.get(i).split(",");
            int a1 = Integer.parseInt(a[0]);
            int a2 = Integer.parseInt(a[1]);

            String[] b = rectangles.get(i + 1).split(",");
            int b1 = Integer.parseInt(b[0]);
            int b2 = Integer.parseInt(b[1]);

            String[] c = rectangles.get(i + 2).split(",");
            int c1 = Integer.parseInt(c[0]);
            int c2 = Integer.parseInt(c[1]);

            currentSum = a1 * a2 + b1 * b2 + c1 * c2;

            if (currentSum > maxSum){

                maxSum = currentSum;

//                result = a1 + "*" + a2 + " + " + b1 + "*" + b2
//                        + " + " + c1 + "*" + c2 + " = " + maxSum;
            }
        }

        System.out.println(maxSum);
    }

}
