import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Al on 19.4.2016 г..
 */
public class Nuts04 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int nLines = Integer.parseInt(sc.nextLine());

        TreeMap<String,LinkedHashMap<String,Integer>> data = new TreeMap<>();

        for (int i = 0; i < nLines; i++) {

            String input = sc.nextLine();

            Pattern pattern = Pattern.compile("(\\w+)\\s*(\\w+)\\s*(\\d+)kg");

            Matcher matcher = pattern.matcher(input);

            while (matcher.find()){

                String company = matcher.group(1);
                String nuts = matcher.group(2);
                int kg = Integer.parseInt(matcher.group(3));

                if (!data.containsKey(company)){

                    data.put(company, new LinkedHashMap<>());
                    data.get(company).put(nuts, kg);
                } else {

                    if (!data.get(company).containsKey(nuts)){

                        data.get(company).put(nuts, kg);
                    } else {

                        int oldKg = data.get(company).get(nuts);

                        oldKg += kg;
                        data.get(company).put(nuts, oldKg);

                    }
                }


            }
        }

        for (Map.Entry<String, LinkedHashMap<String, Integer>> entry : data.entrySet()) {

            LinkedHashMap<String,Integer> support = entry.getValue();

            System.out.printf("%s:", entry.getKey());

            StringBuilder sb = new StringBuilder();

            for (Map.Entry<String, Integer> nuts : support.entrySet()) {

                sb.append(String.format(" %s-%dkg,", nuts.getKey(),nuts.getValue()));

            }
            sb.setCharAt(sb.length() - 1, ' ');

            System.out.println(sb.toString());

        }
    }
}
