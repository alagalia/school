import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Al on 19.4.2016 г..
 */
public class LongestOddEvenSequences {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        Pattern pattern = Pattern.compile("\\d+");

        Matcher matcher = pattern.matcher(input);

        LinkedList<Integer> data = new LinkedList<>();

        boolean isOdd = false;
        boolean isEven = false;
        boolean isZero = false;
        int elementBeforeZero = 0;
        int zeroCount = 0;

        int maxLength = 0;
        int currentLength = 0;

        while (matcher.find()){

            int num = Integer.parseInt(matcher.group());

            if (!data.isEmpty()){

                if (num == 0){

                    if (data.getLast() != 0) {
                        elementBeforeZero = data.getLast();
                    }
                    data.add(num);
                    zeroCount++;

                } else {



                    if (data.getLast() == 0){



                        if (zeroCount % 2 != 0){

                            isEven = elementBeforeZero % 2 == 0;
                            isOdd = elementBeforeZero % 2 != 0;

                            if (data.size() == 1){

                                data.add(num);
                                zeroCount = 0;
                                isEven = false;
                                isOdd = false;
                                continue;
                            }

                            if (isEven){
                                if (num % 2 == 0){
                                    data.add(num);
                                    zeroCount = 0;
                                } else {

                                    currentLength = data.size();
                                    if (currentLength > maxLength ){

                                        maxLength = currentLength;
                                    }
                                    data.clear();
                                    data.add(num);
                                    zeroCount = 0;
                                    isEven = false;
                                    isOdd = false;

                                }
                            }
                            if (isOdd){
                                if (num % 2 != 0){
                                    data.add(num);
                                    zeroCount =0 ;
                                } else {
                                    currentLength = data.size();
                                    if (currentLength > maxLength ){

                                        maxLength = currentLength;
                                    }
                                    data.clear();
                                    data.add(num);
                                    zeroCount = 0;
                                    isEven = false;
                                    isOdd = false;
                                }
                            }
                        } else {

                            isEven = elementBeforeZero % 2 == 0;
                            isOdd = elementBeforeZero % 2 != 0;

                            if (isEven){
                                if (num % 2 != 0){
                                    data.add(num);
                                } else {
                                    currentLength = data.size();
                                    if (currentLength > maxLength ){

                                        maxLength = currentLength;
                                    }
                                    data.clear();
                                    data.add(num);
                                    zeroCount = 0;
                                    isEven = false;
                                    isOdd = false;
                                }
                            }
                            if (isOdd){
                                if (num % 2 == 0){
                                    data.add(num);
                                } else {
                                    currentLength = data.size();
                                    if (currentLength > maxLength ){

                                        maxLength = currentLength;
                                    }
                                    data.clear();
                                    data.add(num);
                                    zeroCount = 0;
                                    isEven = false;
                                    isOdd = false;
                                }
                            }
                        }
                    } else {
                        isEven = data.getLast() % 2 == 0;
                        isOdd = data.getLast() % 2 != 0;

                        if (isEven){

                            if (num % 2 != 0){
                                data.add(num);
                            }else {
                                currentLength = data.size();
                                if (currentLength > maxLength ){

                                    maxLength = currentLength;
                                }
                                data.clear();
                                data.add(num);
                                zeroCount = 0;
                                isEven = false;
                                isOdd = false;
                            }
                        } else {
                            if (num % 2 == 0){
                                data.add(num);
                            }else {
                                currentLength = data.size();
                                if (currentLength > maxLength ){

                                    maxLength = currentLength;
                                }
                                data.clear();
                                data.add(num);
                                zeroCount = 0;
                                isEven = false;
                                isOdd = false;
                            }
                        }
                    }
                }

            } else {

                data.add(num);
                if (num == 0){

                    zeroCount++;
                }
            }

        }

        currentLength = data.size();
        if (currentLength > maxLength ){

            maxLength = currentLength;
        }

        System.out.println(maxLength);
    }
}
