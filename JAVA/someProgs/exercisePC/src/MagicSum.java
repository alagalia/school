import com.sun.javafx.binding.StringFormatter;

import java.util.LinkedList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by Al on 19.4.2016 г..
 */
public class MagicSum {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int remainder = Integer.parseInt(sc.nextLine());

        LinkedList<Integer> nums = new LinkedList<>();

        String input = sc.nextLine();

        while (!input.equals("End")){

            nums.add(Integer.parseInt(input));

            input = sc.nextLine();
        }

        int fNum = 0;
        int snum = 0;
        int tNum = 0;

        String resultAsString = "";
        int maxSum = Integer.MIN_VALUE;
        int currentSum = 0;

        boolean hasFound = false;

        for (int i = 0; i < nums.size(); i++) {

            for (int j = 0; j < nums.size(); j++) {

                for (int k = 0; k < nums.size(); k++) {

                    if (i != j && i != k && j != k){

                        fNum = nums.get(i);
                        snum = nums.get(j);
                        tNum = nums.get(k);

                        boolean result = (fNum + snum + tNum) % remainder == 0;

                        if (result){

                            //System.out.printf("(%d + %d + %d) %% %d == 0", fNum, snum, tNum, remainder);
                            currentSum = fNum + snum + tNum;

                            if (currentSum > maxSum){

                                maxSum = currentSum;
                                resultAsString = String.format("(%d + %d + %d) %% %d = 0", fNum, snum, tNum, remainder);
                            }
                            hasFound = true;

                        }

                    }
                }
            }
        }

        if (hasFound){
            System.out.println(resultAsString);
        } else {
            System.out.println("No");
        }
    }
}
