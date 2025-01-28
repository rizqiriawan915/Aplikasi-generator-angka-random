namespace Aplikasi_Generator_Angka_Random
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAngkaMinimal = new TextBox();
            txtAngkaMaximal = new TextBox();
            txtAngkaTerpilih = new TextBox();
            btnRandom = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 0;
            label1.Text = "Masukkan angka minimal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 1;
            label2.Text = "Masukkan angka maximal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 2;
            label3.Text = "Angka yang terpilih";
            // 
            // txtAngkaMinimal
            // 
            txtAngkaMinimal.Location = new Point(170, 6);
            txtAngkaMinimal.Name = "txtAngkaMinimal";
            txtAngkaMinimal.Size = new Size(249, 23);
            txtAngkaMinimal.TabIndex = 3;
            // 
            // txtAngkaMaximal
            // 
            txtAngkaMaximal.Location = new Point(170, 39);
            txtAngkaMaximal.Name = "txtAngkaMaximal";
            txtAngkaMaximal.Size = new Size(249, 23);
            txtAngkaMaximal.TabIndex = 4;
            // 
            // txtAngkaTerpilih
            // 
            txtAngkaTerpilih.Location = new Point(170, 74);
            txtAngkaTerpilih.Name = "txtAngkaTerpilih";
            txtAngkaTerpilih.ReadOnly = true;
            txtAngkaTerpilih.Size = new Size(249, 23);
            txtAngkaTerpilih.TabIndex = 5;
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(171, 107);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(248, 42);
            btnRandom.TabIndex = 6;
            btnRandom.Text = "Random";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 164);
            Controls.Add(btnRandom);
            Controls.Add(txtAngkaTerpilih);
            Controls.Add(txtAngkaMaximal);
            Controls.Add(txtAngkaMinimal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Random Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAngkaMinimal;
        private TextBox txtAngkaMaximal;
        private TextBox txtAngkaTerpilih;
        private Button btnRandom;
    }
}
