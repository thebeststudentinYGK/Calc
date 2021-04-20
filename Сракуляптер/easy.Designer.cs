namespace Сракуляптер
{
    partial class easy
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
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.um = new System.Windows.Forms.RadioButton();
            this.del = new System.Windows.Forms.RadioButton();
            this.plus = new System.Windows.Forms.RadioButton();
            this.minus = new System.Windows.Forms.RadioButton();
            this.result_but = new System.Windows.Forms.Button();
            this.redirect = new System.Windows.Forms.Button();
            this.RESULTAT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(12, 73);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 20);
            this.input1.TabIndex = 0;
            this.input1.TextChanged += new System.EventHandler(this.input1_TextChanged);
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(204, 73);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 20);
            this.input2.TabIndex = 1;
            this.input2.TextChanged += new System.EventHandler(this.input2_TextChanged);
            // 
            // um
            // 
            this.um.AutoSize = true;
            this.um.Location = new System.Drawing.Point(140, 39);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(29, 17);
            this.um.TabIndex = 2;
            this.um.TabStop = true;
            this.um.Text = "*";
            this.um.UseVisualStyleBackColor = true;
            this.um.CheckedChanged += new System.EventHandler(this.um_CheckedChanged);
            // 
            // del
            // 
            this.del.AutoSize = true;
            this.del.Location = new System.Drawing.Point(140, 62);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(30, 17);
            this.del.TabIndex = 2;
            this.del.TabStop = true;
            this.del.Text = "\\";
            this.del.UseVisualStyleBackColor = true;
            this.del.CheckedChanged += new System.EventHandler(this.del_CheckedChanged);
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Location = new System.Drawing.Point(140, 85);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(31, 17);
            this.plus.TabIndex = 2;
            this.plus.TabStop = true;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.CheckedChanged += new System.EventHandler(this.plus_CheckedChanged);
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.Location = new System.Drawing.Point(140, 108);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(28, 17);
            this.minus.TabIndex = 2;
            this.minus.TabStop = true;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.CheckedChanged += new System.EventHandler(this.minus_CheckedChanged);
            // 
            // result_but
            // 
            this.result_but.Location = new System.Drawing.Point(110, 212);
            this.result_but.Name = "result_but";
            this.result_but.Size = new System.Drawing.Size(91, 23);
            this.result_but.TabIndex = 4;
            this.result_but.Text = "Считаем";
            this.result_but.UseVisualStyleBackColor = true;
            this.result_but.Click += new System.EventHandler(this.result_but_Click);
            // 
            // redirect
            // 
            this.redirect.Location = new System.Drawing.Point(12, 254);
            this.redirect.Name = "redirect";
            this.redirect.Size = new System.Drawing.Size(292, 23);
            this.redirect.TabIndex = 5;
            this.redirect.Text = "Этот калькулятор недостаточно мощный";
            this.redirect.UseVisualStyleBackColor = true;
            this.redirect.Click += new System.EventHandler(this.redirect_Click);
            // 
            // RESULTAT
            // 
            this.RESULTAT.AutoSize = true;
            this.RESULTAT.Location = new System.Drawing.Point(137, 164);
            this.RESULTAT.Name = "RESULTAT";
            this.RESULTAT.Size = new System.Drawing.Size(0, 13);
            this.RESULTAT.TabIndex = 6;
            this.RESULTAT.Click += new System.EventHandler(this.RESULTAT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ответ";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(110, 293);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(91, 23);
            this.clear.TabIndex = 8;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // easy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(317, 328);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RESULTAT);
            this.Controls.Add(this.redirect);
            this.Controls.Add(this.result_but);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.del);
            this.Controls.Add(this.um);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "easy";
            this.Text = "Calc";
            this.Load += new System.EventHandler(this.easy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.RadioButton um;
        private System.Windows.Forms.RadioButton del;
        private System.Windows.Forms.RadioButton plus;
        private System.Windows.Forms.RadioButton minus;
        private System.Windows.Forms.Button result_but;
        private System.Windows.Forms.Button redirect;
        private System.Windows.Forms.Label RESULTAT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear;
    }
}

