import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Al on 29.4.2016 г..
 */
public class P1MelrahSnake {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        String key = sc.nextLine();

        boolean isEmpty = false;

        if (key.length() < 1 || input.length() < 1){

            isEmpty = true;
        }

        while (!key.equals("")){

            int first = input.indexOf(key);

            int last = input.lastIndexOf(key);

            if (input.length() - 2 * key.length() < 0){
                System.out.println("No shake.");
                System.out.println(input);
                break;
            }

            if (first == -1 || last == -1){

                System.out.println("No shake.");
                System.out.println(input);
                break;

            } else if (first != last) {



//                input = input.replaceFirst(key, "");
//                StringBuilder sb = new StringBuilder(input);
                StringBuilder sbKey = new StringBuilder(key);
//                sb.reverse();
//                sbKey.reverse();
//                input = sb.toString();
//                key = sbKey.toString();
//                input = input.replaceFirst(key, "");
//                sb = new StringBuilder(input);
//                sbKey = new StringBuilder(key);
//                sb.reverse();
//                sbKey.reverse();
//                input = sb.toString();

                input = input.substring(0, input.indexOf(key)) + input.substring(input.indexOf(key) + key.length(), input.length());
                input = input.substring(0, input.lastIndexOf(key)) + input.substring(input.lastIndexOf(key) + key.length(), input.length());

                int indexRemove = key.length() / 2;

                System.out.println("Shaked it.");

                if (key.length() == 1){

                    //key = "";
                    System.out.println("No shake.");
                    System.out.println(input);
                    break;

                } else {
                    sbKey.deleteCharAt(indexRemove);
                    key = sbKey.toString();
                }




            } else {

                System.out.println("No shake.");
                System.out.println(input);
                break;
            }


        }

        if (isEmpty){
            System.out.println("No shake.");
            System.out.println(input);
        }
    }
}
