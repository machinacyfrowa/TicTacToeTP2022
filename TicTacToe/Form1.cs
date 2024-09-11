namespace TicTacToe
{
    public partial class Form1 : Form
    {
        //aktywny gracz - zaczynaj¹ kó³ka
        char activePlayer = 'O';

        public Form1()
        {
            InitializeComponent();
        }

        void SwitchPlayer()
        {
            //zmieñ aktywnego gracza
            activePlayer = (activePlayer == 'O') ? 'X' : 'O';
        }

        private void GameButtonClick(object sender, EventArgs e)
        {
            //stwórz obiekt klasy button i rzutuj do niego zawartoœæ sender
            Button button = (Button)sender;

            //jeœli na guziku jest ju¿ jakiœ napis to zakoñcz funkcjê
            if(button.Text != "")
            {
                return;
            }
            //zapisz do guzika aktywnego gracza 
            button.Text = activePlayer.ToString();
            SwitchPlayer();
            //zablokuj guzik
            //button.Enabled = false;
        }
    }
}
