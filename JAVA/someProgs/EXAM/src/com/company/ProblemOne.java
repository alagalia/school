package com.company;

import java.util.Scanner;

public class ProblemOne {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        String key = sc.nextLine();

        while (true){

            int lenght = key.length() / 2 ;

            int first = input.indexOf(key);
            int end = input.indexOf(key, first + 1);

            if (first != end || first == -1 || end == -1 ){

                input = input.replace(key, "");
                System.out.println("Shaked it.");

            } else {

                System.out.println("No shake.");
                System.out.println(input);
                break;
            }

            StringBuilder sb = new StringBuilder(key);


            if (key.length()> 1){
                sb.deleteCharAt(lenght);
            }


            key = sb.toString();
        }


    }
}
