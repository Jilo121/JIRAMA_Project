using MySql.Data.MySqlClient;
using System.Data;

namespace JIRAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            db.openConnection();



            String usermail = emailLogin.Text;
            String pswrd = pswLogin.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM 'user' WHERE 'email' = @usrmail and 'password' = @pass ");
            cmd.Parameters.Add("@usrmail", MySqlDbType.VarChar).Value = usermail;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pswrd;

            adapter.SelectCommand = cmd;

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Existe");
            }
            else
            {
                MessageBox.Show("Faild!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reduce_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}