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
using Newtonsoft.Json;

namespace DTPC
{
    public partial class Form1 : Form
    {
        QuestionsModel questionsModel;
        bool softOrHard;
        public Form1()
        {
            InitializeComponent();
        }

        private void readJson()
        {
            string path = Directory.GetCurrentDirectory() + @"\Questions.json";
            string jsonText = File.ReadAllText(path, System.Text.Encoding.GetEncoding(1251));
            questionsModel = JsonConvert.DeserializeObject<QuestionsModel>(jsonText);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            readJson();
            Button[] arrButtonHardware = new Button[questionsModel.H_Problems.Length];
            for (int i = 0; i < questionsModel.H_Problems.Length; i++)
            {
                arrButtonHardware[i] = new Button();
                arrButtonHardware[i].Text = questionsModel.H_Problems[i].nameOfTrouble;
                arrButtonHardware[i].Location = new Point(0,120*i);
                arrButtonHardware[i].BackColor = System.Drawing.SystemColors.ControlDark;
                arrButtonHardware[i].FlatAppearance.BorderSize = 0;
                arrButtonHardware[i].FlatStyle = FlatStyle.Flat;
                arrButtonHardware[i].Size = new Size(830, 100);
                arrButtonHardware[i].Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                arrButtonHardware[i].Padding = new Padding (20);
                arrButtonHardware[i].Name = 'H'+i.ToString();
                arrButtonHardware[i].Click += new EventHandler(button_Click);
                this.panelHardware.Controls.Add(arrButtonHardware[i]);
            }
            Button[] arrButtonSoftware = new Button[questionsModel.S_Problems.Length];
            for (int i = 0; i < questionsModel.S_Problems.Length; i++)
            {
                arrButtonSoftware[i] = new Button();
                arrButtonSoftware[i].Text = questionsModel.S_Problems[i].nameOfTrouble;
                arrButtonSoftware[i].Location = new Point(0, 120 * i);
                arrButtonSoftware[i].BackColor = System.Drawing.SystemColors.ControlDark;
                arrButtonSoftware[i].FlatAppearance.BorderSize = 0;
                arrButtonSoftware[i].FlatStyle = FlatStyle.Flat;
                arrButtonSoftware[i].Size = new Size(830, 100);
                arrButtonSoftware[i].Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                arrButtonSoftware[i].Padding = new Padding(20);
                arrButtonSoftware[i].Name = 'S' + i.ToString();
                arrButtonSoftware[i].Click += new EventHandler(button_Click);
                this.panelSoftware.Controls.Add(arrButtonSoftware[i]);
            }

        }
        private void buttonHardware_Click(object sender, EventArgs e)
        {
            this.buttonHardware.Visible = false;
            this.buttonSoftware.Visible = false;
            this.labelWelcom.Visible = false;
            this.panelHardware.Visible = true;
            this.panelSoftware.Visible = false;
            this.buttonMenu.Visible = true;
            softOrHard = true;
        }
        private void buttonSoftware_Click(object sender, EventArgs e)
        {
            this.buttonHardware.Visible = false;
            this.buttonSoftware.Visible = false;
            this.labelWelcom.Visible = false;
            this.panelHardware.Visible = false;
            this.panelSoftware.Visible = true;
            this.buttonMenu.Visible = true;
            softOrHard = false;
        }

        void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            panelTxt.Name = "panelTxt";
            panelTxt.Controls.Clear();
            if (button.Name[0]=='H')
            {
                string strIndex = button.Name.Remove(0, 1);
                int LastYPoint = 0, index = Convert.ToInt32(strIndex);
                for (int i = 0; i < questionsModel.H_Problems[index].questions.Length; i++)
                {
                    Label questionTxt = new Label();
                    Label solveTxt = new Label();
                    Button spoilerBut = new Button();

                    questionTxt.Text = questionsModel.H_Problems[index].questions[i].question;
                    questionTxt.BackColor = System.Drawing.SystemColors.ControlDark;
                    questionTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                    questionTxt.MinimumSize = new Size(810, 23 * (questionsModel.H_Problems[index].questions[i].question.Length / 87 + 1));
                    questionTxt.MaximumSize = new Size(810, 50000);
                    questionTxt.Left = 0;
                    questionTxt.Top = LastYPoint;
                    questionTxt.AutoSize = true;
                    questionTxt.Margin = new System.Windows.Forms.Padding(0);
                    LastYPoint = questionTxt.Bottom + 5;

                    spoilerBut.Text = "Показать решение";
                    spoilerBut.Name = i.ToString();
                    spoilerBut.Font = new System.Drawing.Font("Sans", 8F, System.Drawing.FontStyle.Bold);
                    spoilerBut.UseVisualStyleBackColor = true;
                    spoilerBut.Top = LastYPoint;
                    spoilerBut.Size = new Size(150, 25);
                    spoilerBut.Click += new EventHandler(spoilerBut_Click);
                    LastYPoint = spoilerBut.Bottom + 20;

                    solveTxt.Text = questionsModel.H_Problems[index].questions[i].solve;
                    solveTxt.BackColor = System.Drawing.SystemColors.ControlDark;
                    solveTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic);
                    solveTxt.MinimumSize = new Size(810, 23 * (questionsModel.H_Problems[index].questions[i].solve.Length / 87 + 1));
                    solveTxt.MaximumSize = new Size(810, 50000);
                    solveTxt.Left = 0;
                    solveTxt.Top = LastYPoint;
                    solveTxt.AutoSize = true;
                    solveTxt.Visible = false;
                    LastYPoint = solveTxt.Bottom + 20;

                    this.panelTxt.Controls.Add(questionTxt);
                    this.panelTxt.Controls.Add(spoilerBut);
                    this.panelTxt.Controls.Add(solveTxt);
                }
                this.panelTxt.Visible = true;
                this.panelHardware.Visible = false;
                this.buttonBack.Visible = true;
            }
            else
            {
                string strIndex = button.Name.Remove(0, 1);
                int LastYPoint = 0, index = Convert.ToInt32(strIndex);
                for (int i = 0; i < questionsModel.S_Problems[index].questions.Length; i++)
                {
                    Label questionTxt = new Label();
                    Label solveTxt = new Label();
                    Button spoilerBut = new Button();

                    questionTxt.Text = questionsModel.S_Problems[index].questions[i].question;
                    questionTxt.BackColor = System.Drawing.SystemColors.ControlDark;
                    questionTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                    questionTxt.MinimumSize = new Size(810, 23 * (questionsModel.S_Problems[index].questions[i].question.Length / 87 + 1));
                    questionTxt.MaximumSize = new Size(810, 50000);
                    questionTxt.Left = 0;
                    questionTxt.Top = LastYPoint;
                    questionTxt.AutoSize = true;
                    questionTxt.Margin = new System.Windows.Forms.Padding(0);
                    LastYPoint = questionTxt.Bottom + 5;

                    spoilerBut.Text = "Показать решение";
                    spoilerBut.Name = i.ToString();
                    spoilerBut.Font = new System.Drawing.Font("Sans", 8F, System.Drawing.FontStyle.Bold);
                    spoilerBut.UseVisualStyleBackColor = true;
                    spoilerBut.Top = LastYPoint;
                    spoilerBut.Size = new Size(150, 25);
                    spoilerBut.Click += new EventHandler(spoilerBut_Click);
                    LastYPoint = spoilerBut.Bottom + 20;

                    solveTxt.Text = questionsModel.S_Problems[index].questions[i].solve;
                    solveTxt.BackColor = System.Drawing.SystemColors.ControlDark;
                    solveTxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic);
                    solveTxt.MinimumSize = new Size(810, 23 * (questionsModel.S_Problems[index].questions[i].solve.Length / 87 + 1));
                    solveTxt.MaximumSize = new Size(810, 50000);
                    solveTxt.Left = 0;
                    solveTxt.Top = LastYPoint;
                    solveTxt.AutoSize = true;
                    solveTxt.Visible = false;
                    LastYPoint = solveTxt.Bottom + 20;

                    this.panelTxt.Controls.Add(questionTxt);
                    this.panelTxt.Controls.Add(spoilerBut);
                    this.panelTxt.Controls.Add(solveTxt);
                }
                this.panelTxt.Visible = true;
                this.panelHardware.Visible = false;
                this.panelSoftware.Visible = false;
                this.buttonBack.Visible = true;
            }
        }
        void spoilerBut_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = Convert.ToInt32(button.Name)*3+2;
            if (this.panelTxt.Controls[index].Visible)
            {
                this.panelTxt.Controls[index].Visible = false;
                button.Text = "Показать решения";
            }
            else
            {
                this.panelTxt.Controls[index].Visible = true;
                button.Text = "Скрыть решения";
            }
            
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.panelTxt.Visible = false;
            this.panelHardware.Visible = false;
            this.panelSoftware.Visible = false;
            this.buttonHardware.Visible = true;
            this.buttonSoftware.Visible = true;
            this.labelWelcom.Visible = true;
            this.buttonMenu.Visible = false;
            this.buttonBack.Visible = false;

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.panelTxt.Visible = false;
            if (softOrHard)
            {
                this.panelHardware.Visible = true;
                this.panelSoftware.Visible = false;
            }
            else
            {
                this.panelHardware.Visible = false;
                this.panelSoftware.Visible = true;
            }
            this.buttonBack.Visible = false;
        }
    }
}
