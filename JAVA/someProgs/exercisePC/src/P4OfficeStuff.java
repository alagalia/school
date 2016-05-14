import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.jar.Pack200;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Al on 30.4.2016 г..
 */
public class P4OfficeStuff {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int nLines = Integer.parseInt(sc.nextLine());

        TreeMap<String,LinkedHashMap<String,Integer>> data = new TreeMap<>();

        for (int i = 0; i < nLines; i++) {

            String input = sc.nextLine();

            Pattern pattern = Pattern.compile("\\s*\\|\\s*(\\b.+\\b)\\s*\\-\\s*(\\b\\d+\\b)\\s*\\-\\s*(\\b.+\\b)\\s*\\|");

            Matcher matcher = pattern.matcher(input);

            while (matcher.find()){

                String company = matcher.group(1);

                String product = matcher.group(3);

                int quantity = Integer.parseInt(matcher.group(2));


                if (!data.containsKey(company)){

                    data.put(company, new LinkedHashMap<>());
                    data.get(company).put(product, quantity);

                } else {

                    if (!data.get(company).containsKey(product)){

                        data.get(company).put(product, quantity);

                    } else {

                        int support = data.get(company). get(product);

                        support += quantity;

                        data.get(company).put(product, support);
                    }
                }
            }



        }

        for (Map.Entry<String, LinkedHashMap<String, Integer>> entry : data.entrySet()) {


            System.out.printf("%s:", entry.getKey());

            LinkedHashMap<String,Integer> support = entry.getValue();

            StringBuilder sb = new StringBuilder();

            for (Map.Entry<String, Integer> product : support.entrySet()) {

                sb.append(String.format(" %s-%d,", product.getKey(), product.getValue()));
            }

            sb.deleteCharAt(sb.lastIndexOf(","));
            System.out.printf("%s", sb.toString());
            System.out.println();
        }
    }
}
