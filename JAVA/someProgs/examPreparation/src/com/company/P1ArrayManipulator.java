package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class P1ArrayManipulator {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String[] input = sc.nextLine().split("\\s+");

        int [] arrOfInts = new int[input.length];

        toIntegers(input, arrOfInts);

        String command = sc.nextLine();

        while (!command.equals("end")){

            if (command.contains("exchange")){

                arrOfInts = exchangeArr(arrOfInts, command);
            }
            if (command.contains("max") || command.contains("min")){

                if (command.contains("max")){

                    int maxNum = Integer.MIN_VALUE;
                    int index = -1;
                    boolean hasMax = false;

                    if (command.contains("odd")){

                        for ( int i = 0; i < arrOfInts.length; i++) {

                            if (arrOfInts[i] % 2 != 0) {

                                int currentValue = arrOfInts[i];

                                if (currentValue >= maxNum) {

                                    maxNum = currentValue;
                                    index = i;
                                    hasMax = true;
                                }
                            }
                        }

                        if (hasMax){
                            System.out.println(index);
                        } else {
                            System.out.println("No matches");
                        }


                    } else {

                        for ( int i = 0; i < arrOfInts.length; i++) {

                            if (arrOfInts[i] % 2 == 0) {

                                int currentValue = arrOfInts[i];

                                if (currentValue >= maxNum) {

                                    maxNum = currentValue;
                                    index = i;
                                    hasMax = true;
                                }
                            }
                        }

                        if (hasMax){
                            System.out.println(index);
                        } else {
                            System.out.println("No matches");
                        }

                    }
                } else {

                    /// min

                    int minNum = Integer.MAX_VALUE;
                    int index = -1;
                    boolean hasMin = false;

                    if (command.contains("odd")){

                        for ( int i = 0; i < arrOfInts.length; i++) {

                            if (arrOfInts[i] % 2 != 0) {

                                int currentValue = arrOfInts[i];

                                if (currentValue <= minNum) {

                                    minNum = currentValue;
                                    index = i;
                                    hasMin = true;
                                }
                            }
                        }

                        if (hasMin){
                            System.out.println(index);
                        } else {
                            System.out.println("No matches");
                        }


                    } else {

                        for ( int i = 0; i < arrOfInts.length; i++) {

                            if (arrOfInts[i] % 2 == 0) {

                                int currentValue = arrOfInts[i];

                                if (currentValue <= minNum) {

                                    minNum = currentValue;
                                    index = i;
                                    hasMin = true;
                                }
                            }
                        }

                        if (hasMin){
                            System.out.println(index);
                        } else {
                            System.out.println("No matches");
                        }

                    }
                }

            }

            if (command.contains("first") || command.contains("last")){

                List<Integer> odd = new ArrayList<>();
                List<Integer> even = new ArrayList<>();

                for (int i = 0; i < arrOfInts.length; i++) {

                    if (arrOfInts[i] % 2 != 0){
                        odd.add(arrOfInts[i]);
                    } else {
                        even.add(arrOfInts[i]);
                    }
                }

                if (command.contains("first")){

                    String [] support = command.split("\\s+");

                    int num = Integer.parseInt(support[1]);

                    if (num > arrOfInts.length){

                        System.out.println("Invalid count");
                    } else {

                        if (command.contains("odd")) {

                            if (odd.size() != 0) {
                                System.out.printf("[");

                                if (num > odd.size()) {
                                    num = odd.size();
                                }

                                for (int i = 0; i < num; i++) {

                                    if (i != num - 1) {
                                        System.out.printf("%d, ", odd.get(i));
                                    } else {
                                        System.out.printf("%d]", odd.get(i));
                                    }
                                }
                                System.out.println();
                            } else {
                                System.out.println("[]");
                            }

                        } else {

                            if (even.size() != 0) {
                                System.out.printf("[");

                                if (num > even.size()) {
                                    num = even.size();
                                }

                                for (int i = 0; i < num; i++) {

                                    if (i != num - 1) {
                                        System.out.printf("%d, ", even.get(i));
                                    } else {
                                        System.out.printf("%d]", even.get(i));
                                    }
                                }
                                System.out.println();
                            } else {
                                System.out.println("[]");
                            }
                        }
                    }

                } else {

                    String [] support = command.split("\\s+");

                    int num = Integer.parseInt(support[1]);

                    if (num > arrOfInts.length){

                        System.out.println("Invalid count");

                    } else {

                        if (command.contains("odd")){

                            if (odd.size() != 0){
                                int startIndex = odd.size() - num;

                                if (startIndex < 0){
                                    startIndex = 0;
                                }

                                System.out.printf("[");
                                for (int i = startIndex; i < odd.size() ; i++) {


                                    if (i != odd.size() - 1) {
                                        System.out.printf("%d, ", odd.get(i));
                                    } else {
                                        System.out.printf("%d]", odd.get(i));
                                    }

                                }
                                System.out.println();

                            } else {
                                System.out.println("[]");
                            }
                        } else {

                            if (even.size() != 0){

                                int startIndex = even.size() - num;

                                if (startIndex < 0){
                                    startIndex = 0;
                                }

                                System.out.printf("[");
                                for (int i = startIndex; i < even.size() ; i++) {


                                    if (i != even.size() - 1) {
                                        System.out.printf("%d, ", even.get(i));
                                    } else {
                                        System.out.printf("%d]", even.get(i));
                                    }

                                }
                                System.out.println();
                            } else {
                                System.out.println("[]");
                            }

                        }
                    }
                }
            }


            command = sc.nextLine();
        }
        System.out.println(Arrays.toString(arrOfInts));
    }



    private static int[] exchangeArr(int[] arrOfInts, String command) {
        String[] commandSplit = command.split("\\s+");

        int index = Integer.parseInt(commandSplit[1]);

        if (index >= 0 && index < arrOfInts.length){

            int [] support = new int [arrOfInts.length];
            int supportIndex = 0;


            for (int i = index + 1; i < arrOfInts.length; i++) {

                support[supportIndex] = arrOfInts[i];
                supportIndex++;
            }

            for (int i = 0; i <= index  ; i++) {

                support[supportIndex] = arrOfInts[i];
                supportIndex++;
            }

            arrOfInts = support;
//            System.out.printf("[");
//
//            for (int i = 0; i < arrOfInts.length; i++) {
//
//                if (i!=arrOfInts.length - 1){
//                    System.out.printf("%d, ", arrOfInts[i]);
//                } else  {
//
//                    System.out.printf("%d]", arrOfInts[i]);
//                    System.out.println();
//                }
//
//
//            }

        } else {

            System.out.println("Invalid index");
        }
        return arrOfInts;
    }

    private static void toIntegers(String[] arr, int[] arrOfInts) {
        for (int i = 0; i < arr.length; i++) {

            arrOfInts[i] = Integer.parseInt(arr[i]);
        }
    }
}
