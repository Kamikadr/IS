using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace IS
{
    public partial class Form1 : Form
    {
        QuestionsModel questionsModel;
        string jsonText;
        int num = -1;
        public Form1()
        {
            InitializeComponent();
            readJson();
            initialSetup();
        }
        private void readJson() 
        {
            string path = Directory.GetCurrentDirectory() + @"\Questions.json";
            jsonText = File.ReadAllText(path, System.Text.Encoding.GetEncoding(1251));
            questionsModel = JsonSerializer.Deserialize<QuestionsModel>(jsonText);
        }
        private void initialSetup() 
        {
            label1.Text = "Какая проблема с компьютером у вас возникла?";
            rightButton.Text = questionsModel.screenTrouble.nameOfTrouble;
            leftButton.Text = questionsModel.turnOffTrouble.nameOfTrouble;
        }

 
        private void troubleTest(Trouble trouble)
        {
            if (trouble.questions.Count > num)
            {
                label1.Text = trouble.questions[num].question;
                leftButton.Text = trouble.questions[num].leftButtonText;
                rightButton.Text = trouble.questions[num].rightButtonText;
            }
            else label1.Text = "Смените материнскую карту";

        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            num++;
            troubleTest(questionsModel.screenTrouble);
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            num++;
            troubleTest(questionsModel.turnOffTrouble);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            /*if (num != -1) return;
            else 
            {
                num--;
                if (num != -1) initialSetup();
                else troubleTest();
            }*/
        }
    }
}
