package com.company;

import java.util.Scanner;

/**
 * Created by Aleksey on 5/6/2016.
 */
public class P1MelrahShake {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String text = sc.nextLine();
        String key = sc.nextLine();

        boolean hasShake = false;

        while (true){

            hasShake = false;

            int first = text.indexOf(key);
            int last = text.lastIndexOf(key);

            int lenghtKey = key.length();
            int lenghtText = text.length();

            if (lenghtKey < 1 || ((lenghtKey * 2) > lenghtText)){

                break;
            }

            int chToRemove = key.length() / 2;

            if (first != -1 && last != -1 && first != last){

                StringBuilder sb = new StringBuilder();

                sb.append(text.substring(0, first));
                sb.append(text.substring(first + lenghtKey, last));
                sb.append(text.substring(last + lenghtKey));

                text = sb.toString();

                sb = new StringBuilder(key);
                sb.deleteCharAt(chToRemove);

                key = sb.toString();

                hasShake = true;
                System.out.println("Shaked it.");

            } else {
                break;
            }
        }

        if (!hasShake){

            System.out.println("No shake.");
            System.out.println(text);
        }
    }
}
