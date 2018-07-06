namespace team_work
{
    partial class Form_statistic
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
            this.groupbox3 = new System.Windows.Forms.GroupBox();
            this.userTop = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bookTop = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Statistic = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupbox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTop)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookTop)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Statistic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupbox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(9, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(650, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "借书数据统计";
            // 
            // groupbox3
            // 
            this.groupbox3.Controls.Add(this.userTop);
            this.groupbox3.Location = new System.Drawing.Point(325, 34);
            this.groupbox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupbox3.Name = "groupbox3";
            this.groupbox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupbox3.Size = new System.Drawing.Size(321, 162);
            this.groupbox3.TabIndex = 1;
            this.groupbox3.TabStop = false;
            this.groupbox3.Text = "常借书用户TOP";
            // 
            // userTop
            // 
            this.userTop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTop.Location = new System.Drawing.Point(4, 19);
            this.userTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userTop.Name = "userTop";
            this.userTop.RowTemplate.Height = 27;
            this.userTop.Size = new System.Drawing.Size(312, 138);
            this.userTop.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bookTop);
            this.groupBox2.Location = new System.Drawing.Point(14, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(306, 162);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "常借书TOP";
            // 
            // bookTop
            // 
            this.bookTop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookTop.Location = new System.Drawing.Point(4, 19);
            this.bookTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookTop.Name = "bookTop";
            this.bookTop.RowTemplate.Height = 27;
            this.bookTop.Size = new System.Drawing.Size(297, 138);
            this.bookTop.TabIndex = 0;
            this.bookTop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookTop_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Statistic);
            this.groupBox4.Location = new System.Drawing.Point(9, 245);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(650, 185);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "统计总表";
            // 
            // Statistic
            // 
            this.Statistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Statistic.Location = new System.Drawing.Point(14, 19);
            this.Statistic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Statistic.Name = "Statistic";
            this.Statistic.RowTemplate.Height = 27;
            this.Statistic.Size = new System.Drawing.Size(627, 161);
            this.Statistic.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 444);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_statistic";
            this.Text = "Form_statistic";
            this.groupBox1.ResumeLayout(false);
            this.groupbox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userTop)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookTop)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Statistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupbox3;
        private System.Windows.Forms.DataGridView userTop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView bookTop;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView Statistic;
        private System.Windows.Forms.Button button1;
    }
}