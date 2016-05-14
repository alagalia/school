package com.company;

import java.util.List;

/**
 * Created by Aleksey on 5/1/2016.
 */
public class Dragon {

    private String name;

    private int age;

    private List<Egg> eggList;
    private List<Dragon> babies;
    private boolean isAlive = false;

    public static int AGE_OF_DEATH = 6;
    public static int AGE_LAY_EGGS_START = 3;
    public static int AGE_LAY_EGGS_END = 4;

    public Dragon(String name, int age, boolean isAlive) {

        this.name = name;
        this.age = age;
        this.isAlive = isAlive;
    }

    public String getName() {
        return name;
    }

    public List<Dragon> getBabies() {
        return babies;
    }

    public void setBabies(List<Dragon> babies) {
        this.babies = babies;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }


    public boolean isAlive() {
        return isAlive;
    }

    public void setAlive(boolean alive) {
        isAlive = alive;
    }


    public void lay (){

        if (this.age == AGE_LAY_EGGS_START || this.age == AGE_LAY_EGGS_END){

            Egg egg = new Egg(0, this);
            this.eggList.add(egg);
        }


    }

    public void age(){

        if (this.isAlive){

            this.age++;
        }

        if (this.age == AGE_OF_DEATH){

            this.isAlive = false;
        }
    }

    public void increaseOffspring(Dragon baby){

        this.babies.add(baby);
    }

    public Iterable<Egg> getEggs (){

        return this.eggList;
    }
}
