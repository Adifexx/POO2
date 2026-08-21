namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cliqueaqui_Click(object sender, EventArgs e)
        {
            var nome = textnome.Text;
            var sobrenome = textsobrenome.Text;
            textnomecompleto.Text = $"{nome} {sobrenome}";
        }
    }
}
