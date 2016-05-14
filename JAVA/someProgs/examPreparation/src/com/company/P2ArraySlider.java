package com.company;

import java.math.BigInteger;
import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by Aleksey on 5/4/2016.
 */
public class P2ArraySlider {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        String [] nums = input.trim().split("\\s+");

        //String[] support =
        BigInteger[] numbers = new BigInteger[nums.length];

        int k = 0;

        for (int i = 0; i < nums.length; i++) {

            if (!nums[i].equals("")) {

                numbers[i - k] = new BigInteger(nums[i]);
            } else {
                k++;
            }
        }
        input = sc.nextLine();

        int index = 0;

        while (!input.equals("stop")){

            String[] command = input.split("\\s+");

            int offset = Integer.parseInt(command[0]);
            String operand = command[2];
            char operation = command[1].charAt(0);

            index = (index + offset) % numbers.length;
            if (index < 0){
                index = numbers.length - Math.abs(index);
            }
            BigInteger currentNum = numbers[index];

            switch (operation){
                case '+':
                    //currentNum += operand;
                    currentNum = currentNum.add(new BigInteger(operand));
                    numbers[index] = currentNum;

                    break;
                case '-':
                    //currentNum -= operand;
                    currentNum = currentNum.subtract(new BigInteger(operand));
                    int compare = currentNum.compareTo(new BigInteger("0"));
                    if (compare == -1){
                        currentNum = new BigInteger("0");
                    }
                    numbers[index] = currentNum;
                    break;
                case '*':
                    //currentNum *= operand;
                    currentNum = currentNum.multiply(new BigInteger(operand));
                    numbers[index] = currentNum;
                    break;
                case '/':
                    //currentNum /= operand;
                    currentNum = currentNum.divide(new BigInteger(operand));
                    numbers[index] = currentNum;
                    break;
                case '&':
                    //currentNum &= operand;
                    currentNum = currentNum.and(new BigInteger(operand));
                    numbers[index] = currentNum;
                    break;
                case '|':
                    //currentNum |= operand;
                    currentNum = currentNum.or(new BigInteger(operand));
                    numbers[index] = currentNum;
                    break;
                case '^':
                    //currentNum ^= operand;
                    currentNum = currentNum.xor(new BigInteger(operand));
                    numbers[index] = currentNum;
                    break;

            }



            input = sc.nextLine();
        }

        System.out.println(Arrays.toString(numbers));
    }
}
