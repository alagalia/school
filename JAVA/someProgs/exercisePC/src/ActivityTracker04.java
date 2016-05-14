import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Al on 18.4.2016 г..
 */
public class ActivityTracker04 {

    public static void main(String[] args) {

        // user order > A-Z .... month -> 0-9

        Scanner sc = new Scanner(System.in);

        int line = Integer.parseInt(sc.nextLine());

        TreeMap<Integer,HashMap<String,Integer>> data = new TreeMap<>();

        for (int i = 0; i < line; i++) {

            String input = sc.nextLine();

            Pattern pattern = Pattern.compile("\\d+\\s*\\/\\s*(\\d+)\\s*\\/\\s*\\d+\\s*(\\w+)\\s*(\\d+)");

            Matcher matcher = pattern.matcher(input);

            while (matcher.find()){

                int month = Integer.parseInt(matcher.group(1));
                String user = matcher.group(2);
                Integer distance = Integer.parseInt(matcher.group(3));


                if (!data.containsKey(month)){

                    data.put(month, new HashMap<String,Integer>());
                    data.get(month).put(user, distance);

                } else {

                    if (!data.get(month).containsKey(user)){

                        data.get(month).put(user, distance);

                    } else {

                        Integer support = data.get(month).get(user);

                        support += distance;

                        data.get(month).put(user, support);
                    }
                }
            }
        }
        //System.out.println();

        for (Map.Entry<Integer, HashMap<String, Integer>> entry : data.entrySet()) {

            HashMap<String,Integer> support = entry.getValue();

//            support.entrySet().stream()
//                    .sorted((x,y) -> Integer.compare(x.getKey().length(), y.getKey().length()) )
//                    .sorted(Map.Entry.comparingByValue((j,k) -> k.compareTo(j)))
//                    .forEach(a -> System.out.println("sort by value: " + a.getKey() + " " + a.getValue()));




            StringBuilder allUsers = new StringBuilder();

            for (Map.Entry<String, Integer> user : support.entrySet()) {

                allUsers.append(" " +user.getKey() + "(" + user.getValue() + "),");

            }

            allUsers.setCharAt(allUsers.length() - 1, ' ');

            System.out.printf("%s:%s", entry.getKey(), allUsers.toString());
            System.out.println();
        }
    }
}
