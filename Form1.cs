using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noteTakingApp
{
    public partial class Form1 : Form
    {
        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Message", typeof(String));
            dtGridMessages.DataSource = table;
            dtGridMessages.Columns["Message"].Visible = false;
            dtGridMessages.Columns["Title"].Width = 180;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtBxTitle.Clear();
            txtBxMsg.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtBxTitle.Text, txtBxMsg.Text);
            txtBxTitle.Clear();
            txtBxMsg.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int index = dtGridMessages.CurrentCell.RowIndex;

            if (index > -1)
            {
                txtBxTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtBxMsg.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dtGridMessages.CurrentCell.RowIndex;

            table.Rows[index].Delete();
            txtBxTitle.Clear();
            txtBxMsg.Clear();
        }
    }
}
