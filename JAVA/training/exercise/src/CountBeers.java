import java.util.Scanner;

/**
 * Created by Al on 19.4.2016 г..
 */
public class CountBeers {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        int beers = 0;
        int stacks = 0;

        while (!input.equals("End")){

            String [] supportInput = input.split("\\s+");

            int bottles = Integer.parseInt(supportInput[0]);
            String type = supportInput[1];

            if (type.equals("stacks")){

                stacks += bottles;
            } else {

                beers += bottles;
            }

            input = sc.nextLine();
        }

        stacks += beers / 20;

        beers -= (beers / 20) * 20;

        System.out.printf("%d stacks + %d beers", stacks, beers);
        System.out.println();
    }
}
