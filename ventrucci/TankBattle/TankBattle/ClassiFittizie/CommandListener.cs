using Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiFittizie
{
    public interface CommandListener
    {
        void SetDirection(Direction dir, IPlayer p);

        void Shoot(IPlayer p);
    }
}
