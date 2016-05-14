package com.company;

import java.util.LinkedList;
import java.util.Map;
import java.util.Scanner;

/**
 * Created by Aleksey on 4/23/2016.
 */
public class ProblemThree {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        LinkedList<Long> listt = new LinkedList<>();

        LinkedList<String> asString = new LinkedList<>();

        long sum = 0;

        long aa = 0;

        boolean hasCritical = false;

        String input = sc.nextLine();

        while (!input.equals("Break it.")){

            sum = 0;

            String [] arr = input.split("\\s+");

            int a = Integer.parseInt(arr[0]);
            int b = Integer.parseInt(arr[1]);
            int c = Integer.parseInt(arr[2]);
            int d = Integer.parseInt(arr[3]);

            sum = (c + d) - (a + b);

            asString.add(input);

            if (sum == 0 || listt.contains(sum)){

                if (sum != 0) {
                    aa = sum;
                }
                hasCritical = true;
            }

            listt.add(sum);

            input = sc.nextLine();
        }
        if (hasCritical) {

            for (String s : asString) {
                s = s.replace(" ", ", ");

                System.out.printf("Line: [%s]", s);
                System.out.println();
            }

            double zzz = Math.pow(Math.abs(aa), asString.size());
            long breakPoint = (long)zzz % Math.abs(aa);
            //breakPoint = breakPoint % asString.size();
            System.out.printf("Critical Breakpoint: %d", breakPoint);

        } else {

            System.out.println("Critical breakpoint does not exist.");
        }
    }
}
