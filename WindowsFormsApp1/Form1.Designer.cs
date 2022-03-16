
namespace WindowsFormsApp1
{
    partial class Calculator
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Calculating = new System.Windows.Forms.Label();
            this.lb_result = new System.Windows.Forms.Label();
            this.roundButton2 = new WindowsFormsApp1.RoundButton();
            this.roundButton16 = new WindowsFormsApp1.RoundButton();
            this.roundButton15 = new WindowsFormsApp1.RoundButton();
            this.roundButton18 = new WindowsFormsApp1.RoundButton();
            this.roundButton6 = new WindowsFormsApp1.RoundButton();
            this.roundButton5 = new WindowsFormsApp1.RoundButton();
            this.roundButton4 = new WindowsFormsApp1.RoundButton();
            this.roundButton12 = new WindowsFormsApp1.RoundButton();
            this.roundButton11 = new WindowsFormsApp1.RoundButton();
            this.roundButton9 = new WindowsFormsApp1.RoundButton();
            this.roundButton13 = new WindowsFormsApp1.RoundButton();
            this.roundButton8 = new WindowsFormsApp1.RoundButton();
            this.roundButton10 = new WindowsFormsApp1.RoundButton();
            this.roundButton14 = new WindowsFormsApp1.RoundButton();
            this.roundButton7 = new WindowsFormsApp1.RoundButton();
            this.roundButton3 = new WindowsFormsApp1.RoundButton();
            this.roundButton1 = new WindowsFormsApp1.RoundButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_Calculating);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 58);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.roundButton16);
            this.panel2.Controls.Add(this.roundButton15);
            this.panel2.Controls.Add(this.roundButton18);
            this.panel2.Controls.Add(this.roundButton6);
            this.panel2.Controls.Add(this.roundButton5);
            this.panel2.Controls.Add(this.roundButton4);
            this.panel2.Controls.Add(this.roundButton12);
            this.panel2.Controls.Add(this.roundButton11);
            this.panel2.Controls.Add(this.roundButton9);
            this.panel2.Controls.Add(this.roundButton13);
            this.panel2.Controls.Add(this.roundButton8);
            this.panel2.Controls.Add(this.roundButton10);
            this.panel2.Controls.Add(this.roundButton14);
            this.panel2.Controls.Add(this.roundButton7);
            this.panel2.Controls.Add(this.roundButton3);
            this.panel2.Controls.Add(this.roundButton1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 508);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.lb_result);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.roundButton2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(434, 74);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(434, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Calculating";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // lb_Calculating
            // 
            this.lb_Calculating.ForeColor = System.Drawing.Color.White;
            this.lb_Calculating.Location = new System.Drawing.Point(128, 0);
            this.lb_Calculating.Name = "lb_Calculating";
            this.lb_Calculating.Size = new System.Drawing.Size(301, 54);
            this.lb_Calculating.TabIndex = 6;
            this.lb_Calculating.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_result
            // 
            this.lb_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_result.ForeColor = System.Drawing.Color.White;
            this.lb_result.Location = new System.Drawing.Point(137, 0);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(293, 71);
            this.lb_result.TabIndex = 6;
            this.lb_result.Text = "0";
            this.lb_result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_result.Click += new System.EventHandler(this.label4_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.Location = new System.Drawing.Point(348, 360);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(74, 69);
            this.roundButton2.TabIndex = 4;
            this.roundButton2.Text = "roundButton1";
            this.roundButton2.UseVisualStyleBackColor = true;
            // 
            // roundButton16
            // 
            this.roundButton16.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.roundButton16.FlatAppearance.BorderSize = 0;
            this.roundButton16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton16.ForeColor = System.Drawing.Color.White;
            this.roundButton16.Location = new System.Drawing.Point(363, 366);
            this.roundButton16.Name = "roundButton16";
            this.roundButton16.Size = new System.Drawing.Size(50, 50);
            this.roundButton16.TabIndex = 7;
            this.roundButton16.Text = "/";
            this.roundButton16.UseVisualStyleBackColor = false;
            this.roundButton16.Click += new System.EventHandler(this.pro_click);
            // 
            // roundButton15
            // 
            this.roundButton15.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.roundButton15.FlatAppearance.BorderSize = 0;
            this.roundButton15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton15.ForeColor = System.Drawing.Color.White;
            this.roundButton15.Location = new System.Drawing.Point(363, 80);
            this.roundButton15.Name = "roundButton15";
            this.roundButton15.Size = new System.Drawing.Size(50, 50);
            this.roundButton15.TabIndex = 6;
            this.roundButton15.Text = "-";
            this.roundButton15.UseVisualStyleBackColor = false;
            this.roundButton15.Click += new System.EventHandler(this.pro_click);
            // 
            // roundButton18
            // 
            this.roundButton18.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.roundButton18.FlatAppearance.BorderSize = 0;
            this.roundButton18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton18.ForeColor = System.Drawing.Color.White;
            this.roundButton18.Location = new System.Drawing.Point(32, 379);
            this.roundButton18.Name = "roundButton18";
            this.roundButton18.Size = new System.Drawing.Size(50, 50);
            this.roundButton18.TabIndex = 5;
            this.roundButton18.Text = "*";
            this.roundButton18.UseVisualStyleBackColor = false;
            this.roundButton18.Click += new System.EventHandler(this.pro_click);
            // 
            // roundButton6
            // 
            this.roundButton6.BackColor = System.Drawing.Color.Purple;
            this.roundButton6.FlatAppearance.BorderSize = 0;
            this.roundButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton6.ForeColor = System.Drawing.Color.White;
            this.roundButton6.Location = new System.Drawing.Point(311, 292);
            this.roundButton6.Name = "roundButton6";
            this.roundButton6.Size = new System.Drawing.Size(50, 50);
            this.roundButton6.TabIndex = 4;
            this.roundButton6.Text = "9";
            this.roundButton6.UseVisualStyleBackColor = false;
            this.roundButton6.Click += new System.EventHandler(this.btn_click);
            // 
            // roundButton5
            // 
            this.roundButton5.BackColor = System.Drawing.Color.Purple;
            this.roundButton5.FlatAppearance.BorderSize = 0;
            this.roundButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton5.ForeColor = System.Drawing.Color.White;
            this.roundButton5.Location = new System.Drawing.Point(325, 220);
            this.roundButton5.Name = "roundButton5";
            this.roundButton5.Size = new System.Drawing.Size(50, 50);
            this.roundButton5.TabIndex = 4;
            this.roundButton5.Text = ".";
            this.roundButton5.UseVisualStyleBackColor = false;
            this.roundButton5.Click += new System.EventHandler(this.btn_click);
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.Color.Purple;
            this.roundButton4.FlatAppearance.BorderSize = 0;
            this.roundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton4.ForeColor = System.Drawing.Color.White;
            this.roundButton4.Location = new System.Drawing.Point(311, 147);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(50, 50);
            this.roundButton4.TabIndex = 4;
            this.roundButton4.Text = "0";
            this.roundButton4.UseVisualStyleBackColor = false;
            this.roundButton4.Click += new System.EventHandler(this.btn_click);
            // 
            // roundButton12
            // 
            this.roundButton12.BackColor = System.Drawing.Color.Purple;
            this.roundButton12.FlatAppearance.BorderSize = 0;
            this.roundButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton12.ForeColor = System.Drawing.Color.White;
            this.roundButton12.Location = new System.Drawing.Point(79, 304);
            this.roundButton12.Name = "roundButton12";
            this.roundButton12.Size = new System.Drawing.Size(50, 50);
            this.roundButton12.TabIndex = 4;
            this.roundButton12.Text = "6";
            this.roundButton12.UseVisualStyleBackColor = false;
            this.roundButton12.Click += new System.EventHandler(this.btn_click);
            // 
            // roundButton11
            // 
            this.roundButton11.BackColor = System.Drawing.Color.Purple;
            this.roundButton11.FlatAppearance.BorderSize = 0;
            this.roundButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton11.ForeColor = System.Drawing.Color.White;
            this.roundButton11.Location = new System.Drawing.Point(153, 330);
            this.roundButton11.Name = "roundButton11";
            this.roundButton11.Size = new System.Drawing.Size(50, 50);
            this.roundButton11.TabIndex = 4;
            this.roundButton11.Text = "7";
            this.roundButton11.UseVisualStyleBackColor = false;
            this.roundButton11.Click += new System.EventHandler(this.btn_click);
            // 
            // roundButton9
            // 
            this.roundButton9.BackColor = System.Drawing.Color.Purple;
            this.roundButton9.FlatAppearance.BorderSize = 0;
            this.roundButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton9.ForeColor = System.Drawing.Color.White;
            this.roundButton9.Location = new System.Drawing.Point(68, 162);
            this.roundButton9.Name = "roundButton9";
            this.roundButton9.Size = new System.Drawing.Size(50, 50);
            this.roundButton9.TabIndex = 4;
            this.roundButton9.Text = "4";
            this.roundButton9.UseVisualStyleBackColor = false;
            this.roundButton9.Click += new System.EventHandler(this.btn_click);
            // 
            // roundButton13
            // 
            this.roundButton13.BackColor = System.Drawing.Color.Purple;
            this.roundButton13.FlatAppearance.BorderSize = 0;
            this.roundButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton13.ForeColor = System.Drawing.Color.White;
            this.roundButton13.Location = new System.Drawing.Point(59, 233);
            this.roundButton13.Name = "roundButton13";
            this.roundButton13.Size = new System.Drawing.Size(50, 50);
            this.roundButton13.TabIndex = 4;
            this.roundButton13.Text = "5";
            this.roundButton13.UseVisualStyleBackColor = false;
            this.roundButton13.Click += new System.EventHandler(this.btn_click);
            // 
            // roundButton8
            // 
            this.roundButton8.BackColor = System.Drawing.Color.Purple;
            this.roundButton8.FlatAppearance.BorderSize = 0;
            this.roundButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton8.ForeColor = System.Drawing.Color.White;
            this.roundButton8.Location = new System.Drawing.Point(121, 106);
            this.roundButton8.Name = "roundButton8";
            this.roundButton8.Size = new System.Drawing.Size(50, 50);
            this.roundButton8.TabIndex = 4;
            this.roundButton8.Text = "3";
            this.roundButton8.UseVisualStyleBackColor = false;
            this.roundButton8.Click += new System.EventHandler(this.btn_click);
            // 
            // roundButton10
            // 
            this.roundButton10.BackColor = System.Drawing.Color.Purple;
            this.roundButton10.FlatAppearance.BorderSize = 0;
            this.roundButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton10.ForeColor = System.Drawing.Color.White;
            this.roundButton10.Location = new System.Drawing.Point(243, 330);
            this.roundButton10.Name = "roundButton10";
            this.roundButton10.Size = new System.Drawing.Size(50, 50);
            this.roundButton10.TabIndex = 4;
            this.roundButton10.Text = "8";
            this.roundButton10.UseVisualStyleBackColor = false;
            this.roundButton10.Click += new System.EventHandler(this.btn_click);
            // 
            // roundButton14
            // 
            this.roundButton14.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.roundButton14.FlatAppearance.BorderSize = 0;
            this.roundButton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton14.ForeColor = System.Drawing.Color.White;
            this.roundButton14.Location = new System.Drawing.Point(32, 80);
            this.roundButton14.Name = "roundButton14";
            this.roundButton14.Size = new System.Drawing.Size(50, 50);
            this.roundButton14.TabIndex = 4;
            this.roundButton14.Text = "+";
            this.roundButton14.UseVisualStyleBackColor = false;
            this.roundButton14.Click += new System.EventHandler(this.pro_click);
            // 
            // roundButton7
            // 
            this.roundButton7.BackColor = System.Drawing.Color.Purple;
            this.roundButton7.FlatAppearance.BorderSize = 0;
            this.roundButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton7.ForeColor = System.Drawing.Color.White;
            this.roundButton7.Location = new System.Drawing.Point(193, 80);
            this.roundButton7.Name = "roundButton7";
            this.roundButton7.Size = new System.Drawing.Size(50, 50);
            this.roundButton7.TabIndex = 4;
            this.roundButton7.Text = "2";
            this.roundButton7.UseVisualStyleBackColor = false;
            this.roundButton7.Click += new System.EventHandler(this.btn_click);
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.Purple;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton3.ForeColor = System.Drawing.Color.White;
            this.roundButton3.Location = new System.Drawing.Point(261, 92);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(50, 50);
            this.roundButton3.TabIndex = 4;
            this.roundButton3.Text = "1";
            this.roundButton3.UseVisualStyleBackColor = false;
            this.roundButton3.Click += new System.EventHandler(this.btn_click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Maroon;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(153, 162);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(140, 140);
            this.roundButton1.TabIndex = 4;
            this.roundButton1.Text = "C";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 566);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Calculator";
            this.ShowInTaskbar = false;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_Calculating;
        private System.Windows.Forms.Label label1;
        private RoundButton roundButton6;
        private RoundButton roundButton5;
        private RoundButton roundButton4;
        private RoundButton roundButton12;
        private RoundButton roundButton11;
        private RoundButton roundButton9;
        private RoundButton roundButton13;
        private RoundButton roundButton8;
        private RoundButton roundButton10;
        private RoundButton roundButton7;
        private RoundButton roundButton3;
        private RoundButton roundButton1;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.Label label2;
        private RoundButton roundButton2;
        private RoundButton roundButton14;
        private RoundButton roundButton16;
        private RoundButton roundButton15;
        private RoundButton roundButton18;
    }
}

