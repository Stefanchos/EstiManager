
namespace EstiManager_2
{
    partial class zip
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
            this.no_btn = new System.Windows.Forms.Button();
            this.y_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // no_btn
            // 
            this.no_btn.Location = new System.Drawing.Point(175, 76);
            this.no_btn.Name = "no_btn";
            this.no_btn.Size = new System.Drawing.Size(75, 23);
            this.no_btn.TabIndex = 0;
            this.no_btn.Text = "Нет";
            this.no_btn.UseVisualStyleBackColor = true;
            // 
            // y_btn
            // 
            this.y_btn.Location = new System.Drawing.Point(256, 76);
            this.y_btn.Name = "y_btn";
            this.y_btn.Size = new System.Drawing.Size(75, 23);
            this.y_btn.TabIndex = 1;
            this.y_btn.Text = "Да";
            this.y_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Создать резервную копию?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // zip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 111);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.y_btn);
            this.Controls.Add(this.no_btn);
            this.MaximumSize = new System.Drawing.Size(500, 150);
            this.MinimumSize = new System.Drawing.Size(500, 150);
            this.Name = "zip";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button no_btn;
        private System.Windows.Forms.Button y_btn;
        private System.Windows.Forms.Label label1;
    }
}