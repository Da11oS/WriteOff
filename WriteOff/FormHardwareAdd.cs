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
    public partial class FormHardwareAdd : Form
    {
        public FormHardwareAdd()
        {
            InitializeComponent();
        }
        int oper { get; set; }

        int F_Employeer { get; set; }

        DataContext db => ProjectSingelton.db;

        public FormHardwareAdd(int oper, int idSotrudnik)
        {
            this.oper = oper;
            this.F_Employeer = idSotrudnik;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.oper == 1)
            {
                var x = new Hardwares
                {
                    Name = textBox_Name.Text,
                    Type = textBox_Type.Text,
                    Date = dateTimePicker_Date.Value,
                    FIO = textBox_FIO.Text,
                    Place = textBox_FIO.Text
                };
                db.GetTable<Hardwares>().InsertOnSubmit(x);
                db.SubmitChanges();
            }
            else
            {
                var x = db.GetTable<Hardwares>().FirstOrDefault(u => u.ID == this.F_Employeer);
                x.Name = textBox_Name.Text;
                x.Type = textBox_Type.Text;
                x.Date = dateTimePicker_Date.Value;
                x.FIO = textBox_FIO.Text;
                x.Place = textBox_Place.Text;
                db.SubmitChanges();
            }
            var frm = this.Owner as FormHardwares;
            frm.LoadData();
            frm.Refresh();
            this.Close();
        }

        private void FormEmployeerAdd_Load(object sender, EventArgs e)
        {
            if (this.oper == 1)
            {
                button1.Text = "Добавить";
                this.textBox_Name.Text = "";
                textBox_Type.Text = "";
                this.dateTimePicker_Date.Value = DateTime.Now;
                textBox_Place.Text = "";
            }
            else
            {
                button1.Text = "Редактировать";
                var x = db.GetTable<Hardwares>().FirstOrDefault(u => u.ID == this.F_Employeer);
                this.textBox_Name.Text = x.Name;
                textBox_Type.Text = x.Type;
                this.dateTimePicker_Date.Value = DateTime.Now;
                textBox_Place.Text = x.Place;

            }

        }

    }
}
