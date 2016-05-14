package com.company;

import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.TreeSet;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Aleksey on 5/6/2016.
 */
public class P4GUnit {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        TreeMap<String,TreeMap<String,TreeSet<String>>> data = new TreeMap<>();

        while (!input.equals("It's testing time!")){

            Pattern pattern = Pattern.compile("^([A-Z][a-zA-Z0-9]+) \\| ([A-Z][a-zA-Z0-9]+) \\| ([A-Z][a-zA-Z0-9]+)$");

            Matcher matcher = pattern.matcher(input);

            while (matcher.find()){

                String clas = matcher.group(1);
                String method = matcher.group(2);
                String test = matcher.group(3);

                if (!data.containsKey(clas)){

                    data.put(clas, new TreeMap<>());

                }

                if (!data.get(clas).containsKey(method)){

                    data.get(clas).put(method, new TreeSet<>());
                }

                //data.get(clas).get(method).add(test);
                if (!data.get(clas).get(method).contains(test)){
                    data.get(clas).get(method).add(test);
                }

            }

            input = sc.nextLine();
        }

        data.entrySet().stream().sorted((x1, x2) -> {
            int fElement = countTests(x1.getValue());
            int sElement = countTests(x2.getValue());

            if (fElement != sElement){

                return Integer.compare(sElement, fElement);
            } else {

                int fMethod = countMethods(x1.getValue());
                int sMethod = countMethods(x2.getValue());

                return Integer.compare(fMethod, sMethod);

            }
        }).forEach(x -> {
            System.out.println(x.getKey() + ":");
            x.getValue().entrySet().stream()
                    .sorted((y1, y2) -> Integer.compare(y2.getValue().size(), y1.getValue().size() ) )
                    .forEach(y -> {
                        System.out.println("##" + y.getKey());
                        y.getValue().stream().sorted((w1, w2) -> {

                            return Integer.compare(w1.length(), w2.length());


                        } )
                                .forEach(w -> {
                                    System.out.println("####" + w );
                                });
                    });
        });
    }

    private static int countMethods(TreeMap<String, TreeSet<String>> value) {

        int count = 0;

        for (Map.Entry<String, TreeSet<String>> entry : value.entrySet()) {

            count++;
        }

        return count = value.size();
    }

    private static int countTests(TreeMap<String, TreeSet<String>> value) {

        int count = 0;

        for (Map.Entry<String, TreeSet<String>> entry : value.entrySet()) {

            TreeSet<String> support = entry.getValue();

            count += support.size();
        }
        return count;
    }
}
