package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Aleksey on 5/10/2016.
 */
public class P3RoyalFlush {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int nLines = Integer.parseInt(sc.nextLine());

        String [] royalStraight = new String[]{"10", "J", "Q", "K", "A"};
        String straight = "10 J Q K A";

        List<Boolean> spades = new ArrayList<>();
        List<Boolean> hearts = new ArrayList<>();
        List<Boolean> diamonds = new ArrayList<>();
        List<Boolean> clubs = new ArrayList<>();


        int indexC = 0;
        int indexD = 0;
        int indexH = 0;
        int indexS = 0;
        int count = 0;

        //String lastFace = "";
        //String lastSuit = "";

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < nLines; i++) {

            String input = sc.nextLine();

            sb.append(input);
        }

        Pattern pathern = Pattern.compile("([0-9AKJQ]+)([schd])");

        Matcher matcher = pathern.matcher(sb.toString());

        while (matcher.find()){

            String face = matcher.group(1).trim();
            String suit = matcher.group(2).trim();

            if (straight.contains(face)){

                if (suit.equals("c")){

                    if (face.equals(royalStraight[indexC])){

                        clubs.add(true);
                        indexC++;

                        if (clubs.size() == 5){

                            System.out.println("Royal Flush Found - Clubs");
                            clubs.clear();
                            indexC = 0;
                            count++;

                        }
                    } else {

                        clubs.clear();
                        indexC = 0;

                        if (face.equals(royalStraight[indexC])){
                            clubs.add(true);
                            indexC++;
                        }
                    }

                }
                if (suit.equals("d")){

                    if (face.equals(royalStraight[indexD])){

                        diamonds.add(true);
                        indexD++;

                        if (diamonds.size() == 5){

                            System.out.println("Royal Flush Found - Diamonds");
                            diamonds.clear();
                            indexD = 0;
                            count++;

                        }
                    } else {

                        diamonds.clear();
                        indexD = 0;

                        if (face.equals(royalStraight[indexD])){
                            diamonds.add(true);
                            indexD++;
                        }
                    }

                }
                if (suit.equals("h")){

                    if (face.equals(royalStraight[indexH])){

                        hearts.add(true);
                        indexH++;

                        if (hearts.size() == 5){

                            System.out.println("Royal Flush Found - Hearts");
                            hearts.clear();
                            indexH = 0;
                            count++;

                        }
                    } else {

                        hearts.clear();
                        indexH = 0;
                        if (face.equals(royalStraight[indexH])){
                            hearts.add(true);
                            indexH++;
                        }
                    }

                }
                if (suit.equals("s")){

                    if (face.equals(royalStraight[indexS])){

                        spades.add(true);
                        indexS++;

                        if (spades.size() == 5){

                            System.out.println("Royal Flush Found - Spades");
                            spades.clear();
                            indexS = 0;
                            count++;

                        }
                    } else {

                        spades.clear();
                        indexS = 0;
                        if (face.equals(royalStraight[indexS])){
                            spades.add(true);
                            indexS++;
                        }
                    }

                }


            } else {

                if (suit.equals("c")){

                    clubs.clear();
                    indexC = 0;
                }
                if (suit.equals("d")){

                    diamonds.clear();
                    indexD = 0;
                }
                if (suit.equals("h")){

                    hearts.clear();
                    indexH = 0;
                }
                if (suit.equals("s")){

                    spades.clear();
                    indexS = 0;
                }

            }

        }

        System.out.println("Royal's Royal Flushes - " + count + ".");
    }
}

