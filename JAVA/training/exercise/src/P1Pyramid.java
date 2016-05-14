import java.util.*;

/**
 * Created by Al on 29.4.2016 г..
 */
public class P1Pyramid {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int nLines = Integer.parseInt(sc.nextLine());

        LinkedList<Long> nums = new LinkedList<>();

        long lastNum = Long.MIN_VALUE;

        for (int i = 0; i < nLines; i++) {

            String [] input = sc.nextLine().split("\\s+");

            List<Long> support = new ArrayList<>();

            for (int j = 0; j < input.length; j++) {

                if (!input[j].equals("")){

                    support.add(Long.parseLong(input[j]));
                }
            }

//            Arrays.sort(input);

            Collections.sort(support);

            boolean hasNext = false;

            for (int j = 0; j < support.size(); j++) {

                long currentNum = support.get(j);

                if (currentNum > lastNum){

                    nums.add(currentNum);

                    lastNum = currentNum;

                    hasNext = true;
                    break;
                }

            }

            if (!hasNext){

                lastNum++;
            }

        }

        String result = String.join(", ", nums.toString());

        result = result.replace("[", "").replace("]", "");

        System.out.println(result);
    }
}
