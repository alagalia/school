package game.states;

import characters.Minotaur;
import characters.SwordsMan;
import manageres.EnemiesManager;
import manageres.SwordsManManager;
import org.newdawn.slick.GameContainer;
import org.newdawn.slick.Graphics;
import org.newdawn.slick.Image;
import org.newdawn.slick.SlickException;
import org.newdawn.slick.state.BasicGameState;
import org.newdawn.slick.state.StateBasedGame;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by TADimitrov on 3/30/2016.
 */
public class Play extends BasicGameState {
    private int stateID;
    private SwordsManManager swordsManManager = new SwordsManManager();
    private EnemiesManager enemiesManager = new EnemiesManager();

    public Image levelOneMap;
    private Image backGround;

    public static SwordsMan swordMan;
    public static Minotaur minotaur;
    public Minotaur minotaur2;

    private List<Minotaur> minotaurs = new ArrayList<>();

    public List<Minotaur> getMinotaurs() {
        return minotaurs;
    }

    public Play(int state) {
        this.stateID = state;
    }

    @Override
    public int getID() {
        return this.stateID;
    }

    @Override
    public void init(GameContainer gameContainer, StateBasedGame stateBasedGame) throws SlickException {

        //backGround = new Image("resources/img/basicGrid20x20.png");
        //levelOneMap = new Image("resources/img/World.png");

        this.levelOneMap = new Image("resources/img/t.png");

        //this.swordMan = new SwordsMan(0,0,"Alex"); /// x = 0 ?,y = 0 ?  starting position of our Character ;)

        //for (int i = 0; i <= 2; i++) {

        // this.minotaurs.add(new Minotaur( i * 100, 100));
        //}

        //this.minotaur1 = new Minotaur(900,900);
        //this.minotaur2 = new Minotaur(300,300);

        this.swordsManManager.createCharacter();

        this.enemiesManager.createCharacter();

    }

    @Override
    public void render(GameContainer gameContainer, StateBasedGame stateBasedGame, Graphics graphics) throws SlickException {

        this.levelOneMap.draw(this.swordsManManager.getCharacter().getPosX(), this.swordsManManager.getCharacter().getPosY() );


        this.swordsManManager.drawCharacter();
        this.enemiesManager.drawCharacter();



        graphics.drawString("X "+ this.swordsManManager.getCharacter().getPosX()+ "", 0, 30);
        graphics.drawString("Y "+ this.swordsManManager.getCharacter().getPosY()+ "", 0, 50);
        // this.swordMan.render(gameContainer,graphics);

        //this.minotaur1.render(gameContainer,graphics);
        ///this.minotaur2.render(gameContainer,graphics);

        // for(Minotaur minotaur: getMinotaurs()){

        // minotaur.render(gameContainer,graphics);
        //}


    }

    @Override
    public void update(GameContainer gameContainer, StateBasedGame stateBasedGame, int delta) throws SlickException {
        this.swordsManManager.moveCharacter(gameContainer);

        this.enemiesManager.moveCharacter(gameContainer);
        /// if mission accomplished stateBasedGame -- main menu or next level
        // this.swordMan.update(gameContainer, this.stateID);
        //this.minotaur1.update(gameContainer,this.stateID);
        //this.minotaur2.update(gameContainer,this.stateID);

        //for(Minotaur minotaur: getMinotaurs()){

        // minotaur.update(gameContainer, this.stateID);
        // }

    }
}
