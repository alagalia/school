import javafx.collections.transformation.SortedList;

import java.math.BigDecimal;
import java.util.*;

/**
 * Created by Al on 19.4.2016 г..
 */
public class ThreeLargestNumbers {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int nLines = Integer.parseInt(sc.nextLine());

        List<BigDecimal> data = new ArrayList<>();

        for (int i = 0; i < nLines; i++) {

            BigDecimal current = new BigDecimal(sc.nextLine());

            if (data.size() < 3){

                data.add(current);
            } else {

                Collections.sort(data);
                BigDecimal num = data.get(0);

                int resultCompare = num.compareTo(current);

                if (resultCompare < 0 ){

                    data.remove(0);
                    data.add(current);
                }
            }
        }

        System.out.println();
        data.stream().sorted((x,y) -> y.compareTo(x)).forEach(k -> {System.out.printf("%s\n",k.toPlainString());});
    }
}
