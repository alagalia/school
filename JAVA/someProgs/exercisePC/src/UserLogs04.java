import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Al on 16.4.2016 г..
 */
public class UserLogs04 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        // user: a-z alphabetic
        // ip => count, ip => count --- linked

        TreeMap<String,LinkedHashMap<String,Integer>> data = new TreeMap<>();

        String logs = sc.nextLine();

        while (!logs.equals("end")){

            Pattern pattern = Pattern.compile("\\s*IP\\s*=([^\\s]+)\\s*.+\\s*user\\s*=\\s*(.{3,50})");

            Matcher matcher = pattern.matcher(logs);

            while (matcher.find()){

                String username = matcher.group(2);
                String ip = matcher.group(1);

                if (!data.containsKey(username)){

                    data.put(username,new LinkedHashMap<>());
                    data.get(username).put(ip, 1);

                } else {

                    if (!data.get(username).containsKey(ip)){

                        data.get(username).put(ip, 1);

                    } else {

                        int count = data.get(username).get(ip);
                        count++;
                        data.get(username).put(ip, count);
                    }
                }
            }

            logs = sc.nextLine();
        }

        for (Map.Entry<String, LinkedHashMap<String, Integer>> entry : data.entrySet()) {

            LinkedHashMap<String,Integer> support = entry.getValue();

            System.out.printf("%s:",entry.getKey());
            System.out.println();

            int lenght = support.size();
            int count = 1;

            for (Map.Entry<String, Integer> stringIntegerEntry : support.entrySet()) {


                if (lenght == count){

                    System.out.printf("%s => %d.", stringIntegerEntry.getKey(), stringIntegerEntry.getValue());
                    System.out.println();

                } else {

                    System.out.printf("%s => %d, ", stringIntegerEntry.getKey(), stringIntegerEntry.getValue());

                }
                count++;
            }

        }
    }
}
