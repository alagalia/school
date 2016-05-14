package com.company;

import java.util.LinkedList;
import java.util.Scanner;

/**
 * Created by Aleksey on 4/23/2016.
 */
public class ProblemTwo {

    public static void main(String[] args) {


        Scanner sc = new Scanner(System.in);

        String[] input = sc.nextLine().split("\\s+");

        int row = Integer.parseInt(input[0]);
        int col = Integer.parseInt(input[1]);

        int [][] matrix = new int[row][col];

        int count = 1;

        for (int i = 0; i < row; i++) {

            for (int j = 0; j < col; j++) {

                matrix[i][j] = count;
                count++;
            }
        }

        String coordinates = sc.nextLine();

        while (!coordinates.equals("Nuke it from orbit")){

            String [] bomb = coordinates.split("\\s+");

            int bombRow = Integer.parseInt(bomb[0]);

            int bombCol = Integer.parseInt(bomb[1]);

            int radius = Integer.parseInt(bomb[2]);


            int startRow = bombRow - radius;
            if (startRow < 0){
                startRow =0;

            }
            int endRow = bombRow + radius;

            if (endRow > row - 1){

                endRow = row - 1;
            }

            int startCol = bombCol - radius;
            if (startCol < 0){

                startCol = 0;
            }
            int endCol = bombCol + radius;

            if (endCol > col - 1){
                endCol = col - 1;
            }

            for (int i = bombRow; i <= bombRow; i++) {

                for (int j = startCol; j <= endCol; j++) {



                    if (bombRow >= 0 && bombRow < row){
                        matrix[i][j] = 0;
                    }

                }

            }
            removeZeroes(row, col, matrix);

            for (int i = bombCol; i <= bombCol; i++) {

                for (int j = startRow; j < endRow; j++) {

                    if (bombCol >= 0 && bombCol < col) {

                        matrix[j][i] = 0;
                    }

                }
            }


            removeZeroes(row, col, matrix);


            coordinates = sc.nextLine();
        }

        for (int i = 0; i < row; i++) {

            for (int j = 0; j < col; j++) {

                String a = matrix[i][j] + "";

                if (a.equals("0")){
                    a = "";
                    System.out.printf(a);
                } else {
                    if (j == col-1){
                        System.out.printf(a + "");
                    } else {
                        System.out.printf(a + " ");
                    }

                }

            }
            System.out.println();
        }
    }

    private static void removeZeroes(int row, int col, int[][] matrix) {

        for (int i = 0; i < row; i++) {

            LinkedList<Integer> sb = new LinkedList<>();

            for (int j = 0; j < col; j++) {

                int a = matrix[i][j];
                if (a != 0) {
                    sb.add(matrix[i][j]);
                }

            }

            for (int j = 0; j < col; j++) {

                if (j >= sb.size()){
                    matrix[i][j] = 0;
                } else {
                    int a = sb.get(j);
                    matrix[i][j] = a;
                }
            }
        }
    }
}
