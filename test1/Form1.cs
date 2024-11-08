
namespace test1

{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            label1.Text = DotNetEnv.Env.GetString("TEST_TEEST", "Variable not found");
        }
    }
}