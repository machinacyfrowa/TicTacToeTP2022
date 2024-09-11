namespace TicTacToe
{
    public partial class Form1 : Form
    {
        //aktywny gracz - zaczynaj� k�ka
        Player p = new Player();

        public Form1()
        {
            InitializeComponent();
            //zainicjuj labelk� pokazuj�c� aktywnego gracza
            ActivePlayerLabel.Text = "Aktywny gracz: " + p.GetPlayer();
        }

        void SwitchPlayer()
        {
            //zmie� aktywnego gracza
            p.SwitchPlayer();
            //zmodyfikuj labelk� pokazuj�c� aktywnego gracza
            ActivePlayerLabel.Text = "Aktywny gracz: " + p.GetPlayer();
        }

        private void GameButtonClick(object sender, EventArgs e)
        {
            //stw�rz obiekt klasy button i rzutuj do niego zawarto�� sender
            Button button = (Button)sender;

            //je�li na guziku jest ju� jaki� napis to zako�cz funkcj�
            if(button.Text != "")
            {
                return;
            }
            //zapisz do guzika aktywnego gracza 
            button.Text = p.GetPlayer();
            //sprawdzamy czy kto� wygra�
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
            //licznik pustych guzik�w
            int empty = 0;
            foreach (Button button in buttonList)
            {
                if (button.Text == String.Empty)
                {
                    //je�li guzik nie ma znaku to zwi�ksz licznik pustych guzik�w
                    empty++;
                }
            }
            //sprawdzamy najpierw wiersze
            //sprawdzamy czy �aden z guzik�w w g�rnym wierszu nie jest pusty
            if(TopLeft.Text != String.Empty && 
                TopCenter.Text != String.Empty && 
                TopRight.Text != String.Empty)
            {
                //je�li nie ma pustych sprawdzamy czy lewy i �rodkowy oraz
                // �rodkowy i prawy s� takie same
                if(TopLeft.Text == TopCenter.Text && TopCenter.Text == TopRight.Text)
                {
                    //je�li s� takie same to wygrywa gracz kt�ry ma taki sam znak
                    //nie ma znaczenia z kt�rego guzika pobieramy tekst
                    MessageBox.Show("Wygra� gracz: " + TopLeft.Text);
                    RestartGame();
                }
            }
            //sprawdzamy czy �aden z guzik�w w �rodkowym wierszu nie jest pusty
            if (CenterLeft.Text != String.Empty &&
                CenterCenter.Text != String.Empty &&
                CenterRight.Text != String.Empty)
            {
                //je�li nie ma pustych sprawdzamy czy lewy i �rodkowy oraz
                // �rodkowy i prawy s� takie same
                if (CenterLeft.Text == CenterCenter.Text && CenterCenter.Text == CenterRight.Text)
                {
                    //je�li s� takie same to wygrywa gracz kt�ry ma taki sam znak
                    //nie ma znaczenia z kt�rego guzika pobieramy tekst
                    MessageBox.Show("Wygra� gracz: " + CenterLeft.Text);
                    RestartGame();
                }
            }

            //je�eli nie wyst�pi� �aden z warunk�w wygranej i nie ma pustych guzik�w
            //to nast�pi� remis
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
            //dla ka�dego guzika w li�cie
            foreach (Button button in buttonList)
            {
                //wyczy�� tekst
                button.Text = String.Empty;
            }
            //resetuj aktywnego gracza
            p.Reset();
            //zmodyfikuj labelk� pokazuj�c� aktywnego gracza
            ActivePlayerLabel.Text = "Aktywny gracz: " + p.GetPlayer();
        }
    }
}
