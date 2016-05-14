package com.company;

import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by Aleksey on 5/4/2016.
 */
public class P1CommandInterpreter {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String [] input = sc.nextLine().trim().split("\\s+");

        String command = sc.nextLine();

        while (!command.equals("end")){

            if (command.contains("reverse")){

                String[] support = command.split("\\s+");
                int index = Integer.parseInt(support[2]);
                int count = Integer.parseInt(support[4]);

                if (checkParameters(index, count, input)){

                    String [] supportData = new String[count];

                    for (int i = index, j = 0; i < index + count ; i++, j++) {

                        supportData[j] = input[i];
                    }
                    int j = count - 1;

                    for (int i = 0; i < input.length; i++) {

                        if (i >= index && i < index + count ){

                            input[i] = supportData[j];
                            j--;
                        }
                    }
                }
            }
            if (command.contains("sort")){

                String[] support = command.split("\\s+");
                int index = Integer.parseInt(support[2]);
                int count = Integer.parseInt(support[4]);

                if (checkParameters(index, count, input)){

                    String [] supportData = new String[count];

                    for (int i = index, j = 0; i < index + count ; i++, j++) {

                        supportData[j] = input[i];
                    }
                    //int j = count - 1;

                    Arrays.sort(supportData);
                    Arrays.sort(input, index, index + count);

                    for (int i = index, j = 0; i < index + count ; i++, j++) {

                        input[i] = supportData[j];
                    }
                }
            }
            if (command.contains("Left")){

                String[] support = command.split("\\s+");
                int count = Integer.parseInt(support[1]);

                if (count >= 0) {

                    String[] supportData = new String[input.length];

                    count = count % input.length;

                    for (int i = 0; i < input.length; i++) {

                        int ind = (count + i) % input.length;

                        supportData[i] = input[ind];
                    }

                    input = supportData;
                } else {
                    System.out.println("Invalid input parameters.");
                }
            }
            if (command.contains("Right")){

                String[] support = command.split("\\s+");
                int count = Integer.parseInt(support[1]);

                if (count >= 0) {
                    String[] supportData = new String[input.length];

                    count = count % input.length;

                    for (int i = 0; i < input.length; i++) {

                        supportData[i] = input[(input.length - count + i) % input.length];
                    }

                    input = supportData;
                } else {
                    System.out.println("Invalid input parameters.");
                }

            }

            command = sc.nextLine();
        }
        System.out.println(Arrays.toString(input));
    }



    public static boolean checkParameters (int index, int count, String[] input ){

        if (index < 0 || count < 0 ){
            System.out.println("Invalid input parameters.");
            return false;
        }
        if (index >= input.length || count > input.length){
            System.out.println("Invalid input parameters.");
            return false;
        }
        if ((index + count) > input.length){
            System.out.println("Invalid input parameters.");
            return false;
        }
        return true;
    }
}
