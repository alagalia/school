package com.company;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Aleksey on 5/3/2016.
 */
public class P3ShmoogleCounter {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        List<String> ints = new LinkedList<>();
        List<String> doubles = new LinkedList<>();

        String input = sc.nextLine();

        while (!input.equals("//END_OF_CODE")){

            Pattern pattern = Pattern.compile("(\\bint\\s+([a-z][a-zA-Z]{0,24}\\b))|(\\bdouble\\s+([a-z][A-Za-z]{0,24}\\b))");

            Matcher matcher = pattern.matcher(input);

            while (matcher.find()){

                String intss = matcher.group(2);
                String doubless = matcher.group(4);

                if (intss != null){

                    ints.add(intss);
                }
                if (doubless != null){
                    doubles.add(doubless);
                }
            }

            input = sc.nextLine();
        }

        if (doubles.size() != 0) {

            Collections.sort(doubles);
            System.out.printf("Doubles: %s", String.join(", ", doubles));
            System.out.println();
        } else {
            System.out.println("Doubles: None");
        }

        if (ints.size() != 0 ){

            Collections.sort(ints);
            System.out.printf("Ints: %s", String.join(", ", ints));
            System.out.println();
        } else {
            System.out.println("Ints: None");
        }
    }
}
