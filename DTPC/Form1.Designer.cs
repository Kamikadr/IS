using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace DTPC
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWelcom = new System.Windows.Forms.Label();
            this.buttonHardware = new System.Windows.Forms.Button();
            this.buttonSoftware = new System.Windows.Forms.Button();
            this.panelHardware = new System.Windows.Forms.Panel();
            this.panelSoftware = new System.Windows.Forms.Panel();
            this.panelTxt = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcom
            // 
            this.labelWelcom.AutoSize = true;
            this.labelWelcom.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.labelWelcom.Location = new System.Drawing.Point(289, 126);
            this.labelWelcom.Name = "labelWelcom";
            this.labelWelcom.Size = new System.Drawing.Size(549, 29);
            this.labelWelcom.TabIndex = 0;
            this.labelWelcom.Text = "Какого характера проблема на Вашем ПК?";
            // 
            // buttonHardware
            // 
            this.buttonHardware.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.buttonHardware.Location = new System.Drawing.Point(294, 290);
            this.buttonHardware.Name = "buttonHardware";
            this.buttonHardware.Size = new System.Drawing.Size(195, 89);
            this.buttonHardware.TabIndex = 1;
            this.buttonHardware.Text = "Hardware";
            this.buttonHardware.UseVisualStyleBackColor = true;
            this.buttonHardware.Click += new System.EventHandler(this.buttonHardware_Click);
            // 
            // buttonSoftware
            // 
            this.buttonSoftware.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSoftware.Location = new System.Drawing.Point(657, 290);
            this.buttonSoftware.Name = "buttonSoftware";
            this.buttonSoftware.Size = new System.Drawing.Size(181, 89);
            this.buttonSoftware.TabIndex = 1;
            this.buttonSoftware.Text = "Software";
            this.buttonSoftware.UseVisualStyleBackColor = true;
            this.buttonSoftware.Click += new System.EventHandler(this.buttonSoftware_Click);
            // 
            // panelHardware
            // 
            this.panelHardware.AutoScroll = true;
            this.panelHardware.Location = new System.Drawing.Point(12, 12);
            this.panelHardware.Name = "panelHardware";
            this.panelHardware.Size = new System.Drawing.Size(1108, 400);
            this.panelHardware.TabIndex = 1;
            this.panelHardware.Visible = false;
            // 
            // panelSoftware
            // 
            this.panelSoftware.AutoScroll = true;
            this.panelSoftware.Location = new System.Drawing.Point(12, 12);
            this.panelSoftware.Name = "panelHardware";
            this.panelSoftware.Size = new System.Drawing.Size(1108, 400);
            this.panelSoftware.TabIndex = 1;
            this.panelSoftware.Visible = false;
            // 
            // panelTxt
            // 
            this.panelTxt.AutoScroll = true;
            this.panelTxt.Location = new System.Drawing.Point(12, 12);
            this.panelTxt.Name = "panelTxt";
            this.panelTxt.Size = new System.Drawing.Size(1108, 400);
            this.panelTxt.TabIndex = 0;
            this.panelTxt.Visible = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(968, 418);
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(152, 64);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.Visible = false;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(12, 418);
            this.buttonMenu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(152, 64);
            this.buttonMenu.TabIndex = 3;
            this.buttonMenu.Text = "В главное меню";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            this.buttonMenu.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1132, 494);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.panelTxt);
            this.Controls.Add(this.panelHardware);
            this.Controls.Add(this.panelSoftware);
            this.Controls.Add(this.buttonSoftware);
            this.Controls.Add(this.buttonHardware);
            this.Controls.Add(this.labelWelcom);
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "DTPC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelWelcom;
        private Button buttonHardware;
        private Button buttonSoftware;
        private Panel panelHardware;
        private Panel panelTxt;
        private Button buttonBack;
        private Button buttonMenu;
        private Panel panelSoftware;
    }
}

