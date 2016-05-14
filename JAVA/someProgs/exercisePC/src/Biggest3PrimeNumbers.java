import java.util.LinkedList;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Al on 18.4.2016 г..
 */
public class Biggest3PrimeNumbers {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        TreeMap<Integer,String> sum = new TreeMap<>();

        Pattern pattern = Pattern.compile("([\\d-]+)");

        Matcher matcher = pattern.matcher(input);

        while (matcher.find()){

            int num = Integer.parseInt(matcher.group(1));

            if (isPrime(num)){

                if (sum.size() < 3){

                    sum.put(num, "");

                } else {

                    if (!sum.containsKey(num)) {
                        int a = sum.firstKey();

                        if (num > a) {

                            sum.remove(a);
                            sum.put(num, "");
                        }
                    }
                }

            }
        }
        if (sum.size() < 3){

            System.out.println("No");

        } else {

            int sumOfPrimes = 0;
            for (Integer num : sum.keySet()) {

                sumOfPrimes += num;
            }
            System.out.println(sumOfPrimes);

        }
    }

    private static boolean isPrime(int num) {

        if (num < 2){

            return false;
        }

        if (num == 2){
            return true;
        }
        if (num % 2 == 0){
            return false;
        }

        for (int i = 3; i * i <= num ; i+= 2) {


            if (num % i == 0){
                return  false;
            }

        }

        return true;
    }
}
