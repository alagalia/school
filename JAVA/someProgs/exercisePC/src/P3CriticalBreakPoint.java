import java.math.BigInteger;
import java.util.LinkedList;
import java.util.Scanner;

/**
 * Created by Al on 27.4.2016 г..
 */
public class P3CriticalBreakPoint {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        LinkedList<Long> breakPoints = new LinkedList<>();

        LinkedList<String> coordAsString = new LinkedList<>();

        long currentRatio = 0;
        
        boolean hasCritical = true;

        while (!input.equals("Break it.")){

            String [] coordinates = input.split("\\s+");

            coordAsString.add(input);

            long x1 = Long.parseLong(coordinates[0]);
            long y1 = Long.parseLong(coordinates[1]);
            long x2 = Long.parseLong(coordinates[2]);
            long y2 = Long.parseLong(coordinates[3]);

            long criticalRatio = Math.abs((x2 + y2) - (x1 + y1));

            if (criticalRatio != 0){

                if (breakPoints.size() == 0) {
                    breakPoints.add(criticalRatio);
                }
            }

            if (criticalRatio != 0 && !breakPoints.contains(criticalRatio)){

                hasCritical = false;
            }
            if (hasCritical && criticalRatio != 0){
                currentRatio = criticalRatio;
            }

            if (breakPoints.size() != 0){
                breakPoints.add(criticalRatio);
            }



            input = sc.nextLine();
        }


        
        if (hasCritical){

            for (String s : coordAsString) {

                String[] support = s.split("\\s+");

                System.out.printf("Line: [%s]\n", String.join(", ", support));

            }

            BigInteger bigInteger = BigInteger.valueOf(currentRatio);
            BigInteger lines = BigInteger.valueOf (coordAsString.size());

            bigInteger = bigInteger.pow(coordAsString.size());

            //bigInteger = bigInteger.divide(lines);

            bigInteger = bigInteger.remainder(lines);

            System.out.printf("Critical Breakpoint: %s", bigInteger);

        } else {


            System.out.println("Critical breakpoint does not exist.");
        }
    }
}
