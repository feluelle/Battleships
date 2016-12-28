using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleships.Game
{
    public interface IGame
    {
        void Panel_MouseDown(object sender, MouseEventArgs e);
        void Panel_MouseMove(object sender, MouseEventArgs e);
        void Panel_MouseUp(object sender, MouseEventArgs e);
        void Panel_MouseClick(object sender, MouseEventArgs e);
    }
}
