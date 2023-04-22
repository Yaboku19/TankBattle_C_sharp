namespace gameobjectimportedbyfrascio
{
    public interface IGameObject 
    {
        List<IComponent> Components {get ; } //getComponents
        Transform Transform{get ; } //getTransform

        Direction Direction {set; } //setDirection 

        Point2d Position {set; } //setPosition 

        void Update(double time);

        IGameObject AddComponent(IComponent component);

        T? GetComponent<T>() where T : IComponent;

    }

}