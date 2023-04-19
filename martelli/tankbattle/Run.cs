
using world.api;
using world.impl;
using gameobjectimportedbyfrascio;

public class Run
{
    public static void Main ()
    {
        Console.WriteLine("Hello World");
        IWorld world = new World(new List<IGameObject> {createGameObj(1, 1), createGameObj(5, 4)});
        Console.WriteLine(world.Entities.Count());
    }

    private static IGameObject createGameObj(double x, double y) => 
        new GameObject(new Transform(new Point2d(x, y), Direction.DOWN, 10, 10));

}