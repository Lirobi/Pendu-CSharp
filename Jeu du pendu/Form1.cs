using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Jeu_du_pendu
{
    public partial class Pendu : Form
    {
        public Pendu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initMot();
        }

        string[] tabMots = new string[8] { "instructions", "enterrement", "rampant", "palais", "tornade","mariage","renault", "sand-wich"};
        string motMystere;
        bool win;
        bool lose;

        int erreurs = 0;

        private int generePlace()
        {
            Random rnd = new Random();
            int pos = rnd.Next(0, tabMots.Length);
            return pos;
        }

        private void initMot()
        {
            int position = generePlace();
            motMystere = tabMots[position];

            int bordGauche = 30;

            int bordHaut = 30;
            int hauteur = 50;
            int largeur = 50;

            for (int i = 0; i < motMystere.Length; i++)
            {
                //instanciation d'un label
                Label l = new Label();
                //parametrage du label
                l.Top = bordHaut;
                l.Left = bordGauche;
                if (i == 0 || i == motMystere.Length - 1 || motMystere[i] == '-')
                {
                    l.Text = motMystere[i].ToString();
                }
                l.Tag = motMystere[i].ToString();
                l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                l.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                l.Height = hauteur;
                l.Width = largeur;
                grpCases.Controls.Add(l);
                bordGauche += 70;

            }

        }
        private void checkWin()
        {
            win = true;
            lose = false;
            if (erreurs >= 11)
            {
                MessageBox.Show("Vous avez perdu, le mot était " + motMystere);
                lose = true;
            }
            foreach (Label l in grpCases.Controls)
            {
                if (l.Text == string.Empty)
                {
                    win = false;
                }
            }
            if (win)
            {
                MessageBox.Show("Vous avez gagné");

            }

        }
        private void txtProposition_KeyPress(object sender, KeyPressEventArgs e)
        {

            char key = e.KeyChar;
            if (key != (char)Keys.Enter && key != (char)Keys.Back && !char.IsLetter(key))
            {
                e.Handled = true;
            }
            if (key == (char)Keys.Enter)
            {
                bool erreur = true;
                for (int i = 0; i < motMystere.Length; i++)
                {
                    if (((Label)grpCases.Controls[i]).Tag.ToString() == txtProposition.Text)
                    {
                        Label l = ((Label)grpCases.Controls[i]);
                        l.Text = txtProposition.Text;
                        erreur = false;
                    }


                }

                if (erreur)
                {
                    erreurs++;
                    lblErreurs.Text = "Erreurs : " + erreurs;
                }
                checkWin();

                txtProposition.Clear();
            }

        }

        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            grpCases.Controls.Clear();
            txtProposition.Text = "";
            initMot();
        }
    }
}