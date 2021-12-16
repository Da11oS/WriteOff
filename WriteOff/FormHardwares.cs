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
    public partial class FormHardwares : Form
    {
        public FormHardwares()
        {
            InitializeComponent();
        }
        DataContext db => ProjectSingelton.db;

        public int CurrentWriteOff;
        public FormHardwares(int writeOff)
        {
            InitializeComponent();
            CurrentWriteOff = writeOff;
        }
        public void LoadData()
        {
            label1.Text = "Оборудование списываются по причине: " + db.GetTable<WriteOff>().Select(d => new
            {
                d.ID,
                d.Reason
            }).FirstOrDefault(d => d.ID == this.CurrentWriteOff).Reason;

            dataGridView_Hardware.DataSource = db.GetTable<Hardwares>().Select(d => new
            {
                d.ID,
                d.Name,
                d.Type,
                d.FIO,
                d.Place,
                d.Date
            });

            dataGridView_Hardware.Columns["ID"].Visible = false;
            dataGridView_Hardware.Columns["ID"].DisplayIndex = 0;

            dataGridView_Hardware.Columns["Name"].HeaderText = "Причина списания";
            dataGridView_Hardware.Columns["Name"].DisplayIndex = 1;

            dataGridView_Hardware.Columns["Type"].HeaderText = "Тип оборудования";
            dataGridView_Hardware.Columns["Type"].DisplayIndex = 2;

            dataGridView_Hardware.Columns["Date"].HeaderText = "Дата поступления";
            dataGridView_Hardware.Columns["Date"].DisplayIndex = 3;

            dataGridView_Hardware.Columns["FIO"].HeaderText = "ФИО ответственного";
            dataGridView_Hardware.Columns["FIO"].DisplayIndex = 4;

            dataGridView_Hardware.Columns["Place"].HeaderText = "Место установки";
            dataGridView_Hardware.Columns["Place"].DisplayIndex = 5;


            dataGridView_Hardware.Refresh();
        }
        private void dataGridView_Hardware_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void dataGridView_Hardware_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dataGridView_Hardware.CurrentCell = dataGridView_Hardware.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dataGridView_Hardware.Rows[e.RowIndex].Selected = true;
                    dataGridView_Hardware.Focus();

                }
                catch (Exception)
                {

                }
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormHardwareAdd(2, Convert.ToInt32(dataGridView_Hardware.SelectedRows[0].Cells["ID"].Value));
            frm.Owner = this;
            frm.Show();
        }

        private void dataGridView_Hardware_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var frm = new FormHardwareAdd(1, 0);
            frm.Owner = this;
            frm.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
