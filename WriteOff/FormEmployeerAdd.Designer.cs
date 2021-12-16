
namespace WriteOff
{
    partial class FormEmployeerAdd
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
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Patronymic = new System.Windows.Forms.TextBox();
            this.textBox_Position = new System.Windows.Forms.TextBox();
            this.textBox_Branch = new System.Windows.Forms.TextBox();
            this.label_Surname = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Patronymic = new System.Windows.Forms.Label();
            this.label_Position = new System.Windows.Forms.Label();
            this.label_Branch = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(139, 42);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(200, 20);
            this.textBox_Surname.TabIndex = 0;
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Location = new System.Drawing.Point(139, 172);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Date.TabIndex = 1;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(139, 68);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(200, 20);
            this.textBox_Name.TabIndex = 0;
            // 
            // textBox_Patronymic
            // 
            this.textBox_Patronymic.Location = new System.Drawing.Point(139, 94);
            this.textBox_Patronymic.Name = "textBox_Patronymic";
            this.textBox_Patronymic.Size = new System.Drawing.Size(200, 20);
            this.textBox_Patronymic.TabIndex = 0;
            // 
            // textBox_Position
            // 
            this.textBox_Position.Location = new System.Drawing.Point(139, 120);
            this.textBox_Position.Name = "textBox_Position";
            this.textBox_Position.Size = new System.Drawing.Size(200, 20);
            this.textBox_Position.TabIndex = 0;
            // 
            // textBox_Branch
            // 
            this.textBox_Branch.Location = new System.Drawing.Point(139, 146);
            this.textBox_Branch.Name = "textBox_Branch";
            this.textBox_Branch.Size = new System.Drawing.Size(200, 20);
            this.textBox_Branch.TabIndex = 0;
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Location = new System.Drawing.Point(12, 45);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(56, 13);
            this.label_Surname.TabIndex = 2;
            this.label_Surname.Text = "Фамилия";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(12, 71);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(29, 13);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Имя";
            // 
            // label_Patronymic
            // 
            this.label_Patronymic.AutoSize = true;
            this.label_Patronymic.Location = new System.Drawing.Point(12, 97);
            this.label_Patronymic.Name = "label_Patronymic";
            this.label_Patronymic.Size = new System.Drawing.Size(54, 13);
            this.label_Patronymic.TabIndex = 2;
            this.label_Patronymic.Text = "Отчество";
            // 
            // label_Position
            // 
            this.label_Position.AutoSize = true;
            this.label_Position.Location = new System.Drawing.Point(12, 123);
            this.label_Position.Name = "label_Position";
            this.label_Position.Size = new System.Drawing.Size(65, 13);
            this.label_Position.TabIndex = 2;
            this.label_Position.Text = "Должность";
            // 
            // label_Branch
            // 
            this.label_Branch.AutoSize = true;
            this.label_Branch.Location = new System.Drawing.Point(12, 149);
            this.label_Branch.Name = "label_Branch";
            this.label_Branch.Size = new System.Drawing.Size(87, 13);
            this.label_Branch.TabIndex = 2;
            this.label_Branch.Text = "Подразделение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Дата приему на работу";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormEmployeerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 313);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_Branch);
            this.Controls.Add(this.label_Position);
            this.Controls.Add(this.label_Patronymic);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.textBox_Branch);
            this.Controls.Add(this.textBox_Position);
            this.Controls.Add(this.textBox_Patronymic);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Surname);
            this.Name = "FormEmployeerAdd";
            this.Text = "FormEmployeerAdd";
            this.Load += new System.EventHandler(this.FormEmployeerAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Patronymic;
        private System.Windows.Forms.TextBox textBox_Position;
        private System.Windows.Forms.TextBox textBox_Branch;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Patronymic;
        private System.Windows.Forms.Label label_Position;
        private System.Windows.Forms.Label label_Branch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}