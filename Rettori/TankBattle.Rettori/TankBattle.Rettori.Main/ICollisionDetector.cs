namespace TankBattle.Rettori.Main
{
    /// <summary>
    /// Represents a strategy to check if the Transform of two objects are colliding.
    /// </summary>
    public interface ICollisionDetector
    {
        /// <summary>
        /// Checks if any corner of the two Transforms is in the area of the other.
        /// </summary>
        /// <param name="object1"> first Transform object</param>
        /// <param name="object2"> second Transform object</param>
        /// <returns> if the objects are colliding</returns>
        bool Detect(Transform object1, Transform object2);
    }
}
