package com.company;

import java.util.LinkedList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Aleksey on 5/5/2016.
 */
public class P3TextTransformer {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        StringBuilder sb = new StringBuilder();

        int openCloseIndex = 0;
        boolean append = false;

        while (!input.equals("burp")){

            sb.append(input);

            input = sc.nextLine();
        }

        List<String> data = new LinkedList<>();

        String support = sb.toString();
        support = support.replace("\\s+", " ");
        sb = new StringBuilder(support);

        Pattern pattern = Pattern.compile("([$%&'])([^$%&']+)\\1");

        Matcher matcher = pattern.matcher(sb.toString());

        while (matcher.find()){

            String matchh = matcher.group(2);
//            String percent = matcher.group(2);
//            String and = matcher.group(2);
//            String singleQuates = matcher.group(2);
            String group = matcher.group(1);

            StringBuilder result = new StringBuilder();

            if (group.contains("$")){

                int value = 1;

                result = addOrSubstractSpecialSymbol(matchh, result, value);

            }
            if (group.contains("%")){

                int value = 2;
                result = addOrSubstractSpecialSymbol(matchh, result, value);

            }
            if (group.contains("&")){
                int value = 3;
                result = addOrSubstractSpecialSymbol(matchh, result, value);

            }
            if (group.contains("'")){

                int value = 4;
                result = addOrSubstractSpecialSymbol(matchh, result, value);
            }

            data.add(result.toString());
        }

//        for (String s : data) {
//
//            System.out.println(s);
//        }

        System.out.printf("%s", String.join(" ", data));

        //System.out.println();
    }

    private static StringBuilder addOrSubstractSpecialSymbol(String text, StringBuilder result, int value) {
        for (int i = 0; i < text.length(); i++) {

            char ch = text.charAt(i);

            if (i % 2 == 0){

                ch += value;
                result.append(ch + "");

            } else {
                ch -= value;
                result.append(ch + "");
            }
        }
        return result;
    }
}
