import java.util.Scanner;

/**
 * Created by Alex on 6.4.2016 г..
 */
public class CountSubstringOccurrences {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine().toLowerCase();
        String subbstring = scanner.nextLine().toLowerCase();

        int index = input.indexOf(subbstring);
        int counter = 0;
        while (index != -1) {
            index = input.indexOf(subbstring, index + 1);
            counter++;
        }
        System.out.println(counter);


        //String currentSubstring = s.substring(i*substring.length(), ((i+1) * substring.length()));
        //if(currentSubstring.equals(substring)){
        //    occurrences++;
        //}
    }
}
