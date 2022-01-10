
namespace EstiManager_2
{
    partial class Backup
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
            this.recover = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // recover
            // 
            this.recover.Location = new System.Drawing.Point(376, 276);
            this.recover.Name = "recover";
            this.recover.Size = new System.Drawing.Size(96, 23);
            this.recover.TabIndex = 0;
            this.recover.Text = "Восстановить";
            this.recover.UseVisualStyleBackColor = true;
            this.recover.Click += new System.EventHandler(this.recover_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(295, 276);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 1;
            this.exit.Text = "Отмена";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            Search search = new Search();
            this.comboBox1.Items.AddRange(search.bupFiles);
            this.comboBox1.Location = new System.Drawing.Point(12, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(460, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите файл резервной копии:";
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.recover);
            this.MaximumSize = new System.Drawing.Size(500, 350);
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button recover;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}