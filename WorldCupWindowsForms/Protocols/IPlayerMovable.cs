using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCupWindowsForms.UserControls;

namespace WorldCupWindowsForms.Protocols
{
    public interface IPlayerMovable
    {
        void MovePlayerControl(PlayerUC playerUC);
    }
}
