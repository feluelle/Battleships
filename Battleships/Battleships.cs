using System;
using System.Windows.Forms;
using Battleships.Game;

namespace Battleships
{
    public partial class frm_Battleships : Form
    {
        Game.Game game = null;

        public frm_Battleships()
        {
            InitializeComponent();
        }

        void frm_Battleships_Load(object sender, EventArgs e)
        {
            GameStatusController.ActiveGameStatus = GameStatus.Creation;
            GameStatusController.ActivePanelStatus = PanelStatus.None;
        }
        void creationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameStatusController.ActiveGameStatus = GameStatus.Creation;
            GameStatusController.ActivePanelStatus = PanelStatus.None;
        }
        void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameStatusController.ActiveGameStatus = GameStatus.Start;
            GameStatusController.ActivePanelStatus = PanelStatus.None;
        }

        private void newToolStripMenuItemSingleplayer_Click(object sender, EventArgs e)
        {
            if (game != null)
                game.Close(sfd_Save);

            game = new SingleplayerGame(this);
        }
        private void loadToolStripMenuItemSingleplayer_Click(object sender, EventArgs e)
        {
            if (game != null)
                game.Close(sfd_Save);

            game = new SingleplayerGame(this, true);
            game.Load(ofd_Open);
        }

        private void newToolStripMenuItemMultiplayer_Click(object sender, EventArgs e)
        {
            if (game != null)
                game.Close(sfd_Save);

            game = new MultiplayerGame(this);
        }
        private void loadToolStripMenuItemMultiplayer_Click(object sender, EventArgs e)
        {
            if (game != null)
                game.Close(sfd_Save);

            game = new MultiplayerGame(this, true);
            game.Load(ofd_Open);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (game != null)
                game.Save(sfd_Save);
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (game != null)
                game.Close(sfd_Save);
        }
    }
}
