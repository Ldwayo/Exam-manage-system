namespace team_work
{
    partial class Form_My_Information
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reader_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sex_man = new System.Windows.Forms.RadioButton();
            this.sex_woman = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.birth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.birth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sex_woman);
            this.groupBox1.Controls.Add(this.sex_man);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.reader_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.admin_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "我的信息";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // admin_id
            // 
            this.admin_id.Location = new System.Drawing.Point(145, 38);
            this.admin_id.Name = "admin_id";
            this.admin_id.Size = new System.Drawing.Size(105, 21);
            this.admin_id.TabIndex = 1;
            this.admin_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "读者号：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // reader_id
            // 
            this.reader_id.Location = new System.Drawing.Point(365, 41);
            this.reader_id.Name = "reader_id";
            this.reader_id.Size = new System.Drawing.Size(99, 21);
            this.reader_id.TabIndex = 3;
            this.reader_id.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "用户名：";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(145, 88);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(105, 21);
            this.name.TabIndex = 5;
            this.name.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "性别：";
            // 
            // sex_man
            // 
            this.sex_man.AutoSize = true;
            this.sex_man.Location = new System.Drawing.Point(365, 91);
            this.sex_man.Name = "sex_man";
            this.sex_man.Size = new System.Drawing.Size(35, 16);
            this.sex_man.TabIndex = 7;
            this.sex_man.TabStop = true;
            this.sex_man.Text = "男";
            this.sex_man.UseVisualStyleBackColor = true;
            // 
            // sex_woman
            // 
            this.sex_woman.AutoSize = true;
            this.sex_woman.Location = new System.Drawing.Point(431, 93);
            this.sex_woman.Name = "sex_woman";
            this.sex_woman.Size = new System.Drawing.Size(35, 16);
            this.sex_woman.TabIndex = 8;
            this.sex_woman.TabStop = true;
            this.sex_woman.Text = "女";
            this.sex_woman.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "出生日期：";
            // 
            // birth
            // 
            this.birth.Location = new System.Drawing.Point(145, 133);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(105, 21);
            this.birth.TabIndex = 10;
            this.birth.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "住址：";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(364, 133);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(100, 21);
            this.address.TabIndex = 12;
            this.address.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "手机号：";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(145, 183);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(105, 21);
            this.tel.TabIndex = 14;
            this.tel.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "密码：";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(363, 183);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(101, 21);
            this.password.TabIndex = 16;
            this.password.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "查看";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 28);
            this.button2.TabIndex = 18;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(399, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 28);
            this.button3.TabIndex = 19;
            this.button3.Text = "返回";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_My_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_My_Information";
            this.Text = "My_Information";
            this.Load += new System.EventHandler(this.My_Information_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox admin_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reader_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.RadioButton sex_woman;
        private System.Windows.Forms.RadioButton sex_man;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker birth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}