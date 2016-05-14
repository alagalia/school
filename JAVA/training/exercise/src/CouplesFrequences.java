import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

/**
 * Created by Al on 18.4.2016 г..
 */
public class CouplesFrequences {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String [] input = sc.nextLine().split("\\s+");

        LinkedHashMap<String,Integer> data = new LinkedHashMap<>();

        for (int i = 0; i < input.length - 1; i++) {

            String support = input[i] + " " + input[i + 1];

            if (!data.containsKey(support)){

                data.put(support, 1);
            } else {

                int a = data.get(support);

                a++;

                data.put(support, a);
            }

        }

        int totalSize = input.length - 1;

        for (Map.Entry<String, Integer> entry : data.entrySet()) {

            double percent = entry.getValue();
            percent = (100d / (double)totalSize) * percent;

            System.out.printf("%s -> %.2f%%", entry.getKey(), percent);
            System.out.println();

        }
    }
}
