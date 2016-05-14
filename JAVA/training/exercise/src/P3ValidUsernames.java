import java.util.LinkedList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Al on 30.4.2016 г..
 */
public class P3ValidUsernames {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        Pattern pattern = Pattern.compile("\\b([a-zA-Z]\\w{2,23})\\b");

        Matcher matcher = pattern.matcher(input);

        LinkedList<String> data = new LinkedList<>();

        while (matcher.find()){

            data.add(matcher.group(1));
        }

        int longestLenght = -1;
        int indexOfLongestLenght = -1;

        int currentLenght = 0;

        for (int i = 0; i < data.size() - 1 ; i++) {

            currentLenght = data.get(i).length() + data.get(i + 1). length();

            if (currentLenght > longestLenght){

                longestLenght = currentLenght;
                indexOfLongestLenght = i;
            }

        }

        System.out.printf("%s\n", data.get(indexOfLongestLenght));
        System.out.printf("%s\n", data.get(indexOfLongestLenght + 1));
    }
}
