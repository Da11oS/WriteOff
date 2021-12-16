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
    public partial class FormWriteOff : Form
    {
        DataContext db => ProjectSingelton.db;
        public int CurrentEmployeer;
        public FormWriteOff()
        {
            InitializeComponent();
        }
        public FormWriteOff(int employeer)
        {
            InitializeComponent();
            CurrentEmployeer = employeer;
        }
        public void LoadData()
        {

            label1.Text = "Списания сотрудника: " + db.GetTable<Employeer>().Select(d => new 
            { 
                d.ID, 
                fio = d.Surname + " " + d.Name + " " + d.Patronymic 
            }).FirstOrDefault(d => d.ID == this.CurrentEmployeer).fio;

            dataGridView_WriteOff.DataSource = db.GetTable<WriteOff>().Select(d => new
            { 
                d.ID, d.Reason, d.F_Hardware, d.Date,
                Col = db.GetTable<Hardwares>().Where(f => f.ID == d.F_Hardware).Count() 
            });

            dataGridView_WriteOff.Columns["ID"].Visible = false;
            dataGridView_WriteOff.Columns["ID"].DisplayIndex = 0;

            dataGridView_WriteOff.Columns["Reason"].HeaderText = "Причина списания";
            dataGridView_WriteOff.Columns["Reason"].DisplayIndex = 1;

            dataGridView_WriteOff.Columns["F_Hardware"].HeaderText = "Код оборудования";
            dataGridView_WriteOff.Columns["F_Hardware"].DisplayIndex = 1;

            dataGridView_WriteOff.Columns["Date"].HeaderText = "Дата списания";
            dataGridView_WriteOff.Columns["Date"].DisplayIndex = 1;

            dataGridView_WriteOff.Columns["Col"].HeaderText = "Подарков";
            dataGridView_WriteOff.Columns["Col"].DisplayIndex = 2;

            dataGridView_WriteOff.Refresh();
        }
        private void dataGridView_WriteOff_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void dataGridView_WriteOff_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dataGridView_WriteOff.CurrentCell = dataGridView_WriteOff.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dataGridView_WriteOff.Rows[e.RowIndex].Selected = true;
                    dataGridView_WriteOff.Focus();

                }
                catch (Exception)
                {

                }
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWriteOffAdd frm = new FormWriteOffAdd(2, Convert.ToInt32(dataGridView_WriteOff.SelectedRows[0].Cells["ID"].Value));
            frm.Owner = this;
            frm.Show();
        }

        private void FormWriteOff_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var frm = new FormWriteOffAdd(1, 0);
            frm.Owner = this;
            frm.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FormHardwares(Convert.ToInt32(dataGridView_WriteOff.SelectedRows[0].Cells["ID"].Value));
                frm.Show();
            }
            finally { }
        }
    }
}
