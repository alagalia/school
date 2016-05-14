package com.company;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

/**
 * Created by Aleksey on 5/4/2016.
 */
public class P4PopulationCounter {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        LinkedHashMap<String,LinkedHashMap<String,Long>> data = new LinkedHashMap<>();

        String input = sc.nextLine();

        while (!input.equals("report")){

            String [] splitInput = input.split("\\|");

            String city = splitInput[0];
            String country = splitInput[1];
            long population = Long.parseLong(splitInput[2]);

            if (!data.containsKey(country)){

                data.put(country, new LinkedHashMap<>());
                data.get(country).put(city, population);

            } else {

                if (!data.get(country).containsKey(city)){

                    data.get(country).put(city, population);

                } else {

                    long addPopulation = data.get(country).get(city);

                    addPopulation += population;
                    data.get(country).put(city, addPopulation);
                }
            }

            input = sc.nextLine();
        }

        data.entrySet().stream().sorted((x1, x2) -> {
            long first = getAllPopulation(x1);
            long second = getAllPopulation(x2);

             return Long.compare(second, first);
        }).forEach(x -> {
            System.out.printf("%s (total population: %d)\n", x.getKey(), getAllPopulation(x));
            x.getValue().entrySet().stream().sorted((y1,y2) -> Long.compare(y2.getValue(), y1.getValue()) ).forEach(y -> {
                System.out.printf("=>%s: %d\n", y.getKey(), y.getValue());
            });
        });
    }



    private static long getAllPopulation(Map.Entry<String, LinkedHashMap<String, Long>> x1) {

        LinkedHashMap<String,Long> support = x1.getValue();

        long addPopulation = 0l;

        for (Map.Entry<String, Long> entry : support.entrySet()) {

            addPopulation += entry.getValue();
        }
        return addPopulation;
    }
}
