
namespace WriteOff
{
    partial class FormHardwareAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Branch = new System.Windows.Forms.Label();
            this.label_Position = new System.Windows.Forms.Label();
            this.label_Patronymic = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Surname = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.textBox_Place = new System.Windows.Forms.TextBox();
            this.textBox_FIO = new System.Windows.Forms.TextBox();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Branch
            // 
            this.label_Branch.AutoSize = true;
            this.label_Branch.Location = new System.Drawing.Point(18, 138);
            this.label_Branch.Name = "label_Branch";
            this.label_Branch.Size = new System.Drawing.Size(94, 13);
            this.label_Branch.TabIndex = 11;
            this.label_Branch.Text = "Место установки";
            // 
            // label_Position
            // 
            this.label_Position.AutoSize = true;
            this.label_Position.Location = new System.Drawing.Point(12, 112);
            this.label_Position.Name = "label_Position";
            this.label_Position.Size = new System.Drawing.Size(117, 13);
            this.label_Position.TabIndex = 12;
            this.label_Position.Text = "ФИО ответственного";
            // 
            // label_Patronymic
            // 
            this.label_Patronymic.AutoSize = true;
            this.label_Patronymic.Location = new System.Drawing.Point(12, 86);
            this.label_Patronymic.Name = "label_Patronymic";
            this.label_Patronymic.Size = new System.Drawing.Size(100, 13);
            this.label_Patronymic.TabIndex = 13;
            this.label_Patronymic.Text = "Дата поступления";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(12, 60);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(100, 13);
            this.label_Name.TabIndex = 14;
            this.label_Name.Text = "Тип оборудования";
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Location = new System.Drawing.Point(12, 34);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(131, 13);
            this.label_Surname.TabIndex = 15;
            this.label_Surname.Text = "Название оборудования";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Location = new System.Drawing.Point(151, 86);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Date.TabIndex = 9;
            // 
            // textBox_Place
            // 
            this.textBox_Place.Location = new System.Drawing.Point(151, 135);
            this.textBox_Place.Name = "textBox_Place";
            this.textBox_Place.Size = new System.Drawing.Size(200, 20);
            this.textBox_Place.TabIndex = 4;
            // 
            // textBox_FIO
            // 
            this.textBox_FIO.Location = new System.Drawing.Point(151, 109);
            this.textBox_FIO.Name = "textBox_FIO";
            this.textBox_FIO.Size = new System.Drawing.Size(200, 20);
            this.textBox_FIO.TabIndex = 5;
            // 
            // textBox_Type
            // 
            this.textBox_Type.Location = new System.Drawing.Point(151, 57);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(200, 20);
            this.textBox_Type.TabIndex = 7;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(151, 31);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(200, 20);
            this.textBox_Name.TabIndex = 8;
            // 
            // FormHardwareAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 320);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Branch);
            this.Controls.Add(this.label_Position);
            this.Controls.Add(this.label_Patronymic);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.textBox_Place);
            this.Controls.Add(this.textBox_FIO);
            this.Controls.Add(this.textBox_Type);
            this.Controls.Add(this.textBox_Name);
            this.Name = "FormHardwareAdd";
            this.Text = "FormHardwareAdd";
            this.Load += new System.EventHandler(this.FormEmployeerAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Branch;
        private System.Windows.Forms.Label label_Position;
        private System.Windows.Forms.Label label_Patronymic;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.TextBox textBox_Place;
        private System.Windows.Forms.TextBox textBox_FIO;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.TextBox textBox_Name;
    }
}