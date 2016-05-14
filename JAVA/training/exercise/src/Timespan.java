import java.util.Scanner;

/**
 * Created by Al on 19.4.2016 г..
 */
public class Timespan {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String[] firstTime = sc.nextLine().split(":");

        String[] secondTime = sc.nextLine().split(":");

        long fHours = Long.parseLong(firstTime[0]);
        long fMinutes = Long.parseLong(firstTime[1]);
        long fSeconds = Long.parseLong(firstTime[2]);

        fMinutes += fHours * 60;
        fSeconds += fMinutes * 60;

        long sHours = Long.parseLong(secondTime[0]);
        long sMinutes = Long.parseLong(secondTime[1]);
        long sSeconds = Long.parseLong(secondTime[2]);

        sMinutes += 60 * sHours;
        sSeconds += 60 * sMinutes;

        long difference = fSeconds - sSeconds;

        long hours = difference / 3600;
        difference -= hours * 3600;

        long minutes = difference / 60;
        difference -= minutes * 60;

        long seconds = difference;

        String min = minutes + "";
        String sec = seconds + "";

        if (minutes < 10){

            min = "0" + minutes;
        }
        if (seconds < 10){
            sec = "0" + seconds;
        }


        String result = hours + ":" + min + ":" + sec;

        System.out.println(result);



    }
}
