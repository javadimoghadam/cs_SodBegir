namespace SodBegir_App
{
    partial class Form1
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
            this.Profit_importer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ALi = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.Years = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Profit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.seporde = new System.Windows.Forms.TextBox();
            this.Sepordeh = new System.Windows.Forms.Label();
            this.Warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Profit_importer
            // 
            this.Profit_importer.Font = new System.Drawing.Font("IRANSans", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Profit_importer.ForeColor = System.Drawing.Color.SeaGreen;
            this.Profit_importer.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.Profit_importer.Location = new System.Drawing.Point(23, 121);
            this.Profit_importer.Margin = new System.Windows.Forms.Padding(2);
            this.Profit_importer.Multiline = true;
            this.Profit_importer.Name = "Profit_importer";
            this.Profit_importer.Size = new System.Drawing.Size(274, 31);
            this.Profit_importer.TabIndex = 0;
            this.Profit_importer.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(656, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "سود بگیر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(489, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "نرم افزار نشان دهنده میزان سود بانکی\r\n";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // ALi
            // 
            this.ALi.ActiveLinkColor = System.Drawing.Color.Firebrick;
            this.ALi.AutoSize = true;
            this.ALi.Font = new System.Drawing.Font("IRANSans", 13F);
            this.ALi.LinkColor = System.Drawing.Color.Peru;
            this.ALi.Location = new System.Drawing.Point(9, 7);
            this.ALi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ALi.Name = "ALi";
            this.ALi.Size = new System.Drawing.Size(172, 28);
            this.ALi.TabIndex = 4;
            this.ALi.TabStop = true;
            this.ALi.Text = "Coded By Ali Javadi";
            this.ALi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ALi_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSans", 9F);
            this.label3.Location = new System.Drawing.Point(166, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "میزان سرمایه اولیه (ریال)";
            // 
            // Years
            // 
            this.Years.AutoSize = true;
            this.Years.Font = new System.Drawing.Font("IRANSans", 9F);
            this.Years.Location = new System.Drawing.Point(491, 36);
            this.Years.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Years.Name = "Years";
            this.Years.Size = new System.Drawing.Size(0, 19);
            this.Years.TabIndex = 6;
            this.Years.Click += new System.EventHandler(this.Years_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("IRANSans", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(550, 120);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "سودم چقدره ؟";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Profit
            // 
            this.Profit.Font = new System.Drawing.Font("IRANSans", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Profit.ForeColor = System.Drawing.Color.SeaGreen;
            this.Profit.Location = new System.Drawing.Point(321, 122);
            this.Profit.Margin = new System.Windows.Forms.Padding(2);
            this.Profit.Multiline = true;
            this.Profit.Name = "Profit";
            this.Profit.Size = new System.Drawing.Size(53, 30);
            this.Profit.TabIndex = 7;
            this.Profit.TextChanged += new System.EventHandler(this.Profit_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRANSans", 9F);
            this.label4.Location = new System.Drawing.Point(320, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "درصد سود";
            // 
            // seporde
            // 
            this.seporde.Font = new System.Drawing.Font("IRANSans", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.seporde.ForeColor = System.Drawing.Color.SeaGreen;
            this.seporde.Location = new System.Drawing.Point(392, 122);
            this.seporde.Margin = new System.Windows.Forms.Padding(2);
            this.seporde.Multiline = true;
            this.seporde.Name = "seporde";
            this.seporde.Size = new System.Drawing.Size(151, 30);
            this.seporde.TabIndex = 9;
            // 
            // Sepordeh
            // 
            this.Sepordeh.AutoSize = true;
            this.Sepordeh.Font = new System.Drawing.Font("IRANSans", 9F);
            this.Sepordeh.Location = new System.Drawing.Point(388, 100);
            this.Sepordeh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sepordeh.Name = "Sepordeh";
            this.Sepordeh.Size = new System.Drawing.Size(155, 19);
            this.Sepordeh.TabIndex = 10;
            this.Sepordeh.Text = "میزان زمان سپرده گذاری (روز)";
            this.Sepordeh.Click += new System.EventHandler(this.Sepordeh_Click);
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Font = new System.Drawing.Font("IRANSans", 10F);
            this.Warning.ForeColor = System.Drawing.Color.Red;
            this.Warning.Location = new System.Drawing.Point(667, 127);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(0, 22);
            this.Warning.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 171);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.Sepordeh);
            this.Controls.Add(this.seporde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Profit);
            this.Controls.Add(this.Years);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ALi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Profit_importer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "SodBegir / Coded By Ali Javadi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Profit_importer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel ALi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Years;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Profit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox seporde;
        private System.Windows.Forms.Label Sepordeh;
        private System.Windows.Forms.Label Warning;
    }
}

