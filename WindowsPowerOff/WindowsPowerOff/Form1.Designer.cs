namespace WindowsPowerOff
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_start = new System.Windows.Forms.Button();
            this.radioButton_60 = new System.Windows.Forms.RadioButton();
            this.radioButton_120 = new System.Windows.Forms.RadioButton();
            this.radioButton_180 = new System.Windows.Forms.RadioButton();
            this.radioButton_free = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nUP_free = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUP_free)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 103);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(100, 32);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // radioButton_60
            // 
            this.radioButton_60.AutoSize = true;
            this.radioButton_60.Checked = true;
            this.radioButton_60.Location = new System.Drawing.Point(25, 58);
            this.radioButton_60.Name = "radioButton_60";
            this.radioButton_60.Size = new System.Drawing.Size(14, 13);
            this.radioButton_60.TabIndex = 2;
            this.radioButton_60.TabStop = true;
            this.radioButton_60.UseVisualStyleBackColor = true;
            // 
            // radioButton_120
            // 
            this.radioButton_120.AutoSize = true;
            this.radioButton_120.Location = new System.Drawing.Point(100, 58);
            this.radioButton_120.Name = "radioButton_120";
            this.radioButton_120.Size = new System.Drawing.Size(14, 13);
            this.radioButton_120.TabIndex = 3;
            this.radioButton_120.UseVisualStyleBackColor = true;
            // 
            // radioButton_180
            // 
            this.radioButton_180.AutoSize = true;
            this.radioButton_180.Location = new System.Drawing.Point(175, 58);
            this.radioButton_180.Name = "radioButton_180";
            this.radioButton_180.Size = new System.Drawing.Size(14, 13);
            this.radioButton_180.TabIndex = 4;
            this.radioButton_180.UseVisualStyleBackColor = true;
            // 
            // radioButton_free
            // 
            this.radioButton_free.AutoSize = true;
            this.radioButton_free.Location = new System.Drawing.Point(250, 58);
            this.radioButton_free.Name = "radioButton_free";
            this.radioButton_free.Size = new System.Drawing.Size(14, 13);
            this.radioButton_free.TabIndex = 5;
            this.radioButton_free.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "60";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "120";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "180";
            // 
            // nUP_free
            // 
            this.nUP_free.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUP_free.Location = new System.Drawing.Point(270, 51);
            this.nUP_free.Maximum = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.nUP_free.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUP_free.Name = "nUP_free";
            this.nUP_free.Size = new System.Drawing.Size(58, 29);
            this.nUP_free.TabIndex = 9;
            this.nUP_free.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUP_free.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(0, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(366, 2);
            this.label8.TabIndex = 14;
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(241, 103);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(100, 32);
            this.btn_stop.TabIndex = 15;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 150);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(353, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Zeit für Herunterfahren (in Minuten)";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(0, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(366, 2);
            this.label5.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(353, 172);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nUP_free);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton_free);
            this.Controls.Add(this.radioButton_180);
            this.Controls.Add(this.radioButton_120);
            this.Controls.Add(this.radioButton_60);
            this.Controls.Add(this.btn_start);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Power Off";
            ((System.ComponentModel.ISupportInitialize)(this.nUP_free)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.RadioButton radioButton_60;
        private System.Windows.Forms.RadioButton radioButton_120;
        private System.Windows.Forms.RadioButton radioButton_180;
        private System.Windows.Forms.RadioButton radioButton_free;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUP_free;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

