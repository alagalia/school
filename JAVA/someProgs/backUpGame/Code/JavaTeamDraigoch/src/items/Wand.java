package items;

import characters.Mage;
import contracts.Character;

public class Wand extends Equipment {
    private int spellAttack;
    ;
    private int lightRadius;

    public Wand(int itemID, int spellAttack, int lightRadius) {
        super(itemID);
        this.spellAttack = spellAttack;
        this.lightRadius = lightRadius;
    }

    @Override
    public void applyItemEffect(Character character) {
        if (character instanceof Mage) {
            ((Mage)character).setSpellAttack(this.spellAttack);
        }

        character.setLightRadius(this.lightRadius);
    }
}