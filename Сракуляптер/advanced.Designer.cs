namespace Сракуляптер
{
    partial class advanced
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
            this.input2 = new System.Windows.Forms.TextBox();
            this.input1 = new System.Windows.Forms.TextBox();
            this.RESULTAT = new System.Windows.Forms.Label();
            this.result_but = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.RadioButton();
            this.plus = new System.Windows.Forms.RadioButton();
            this.del = new System.Windows.Forms.RadioButton();
            this.um = new System.Windows.Forms.RadioButton();
            this.pow2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sqrt = new System.Windows.Forms.RadioButton();
            this.sin = new System.Windows.Forms.RadioButton();
            this.cos = new System.Windows.Forms.RadioButton();
            this.tg = new System.Windows.Forms.RadioButton();
            this.input_dop = new System.Windows.Forms.TextBox();
            this.redirect = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(205, 29);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 20);
            this.input2.TabIndex = 3;
            this.input2.TextChanged += new System.EventHandler(this.input2_TextChanged);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(13, 29);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 20);
            this.input1.TabIndex = 2;
            this.input1.TextChanged += new System.EventHandler(this.input1_TextChanged);
            // 
            // RESULTAT
            // 
            this.RESULTAT.AutoSize = true;
            this.RESULTAT.Location = new System.Drawing.Point(127, 283);
            this.RESULTAT.Name = "RESULTAT";
            this.RESULTAT.Size = new System.Drawing.Size(0, 13);
            this.RESULTAT.TabIndex = 12;
            this.RESULTAT.Click += new System.EventHandler(this.RESULTAT_Click);
            // 
            // result_but
            // 
            this.result_but.Location = new System.Drawing.Point(110, 321);
            this.result_but.Name = "result_but";
            this.result_but.Size = new System.Drawing.Size(91, 23);
            this.result_but.TabIndex = 11;
            this.result_but.Text = "Считаем";
            this.result_but.UseVisualStyleBackColor = true;
            this.result_but.Click += new System.EventHandler(this.result_but_Click);
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.Location = new System.Drawing.Point(140, 81);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(28, 17);
            this.minus.TabIndex = 7;
            this.minus.TabStop = true;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.CheckedChanged += new System.EventHandler(this.minus_CheckedChanged);
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Location = new System.Drawing.Point(140, 58);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(31, 17);
            this.plus.TabIndex = 8;
            this.plus.TabStop = true;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.CheckedChanged += new System.EventHandler(this.plus_CheckedChanged);
            // 
            // del
            // 
            this.del.AutoSize = true;
            this.del.Location = new System.Drawing.Point(140, 35);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(30, 17);
            this.del.TabIndex = 9;
            this.del.TabStop = true;
            this.del.Text = "\\";
            this.del.UseVisualStyleBackColor = true;
            this.del.CheckedChanged += new System.EventHandler(this.del_CheckedChanged);
            // 
            // um
            // 
            this.um.AutoSize = true;
            this.um.Location = new System.Drawing.Point(140, 12);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(29, 17);
            this.um.TabIndex = 10;
            this.um.TabStop = true;
            this.um.Text = "*";
            this.um.UseVisualStyleBackColor = true;
            this.um.CheckedChanged += new System.EventHandler(this.um_CheckedChanged);
            // 
            // pow2
            // 
            this.pow2.AutoSize = true;
            this.pow2.Location = new System.Drawing.Point(176, 117);
            this.pow2.Name = "pow2";
            this.pow2.Size = new System.Drawing.Size(37, 17);
            this.pow2.TabIndex = 7;
            this.pow2.TabStop = true;
            this.pow2.Text = "^2";
            this.pow2.UseVisualStyleBackColor = true;
            this.pow2.CheckedChanged += new System.EventHandler(this.pow2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Дополнительные функции:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ответ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sqrt
            // 
            this.sqrt.AutoSize = true;
            this.sqrt.Location = new System.Drawing.Point(176, 140);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(42, 17);
            this.sqrt.TabIndex = 7;
            this.sqrt.TabStop = true;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.CheckedChanged += new System.EventHandler(this.sqrt_CheckedChanged);
            // 
            // sin
            // 
            this.sin.AutoSize = true;
            this.sin.Location = new System.Drawing.Point(176, 163);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(38, 17);
            this.sin.TabIndex = 7;
            this.sin.TabStop = true;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.CheckedChanged += new System.EventHandler(this.sin_CheckedChanged);
            // 
            // cos
            // 
            this.cos.AutoSize = true;
            this.cos.Location = new System.Drawing.Point(176, 186);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(42, 17);
            this.cos.TabIndex = 7;
            this.cos.TabStop = true;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.CheckedChanged += new System.EventHandler(this.cos_CheckedChanged);
            // 
            // tg
            // 
            this.tg.AutoSize = true;
            this.tg.Location = new System.Drawing.Point(176, 209);
            this.tg.Name = "tg";
            this.tg.Size = new System.Drawing.Size(34, 17);
            this.tg.TabIndex = 7;
            this.tg.TabStop = true;
            this.tg.Text = "tg";
            this.tg.UseVisualStyleBackColor = true;
            this.tg.CheckedChanged += new System.EventHandler(this.tg_CheckedChanged);
            // 
            // input_dop
            // 
            this.input_dop.Location = new System.Drawing.Point(42, 162);
            this.input_dop.Name = "input_dop";
            this.input_dop.Size = new System.Drawing.Size(100, 20);
            this.input_dop.TabIndex = 15;
            this.input_dop.TextChanged += new System.EventHandler(this.input_dop_TextChanged);
            // 
            // redirect
            // 
            this.redirect.Location = new System.Drawing.Point(12, 360);
            this.redirect.Name = "redirect";
            this.redirect.Size = new System.Drawing.Size(292, 23);
            this.redirect.TabIndex = 16;
            this.redirect.Text = "Этот калькулятор недостаточно мощный";
            this.redirect.UseVisualStyleBackColor = true;
            this.redirect.Click += new System.EventHandler(this.redirect_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(110, 403);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(91, 23);
            this.clear.TabIndex = 17;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // advanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(317, 438);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.redirect);
            this.Controls.Add(this.input_dop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RESULTAT);
            this.Controls.Add(this.result_but);
            this.Controls.Add(this.tg);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.pow2);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.del);
            this.Controls.Add(this.um);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "advanced";
            this.Text = "Advanced calc";
            this.Load += new System.EventHandler(this.advanced_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.Label RESULTAT;
        private System.Windows.Forms.Button result_but;
        private System.Windows.Forms.RadioButton minus;
        private System.Windows.Forms.RadioButton plus;
        private System.Windows.Forms.RadioButton del;
        private System.Windows.Forms.RadioButton um;
        private System.Windows.Forms.RadioButton pow2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton sqrt;
        private System.Windows.Forms.RadioButton sin;
        private System.Windows.Forms.RadioButton cos;
        private System.Windows.Forms.RadioButton tg;
        private System.Windows.Forms.TextBox input_dop;
        private System.Windows.Forms.Button redirect;
        private System.Windows.Forms.Button clear;
    }
}