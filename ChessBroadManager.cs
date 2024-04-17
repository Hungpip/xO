using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xO
{
    public class ChessBroadManager
    {
        #region Properties
        private Panel chessBroad;

        public Panel ChessBroad
        {
            get { return chessBroad; }
            set { chessBroad = value; }
        }
        #endregion

        #region Intitialize
        public ChessBroadManager(Panel chessBoard)
        {
            this.ChessBroad = chessBoard;
        }
        #endregion

        #region Methods
        void DrawChessBoard()
        {
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                for (int y = 0; y < Cons.CHESS_BOARD_WIDTH; y++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y)
                    };

                    ChessBroad.Controls.Add(btn);

                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.CHESS_WIDTH);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }

        #endregion


    }
}
