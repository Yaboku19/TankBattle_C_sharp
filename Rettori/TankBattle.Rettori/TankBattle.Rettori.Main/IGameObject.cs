using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBattle.Rettori.Main
{
    public interface IGameObject
    {
        T GetComponent<T>() where T : IComponent;

        Transform Transform { get; }
    }
}
