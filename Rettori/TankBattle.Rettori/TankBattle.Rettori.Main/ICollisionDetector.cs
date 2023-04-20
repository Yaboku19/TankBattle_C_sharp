using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBattle.Rettori.Main
{
    public interface ICollisionDetector
    {
        bool Detect(Transform object1, Transform object2);
    }
}
