import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Alex on 6.4.2016 г..
 */
public class CountAllWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();

        Pattern pattern = Pattern.compile("([A-Za-z]+)");
        Matcher matcher = pattern.matcher(input);

        int count = 0;

        while(matcher.find()){
            count++;
        }

        System.out.println(count);
    }
}
