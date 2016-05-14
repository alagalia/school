import java.util.Scanner;

/**
 * Created by Al on 18.4.2016 г..
 */
public class VideoDuration {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int hours = 0;
        int minutes = 0;

        String input = sc.nextLine();

        while (!input.equals("End")){

            String [] support = input.split(":");

            hours += Integer.parseInt(support[0]);
            minutes += Integer.parseInt(support[1]);

            input = sc.nextLine();
        }

        int minToHours = minutes / 60;

        minutes -= minToHours * 60;

        hours += minToHours;

        if (minutes < 10){

            System.out.println(hours + ":0" + minutes);
        } else {

            System.out.println(hours + ":" + minutes);
        }
    }
}
