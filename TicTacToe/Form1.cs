namespace TicTacToe
{
    public partial class Form1 : Form
    {
        //aktywny gracz - zaczynaj¹ kó³ka
        char activePlayer = 'O';

        public Form1()
        {
            InitializeComponent();
            //zainicjuj labelkê pokazuj¹c¹ aktywnego gracza
            ActivePlayerLabel.Text = "Aktywny gracz: " + activePlayer;
        }

        void SwitchPlayer()
        {
            //zmieñ aktywnego gracza
            activePlayer = (activePlayer == 'O') ? 'X' : 'O';
            //zmodyfikuj labelkê pokazuj¹c¹ aktywnego gracza
            ActivePlayerLabel.Text = "Aktywny gracz: " + activePlayer;
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
        void CheckResult()
        {
            //sprawdzamy najpierw wiersze
            //sprawdzamy czy ¿aden z guzików w górnym wierszu nie jest pusty
            if(TopLeft.Text != String.Empty && 
                TopCenter.Text != String.Empty && 
                TopRight.Text != String.Empty)
            {
                //jeœli nie ma pustych sprawdzamy czy lewy i œrodkowy oraz
                // œrodkowy i prawy s¹ takie same
                if(TopLeft.Text == TopCenter.Text && TopCenter.Text == TopRight.Text)
                {
                    //jeœli s¹ takie same to wygrywa gracz który ma taki sam znak
                    //nie ma znaczenia z którego guzika pobieramy tekst
                    MessageBox.Show("Wygra³ gracz: " + TopLeft.Text);
                }
            }
        }
    }
}
