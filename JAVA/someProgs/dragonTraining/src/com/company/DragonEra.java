package com.company;

import java.util.List;
import java.util.Scanner;

public class DragonEra {

    public static long NUMBER_OF_DRAGON = 0;

    public static List<Dragon> dragons;

    public static void main(String[] args) {


        Scanner sc = new Scanner(System.in);

        int startingDragons = Integer.parseInt(sc.nextLine());

        for (int i = 0; i < startingDragons; i++) {

            NUMBER_OF_DRAGON++;

            Dragon dragon = new Dragon( "Dragon_" + NUMBER_OF_DRAGON, 0, true);

            int eggs = Integer.parseInt(sc.nextLine());


            for (int j = 0; j < eggs; j++) {

                Egg egg = new Egg(0, dragon);
                dragon.lay(egg);

            }

            dragons.add(dragon);

        }

        int yearsWillWork = Integer.parseInt(sc.nextLine());

        for (int i = 0; i < yearsWillWork; i++) {

            String typeOfYear = sc.nextLine();

            int yearFactor = 0;

            switch (typeOfYear){

                case "Bad": yearFactor = 0;
                    break;
                case "Normal": yearFactor = 1;
                    break;
                case "Good": yearFactor = 2;
                    break;
            }

            for (Dragon dragon : dragons) {

                passAge(dragon, yearFactor);

            }

        }


    }

    public static void passAge(Dragon dragon, int yearFactor){


        dragon.age();
        dragon.lay();

        for (Egg egg : dragon.getEggs()) {

            Egg.yearFactor = yearFactor;

            egg.age();
            egg.hatch();
        }

        for (Dragon child : dragon.getBabies()){
            passAge(child, yearFactor);
        }
    }
}
