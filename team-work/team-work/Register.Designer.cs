namespace team_work
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.makesure_password = new System.Windows.Forms.TextBox();
            this.sex_man = new System.Windows.Forms.RadioButton();
            this.sex_woman = new System.Windows.Forms.RadioButton();
            this.birth = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.reader_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(255, 72);
            this.name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name.MaxLength = 15;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(157, 25);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "出生日期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 308);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "确认密码：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(255, 265);
            this.password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password.MaxLength = 15;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(157, 25);
            this.password.TabIndex = 6;
            this.password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // makesure_password
            // 
            this.makesure_password.Location = new System.Drawing.Point(255, 308);
            this.makesure_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.makesure_password.MaxLength = 15;
            this.makesure_password.Name = "makesure_password";
            this.makesure_password.PasswordChar = '*';
            this.makesure_password.Size = new System.Drawing.Size(157, 25);
            this.makesure_password.TabIndex = 7;
            this.makesure_password.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // sex_man
            // 
            this.sex_man.AutoSize = true;
            this.sex_man.Location = new System.Drawing.Point(255, 112);
            this.sex_man.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sex_man.Name = "sex_man";
            this.sex_man.Size = new System.Drawing.Size(43, 19);
            this.sex_man.TabIndex = 8;
            this.sex_man.TabStop = true;
            this.sex_man.Text = "男";
            this.sex_man.UseVisualStyleBackColor = true;
            this.sex_man.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // sex_woman
            // 
            this.sex_woman.AutoSize = true;
            this.sex_woman.Location = new System.Drawing.Point(344, 112);
            this.sex_woman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sex_woman.Name = "sex_woman";
            this.sex_woman.Size = new System.Drawing.Size(43, 19);
            this.sex_woman.TabIndex = 9;
            this.sex_woman.TabStop = true;
            this.sex_woman.Text = "女";
            this.sex_woman.UseVisualStyleBackColor = true;
            this.sex_woman.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // birth
            // 
            this.birth.Location = new System.Drawing.Point(255, 144);
            this.birth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(157, 25);
            this.birth.TabIndex = 10;
            this.birth.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 358);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 358);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "账号：";
            // 
            // reader_id
            // 
            this.reader_id.Location = new System.Drawing.Point(255, 29);
            this.reader_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reader_id.MaxLength = 15;
            this.reader_id.Name = "reader_id";
            this.reader_id.Size = new System.Drawing.Size(157, 25);
            this.reader_id.TabIndex = 14;
            this.reader_id.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "住址：";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(255, 185);
            this.address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(157, 25);
            this.address.TabIndex = 16;
            this.address.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "手机号：";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(255, 222);
            this.tel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tel.MaxLength = 11;
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(155, 25);
            this.tel.TabIndex = 18;
            this.tel.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(432, 358);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 29);
            this.button3.TabIndex = 19;
            this.button3.Text = "返回";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 445);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reader_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.sex_woman);
            this.Controls.Add(this.sex_man);
            this.Controls.Add(this.makesure_password);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Register";
            this.Text = "用户注册";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox makesure_password;
        private System.Windows.Forms.RadioButton sex_man;
        private System.Windows.Forms.RadioButton sex_woman;
        private System.Windows.Forms.DateTimePicker birth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reader_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Button button3;
    }
}