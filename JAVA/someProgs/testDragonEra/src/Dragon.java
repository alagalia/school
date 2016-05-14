import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

/**
 * Created by Al on 1.5.2016 г..
 */
public class Dragon {

    private int age;
    private String name;

    private List<Egg> eggs;
    private List<Dragon> children;

    private final int AGE_DEATH = 6;
    private final int AGE_LAY_EGGS_START = 3;
    private final int AGE_LAY_EGGS_END = 4;

    private boolean isAlive = true;

    public Dragon(int age, String name) {
        this.age = age;
        this.name = name;
        this.eggs = new ArrayList<>();
        this.children = new ArrayList<>();
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Iterable<Egg> getEggs() {
        return this.eggs;
    }

    public Iterable<Dragon> getChildren() {
        return this.children;
    }

    public boolean isAlive() {
        return isAlive;
    }

    public void setAlive(boolean alive) {
        isAlive = alive;
    }

    public void setChildren(List<Dragon> children) {
        this.children = children;
    }

    public void setEggs(List<Egg> eggs) {
        this.eggs = eggs;
    }

    public void addEggs(Egg egg){

        eggs.add(egg);
    }

    public void increaseOffspring(Dragon dragon){

        this.children.add(dragon);
    }

    public void age(){

        if (this.isAlive){

            this.age++;
        }

        if (this.age == AGE_DEATH){

            this.isAlive = false;
        }
    }

    public void lay(){

        if (this.age == AGE_LAY_EGGS_START || this.age == AGE_LAY_EGGS_END){

            Egg egg = new Egg(0, this);
            this.eggs.add(egg);
        }
    }


}
