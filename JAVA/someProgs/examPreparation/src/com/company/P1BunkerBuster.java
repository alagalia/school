package com.company;

import java.util.Scanner;

/**
 * Created by Aleksey on 5/4/2016.
 */
public class P1BunkerBuster {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String[] dimensions = sc.nextLine().split("\\s+");

        int row = Integer.parseInt(dimensions[0]);
        int col = Integer.parseInt(dimensions[1]);

        int [][] matrix = new int[row][col];

        for (int i = 0; i < row; i++) {

            String[] input = sc.nextLine().split("\\s+");

            for (int j = 0; j < col; j++) {

                int num = Integer.parseInt(input[j]);

                matrix[i][j] = num;
            }
        }

        String input = sc.nextLine();

        while (!input.equals("cease fire!")){

            String [] bombCoord = input.split("\\s+");

            int bRow = Integer.parseInt(bombCoord[0]);
            int bCol = Integer.parseInt(bombCoord[1]);
            char asChar = bombCoord[2].charAt(0);
            int bPower = (int)asChar;


            if (bRow >= 0 && bRow < row && bCol >= 0 && bCol < col){

                int currentValue = matrix[bRow][bCol];

                if (currentValue > 0) {

                    matrix[bRow][bCol] = currentValue - bPower;
                }
            }

            double halfPower = bPower / 2d;
            long support = Math.round(halfPower);
            bPower = (int)support;

            for (int i = bRow - 1; i <= bRow + 1; i++) {

                for (int j = bCol - 1; j <= bCol + 1 ; j++) {

                    if (i >= 0 && i < row && j >= 0 && j < col){

                        if (i != bRow || j != bCol){

                            int currentValue = matrix[i][j];

                            if (currentValue > 0) {

                                matrix[i][j] = currentValue - bPower;
                            }
                        }
                    }
                }
            }

            input = sc.nextLine();
        }

        int counter = 0;

        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {

                int value = matrix[i][j];
                if (value <= 0){
                    counter++;
                }
            }
        }

        System.out.printf("Destroyed bunkers: %d\n", counter);
        System.out.printf("Damage done: %.1f %%\n", ((double)counter / (row * col)) * 100);
    }
}
