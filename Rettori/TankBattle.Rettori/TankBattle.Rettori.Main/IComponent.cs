using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBattle.Rettori.Main
{
    public interface IComponent
    {
        IGameObject GameObject { get; }

        void AttachGameObject(IGameObject gameObject);
    }
}
