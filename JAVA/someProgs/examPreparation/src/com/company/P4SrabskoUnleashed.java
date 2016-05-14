package com.company;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Aleksey on 5/3/2016.
 */
public class P4SrabskoUnleashed {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        LinkedHashMap<String,LinkedHashMap<String,Long>> data = new LinkedHashMap<>();

        String input = sc.nextLine();

        while (!input.equals("End")){

            Pattern pattern = Pattern.compile("^([a-zA-Z]+\\s?[a-zA-Z]*\\s?[a-zA-Z]*) @([a-zA-Z]+\\s?[a-zA-Z]*\\s?[a-zA-Z]*) (\\d+) (\\d+)$");
            Matcher matcher = pattern.matcher(input);

            while (matcher.find()){

                String name = matcher.group(1);
                String venue = matcher.group(2);
                long ticketPrice = Long.parseLong(matcher.group(3));
                long sellTickets = Long.parseLong(matcher.group(4));

                if (!data.containsKey(venue)){

                    data.put(venue, new LinkedHashMap<>());
                    data.get(venue).put(name, ticketPrice * sellTickets);
                } else {

                    if (!data.get(venue).containsKey(name)){

                        data.get(venue).put(name, ticketPrice * sellTickets);
                    } else {

                        long sum = data.get(venue).get(name);

                        sum += ticketPrice * sellTickets;

                        data.get(venue).put(name, sum);
                    }
                }
            }

            input = sc.nextLine();
        }

        for (Map.Entry<String, LinkedHashMap<String, Long>> entry : data.entrySet()) {

            LinkedHashMap<String,Long> support = entry.getValue();

            System.out.printf("%s", entry.getKey());
            System.out.println();

            support.entrySet().stream().sorted((x,y) -> {
                long first = x.getValue();
                long second = y.getValue();

                return Long.compare(second, first);
            }).forEach(q -> {
                System.out.printf("#  %s -> %d", q.getKey(), q.getValue());
                System.out.println();
            });
        }
    }
}
