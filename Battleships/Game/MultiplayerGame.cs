using System.Windows.Forms;
using System.Drawing;
using System.Linq;

using Battleships.Engine.PlayingField;
using Battleships.Engine.Ships;
using Battleships.Engine.Boxes;

namespace Battleships.Game
{
    class MultiplayerGame : Game, IGame
    {
        public Panel SingleplayerPanel { get; private set; }
        public PlayingField SingleplayerPlayingField { get; private set; }

        public Panel MultiplayerPanel { get; private set; }
        public PlayingField MultiplayerPlayingField { get; private set; }

        public MultiplayerGame(Form form, bool loadsGame = false) : base(form, loadsGame)
        {

        }

        internal override void CreatePlayingField()
        {
            SingleplayerPlayingField = new PlayingField(new Size(10, 10));

            MultiplayerPlayingField = new PlayingField(new Size(10, 10));
        }
        internal override void CreatePanel()
        {
            SingleplayerPanel = new Panel()
            {
                Name = "pnl_Spielfeld",
                Location = new Point(DRAWING_BORDER_PX, DRAWING_BORDER_PX + DRAWING_MENU_HEIGHT_PX),
                Size = new Size(SingleplayerPlayingField.Size.Width * PlayingField.BoxSize.Width + PlayingFieldController.Drawer.DRAWING_BUG_PX,
                                SingleplayerPlayingField.Size.Height * PlayingField.BoxSize.Height + PlayingFieldController.Drawer.DRAWING_BUG_PX)
            };
            SingleplayerPanel.MouseClick += Panel_MouseClick;
            SingleplayerPanel.MouseDown += Panel_MouseDown;
            SingleplayerPanel.MouseUp += Panel_MouseUp;
            SingleplayerPanel.MouseMove += Panel_MouseMove;
            Form.Controls.Add(SingleplayerPanel);

            MultiplayerPanel = new Panel()
            {
                Name = SingleplayerPanel.Name + "2",
                Location = new Point(DRAWING_BORDER_PX + SingleplayerPanel.Location.X + SingleplayerPanel.Width, SingleplayerPanel.Location.Y),
                Size = SingleplayerPanel.Size
            };
            MultiplayerPanel.MouseClick += Panel_MouseClick;
            MultiplayerPanel.MouseDown += Panel_MouseDown;
            MultiplayerPanel.MouseUp += Panel_MouseUp;
            MultiplayerPanel.MouseMove += Panel_MouseMove;
            Form.Controls.Add(MultiplayerPanel);

            Form.Size = Form.PreferredSize;
        }
        internal override void Init(bool withRandomShips = false)
        {
            PlayingFieldController.Use(SingleplayerPlayingField);
            PlayingFieldController.Drawer.Use(SingleplayerPanel);

            if (withRandomShips)
            {
                for (int i = 0; i < 1; i++)
                    PlayingFieldController.AddShipRandomlyPlaced(new Battleship());
                for (int i = 0; i < 2; i++)
                    PlayingFieldController.AddShipRandomlyPlaced(new Cruiser());
                for (int i = 0; i < 3; i++)
                    PlayingFieldController.AddShipRandomlyPlaced(new Destroyer());
                for (int i = 0; i < 4; i++)
                    PlayingFieldController.AddShipRandomlyPlaced(new UBoat());
            }

            PlayingFieldController.Drawer.InitGraphic();

            PlayingFieldController.Use(MultiplayerPlayingField);
            PlayingFieldController.Drawer.Use(MultiplayerPanel);

            if (withRandomShips)
            {
                for (int i = 0; i < 1; i++)
                    PlayingFieldController.AddShipRandomlyPlaced(new Battleship());
                for (int i = 0; i < 2; i++)
                    PlayingFieldController.AddShipRandomlyPlaced(new Cruiser());
                for (int i = 0; i < 3; i++)
                    PlayingFieldController.AddShipRandomlyPlaced(new Destroyer());
                for (int i = 0; i < 4; i++)
                    PlayingFieldController.AddShipRandomlyPlaced(new UBoat());
            }

            PlayingFieldController.Drawer.InitGraphic();
        }

        internal override void Save(SaveFileDialog saveDialog)
        {
            if (PlayingFieldController.Active != null)
            {
                if (PlayingFieldController.Save())
                {
                    Form.Text = "Schiffe versenken - " + PlayingFieldController.FileName.Split('\\').Last();
                    MessageBox.Show("Playing field successfully saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                        if (PlayingFieldController.SaveAs(saveDialog.FileName))
                        {
                            Form.Text = "Schiffe versenken - " + PlayingFieldController.FileName.Split('\\').Last();
                            MessageBox.Show("Playing field successfully saved!", "Save As", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Playing field could not be saved!", "Save As", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        internal override void Load(OpenFileDialog openDialog)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
                if (PlayingFieldController.Load(openDialog.FileName))
                {
                    SingleplayerPlayingField = PlayingFieldController.Active;
                    CreatePanel();
                    PlayingFieldController.Drawer.Use(SingleplayerPanel);
                    PlayingFieldController.Drawer.LoadGraphic();

                    Form.Text = "Schiffe versenken - " + PlayingFieldController.FileName.Split('\\').Last();
                    MessageBox.Show("Playing field successfully loaded!", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Playing field could not be loaded!", "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        internal override void Close(SaveFileDialog saveDialog)
        {
            if (PlayingFieldController.Active != null)
            {
                DialogResult dr = MessageBox.Show("Do you want to save it before closing?", "Close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                    Save(saveDialog);
                if (dr != DialogResult.Cancel)
                {
                    PlayingFieldController.Close();
                    Form.Controls.Remove(SingleplayerPanel);
                    Form.Text = "Schiffe versenken";
                }
            }
        }

        public override void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            base.Panel_MouseClick(sender, e);

            if (e.Button == MouseButtons.Left)
            {
                Box hitBox = PlayingFieldHelper.GetBox(e.Location);

                if (hitBox.Kind == BoxKind.Ship && PlayingFieldHelper.GetShip((ShipBox)hitBox).IsSunk)
                    MessageBox.Show("Ship of Player " + (PlayingFieldController.Active.Equals(SingleplayerPlayingField) ? "1" : "2") + " sunk!");

                if (PlayingFieldHelper.AreAllShipsSunk())
                    MessageBox.Show("All ships of Player " + (PlayingFieldController.Active.Equals(SingleplayerPlayingField) ? "1" : "2") + " sunk!");
            }
        }
        public override void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Panel pnl = (Panel)sender;
            if (pnl.Name == "pnl_Spielfeld" && GameStatusController.ActivePanelStatus != PanelStatus.Singleplayer)
            {
                GameStatusController.ActivePanelStatus = PanelStatus.Singleplayer;

                switch (GameStatusController.ActiveGameStatus)
                {
                    case GameStatus.Creation:
                        PlayingFieldController.Use(SingleplayerPlayingField);
                        break;
                    case GameStatus.Start:
                        PlayingFieldController.Use(MultiplayerPlayingField);
                        break;
                    default:
                        break;
                }

                PlayingFieldController.Drawer.Use(pnl);
            }
            else if (pnl.Name == "pnl_Spielfeld2" && GameStatusController.ActivePanelStatus != PanelStatus.Multiplayer)
            {
                GameStatusController.ActivePanelStatus = PanelStatus.Multiplayer;

                switch (GameStatusController.ActiveGameStatus)
                {
                    case GameStatus.Creation:
                        PlayingFieldController.Use(MultiplayerPlayingField);
                        break;
                    case GameStatus.Start:
                        PlayingFieldController.Use(SingleplayerPlayingField);
                        break;
                    default:
                        break;
                }

                PlayingFieldController.Drawer.Use(pnl);
            }

            base.Panel_MouseDown(sender, e);
        }
        public override void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            base.Panel_MouseMove(sender, e);
        }
        public override void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            base.Panel_MouseUp(sender, e);
        }
    }
}
