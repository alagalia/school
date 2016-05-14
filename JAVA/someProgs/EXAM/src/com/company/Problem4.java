package com.company;


import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Problem4 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        TreeMap<String,TreeMap<String,List<String>>> data = new TreeMap<>();

        TreeMap<String,Integer> support = new TreeMap<>();

        while (!input.equals("It's testing time!")){

            Pattern pattern = Pattern.compile("\\s*([A-Z]+\\w+)\\s*\\|\\s*([A-Z]+\\w+)\\s*\\|\\s*([A-Z]+\\w+)");

            Matcher matcher = pattern.matcher(input);

            while (matcher.find()){

                String classs = matcher.group(1);

                String methodsss = matcher.group(2);

                String testsss = matcher.group(3);


                if (!data.containsKey(classs)){

                    data.put(classs, new TreeMap<>());

                    data.get(classs).put(methodsss, new ArrayList<>());
                    data.get(classs).get(methodsss).add(testsss);

                    support.put(classs,1);
                } else {

                    if (!data.get(classs).containsKey(methodsss)){

                        data.get(classs).put(methodsss, new ArrayList<>());

                        data.get(classs).get(methodsss).add(testsss);
                        int a = support.get(classs);

                        a++;
                        support.put(classs,a);
                    } else {

                        if (!data.get(classs).get(methodsss).contains(testsss)){

                            data.get(classs).get(methodsss).add(testsss);
                            int a = support.get(classs);

                            a++;
                            support.put(classs,a);
                        }
                    }
                }


            }

            input = sc.nextLine();
        }



//        for (Map.Entry<String, TreeMap<String, List<String>>> entry : data.entrySet()) {
//
//
//            TreeMap<String,List<String>> aaa = entry.getValue();
//
//            int a = aaa.values().size();
//        }


        System.out.println();

//        support.entrySet().stream().sorted((x,y) -> Integer.compare(y.getValue(), x.getValue()))
//
//                .forEach(p -> {
//                    System.out.println(p.getKey()+":");
//
//                    System.out.printf("##%s",);
//                });



    }
}
