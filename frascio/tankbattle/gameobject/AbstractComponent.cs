namespace gameobject
{
    public abstract class AbstractComponent : IComponent
    {
        
        public abstract void Update(double time);

        #pragma warning disable CS8618
        public IGameObject GameObject {get; set; }

    }
}