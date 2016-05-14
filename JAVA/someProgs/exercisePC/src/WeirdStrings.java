import javafx.collections.transformation.SortedList;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Al on 19.4.2016 г..
 */
public class WeirdStrings {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        input = input.replaceAll("[\\\\\\/\\(\\)|\\s]+","");

        Pattern pattern = Pattern.compile("([a-zA-Z]+)");

        Matcher matcher = pattern.matcher(input);

        LinkedList<String> data = new LinkedList<>();

        List<Integer> ind = new ArrayList<>();

        while (matcher.find()){

            data.add(matcher.group(1));
        }

        int maxSum = 0;
        int currentSum = 0;
        int fIndex = 0;
        int sIndex = 0;


        for (int i = 0; i < data.size() - 1; i++) {

            String fString = data.get(i);
            String sString = data.get(i+1);

            int fSum = sumCharacters(fString);
            int sSum = sumCharacters(sString);

            currentSum = fSum + sSum;

            if (currentSum >= maxSum){

                maxSum = currentSum;

                fIndex = i;
                sIndex = i + 1;
            }
        }

        System.out.println(data.get(fIndex));
        System.out.println(data.get(sIndex));
    }

    private static int sumCharacters(String str) {

        int sum = 0;

        for (int i = 0; i < str.length(); i++) {

            int asNum = str.charAt(i);

            if (asNum >= 65 && asNum <= 90){

                sum += asNum - 64;
            } else {

                sum += asNum - 96;
            }
        }

        return sum;
    }
}
