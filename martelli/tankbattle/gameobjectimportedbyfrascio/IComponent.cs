namespace gameobjectimportedbyfrascio
{
    public interface IComponent
    {
        void Update(double time);

        IGameObject GameObject {get; set; }
    }
}