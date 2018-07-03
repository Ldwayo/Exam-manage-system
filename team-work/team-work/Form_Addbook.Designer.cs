namespace team_work
{
    partial class Form_Addbook
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.book_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.publish = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.class_id = new System.Windows.Forms.TextBox();
            this.pubdate = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.introduction = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书编号：";
            // 
            // book_id
            // 
            this.book_id.Location = new System.Drawing.Point(179, 52);
            this.book_id.Name = "book_id";
            this.book_id.Size = new System.Drawing.Size(157, 25);
            this.book_id.TabIndex = 1;
            this.book_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "作者：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "出版社：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "简介：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "价格：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "出版日期：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "类别编号：";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(179, 94);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(157, 25);
            this.name.TabIndex = 1;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(179, 134);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(157, 25);
            this.author.TabIndex = 1;
            // 
            // publish
            // 
            this.publish.Location = new System.Drawing.Point(179, 177);
            this.publish.Name = "publish";
            this.publish.Size = new System.Drawing.Size(157, 25);
            this.publish.TabIndex = 1;
            this.publish.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(179, 337);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(157, 25);
            this.price.TabIndex = 1;
            // 
            // class_id
            // 
            this.class_id.Location = new System.Drawing.Point(179, 427);
            this.class_id.Name = "class_id";
            this.class_id.Size = new System.Drawing.Size(157, 25);
            this.class_id.TabIndex = 1;
            // 
            // pubdate
            // 
            this.pubdate.Location = new System.Drawing.Point(179, 384);
            this.pubdate.Name = "pubdate";
            this.pubdate.Size = new System.Drawing.Size(200, 25);
            this.pubdate.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // introduction
            // 
            this.introduction.Location = new System.Drawing.Point(179, 221);
            this.introduction.Name = "introduction";
            this.introduction.Size = new System.Drawing.Size(325, 94);
            this.introduction.TabIndex = 4;
            this.introduction.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "确认添加";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form_Addbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 565);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.introduction);
            this.Controls.Add(this.pubdate);
            this.Controls.Add(this.class_id);
            this.Controls.Add(this.price);
            this.Controls.Add(this.publish);
            this.Controls.Add(this.author);
            this.Controls.Add(this.name);
            this.Controls.Add(this.book_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Addbook";
            this.Text = "Form_Addbook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox book_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox publish;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox class_id;
        private System.Windows.Forms.DateTimePicker pubdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox introduction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}