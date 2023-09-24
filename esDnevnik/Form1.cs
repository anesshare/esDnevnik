namespace esDnevnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Globalne.form1 = this;
            Globalne.panel1 = this.panel1;
            Login login = new Login();
            PromeniUC.promeniUC(login, panel1);
        }

       
    }
}