namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static LinkedList<Button> _lista = new LinkedList<Button>();
        public static int j = 0;
        int k = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRemover(object sender, EventArgs e)
        {
            if (_lista.Count() > 0)
            {
                _lista.Remove(_lista.ElementAt(0));
                panelNum.Controls.RemoveAt(0);
            }
        }

        private void BtnGenerar(object sender, EventArgs e)
        {
            if (j == 0)
            {
                for (int i = 0; i < 10; i++)
                {

                    var b = new Button();
                    b.Text = i.ToString();

                    b.Location = new Point(i * 75, 0);
                    panelNum.Controls.Add(b);

                    _lista.AddLast(b);

                }
                j++;

            }
            else if (j == 1)
            {

                for (int i = 0; i < 10; i++)
                {

                    var b = new Button();
                    b.Text = i.ToString();

                    b.Location = new Point(i * 75, 20);
                    panelNum.Controls.Add(b);

                    _lista.AddLast(b);

                }
                j++;
            }
            else if (j == 2)
            {
                for (int i = 0; i < 10; i++)
                {

                    var b = new Button();
                    b.Text = i.ToString();

                    b.Location = new Point(i * 75, 40);
                    panelNum.Controls.Add(b);

                    _lista.AddLast(b);

                }
                j++;
            }
            else if (j == 3)
            {
                for (int i = 0; i < 10; i++)
                {

                    var b = new Button();
                    b.Text = i.ToString();

                    b.Location = new Point(i * 75, 60);
                    panelNum.Controls.Add(b);

                    _lista.AddLast(b);

                }
            }




        }
        private void panelCalc_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
//Comentario nuevo