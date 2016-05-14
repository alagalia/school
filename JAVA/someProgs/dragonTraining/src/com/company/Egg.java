package com.company;

/**
 * Created by Aleksey on 5/1/2016.
 */
public class Egg {

    private int age;
    private Dragon parent;

    public static int yearFactor;

    private static int AGE_HATCH = 2;

    public Egg(int age, Dragon parent) {
        this.age = age;
        this.parent = parent;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public Dragon getParent() {
        return parent;
    }

    public void setParent(Dragon parent) {
        this.parent = parent;
    }

    public void age(){

        this.age++;
    }

    public int getYearFacotor() {
        return yearFactor;
    }

    public void setYearFacotor(int yearFacotor) {
        this.yearFactor = yearFacotor;
    }

    public void hatch(){

        if (this.age == AGE_HATCH){


            for (int i = 0; i < this.getYearFacotor(); i++) {

                DragonEra.NUMBER_OF_DRAGON++;

                Dragon baby = new Dragon(this.parent.getName() + "/" + "Dragon_" + DragonEra.NUMBER_OF_DRAGON, 0, true);
                this.parent.increaseOffspring(baby);
            }
        }


    }
}
