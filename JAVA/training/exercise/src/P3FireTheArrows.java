import java.util.LinkedList;
import java.util.Scanner;

/**
 * Created by Al on 29.4.2016 г..
 */
public class P3FireTheArrows {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int matrixRow = Integer.parseInt(sc.nextLine());

        LinkedList<String> matrix = new LinkedList<>();
        LinkedList<String> support = new LinkedList<>();

        for (int i = 0; i < matrixRow; i++) {

            String input = sc.nextLine();

            matrix.add(input);
            support.add(input);

        }

        boolean hasStop = false;






        while (true){

            for (int i = 0; i < matrixRow; i++) {

                StringBuilder currentRow = new StringBuilder(matrix.get(i));

                for (int j = 0; j < currentRow.length(); j++) {

                    currentRow = new StringBuilder(matrix.get(i));

                    char a = currentRow.charAt(j);

                    char b = 'x';

                    if (a == '<'){
                        //StringBuilder workRow = currentRow;

                        int index = j - 1;

                        if (j == 0){


                            continue;
                        } else {

                            b = currentRow.charAt(index);

                            if (b == '>' || b == 'v' || b == '<' || b == '^'){

                                continue;
                            } else {

                                currentRow.setCharAt(index, '<');
                                currentRow.setCharAt(j, 'o');

                                matrix.set(i, currentRow.toString());
                            }
                        }


                    }
                    if (a == '>'){

                        int index = j + 1;

                        if (j == currentRow.length() - 1){

                            continue;
                        } else {

                            b = currentRow.charAt(index);

                            if (b == '>' || b == 'v' || b == '<' || b == '^'){

                                continue;
                            } else {

                                currentRow.setCharAt(index, '>');
                                currentRow.setCharAt(j, 'o');

                                matrix.set(i, currentRow.toString());
                            }
                        }
                    }
                    if (a == 'v'){

                        int rowIndex = i + 1;

                        if (i == matrixRow - 1 ){

                            continue;
                        } else {

                            b = matrix.get(rowIndex).charAt(j);

                            if ( b == '>' || b == 'v' || b == '<' || b == '^'){

                                continue;
                            } else {

                                currentRow.setCharAt(j, 'o');
                                matrix.set(i, currentRow.toString());
                                currentRow = new StringBuilder(matrix.get(rowIndex));
                                currentRow.setCharAt(j, 'v');
                                matrix.set(rowIndex, currentRow.toString());
                            }



                        }

                    }
                    if (a == '^'){

                        int rowIndex = i - 1;

                        if (i == 0 ){

                            continue;
                        } else {

                            b = matrix.get(rowIndex).charAt(j);

                            if ( b == '>' || b == 'v' || b == '<' || b == '^'){

                                continue;
                            } else {

                                currentRow.setCharAt(j, 'o');
                                matrix.set(i, currentRow.toString());
                                currentRow = new StringBuilder(matrix.get(rowIndex));
                                currentRow.setCharAt(j, '^');
                                matrix.set(rowIndex, currentRow.toString());
                            }
                        }

                    }

                }



            }

            hasStop = matrix.equals(support);


            if (hasStop){
                break;
            } else {

                support.clear();
                for (int i = 0; i < matrix.size(); i++) {

                    String aa = matrix.get(i);
                    support.add(aa);
                }
            }
        }

        for (int i = 0; i < matrix.size(); i++) {

            System.out.println(matrix.get(i));
        }
    }
}
