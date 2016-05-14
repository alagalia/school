import java.util.*;

/**
 * Created by Al on 29.4.2016 г..
 */
public class P4SchoolSystem {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int nLines = Integer.parseInt(sc.nextLine());

        TreeMap<String,TreeMap<String,List<Integer>>> data = new TreeMap<>();

        for (int i = 0; i < nLines; i++) {

            String[] input = sc.nextLine().split("\\s+");

            String name = input[0] + " " + input[1];
            //String sName = input[1];
            String subject = input[2];
            int score = Integer.parseInt(input[3]);


            if (!data.containsKey(name)){

                data.put(name, new TreeMap<>());
                data.get(name).put(subject, new ArrayList<>());
                data.get(name).get(subject).add(score);

            } else {

                if (!data.get(name).containsKey(subject)){

                    data.get(name).put(subject, new ArrayList<>());
                    data.get(name).get(subject).add(score);

                } else {

                    data.get(name).get(subject).add(score);
                }
            }
        }

        for (Map.Entry<String, TreeMap<String, List<Integer>>> entry : data.entrySet()) {

            System.out.printf("%s: [", entry.getKey());

            StringBuilder sb = new StringBuilder();

            TreeMap<String,List<Integer>> support = entry.getValue();

            for (Map.Entry<String, List<Integer>> subject : support.entrySet()) {

                double score = 0;

                List<Integer> marks = subject.getValue();

                for (Integer mark : marks) {
                    score += mark;
                }

                score = score / marks.size();
                sb.append(String.format("%s - %.2f, ", subject.getKey(), score));

            }
            sb.setCharAt(sb.length() - 2, '\u0000');
            sb.setCharAt(sb.length() - 1, '\u0000');

            //String aa = sb.toString();


            System.out.printf("%s]\n", sb.toString());

        }
    }
}
