using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteOff
{
    public partial class FormEmployeer : Form
    {
        DataContext db = ProjectSingelton.db;
        public FormEmployeer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadDate()
        {

            dataGridView_Employeer.DataSource = db.GetTable<Employeer>().Select(d => 
            new { 
                d.ID, 
                d.Surname, 
                d.Name, 
                d.Patronymic, 
                d.Position,
                d.Branch,
                Count = db.GetTable<WriteOff>().Where(f => f.F_Employeer == d.ID).Count() 
            });

            dataGridView_Employeer.Columns["ID"].Visible = false;
            dataGridView_Employeer.Columns["ID"].DisplayIndex = 0;

            dataGridView_Employeer.Columns["Surname"].HeaderText = "Фамилия";
            dataGridView_Employeer.Columns["Surname"].DisplayIndex = 1;

            dataGridView_Employeer.Columns["Name"].HeaderText = "Имя";
            dataGridView_Employeer.Columns["Name"].DisplayIndex = 2;

            dataGridView_Employeer.Columns["Patronymic"].HeaderText = "Отчество";
            dataGridView_Employeer.Columns["Patronymic"].DisplayIndex = 3;

            dataGridView_Employeer.Columns["Position"].HeaderText = "Должность";
            dataGridView_Employeer.Columns["Position"].DisplayIndex = 4;

            dataGridView_Employeer.Columns["Branch"].HeaderText = "Подразделение";
            dataGridView_Employeer.Columns["Branch"].DisplayIndex = 5;

            dataGridView_Employeer.Columns["Count"].HeaderText = "Списаний";
            dataGridView_Employeer.Columns["Count"].DisplayIndex = 6;

            dataGridView_Employeer.Refresh();
        }

        private void FormEmployeer_Load(object sender, EventArgs e)
        {
            LoadDate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEmployeerAdd frm = new FormEmployeerAdd(1, 0);
            frm.Owner = this;
            frm.Show();
        }

        private void dataGridView_Employeer_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void dataGridView_Employeer_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dataGridView_Employeer.CurrentCell = dataGridView_Employeer.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dataGridView_Employeer.Rows[e.RowIndex].Selected = true;
                    dataGridView_Employeer.Focus();

                }
                catch (Exception)
                {

                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sotr = db.GetTable<Employeer>().FirstOrDefault(u => u.ID == Convert.ToInt32(dataGridView_Employeer.SelectedRows[0].Cells["Id"].Value));
            db.GetTable<Employeer>().DeleteOnSubmit(sotr);
            db.SubmitChanges();

            this.LoadDate();

        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormEmployeerAdd(2, Convert.ToInt32(dataGridView_Employeer.SelectedRows[0].Cells["ID"].Value));
            frm.Owner = this;
            frm.Show();
        }


        private void списанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FormWriteOff(Convert.ToInt32(dataGridView_Employeer.SelectedRows[0].Cells["ID"].Value));
                frm.Show();
            }
            finally { }
        }
    }
}
