namespace ProjektGrafy
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
            this.loadGrafButton = new System.Windows.Forms.Button();
            this.checkGrafButton = new System.Windows.Forms.Button();
            this.grafLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.leftPartLabel = new System.Windows.Forms.Label();
            this.rightPartLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grafIsDwudzielnyCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.debugLogLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadGrafButton
            // 
            this.loadGrafButton.BackColor = System.Drawing.SystemColors.Control;
            this.loadGrafButton.Location = new System.Drawing.Point(13, 13);
            this.loadGrafButton.Name = "loadGrafButton";
            this.loadGrafButton.Size = new System.Drawing.Size(114, 122);
            this.loadGrafButton.TabIndex = 0;
            this.loadGrafButton.Text = "Wczytaj graf";
            this.loadGrafButton.UseVisualStyleBackColor = false;
            this.loadGrafButton.Click += new System.EventHandler(this.loadGrafButton_Click);
            // 
            // checkGrafButton
            // 
            this.checkGrafButton.Location = new System.Drawing.Point(12, 141);
            this.checkGrafButton.Name = "checkGrafButton";
            this.checkGrafButton.Size = new System.Drawing.Size(114, 120);
            this.checkGrafButton.TabIndex = 1;
            this.checkGrafButton.Text = "Sprawdź graf";
            this.checkGrafButton.UseVisualStyleBackColor = true;
            this.checkGrafButton.Click += new System.EventHandler(this.checkGrafButton_Click);
            // 
            // grafLabel
            // 
            this.grafLabel.BackColor = System.Drawing.SystemColors.Info;
            this.grafLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grafLabel.Location = new System.Drawing.Point(133, 13);
            this.grafLabel.Name = "grafLabel";
            this.grafLabel.Size = new System.Drawing.Size(250, 250);
            this.grafLabel.TabIndex = 2;
            this.grafLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(390, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 77);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lewa część grafu";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(491, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prawa część grafu";
            // 
            // leftPartLabel
            // 
            this.leftPartLabel.BackColor = System.Drawing.SystemColors.Info;
            this.leftPartLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftPartLabel.Location = new System.Drawing.Point(390, 30);
            this.leftPartLabel.Name = "leftPartLabel";
            this.leftPartLabel.Size = new System.Drawing.Size(97, 233);
            this.leftPartLabel.TabIndex = 5;
            // 
            // rightPartLabel
            // 
            this.rightPartLabel.BackColor = System.Drawing.SystemColors.Info;
            this.rightPartLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rightPartLabel.Location = new System.Drawing.Point(491, 30);
            this.rightPartLabel.Name = "rightPartLabel";
            this.rightPartLabel.Size = new System.Drawing.Size(97, 233);
            this.rightPartLabel.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.grafIsDwudzielnyCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 49);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Właściwości grafu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = " Graf dwudzielny jest pełny";
            // 
            // grafIsDwudzielnyCheckBox
            // 
            this.grafIsDwudzielnyCheckBox.AutoSize = true;
            this.grafIsDwudzielnyCheckBox.Location = new System.Drawing.Point(6, 20);
            this.grafIsDwudzielnyCheckBox.Name = "grafIsDwudzielnyCheckBox";
            this.grafIsDwudzielnyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.grafIsDwudzielnyCheckBox.TabIndex = 1;
            this.grafIsDwudzielnyCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.debugLogLabel);
            this.groupBox2.Location = new System.Drawing.Point(235, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 116);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // debugLogLabel
            // 
            this.debugLogLabel.BackColor = System.Drawing.SystemColors.Info;
            this.debugLogLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.debugLogLabel.Location = new System.Drawing.Point(6, 16);
            this.debugLogLabel.Name = "debugLogLabel";
            this.debugLogLabel.Size = new System.Drawing.Size(341, 95);
            this.debugLogLabel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 64);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sprawdzanie, czy graf dwudzielny jest pełny\r\nAutorzy:\r\nRobert Borkowski\r\nSylweste" +
    "r Ciechoński";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Macierz grafu dwudzielnego ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(604, 396);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rightPartLabel);
            this.Controls.Add(this.leftPartLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grafLabel);
            this.Controls.Add(this.checkGrafButton);
            this.Controls.Add(this.loadGrafButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sprawdzanie, czy graf dwudzielny jest pełny";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadGrafButton;
        private System.Windows.Forms.Button checkGrafButton;
        private System.Windows.Forms.Label grafLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label leftPartLabel;
        private System.Windows.Forms.Label rightPartLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox grafIsDwudzielnyCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label debugLogLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

