import java.util.Scanner;

/**
 * Created by Al on 18.4.2016 г..
 */
public class DozensOfEggs {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int dozens = 0;
        int eggs = 0;

        for (int i = 0; i < 7; i++) {

            String[] input = sc.nextLine().split("\\s+");

            switch (input[1]){

                case "eggs": eggs+= Integer.parseInt(input[0]);
                    break;
                case "dozens": dozens += Integer.parseInt(input[0]);
                    break;
            }
        }

        if (eggs > 11){

            int dozen = eggs / 12;

            dozens += eggs / 12;

            eggs -= dozen * 12;
        }

        System.out.printf("%d dozens + %d eggs", dozens, eggs);
    }
}
