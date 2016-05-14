import java.util.LinkedList;
import java.util.Scanner;
import java.util.jar.Pack200;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Al on 29.4.2016 г..
 */
public class P2TerroristWins {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        LinkedList<String> bombs = new LinkedList<>();

        Pattern pattern = Pattern.compile("(\\|.*?\\|)\\1*");

        Matcher matcher = pattern.matcher(input);

        while (matcher.find()){

            bombs.add(matcher.group(1));
        }

        for (int i = 0; i < bombs.size(); i++) {

            int index = input.indexOf(bombs.get(i));

            int bombLenght = bombs.get(i).length();

            int bombPower = 0;

            for (int j = 1; j < bombLenght - 1 ; j++) {

                bombPower += bombs.get(i).charAt(j);
            }

            bombPower = bombPower % 10;

            int startIndex = index - bombPower;
            if (startIndex < 0){

                startIndex = 0;
            }

            int endIndex = index + bombPower + bombLenght - 1;
            if (endIndex > input.length()){

                endIndex = input.length() - 1;
            }

            StringBuilder sb = new StringBuilder(input);

            for (int j = startIndex; j <= endIndex ; j++) {

                sb.setCharAt(j, '.');
            }

            input = sb.toString();


        }

        System.out.println(input);
    }
}
