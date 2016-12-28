using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using Battleships.Engine.Exceptions;
using Battleships.Engine.PlayingField;
using Battleships.Engine.Ships;

namespace Battleships.Game
{
    public abstract class Game : IGame
    {
        //-- Wird zum Hinzufügen eines temporären Schiffes benötigt
        Ship verifiedShip = null;
        Point mouseStart = Point.Empty;
        Ship tempShip = null;
        //--
        public const short DRAWING_BORDER_PX = 4;
        public const short DRAWING_MENU_HEIGHT_PX = 24;

        public Form Form { get; private set; }

        public Game(Form form, bool loadsGame)
        {
            this.Form = form;

            if (!loadsGame)
            {
                CreatePlayingField();

                CreatePanel();

                Init(true); 
            }
        }

        internal abstract void CreatePlayingField();
        internal abstract void CreatePanel();
        internal abstract void Init(bool withRandomShips = false);

        internal abstract void Save(SaveFileDialog saveDialog);
        internal abstract void Load(OpenFileDialog saveDialog);
        internal abstract void Close(SaveFileDialog saveDialog);


        public virtual void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    PlayingFieldController.Drawer.FillBox(PlayingFieldHelper.GetBox(e.Location));
                    break;
                default:
                    break;
            }
        }
        public virtual void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    mouseStart = e.Location;
                    break;
                case MouseButtons.Middle:
                    PlayingFieldController.Drawer.DrawCheat(true);
                    break;
                default:
                    break;
            }
        }
        public virtual void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    if (verifiedShip != null && tempShip != null && PlayingFieldHelper.GetBoxPoint(mouseStart).Equals(tempShip.Boxes.First().Rect.Location))
                        verifiedShip = PlayingFieldController.Drawer.DeleteAndUnDrawTempShip(tempShip);

                    ShipProperties shipProperties = createAndGetShipProperties(e.Location);

                    tempShip = createAndGetShipByLength(shipProperties.Length);

                    if (tempShip != null)
                        verifiedShip = PlayingFieldController.Drawer.CreateAndDrawTempShip(tempShip, shipProperties.Start, shipProperties.Direction);
                    break;
                default:
                    break;
            }
        }
        public virtual void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    if (mouseStart != e.Location && verifiedShip != null)
                        try
                        {
                            PlayingFieldController.AddShipDirectly(verifiedShip);
                        }
                        catch (ShipException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    break;
                case MouseButtons.Middle:
                    PlayingFieldController.Drawer.DrawCheat(false);
                    break;
                default:
                    break;
            }
        }

        private ShipProperties createAndGetShipProperties(Point e)
        {
            int dx = e.X - mouseStart.X;
            int dy = e.Y - mouseStart.Y;
            int shipLength = 1;
            ShipDirection shipDirection = ShipDirection.None;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                shipLength = (int)Math.Ceiling((double)Math.Abs(dx) / PlayingField.BoxSize.Width);
                shipDirection = (dx > 0) ? ShipDirection.Right : ShipDirection.Left;
            }
            else
            {
                shipLength = (int)Math.Ceiling((double)Math.Abs(dy) / PlayingField.BoxSize.Height);
                shipDirection = (dy > 0) ? ShipDirection.Down : ShipDirection.Up;
            }

            return new ShipProperties(shipLength, shipDirection, mouseStart);
        }
        private Ship createAndGetShipByLength(int shipLength)
        {
            Ship tempShip = null;

            switch (shipLength)
            {
                case 0:
                case 1:
                    tempShip = null;
                    break;
                case 2:
                    tempShip = new UBoat();
                    break;
                case 3:
                    tempShip = new Destroyer();
                    break;
                case 4:
                    tempShip = new Cruiser();
                    break;
                case 5:
                default:
                    tempShip = new Battleship();
                    break;
            }

            return tempShip;
        }
    }

    internal class ShipProperties
    {
        public Point Start { get; private set; }
        public int Length { get; private set; }
        public ShipDirection Direction { get; private set; }

        public ShipProperties(int shipLength, ShipDirection shipDirection, Point shipStart)
        {
            this.Length = shipLength;
            this.Direction = shipDirection;
            this.Start = shipStart;
        }
    }
}
