import java.util.Scanner;

/**
 * Created by Alex on 6.4.2016 г..
 */
public class CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] inputArr = sc.nextLine().toLowerCase().split("\\W");
        String word = sc.nextLine().toLowerCase();

        int count = 0;
        for (String s : inputArr) {
            if (s.equals(word)){
                count++;
            }
        }

        System.out.println(count);
    }
}
