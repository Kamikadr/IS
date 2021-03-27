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

        // Глобальные переменные, требуемые в ходе работы приложения \\
        QuestionsModel questionsModel;
        Trouble CurrentTrouble;

        int CurQuestionsAmount;
        int num;

        // Инициализация приложения. Первый запуск. \\
        public Form1()
        {
            InitializeComponent();
            readJson();
            setupListBoxes();
            initStartup();
        }

        // Метод, предназначенный для чтения всех вопросов и решений из базы вопросов \\
        private void readJson()
        {
            string path = Directory.GetCurrentDirectory() + @"\Questions.json";
            string jsonText = File.ReadAllText(path, System.Text.Encoding.GetEncoding(1251));
            questionsModel = JsonSerializer.Deserialize<QuestionsModel>(jsonText);
        }

        // Заполнение списков проблемами, которые занесены в базу вопросов \\
        private void setupListBoxes()
        {
            foreach (Trouble S_trouble in questionsModel.S_Problems)
            {
                listSoftW.Items.Add(S_trouble.nameOfTrouble);
            }
            foreach (Trouble H_trouble in questionsModel.H_Problems)
            {
                listHardW.Items.Add(H_trouble.nameOfTrouble);
            }
        }

        // Инициализация Главного меню \\
        private void initStartup()
        {
            labelMain.Text = "Выберите тип проблемы и подтвердите выбор";

            hideChoosePanels();

            listSoftW.Enabled = false;
            listHardW.Enabled = false;

            swRBtn.Checked = false;
            hwRBtn.Checked = false;

            backButton.Enabled = false;
        }

        // Метод, устанавливающий следующий наводящий вопрос на экране пользователя \\
        private void setQuestion()
        {
            labelMain.Text = CurrentTrouble.questions[num].question;
            rightButton.Text = CurrentTrouble.questions[num].rightButtonText;
            leftButton.Text = CurrentTrouble.questions[num].leftButtonText;
        }

        // Основное событие Правой кнопки. Отвечает за продвижение по цепи вопросов \\
        private void rightButton_Click(object sender, EventArgs e)
        { 
            num++;

            if (num == CurQuestionsAmount) {
                labelMain.Text = "Обратитесь в сервисный центр.";

                hideChoosePanels();
            }
            else setQuestion();
        }

        // Основное событие Левой кнопки. Открывает решение проблемы при очередном вопросе \\
        private void leftButton_Click(object sender, EventArgs e)
        {
            labelMain.Text = CurrentTrouble.questions[num].solve;

            hideChoosePanels();
        }

        // Основное событие Кнопки возврата. Возвращает на предыдущий вопрос цепи вопросов \\
        private void backButton_Click(object sender, EventArgs e)
        {
            if (num == 0) return;
            else
            {
                num--;
                setQuestion();
            }
        }

        // Основное событие Кнопки Главного меню. Возвращает в главное меню \\
        private void startupButton_Click(object sender, EventArgs e)
        {
            showStartupPanels();
            initStartup();
            startupButton.Enabled = false;
        }

        // Основное событие Кнопки Подтверждения. Открывает цепь вопросов \\
        private void button1_Click(object sender, EventArgs e)
        {
            if (swRBtn.Checked)
            {
                if (listSoftW.SelectedIndex == -1) return;

                CurrentTrouble = questionsModel.S_Problems[listSoftW.SelectedIndex];
            }
            else
            {
                if (listHardW.SelectedIndex == -1) return;

                CurrentTrouble = questionsModel.H_Problems[listHardW.SelectedIndex];
            }

            hideStartupPanels();
            showChoosePanels();
            startupButton.Enabled = true;

            CurQuestionsAmount = CurrentTrouble.questions.Count;
            num = 0;

            setQuestion();
        }

        // Методы, желательные для удобства пользовательского интерфейса \\
        private void hideStartupPanels()
        {
            listSoftW.Visible = false;
            listHardW.Visible = false;

            swRBtn.Visible = false;
            hwRBtn.Visible = false;

            buttonAccept.Visible = false;
        }
        private void showStartupPanels()
        {
            listSoftW.Visible = true;
            listHardW.Visible = true;

            swRBtn.Visible = true;
            hwRBtn.Visible = true;

            buttonAccept.Visible = true;
        }
        private void hideChoosePanels()
        {
            leftButton.Visible = false;
            rightButton.Visible = false;

            backButton.Enabled = false;
        }
        private void showChoosePanels()
        {
            leftButton.Visible = true;
            rightButton.Visible = true;

            backButton.Enabled = true;
        }

        // События, желательные для удобства пользовательского интерфейса \\
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAccept.Enabled = true;
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAccept.Enabled = true;
        }
        private void swRBtn_CheckedChanged(object sender, EventArgs e)
        {
            listSoftW.Enabled = true;
            listHardW.Enabled = false;

            listHardW.ClearSelected();
        }
        private void hwRBtn_CheckedChanged(object sender, EventArgs e)
        {
            listSoftW.Enabled = false;
            listHardW.Enabled = true;

            listSoftW.ClearSelected();
        }
    }
}
