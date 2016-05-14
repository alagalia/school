import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Alex on 6.4.2016 г..
 */
public class StratsAndEndsWithCapital {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String rgx = "(\\b([A-Z])([a-zA-Z]+)?([A-Z])\\b)";

        Pattern pattern = Pattern.compile(rgx);
        Matcher matcher = pattern.matcher(input);

        while(matcher.find()){
            System.out.printf("%s ", matcher.group(1));
        }
    }
}
