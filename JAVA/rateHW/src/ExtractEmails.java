import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Alex on 6.4.2016 г..
 */
public class ExtractEmails {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String rgx = "([A-za-z.-]+@+[A-za-z]+[-.A-Za-z]+.[com|bg|edu|uk|de])";

        Pattern pattern = Pattern.compile(rgx);
        Matcher matcher = pattern.matcher(input);

        while(matcher.find()){
            System.out.println(matcher.group());
        }
    }
}
