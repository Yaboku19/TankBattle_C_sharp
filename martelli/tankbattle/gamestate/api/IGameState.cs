namespace gamestate.api
{
    using gameobjectimportedbyfrascio;
    public interface IGameState : CommandListener
    {
        void CreateWorld();

        void Update(double time);

        IEnumerable<Transform> BulletsTrasform {get; }

        IEnumerable<Transform> WallsTrasform {get; }

        Transform GetTankTrasform(int player);

        int GetTankLife(int player);
    }
}
/*
public interface GameState extends CommandListener {

    /**
     * Creates a World with the following parameters.
     * @param firstPlayer the first player
     * @param secondPlayer the second player
     * @param dataList the data for the map
    void createWorld(Player firstPlayer, Player secondPlayer, MapData dataList);

    /**
     * Update the GameObject.
     * @param time indicates the time passed after last update
    void update(Double time);

    /**
     * Gets all the bullets {@link Transform}.
     * @return a {@link Stream} of {@link Transform} of Bullets
    Stream<Transform> getBulletsTrasform();

    /**
     * Gets all the walls {@link Transform}.
     * @return a {@link Stream} of {@link Transform} of Walls
    Stream<Transform> getWallsTrasform();

    /**
     * Gets tank {@link Transform} from the given {@link Player}.
     * @param player used to identify the tank
     * @return return the {@link Transform} of the tank
    Transform getTankTrasform(Player player);

    /**
     * Return the life of the given {@link Player}.
     * @param player used to identify the tank
     * @return life points
    int getTankLife(Player player);
}*/