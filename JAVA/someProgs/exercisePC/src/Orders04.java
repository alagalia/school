import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

/**
 * Created by Al on 19.4.2016 г..
 */
public class Orders04 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int nLines = Integer.parseInt(sc.nextLine());

        LinkedHashMap<String,TreeMap<String,Integer>> data = new LinkedHashMap<>();


        for (int i = 0; i < nLines; i++) {

            String[] input = sc.nextLine().split("\\s+");

            String name = input[0];
            int quantity = Integer.parseInt(input[1]);
            String product = input[2];

            if (!data.containsKey(product)){

                data.put(product,new TreeMap<>());
                data.get(product).put(name,quantity);
            } else {

                if (!data.get(product).containsKey(name)){

                    data.get(product).put(name, quantity);
                } else {

                    int supportQuantity = data.get(product).get(name);
                    supportQuantity += quantity;
                    data.get(product).put(name, supportQuantity);

                }
            }
        }

        for (Map.Entry<String, TreeMap<String, Integer>> entry : data.entrySet()) {

            TreeMap<String,Integer> support = entry.getValue();

            System.out.printf("%s:", entry.getKey());
            StringBuilder line = new StringBuilder();

            for (Map.Entry<String, Integer> second : support.entrySet()) {

                line.append(" " + second.getKey() + " " + second.getValue() + ",");

            }
            line.setCharAt(line.length()-1, ' ');
            System.out.printf("%s", line.toString());
            System.out.println();
        }
    }
}
