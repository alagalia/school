package com.company;

import java.util.Scanner;

/**
 * Created by Aleksey on 5/5/2016.
 */
public class P2TargetPractice {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String [] someInput = sc.nextLine().trim().split("\\s+");

        int row = Integer.parseInt(someInput[0]);
        int col = Integer.parseInt(someInput[1]);

        String str = sc.nextLine();

        String [] bomb = sc.nextLine().trim().split("\\s+");

        int bRow = Integer.parseInt(bomb[0]);
        int bCol = Integer.parseInt(bomb[1]);
        int radius = Integer.parseInt(bomb[2]);

        String [][] matrix = new String [row][col];

        int whichRow = 0;
        int strIndex = 0;

        /// fill matrix

        for (int i = row - 1; i >= 0; i--) {

            if (whichRow % 2 != 0) {

                for (int j = 0; j < col; j++) {

                    matrix[i][j] = str.charAt(strIndex) + "";
                    strIndex++;
                    if (strIndex == str.length()){
                        strIndex = 0;
                    }

                }
            }

            if (whichRow % 2 == 0) {

                for (int j = col - 1; j >= 0; j--) {

                    matrix[i][j] = str.charAt(strIndex) + "";
                    strIndex++;
                    if (strIndex == str.length()){
                        strIndex = 0;
                    }
                }
            }

            whichRow++;
        }


        /// shoot at matrix
        for (int i = 0; i < row; i++) {

            for (int j = 0; j < col; j++) {

                if (checkCell(i, j, bRow, bCol, radius)){

                    matrix[i][j] = " ";
                }
            }
        }

        for (int column = 0; column < col; column++) {

            fallingDown(column, row, matrix);
        }

        /// print matrix
        for (int i = 0; i < row; i++) {

            for (int j = 0; j < col; j++) {

                System.out.printf("%s", matrix[i][j]);
            }
            System.out.println();
        }
    }

    private static void fallingDown(int column, int row, String[][] matrix) {

        StringBuilder sb = new StringBuilder();

        for (int i = row - 1; i >= 0; i--) {

            if (!matrix[i][column].equals(" ")) {

                sb.append(matrix[i][column]);
            }
        }

        for (int i = row - 1, j = 0; i >= 0; i--, j++) {

            if (j < sb.length()) {

                matrix[i][column] = sb.charAt(j) + "";
            } else {

                matrix[i][column] = " ";
            }
        }


    }

    public static boolean checkCell(int i, int j, int bRow, int bCol, int radius){

        double distance  = Math.sqrt(Math.pow(bRow - i,2) + Math.pow(bCol - j,2));

        if (distance <= radius){
            return true;
        } else {
            return false;
        }
    }
}
