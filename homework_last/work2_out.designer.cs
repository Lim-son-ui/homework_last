
namespace homework
{
    partial class work2out
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
            System.Windows.Forms.Label loan_amount;
            System.Windows.Forms.Label year;
            System.Windows.Forms.Label rate;
            System.Windows.Forms.Label month_pay;
            System.Windows.Forms.Label year_pay;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(work2out));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            loan_amount = new System.Windows.Forms.Label();
            year = new System.Windows.Forms.Label();
            rate = new System.Windows.Forms.Label();
            month_pay = new System.Windows.Forms.Label();
            year_pay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loan_amount
            // 
            loan_amount.AutoSize = true;
            loan_amount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            loan_amount.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            loan_amount.Location = new System.Drawing.Point(240, 56);
            loan_amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            loan_amount.Name = "loan_amount";
            loan_amount.Size = new System.Drawing.Size(120, 27);
            loan_amount.TabIndex = 0;
            loan_amount.Text = "貸款金額";
            loan_amount.Click += new System.EventHandler(this.label1_Click);
            // 
            // year
            // 
            year.AutoSize = true;
            year.BackColor = System.Drawing.SystemColors.ActiveCaption;
            year.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            year.Location = new System.Drawing.Point(240, 161);
            year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            year.Name = "year";
            year.Size = new System.Drawing.Size(66, 27);
            year.TabIndex = 0;
            year.Text = "期限";
            year.Click += new System.EventHandler(this.label2_Click);
            // 
            // rate
            // 
            rate.AutoSize = true;
            rate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            rate.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            rate.Location = new System.Drawing.Point(240, 262);
            rate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rate.Name = "rate";
            rate.Size = new System.Drawing.Size(66, 27);
            rate.TabIndex = 0;
            rate.Text = "利率";
            rate.Click += new System.EventHandler(this.label3_Click);
            // 
            // month_pay
            // 
            month_pay.AutoSize = true;
            month_pay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            month_pay.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            month_pay.Location = new System.Drawing.Point(240, 351);
            month_pay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            month_pay.Name = "month_pay";
            month_pay.Size = new System.Drawing.Size(93, 27);
            month_pay.TabIndex = 0;
            month_pay.Text = "月付款";
            month_pay.Click += new System.EventHandler(this.label4_Click);
            // 
            // year_pay
            // 
            year_pay.AutoSize = true;
            year_pay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            year_pay.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            year_pay.Location = new System.Drawing.Point(240, 432);
            year_pay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            year_pay.Name = "year_pay";
            year_pay.Size = new System.Drawing.Size(93, 27);
            year_pay.TabIndex = 0;
            year_pay.Text = "年付款";
            year_pay.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(761, 429);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "Email";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(432, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "   ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(432, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(432, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "   ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(432, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "   ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(432, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "   ";
            // 
            // work2out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(year_pay);
            this.Controls.Add(month_pay);
            this.Controls.Add(rate);
            this.Controls.Add(year);
            this.Controls.Add(loan_amount);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "work2out";
            this.Text = "work15out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
    }
}