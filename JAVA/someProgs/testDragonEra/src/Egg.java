import java.util.List;

/**
 * Created by Al on 1.5.2016 г..
 */
public class Egg {

    private int age;
    private Dragon parent;
    private final int EGG_HATCH = 2;
    private List<Dragon> children;

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

    public void hatch(){

        if (this.age == EGG_HATCH){

            DragonEra.setNumberOfDragons(DragonEra.getNumberOfDragons() + 1);

            for (int i = 0; i < DragonEra.getHatchDragons(); i++) {

                Dragon baby = new Dragon(0, this.parent.getName() + "/" + "Dragon_" + DragonEra.getNumberOfDragons());

                this.parent.increaseOffspring(baby);
            }
        }
    }

    public void age(){

        this.age++;
    }


}
