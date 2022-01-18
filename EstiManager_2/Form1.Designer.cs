using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;

namespace EstiManager_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ok_btn = new System.Windows.Forms.Button();
            this.no_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.def = new System.Windows.Forms.Button();
            this.rest = new System.Windows.Forms.Button();
            this.Fload = new System.Windows.Forms.Button();
            this.Refr = new System.Windows.Forms.Button();
            this.Sett = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(423, 312);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "Запуск";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // no_btn
            // 
            this.no_btn.Location = new System.Drawing.Point(342, 312);
            this.no_btn.Name = "no_btn";
            this.no_btn.Size = new System.Drawing.Size(75, 23);
            this.no_btn.TabIndex = 1;
            this.no_btn.Text = "Отмена";
            this.no_btn.UseVisualStyleBackColor = true;
            this.no_btn.Click += new System.EventHandler(this.no_btn_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(463, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выбор базы:";
            // 
            // def
            // 
            this.def.Location = new System.Drawing.Point(380, 127);
            this.def.Name = "def";
            this.def.Size = new System.Drawing.Size(118, 23);
            this.def.TabIndex = 5;
            this.def.Text = "По умолчанию";
            this.def.UseVisualStyleBackColor = true;
            this.def.Click += new System.EventHandler(this.def_Click);
            // 
            // rest
            // 
            this.rest.Location = new System.Drawing.Point(380, 156);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(118, 23);
            this.rest.TabIndex = 6;
            this.rest.Text = "Резервные копии";
            this.rest.UseVisualStyleBackColor = true;
            this.rest.Click += new System.EventHandler(this.rest_Click);
            // 
            // Fload
            // 
            this.Fload.BackgroundImage = global::EstiManager_2.Properties.Resources.icons8_папка_30;
            this.Fload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Fload.Location = new System.Drawing.Point(464, 185);
            this.Fload.Name = "Fload";
            this.Fload.Size = new System.Drawing.Size(34, 29);
            this.Fload.TabIndex = 7;
            this.Fload.UseVisualStyleBackColor = true;
            this.Fload.Click += new System.EventHandler(this.Fload_Click);
            // 
            // Refr
            // 
            this.Refr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Refr.Image = global::EstiManager_2.Properties.Resources.icons8_обновить_24;
            this.Refr.Location = new System.Drawing.Point(380, 185);
            this.Refr.Name = "Refr";
            this.Refr.Size = new System.Drawing.Size(34, 29);
            this.Refr.TabIndex = 8;
            this.Refr.UseVisualStyleBackColor = true;
            this.Refr.Click += new System.EventHandler(this.Refr_Click);
            // 
            // Sett
            // 
            this.Sett.BackgroundImage = global::EstiManager_2.Properties.Resources.icons8_настройки_24;
            this.Sett.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Sett.Location = new System.Drawing.Point(422, 185);
            this.Sett.Name = "Sett";
            this.Sett.Size = new System.Drawing.Size(34, 29);
            this.Sett.TabIndex = 9;
            this.Sett.UseVisualStyleBackColor = true;
            this.Sett.Click += new System.EventHandler(this.Sett_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 356);
            this.Controls.Add(this.Sett);
            this.Controls.Add(this.Refr);
            this.Controls.Add(this.Fload);
            this.Controls.Add(this.rest);
            this.Controls.Add(this.def);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.no_btn);
            this.Controls.Add(this.ok_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 395);
            this.MinimumSize = new System.Drawing.Size(550, 395);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstiManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button no_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button def;
        private System.Windows.Forms.Button rest;
        private System.Windows.Forms.Button Fload;
        private System.Windows.Forms.Button Refr;
        private System.Windows.Forms.Button Sett;
    }
}

