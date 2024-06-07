using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace _213
{
    public partial class DbConn : Form
    {
        public string ConnectionString { get; set; }
        public DbConn()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            string Ip = ServerIp.Text;
            string Users = User.Text;
            string Pass = PasswordDb.Text;
            string DbNames = DbName.Text;
            if(string.IsNullOrWhiteSpace(DbNames)) 
            {
                connectionString = $"Host={Ip};Username={Users};Password={Pass}";
            }
            else
            {
                connectionString = $"Host={Ip};Database ={DbNames};Username={Users};Password={Pass}";
            }
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    OkerNot.Text = "Подключение успешно";
                    ConnectionString = connectionString;
                }
            }
            catch (Exception)
            {
                OkerNot.Text = "Произошла ошибка, проверьте данные";
            }
        }

    }
}
