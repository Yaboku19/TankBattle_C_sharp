using Common;
using HumanPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface CommandListener
    {
        void SetDirection(Direction dir, IPlayer p);

        void Shoot(IPlayer p);
    }
}
