import java.util.Scanner;

public class Problem1 {

    public static void main(String[] args) {


        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        String key = sc.nextLine();


        while (!key.equals("")){

            int first = input.indexOf(key);

            int last = input.lastIndexOf(key);

            if (input.length() - 2 * key.length() <= 0){
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
//                StringBuilder sbKey = new StringBuilder(key);
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
    }
}
