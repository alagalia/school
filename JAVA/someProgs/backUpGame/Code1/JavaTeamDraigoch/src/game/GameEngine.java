package game;

import org.newdawn.slick.*;
import org.newdawn.slick.state.*;
import game.states.Menu;
import game.states.Play;

/**
 * Created by TADimitrov on 3/30/2016.
 */
public class GameEngine extends StateBasedGame {
    private static final int HEIGHT = 800;
    private static final int WIDTH = 600;
    private static final boolean FULL_SCREAN = false;
    public static final String NAME = "Diablo";
    public static final int MENU_STATE = 0;
    public static final int PLAY_STATE = 1;
    public static final int MOST_LEFT_COORDINATE = 0;
    public static final int MOST_RIGHT_COORDINATE = -3134;
    public static final int MOST_UP_COORDINATE = 0;
    public static final int MOST_DOWN_COORDINATE = -3134;

    public GameEngine(String name) {
        super(name);
        this.addState(new Menu(MENU_STATE));
        this.addState(new Play(PLAY_STATE));

    }

    @Override
    public void initStatesList(GameContainer gameContainer) throws SlickException {
        this.getState(MENU_STATE).init(gameContainer, this);
        this.getState(PLAY_STATE).init(gameContainer, this);
        this.enterState(MENU_STATE);
    }

    public void run() throws SlickException {
        AppGameContainer appGameContainer;
        appGameContainer = new AppGameContainer(new GameEngine(this.getTitle()));
        appGameContainer.setDisplayMode(HEIGHT,WIDTH,FULL_SCREAN);
        appGameContainer.start();
    }
}
