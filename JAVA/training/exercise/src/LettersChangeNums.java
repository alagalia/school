import java.math.BigDecimal;
import java.math.RoundingMode;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Al on 16.4.2016 г..
 */
public class LettersChangeNums {
    public static void main(String[] args) {

        Scanner sc= new Scanner(System.in);

        String [] input = sc.nextLine().split("\\s+");

        //double sum = 0;
        BigDecimal sum = new BigDecimal("0");

        for (int i = 0; i < input.length; i++) {

            String currentStr = input[i];

            Pattern pattern  = Pattern.compile("([a-zA-Z])(\\d+)([a-zA-Z])");

            Matcher matcher = pattern.matcher(currentStr);

            String firstLetter = "";
            String num = "";
            String secondNum = "";

            while (matcher.find()){

                firstLetter = matcher.group(1);
                char fCh = firstLetter.charAt(0);
                num = matcher.group(2);
                secondNum = matcher.group(3);
                char sCh = secondNum.charAt(0);

                if ((int)fCh >= 65 && (int)fCh <= 90){

                    fCh =(char)((int)fCh - 64);
                    //sum += (double)num / (double)fCh;
                    BigDecimal a = new BigDecimal(num);
                    BigDecimal b = new BigDecimal((int)fCh);
                    sum = sum.add(a.divide(b, 4, RoundingMode.UP));

                } else {

                    fCh = (char)((int)fCh - 96);
                    //sum += num * (int)fCh;
                    BigDecimal a = new BigDecimal(num);
                    BigDecimal b = new BigDecimal((int)fCh);
                    sum = sum.add(a.multiply(b));

                }

                if ((int)sCh >= 65 && (int)sCh <= 90){

                    sCh =(char)((int)sCh - 64);
                    //sum -= (int)sCh;
                    BigDecimal b = new BigDecimal((int)sCh);
                    sum = sum.subtract(b);

                } else {

                    sCh = (char)((int)sCh - 96);
                    //sum += (int)sCh;
                    BigDecimal b = new BigDecimal((int)sCh);
                    sum = sum.add(b);
                }
            }

        }

        System.out.printf("%.2f", sum);
    }
}
