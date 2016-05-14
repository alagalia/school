import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class GandalfStash {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int pointOfHappiness = Integer.parseInt(sc.nextLine());

        String happinessInput = sc.nextLine();



        String [] aaa = happinessInput.split("[^a-zA-Z]");



        for (int i = 0; i < aaa.length ; i++) {

            String match = aaa[i].toLowerCase();

            if (!match.equals("")) {

                if (match.equals("cram")||match.equals("lembas")||match.equals("apple")||
                        match.equals("honeycake")||match.equals("melon")||match.equals("mushrooms")) {

                    switch (match) {

                        case "cram":
                            pointOfHappiness += 2;
                            break;
                        case "lembas":
                            pointOfHappiness += 3;
                            break;
                        case "apple":
                            pointOfHappiness += 1;
                            break;
                        case "melon":
                            pointOfHappiness += 1;
                            break;
                        case "honeycake":
                            pointOfHappiness += 5;
                            break;
                        case "mushrooms":
                            pointOfHappiness -= 10;
                            break;

                    }
                } else {

                    pointOfHappiness -= 1;
                }
            }
        }

        System.out.println(pointOfHappiness);
        if (pointOfHappiness > 15){

            System.out.println("Special JavaScript mood");
        } else if (pointOfHappiness >= 0) {

            System.out.println("Happy");
        } else if (pointOfHappiness >= -5){

            System.out.println("Sad");
        } else {
            System.out.println("Angry");
        }
    }
}
