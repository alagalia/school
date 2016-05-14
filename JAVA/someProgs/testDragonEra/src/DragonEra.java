import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class DragonEra {

    //private static List<Dragon> dragons;

    private static int numberOfDragons;
    private static int hatchDragons;

    public static int getNumberOfDragons() {
        return numberOfDragons;
    }

    public static void setNumberOfDragons(int numberOfDragons) {
        DragonEra.numberOfDragons = numberOfDragons;
    }

    public static int getHatchDragons() {
        return hatchDragons;
    }

    public static void setHatchDragons(int hatchDragons) {
        DragonEra.hatchDragons = hatchDragons;
    }

    public static void main(String[] args) {

        List<Dragon> dragons = new ArrayList<>();

        Scanner sc = new Scanner(System.in);

        int startingDragons = Integer.parseInt(sc.nextLine());

        for (int i = 0; i < startingDragons; i++) {

            numberOfDragons++;

            Dragon dragon = new Dragon(-1, "Dragon_" + numberOfDragons);

            int numberOfEggs = Integer.parseInt(sc.nextLine());

            for (int j = 0; j < numberOfEggs; j++) {

                Egg egg = new Egg(-1, dragon);
                dragon.addEggs(egg);
            }

            dragons.add(dragon);
        }

        int numberOfYears = Integer.parseInt(sc.nextLine());

        for (int i = 0; i < numberOfYears; i++) {

            String typeOfYear = sc.nextLine();

            switch (typeOfYear){

                case "Bad": hatchDragons = 0;
                    break;
                case "Normal": hatchDragons = 1;
                    break;
                case "Good": hatchDragons = 2;
                    break;

            }

            for (Dragon dragon: dragons){

                passAge(dragon, hatchDragons);
            }
        }

        for(Dragon dragon: dragons){

            printDragons(dragon, 0);
        }


    }

    public static void  printDragons(Dragon dragon, int tabuaciq){

        String tabb = "";

        for (int i = 0; i < tabuaciq; i++) {

            tabb += " ";
        }

        if (dragon.isAlive()){

            System.out.printf("%s%s",tabb, dragon.getName());
            System.out.println();
        }

        for(Dragon child: dragon.getChildren()){

            printDragons(child, 2);
        }
    }

    public static void passAge(Dragon dragon, int hatchDragons){
        dragon.age();
        dragon.lay();

        if (dragon.isAlive()) {
            for (Egg egg : dragon.getEggs()) {

                egg.age();
                egg.hatch();
            }
        }

        for (Dragon child: dragon.getChildren()){

            passAge(child, hatchDragons);
        }
    }
}
