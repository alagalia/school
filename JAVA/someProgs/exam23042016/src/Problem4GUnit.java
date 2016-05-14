import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Al on 26.4.2016 г..
 */
public class Problem4GUnit {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        TreeMap<String,TreeMap<String,ArrayList<String>>> data = new TreeMap<>();

        while (!input.equals("It's testing time!")){

            Pattern pattern =
                    Pattern.compile("^\\s*([A-Z][a-zA-Z0-9]+)\\s*\\|\\s*([A-Z][a-zA-Z0-9]+)\\s*\\|\\s*([A-Z][a-zA-Z0-9]+)$");

            Matcher matcher = pattern.matcher(input);

            while (matcher.find()){

                String inputClass = matcher.group(1);
                String inputMethod = matcher.group(2);
                String inputTest = matcher.group(3);

                if (!data.containsKey(inputClass)){

                    data.put(inputClass, new TreeMap<>());
                    data.get(inputClass).put(inputMethod, new ArrayList<>());
                    data.get(inputClass).get(inputMethod).add(inputTest);
                } else {

                    if (!data.get(inputClass).containsKey(inputMethod)){

                        data.get(inputClass).put(inputMethod, new ArrayList<>());
                        data.get(inputClass).get(inputMethod).add(inputTest);
                    } else {

                        if (!data.get(inputClass).get(inputMethod).contains(inputTest)){

                            data.get(inputClass).get(inputMethod).add(inputTest);
                        }
                    }
                }
            }

            input = sc.nextLine();
        }


        data.entrySet().stream()
                .sorted((q1, q2) -> {
                    int a =getTestCount(q1.getValue());
                    int b = getTestCount(q2.getValue());

                    if ( a == b){

                        a = countMethods(q1.getValue());
                        b = countMethods(q2.getValue());

                        if (a != b){

                            return Integer.compare(a, b);

                        } else {

                            return q1.getKey().compareTo(q2.getKey());
                        }


                    } else {
                        return Integer.compare(b, a);
                    }

                } ).forEach(q -> {

            System.out.printf("%s:\n", q.getKey());
            q.getValue().entrySet().stream()
                    .sorted((w1, w2) -> {
                        int aa = w1.getValue().size();
                        int bb = w2.getValue().size();

                        if (aa != bb){
                            return Integer.compare(bb, aa);

                        } else {

                            return w1.getKey().compareTo(w2.getKey());
                        }
                    } ).forEach(w -> {
                System.out.printf("##%s\n", w.getKey());
                w.getValue().stream().sorted((e1,e2) -> {

                    int aaa =e1.length();
                    int bbb = e2.length();

                    if (aaa != bbb){

                        return Integer.compare(aaa, bbb);
                    } else {
                        return e1.compareTo(e2);
                    }
                }).forEach(e -> System.out.printf("####%s\n", e));
            });
        });

//        data.entrySet().stream()
//
//
//                .sorted( (m1, m2) -> Integer.compare( countMethods(m1.getValue()) , countMethods(m2.getValue()) ) )
//                .sorted( (x,y) -> Integer.compare( getTestCount(y.getValue()), getTestCount(x.getValue()) )  )
//
//                 .forEach( q -> {
//                     System.out.printf("%s:\n", q.getKey());
//                     q.getValue().entrySet().stream()
//                             .sorted((nT, nT1)-> Integer.compare( countT(nT1.getValue()), countT(nT.getValue()) ) )
//                             .forEach(w-> {
//                                System.out.printf("##%s\n", w.getKey());
//                                w.getValue().stream()
//                                        .sorted((y1,y2) -> y1.compareTo(y2))
//                                        .sorted((t1,t2) -> Integer.compare(t1.length(), t2.length()))
//
//                                            .forEach(p -> {
//                                                System.out.printf("####%s\n",p);
//                                            });
//                     });
//
//                 });


//                .sorted( (m1, m2) -> Integer.compare( countMethods(m1.getValue()) , countMethods(m2.getValue()) ) )
//                  .sorted( (t1, t2) -> methodByAlp(t1).compareTo(methodByAlp(t2)) )
//                .sorted( (a1, a2) -> methodByAlp(a1).compareTo(methodByAlp(a2))  )
//
//                .forEach(q -> System.out.println(q.getKey()));






    }

    private static int countT(ArrayList<String> value) {

        //int count = value.size();

        return value.size();
    }




    private static int countMethods(TreeMap<String, ArrayList<String>> value) {

        int methods = value.size();

        return methods;
    }


    private static int getTestCount(TreeMap<String, ArrayList<String>> value) {

        int sum = 0;

        for (Map.Entry<String, ArrayList<String>> entry : value.entrySet()) {

            List<String> support = entry.getValue();

            sum += support.size();

        }

        return sum;
    }


}
