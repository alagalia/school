import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Alex on 6.4.2016 г..
 */
public class ExtractWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();

        Pattern pattern = Pattern.compile("([A-Za-z]{2,})");
        Matcher matcher = pattern.matcher(input);

        while(matcher.find()){
            System.out.printf("%s ", matcher.group());
        }

    }
}
