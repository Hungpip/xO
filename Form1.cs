namespace xO
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBroadManager ChessBroad;
        #endregion
        public Form1()
        {
            InitializeComponent();

            ChessBroad = new ChessBroadManager(pnlChessBoard);

            //TODO : Ông fix hộc tôi chỗ này với
            ChessBroad.DrawChessBoard();
        }
            

    }
}
