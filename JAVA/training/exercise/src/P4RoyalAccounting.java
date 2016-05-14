import java.math.BigDecimal;
import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Al on 11.5.2016 г..
 */
public class P4RoyalAccounting {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        LinkedHashMap<String,TreeMap<String,List<String>>> data = new LinkedHashMap<>();

        String input = sc.nextLine();

        List<String> names = new ArrayList<>();

        while (!input.equals("Pishi kuf i da si hodim")){

            Pattern pattern = Pattern.compile("^([a-zA-Z]+);(\\-?\\d+);(\\-?\\d*\\.?\\d+);([a-zA-Z]+)$");

            Matcher matcher = pattern.matcher(input);

            while (matcher.find()){

                String team = matcher.group(4);
                String employee = matcher.group(1);
                String hoursPerDay = matcher.group(2);
                String dailyPayment = matcher.group(3);

                BigDecimal hPd = new BigDecimal(hoursPerDay);
                BigDecimal dPay = new BigDecimal(dailyPayment);

                //BigDecimal dailyIncome = dPay.multiply(hPd).divide(new BigDecimal("24"), 6, BigDecimal.ROUND_HALF_EVEN );
                BigDecimal dailyIncome = dPay.multiply(hPd).setScale(8, BigDecimal.ROUND_HALF_EVEN);
                dailyIncome = dailyIncome.divide(new BigDecimal("24"), 8, BigDecimal.ROUND_HALF_EVEN);
                BigDecimal monthlyPayment = dailyIncome.multiply(new BigDecimal("30"));

                /// 0- hours per day     1 - daily payment      2 - monthly payment     3 - daily income
                if (!names.contains(employee)) {

                    names.add(employee);
                    if (!data.containsKey(team)) {

                        data.put(team, new TreeMap<>());

                    }
                    if (!data.get(team).containsKey(employee)) {

                        data.get(team).put(employee, new ArrayList<>());
                        data.get(team).get(employee).add(hoursPerDay);
                        data.get(team).get(employee).add(dailyPayment);
                        data.get(team).get(employee).add(monthlyPayment.toPlainString());
                        data.get(team).get(employee).add(dailyIncome.toPlainString());

                    }
                }
            }

            input = sc.nextLine();
        }

        data.entrySet().stream().sorted((q1, q2) -> {

            BigDecimal fNum = getMonthlyPayment(q1.getValue());
            BigDecimal sNum = getMonthlyPayment(q2.getValue());

            return sNum.compareTo(fNum);
        }).forEach(q -> {
            System.out.printf("Team - %s", q.getKey());
            System.out.println();

            q.getValue().entrySet().stream().sorted((w1, w2) -> {

                int fHour = Integer.parseInt(w1.getValue().get(0));
                int sHour = Integer.parseInt(w2.getValue().get(0));

                BigDecimal fDailyIncome = new BigDecimal(w1.getValue().get(3));
                BigDecimal sDailyIncome = new BigDecimal(w2.getValue().get(3));

                if (fHour != sHour){

                    return Integer.compare(sHour, fHour);
                } else {
                    return sDailyIncome.compareTo(fDailyIncome);
                }
            }).forEach(w -> {
                System.out.printf("$$$%s - %s - %.6f",w.getKey(), w.getValue().get(0), new BigDecimal(w.getValue().get(3)));
                System.out.println();
            });
        });

    }

    private static BigDecimal getMonthlyPayment(TreeMap<String, List<String>> value) {

        TreeMap<String,List<String>> support = value;

        BigDecimal sum = new BigDecimal("0");

        for (Map.Entry<String, List<String>> entry : support.entrySet()) {

            BigDecimal mPayment = new BigDecimal(entry.getValue().get(2));

            sum = sum.add(mPayment);

        }

        return sum;

    }
}
