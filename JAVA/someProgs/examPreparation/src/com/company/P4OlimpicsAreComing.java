package com.company;

import java.util.*;

/**
 * Created by Aleksey on 5/5/2016.
 */
public class P4OlimpicsAreComing {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        LinkedHashMap<String,HashMap<String,Integer>> data = new LinkedHashMap<>();

        String input = sc.nextLine();

        while (!input.equals("report")){

            String [] list = input.split("\\|");

            String country = list[1].trim();
            country = country.replaceAll("\\s+", " ");

            String name = list[0].trim();
            name = name.replaceAll("\\s+", " ");


            if (!data.containsKey(country)){

                data.put(country, new HashMap<>());
                data.get(country).put(name, 1);
            } else {

                if (!data.get(country).containsKey(name)){

                    data.get(country).put(name, 1);
                } else {

                    int numOfWins = data.get(country).get(name);
                    numOfWins++;

                    data.get(country).put(name, numOfWins);
                }

            }

            input = sc.nextLine();
        }

        System.out.println();
        data.entrySet().stream().sorted((x1,x2) -> {
            int sumOfWinsA = getWins(x1.getValue());
            int sumOfWinsB = getWins(x2.getValue());

            return Integer.compare(sumOfWinsB, sumOfWinsA);
        } ).forEach(x -> {
            System.out.printf("%s (%d participants): %d wins\n", x.getKey(), getCount(x.getValue()), getWins(x.getValue()));
        });
    }

    private static int getCount(HashMap<String, Integer> value) {

        int count = 0;

        for (Map.Entry<String, Integer> entry : value.entrySet()) {

            count++;
        }
        return count;
    }

    private static int getWins(HashMap<String, Integer> value) {

        int sum = 0;

        for (Map.Entry<String, Integer> entry : value.entrySet()) {

            sum += entry.getValue();
        }
        return sum;
    }
}
