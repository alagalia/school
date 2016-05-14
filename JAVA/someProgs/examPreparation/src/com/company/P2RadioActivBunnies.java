package com.company;

import java.util.LinkedList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by Aleksey on 5/3/2016.
 */
public class P2RadioActivBunnies {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        String [] dimensions = sc.nextLine().split("\\s+");

        int row = Integer.parseInt(dimensions[0]);
        int col = Integer.parseInt(dimensions[1]);

        int pRow = 0;
        int pCol = 0;

        List<StringBuilder> matrix = new LinkedList<>();

        for (int i = 0; i < row; i++) {

            String input = sc.nextLine();
            if (input.contains("P")){
                pRow = i;
                pCol = input.indexOf("P");
            }

            StringBuilder sb = new StringBuilder(input);

            matrix.add(sb);
        }

        String command = sc.nextLine();

        boolean won = false;
        boolean die = false;

        for (int i = 0; i < command.length(); i++) {

            char move = command.charAt(i);

            switch (move){
                case 'L': pCol--;
                    if (pCol < 0){
                        won =true;
                        pCol++;
                    }
                    break;
                case 'D': pRow++;
                    if (pRow > row -1){
                        won = true;
                        pRow--;
                    }
                    break;
                case 'R': pCol++;
                    if (pCol > col - 1){
                        won = true;
                        pCol--;
                    }
                    break;
                case 'U': pRow--;
                    if (pRow < 0 ){
                        won = true;
                        pCol++;
                    }
                    break;

            }

            if (won){

                won = true;
                char newChar = '.';
                changeChar(pRow, pCol, matrix, newChar );

            } else {
                System.out.println();

                char ch = matrix.get(pRow).charAt(pCol);

                if (ch == 'B'){

                    die = true;
//                    String result = "dead";
//                    printMatrix(pRow, pCol, matrix, result);

                } else {

                    char newChar = 'P';
                    changeChar(pRow, pCol, matrix, newChar);
                    newChar = '.';

                    if (move == 'U'){
                        pRow++;
                        changeChar(pRow, pCol, matrix, newChar);
                        pRow--;
                    }
                    if (move == 'D'){
                        pRow--;
                        changeChar(pRow, pCol, matrix, newChar);
                        pRow++;
                    }
                    if (move == 'L'){
                        pCol++;
                        changeChar(pRow, pCol, matrix, newChar);
                        pCol--;
                    }
                    if (move == 'R'){
                        pCol--;
                        changeChar(pRow, pCol, matrix, newChar);
                        pCol++;
                    }

                }
            }

            LinkedList<StringBuilder> cloneMatrix = new LinkedList<>(matrix);


            for (int j = 0; j < row; j++) {

                for (int k = 0; k < col; k++) {

                    char ch = matrix.get(j).charAt(k);

                    boolean hasPlayer = false;
                    if (ch == 'B'){

                        char newChar = 'B';

                        int upRow = j - 1 ;
                        int leftRightCol = k;

                        int upDownRow = j;

                        if (upRow >= 0){

                            hasPlayer = checkPosition(upRow, leftRightCol, matrix);
                            if (hasPlayer){

                                die = true;

                            }
                            changeChar(upRow,leftRightCol, cloneMatrix, newChar);

                        }
                        int downRow = j + 1;
                        if (downRow < row){
                            hasPlayer = checkPosition(downRow, leftRightCol, matrix);
                            if (hasPlayer){

                                die = true;

                            }
                            changeChar(downRow,leftRightCol, cloneMatrix, newChar);
                        }

                        int leftCol = k - 1;
                        if (leftCol >= 0){

                            hasPlayer = checkPosition(upDownRow, leftCol, matrix);
                            if (hasPlayer){

                                die = true;

                            }
                            changeChar(upDownRow, leftCol, cloneMatrix, newChar);
                        }

                        int rightCol = k + 1;
                        if (rightCol < col){

                            hasPlayer = checkPosition(upDownRow, rightCol, matrix);
                            if (hasPlayer){

                                die = true;

                            }
                            changeChar(upDownRow, rightCol, cloneMatrix, newChar);
                        }
                    }
                }
            }

            matrix = cloneMatrix;


            if (die){

                String result = "dead";
                printMatrix(pRow, pCol, matrix, result);

                break;
            }
            if (won){

                String result = "won";
                printMatrix(pRow, pCol, matrix, result);
                break;
            }

        }
    }

    private static boolean checkPosition(int row, int col, List<StringBuilder> matrix) {

        char player = matrix.get(row).charAt(col);
        if (player == 'P'){
            return true;
        } else {
            return false;
        }
    }


    private static void changeChar(int pRow, int pCol, List<StringBuilder> matrix, char newChar) {
        StringBuilder support = new StringBuilder(matrix.get(pRow));
        support.setCharAt(pCol, newChar);
        matrix.set(pRow, support);
    }

    private static void printMatrix(int pRow, int pCol, List<StringBuilder> matrix, String result) {
        for (int j = 0; j < matrix.size(); j++) {

            System.out.println(matrix.get(j).toString());
        }

        System.out.printf("%s: %d %d", result, pRow, pCol);
        System.out.println();
    }
}
