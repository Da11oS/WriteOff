
namespace WriteOff
{
    partial class FormWriteOffAdd
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
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Surname = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_Reason = new System.Windows.Forms.TextBox();
            this.textBox_HardwareCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(9, 84);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(84, 13);
            this.label_Date.TabIndex = 12;
            this.label_Date.Text = "Дата списания";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(9, 55);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(101, 13);
            this.label_Name.TabIndex = 14;
            this.label_Name.Text = "Причина спасания";
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Location = new System.Drawing.Point(9, 29);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(100, 13);
            this.label_Surname.TabIndex = 15;
            this.label_Surname.Text = "Код оборудование";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(207, 78);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDate.TabIndex = 9;
            // 
            // textBox_Reason
            // 
            this.textBox_Reason.Location = new System.Drawing.Point(207, 52);
            this.textBox_Reason.Name = "textBox_Reason";
            this.textBox_Reason.Size = new System.Drawing.Size(200, 20);
            this.textBox_Reason.TabIndex = 7;
            // 
            // textBox_HardwareCode
            // 
            this.textBox_HardwareCode.Location = new System.Drawing.Point(207, 26);
            this.textBox_HardwareCode.Name = "textBox_HardwareCode";
            this.textBox_HardwareCode.Size = new System.Drawing.Size(200, 20);
            this.textBox_HardwareCode.TabIndex = 8;
            // 
            // FormWriteOffAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 215);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.textBox_Reason);
            this.Controls.Add(this.textBox_HardwareCode);
            this.Name = "FormWriteOffAdd";
            this.Text = "FormWriteOffAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.TextBox textBox_Reason;
        private System.Windows.Forms.TextBox textBox_HardwareCode;
    }
}