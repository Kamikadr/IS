
namespace IS
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
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.labelMain = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.listSoftW = new System.Windows.Forms.ListBox();
            this.swRBtn = new System.Windows.Forms.RadioButton();
            this.hwRBtn = new System.Windows.Forms.RadioButton();
            this.listHardW = new System.Windows.Forms.ListBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.startupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(548, 85);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(309, 147);
            this.rightButton.TabIndex = 0;
            this.rightButton.Text = "rightBtn";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(12, 85);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(309, 147);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "leftBtn";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // labelMain
            // 
            this.labelMain.AutoEllipsis = true;
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.Location = new System.Drawing.Point(12, 9);
            this.labelMain.MaximumSize = new System.Drawing.Size(845, 200);
            this.labelMain.MinimumSize = new System.Drawing.Size(845, 50);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(845, 50);
            this.labelMain.TabIndex = 2;
            this.labelMain.Text = "ВОПРОС";
            this.labelMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backButton.Enabled = false;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(548, 238);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(309, 30);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // listSoftW
            // 
            this.listSoftW.Enabled = false;
            this.listSoftW.FormattingEnabled = true;
            this.listSoftW.HorizontalScrollbar = true;
            this.listSoftW.Location = new System.Drawing.Point(12, 85);
            this.listSoftW.Name = "listSoftW";
            this.listSoftW.Size = new System.Drawing.Size(309, 147);
            this.listSoftW.TabIndex = 4;
            this.listSoftW.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // swRBtn
            // 
            this.swRBtn.AutoSize = true;
            this.swRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.swRBtn.Location = new System.Drawing.Point(246, 62);
            this.swRBtn.Name = "swRBtn";
            this.swRBtn.Size = new System.Drawing.Size(75, 17);
            this.swRBtn.TabIndex = 5;
            this.swRBtn.TabStop = true;
            this.swRBtn.Text = "Software";
            this.swRBtn.UseVisualStyleBackColor = true;
            this.swRBtn.CheckedChanged += new System.EventHandler(this.swRBtn_CheckedChanged);
            // 
            // hwRBtn
            // 
            this.hwRBtn.AutoSize = true;
            this.hwRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hwRBtn.Location = new System.Drawing.Point(548, 62);
            this.hwRBtn.Name = "hwRBtn";
            this.hwRBtn.Size = new System.Drawing.Size(79, 17);
            this.hwRBtn.TabIndex = 6;
            this.hwRBtn.TabStop = true;
            this.hwRBtn.Text = "Hardware";
            this.hwRBtn.UseVisualStyleBackColor = true;
            this.hwRBtn.CheckedChanged += new System.EventHandler(this.hwRBtn_CheckedChanged);
            // 
            // listHardW
            // 
            this.listHardW.Enabled = false;
            this.listHardW.FormattingEnabled = true;
            this.listHardW.Location = new System.Drawing.Point(548, 85);
            this.listHardW.Name = "listHardW";
            this.listHardW.Size = new System.Drawing.Size(309, 147);
            this.listHardW.TabIndex = 7;
            this.listHardW.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAccept.Enabled = false;
            this.buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccept.Location = new System.Drawing.Point(327, 85);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(215, 147);
            this.buttonAccept.TabIndex = 8;
            this.buttonAccept.Text = "Подтвердить";
            this.buttonAccept.UseVisualStyleBackColor = false;
            this.buttonAccept.Click += new System.EventHandler(this.button1_Click);
            // 
            // startupButton
            // 
            this.startupButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.startupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startupButton.Enabled = false;
            this.startupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startupButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startupButton.ForeColor = System.Drawing.Color.Black;
            this.startupButton.Location = new System.Drawing.Point(12, 238);
            this.startupButton.Name = "startupButton";
            this.startupButton.Size = new System.Drawing.Size(309, 30);
            this.startupButton.TabIndex = 9;
            this.startupButton.Text = "На главный экран";
            this.startupButton.UseVisualStyleBackColor = false;
            this.startupButton.Click += new System.EventHandler(this.startupButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(869, 274);
            this.Controls.Add(this.startupButton);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.listHardW);
            this.Controls.Add(this.hwRBtn);
            this.Controls.Add(this.swRBtn);
            this.Controls.Add(this.listSoftW);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.rightButton);
            this.MaximumSize = new System.Drawing.Size(885, 313);
            this.MinimumSize = new System.Drawing.Size(885, 313);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "DTPC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListBox listSoftW;
        private System.Windows.Forms.RadioButton swRBtn;
        private System.Windows.Forms.RadioButton hwRBtn;
        private System.Windows.Forms.ListBox listHardW;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button startupButton;
    }
}

