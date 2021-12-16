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
    public partial class FormWriteOffAdd : Form
    {
        int oper { get; set; }

        int F_Employeer { get; set; }

        DataContext db => ProjectSingelton.db;

        public FormWriteOffAdd(int oper, int idSotrudnik)
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
                var x = new WriteOff
                {
                    F_Hardware = int.Parse(this.textBox_HardwareCode.Text),
                    Reason = textBox_Reason.Text,
                    Date = dateTimePickerDate.Value,
                };
                db.GetTable<WriteOff>().InsertOnSubmit(x);
                db.SubmitChanges();
            }
            else
            {
                var x = db.GetTable<WriteOff>().FirstOrDefault(u => u.ID == this.F_Employeer);
                x.F_Hardware = int.Parse(this.textBox_HardwareCode.Text);
                x.Reason = textBox_Reason.Text;
                x.Date = dateTimePickerDate.Value;
                x.F_Employeer = this.F_Employeer;
                db.SubmitChanges();
            }
            var frm = this.Owner as FormWriteOff;
            frm.LoadData();
            frm.Refresh();
            this.Close();
        }

        private void FormEmployeerAdd_Load(object sender, EventArgs e)
        {
            if (this.oper == 1)
            {
                button1.Text = "Добавить";
                this.textBox_HardwareCode.Text = "";
                textBox_Reason.Text = "";
                this.dateTimePickerDate.Value = DateTime.Now;
            }
            else
            {
                button1.Text = "Редактировать";
                var x = db.GetTable<WriteOff>().FirstOrDefault(u => u.ID == this.F_Employeer);
                this.textBox_HardwareCode.Text = x.F_Hardware.ToString();
                textBox_Reason.Text = x.Reason;
                this.dateTimePickerDate.Value = x.Date;

            }

        }

    }
}
