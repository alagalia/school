package com.company;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P3RageQuit {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        Pattern pattern = Pattern.compile("(([^\\d]+)(\\d+))");

        Matcher matcher = pattern.matcher(input);

        List<Character> unique = new ArrayList<>();
        HashSet<Character> a = new HashSet<>(); /// проверявах дали  имат еднаква дължина ...

        StringBuilder sb = new StringBuilder();

        while (matcher.find()){

            String symbols = matcher.group(2).toUpperCase();
            int repeats = Integer.parseInt(matcher.group(3));



            for (int i = 0; i < repeats; i++) {

                sb.append(symbols);
            }
        }

        for (int i = 0; i < sb.length(); i++) {

            if (!unique.contains(sb.charAt(i) )){
                unique.add(sb.charAt(i));
            }
//            if (symbols.charAt(i) != ' ') {
//                a.add(symbols.charAt(i));  //// ако използвам хешсет-а в този случай, тест номер 1 минава но много други гърмят
//            }
        }


        System.out.printf("Unique symbols used: %d", unique.size());
        System.out.println();
        System.out.println(sb.toString());
    }
}
