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
    public partial class FormEmployeerAdd : Form
    {
        int oper { get; set; }

        int F_Employeer { get; set; }

        DataContext db = new DataContext(System.Configuration.ConfigurationManager.ConnectionStrings[ProjectSingelton.ConnectionString].ConnectionString);

        public FormEmployeerAdd(int oper, int idSotrudnik)
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
                var x = new Employeer
                {
                    Name = this.textBox_Name.Text,
                    Surname = this.textBox_Surname.Text,
                    Patronymic = this.textBox_Patronymic.Text,
                    Position = this.textBox_Position.Text,
                    Date = this.dateTimePicker_Date.Value,
                    Branch = this.textBox_Branch.Text,
                };
                db.GetTable<Employeer>().InsertOnSubmit(x);
                db.SubmitChanges();
            }
            else
            {
                var sotr = db.GetTable<Employeer>().FirstOrDefault(u => u.ID == this.F_Employeer);
                sotr.Name = this.textBox_Name.Text;
                sotr.Surname = this.textBox_Surname.Text;
                sotr.Patronymic = this.textBox_Patronymic.Text;
                sotr.Position = this.textBox_Position.Text;
                sotr.Date = this.dateTimePicker_Date.Value;
                sotr.Branch = this.textBox_Branch.Text;
                db.SubmitChanges();
            }
            var frm = this.Owner as FormEmployeer;
            frm.LoadDate();
            frm.Refresh();
            this.Close();
        }

        private void FormEmployeerAdd_Load(object sender, EventArgs e)
        {
            if (this.oper == 1)
            {
                button1.Text = "Добавить";
                this.textBox_Name.Text = "";
                this.textBox_Surname.Text = "";
                this.textBox_Patronymic.Text = "";
                this.textBox_Position.Text = "";
                this.dateTimePicker_Date.Value = DateTime.Now;
                this.textBox_Branch.Text = "";
            }
            else
            {
                button1.Text = "Редактировать";
                var sotr = db.GetTable<Employeer>().FirstOrDefault(u => u.ID == this.F_Employeer);
                this.textBox_Name.Text = sotr.Name;
                this.textBox_Surname.Text = sotr.Surname;
                this.textBox_Patronymic.Text = sotr.Patronymic;
                this.textBox_Position.Text = sotr.Position;
                this.dateTimePicker_Date.Value = sotr.Date;
                this.textBox_Branch.Text = sotr.Branch;

            }
        }
    }
}
