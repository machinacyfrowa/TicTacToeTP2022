namespace TicTacToe
{
    public partial class Form1 : Form
    {
        //aktywny gracz - zaczynaj¹ kó³ka
        Player p = new Player();

        public Form1()
        {
            InitializeComponent();
            //zainicjuj labelkê pokazuj¹c¹ aktywnego gracza
            ActivePlayerLabel.Text = "Aktywny gracz: " + p.GetPlayer();
        }

        void SwitchPlayer()
        {
            //zmieñ aktywnego gracza
            p.SwitchPlayer();
            //zmodyfikuj labelkê pokazuj¹c¹ aktywnego gracza
            ActivePlayerLabel.Text = "Aktywny gracz: " + p.GetPlayer();
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
            button.Text = p.GetPlayer();
            //sprawdzamy czy ktoœ wygra³
            CheckResult();
            //zmiana gracza
            SwitchPlayer();
            //zablokuj guzik
            //button.Enabled = false;
        }
        void CheckResult()
        {
            //pobierz wszystkie guziki z layoutu i zapisz do listy
            List<Button> buttonList = 
                        tableLayoutPanel1.Controls.OfType<Button>().ToList();
            //licznik pustych guzików
            int empty = 0;
            foreach (Button button in buttonList)
            {
                if (button.Text == String.Empty)
                {
                    //jeœli guzik nie ma znaku to zwiêksz licznik pustych guzików
                    empty++;
                }
            }
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
                    RestartGame();
                }
            }
            //sprawdzamy czy ¿aden z guzików w œrodkowym wierszu nie jest pusty
            if (CenterLeft.Text != String.Empty &&
                CenterCenter.Text != String.Empty &&
                CenterRight.Text != String.Empty)
            {
                //jeœli nie ma pustych sprawdzamy czy lewy i œrodkowy oraz
                // œrodkowy i prawy s¹ takie same
                if (CenterLeft.Text == CenterCenter.Text && CenterCenter.Text == CenterRight.Text)
                {
                    //jeœli s¹ takie same to wygrywa gracz który ma taki sam znak
                    //nie ma znaczenia z którego guzika pobieramy tekst
                    MessageBox.Show("Wygra³ gracz: " + CenterLeft.Text);
                    RestartGame();
                }
            }

            //je¿eli nie wyst¹pi³ ¿aden z warunków wygranej i nie ma pustych guzików
            //to nast¹pi³ remis
            if(empty == 0)
            {
                MessageBox.Show("Remis");
                RestartGame();
            }
        }
        void RestartGame()
        {
            //pobierz wszystkie guziki z layoutu i zapisz do listy
            List<Button> buttonList =
                        tableLayoutPanel1.Controls.OfType<Button>().ToList();
            //dla ka¿dego guzika w liœcie
            foreach (Button button in buttonList)
            {
                //wyczyœæ tekst
                button.Text = String.Empty;
            }
            //resetuj aktywnego gracza
            p.Reset();
            //zmodyfikuj labelkê pokazuj¹c¹ aktywnego gracza
            ActivePlayerLabel.Text = "Aktywny gracz: " + p.GetPlayer();
        }
    }
}
