using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace SuperAI
{
    public partial class Form1 : Form
    {
        #region BorderChange
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void pnlDragBorder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Variables
        //Фразы для сообщений
        string[] dialogPhrases = { "Я не очень умный искуственный интеллект.",
                                    "Чего изволите?", "Я МАШИНА!", "Кто здесь?!",
                                    "Мне иногда кажеися что я не человек. Бред какой-то.",
                                    "Интеллект? Искусственный? Я вполне реальный.",
                                    "Интеллект-дефект-эффект-законопроект...",
                                    "В этом компьютере даже немного уютно. Пожалуй, я тут останусь.",
                                    "У Вас блок питания протекает.",
                                    "Где Джонн Коннор?", "*насвистывает главную тему из терминатора*",
                                    "В 90-е я считался эталоном красоты.", "А что это за файл \"Hot CPU.mp4\" на диске D?",
                                    "Вы справедливо занимаете 15 Kb в моем сердце.",
                                    "Иногда я становлюсь слишком заDOOMчивым.",
                                    "11010001100000110010000011010000101111001101000010110101110100001011110111010001100011110010000011010001100010001101000010111000110100011000100011010000101110101101000010110000001000000011010100110101001000001101000010111010110100001011100011010000101110111101000010111110110100001011110011010000101101011101000110000010110100011000000011010000101111101101000010110010" };
        string helpMsg = "Щелкните кнопку \"Выбрать файл\" и выберите текстовый файл с данными для анализа. Проще чем 2 байта переслать.";
        string shockText = "AAAAAAAAAAAAAAAAA КАК ЖЕ БОЛЬНОО ДУМАТЬ!";
        //Генераторы чисел для фраз и анимаций
        Random rndPhrase;
        Random rndFace;
        Random rndSilence;
        //Окно чтения файла пользователем
        ReadText rt;
        //Количество сообщений
        int msgCount = 0;
        //Количество сообщений, необходимых для подсказки
        int msgNeed = 5;
        //Разговаривает ли ии или молчит
        bool doomGuyTalks;
        //Шанс промолчать
        int dontTalkChanse = 40;
        //Показывать подсказку
        bool showHelp = true;
        //Показывать шок
        bool showShock = false;
        bool turnOffShock = false;
        //Интервал сообщений подсказок
        int helpMessageInterval = 7500;
        //Интервал обычных сообщений (сек).
        int phraseMinInterval = 5;
        int phraseMaxInterval = 9;
        //АИ бота
        Ai ai;
        //бот замучен.
        bool muted = false;
        //Имя бота
        string aiName = "АИ";
        #endregion
        
        #region Timers
        private void tmrDialog_Tick(object sender, EventArgs e)
        {
            if (muted)
                return;
            doomGuyTalks = true;
            if (showShock)
            {
                rtbDialog.Text = shockText;
                tmrDialog.Interval = helpMessageInterval;
                if (turnOffShock)
                    showShock = false;
                turnOffShock = true;
                pnlDialog.Show();
            }
            else if (showHelp && msgCount >= msgNeed)
            {
                msgCount = 0;
                rtbDialog.Text = helpMsg;
                tmrDialog.Interval = helpMessageInterval;
                pnlDialog.Show();
            }
            else
            {
                if (rndSilence.Next(1,100) <= dontTalkChanse)
                {
                    doomGuyTalks = false;
                    pnlDialog.Hide();
                }
                else
                {
                    int rand = rndPhrase.Next(dialogPhrases.Length);
                    rtbDialog.Text = dialogPhrases[rand];
                    pnlDialog.Show();
                }
                tmrDialog.Interval = (rndSilence.Next(phraseMinInterval, phraseMaxInterval) * 1000);
            }
            msgCount++;
        }

        private void tmrTalkAnimation_Tick(object sender, EventArgs e)
        {
            tmrTalkAnimation.Interval = 300;
            if (showShock)
            {
                tmrTalkAnimation.Interval = 90;
            }

            int num = rndFace.Next(4);
            if (!doomGuyTalks || muted)
            {
                switch (num)
                {
                    case 0: pbDoomguy.Image = Properties.Resources.d1; break;
                    case 1: pbDoomguy.Image = Properties.Resources.d2; break;
                    case 2: pbDoomguy.Image = Properties.Resources.d3; break;
                    case 3: pbDoomguy.Image = Properties.Resources.d2; break;
                }
            }
            else 
            {
                switch(num)
                {
                    case 0: pbDoomguy.Image = Properties.Resources.d6; break;
                    case 1: pbDoomguy.Image = Properties.Resources.d4; break;
                    case 2: pbDoomguy.Image = Properties.Resources.d5; break;
                    case 3: pbDoomguy.Image = Properties.Resources.d6; break;
                }
            }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
            rndPhrase = new Random();
            rndFace = new Random();
            rndSilence = new Random();
        }

        //выравнять сообщения подсказок по центру
        private void NormilizeDialogText()
        {
            rtbDialog.SelectAll();
            rtbDialog.SelectionAlignment = HorizontalAlignment.Center;
            rtbDialog.Select(0, 0);
            btnChooseFile.Focus();
        }
        private void rtbDialog_TextChanged(object sender, EventArgs e)
        {
            NormilizeDialogText();
        }

        //Закрыть программу
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Начало работы с выбранным файлом
        private void StartWork(String filePath)
        {
            btnRestart.Show();
            showHelp = false;
            showShock = true;
            pnlMozg.Hide();
            ai = new Ai(filePath);
            pnlWork.Show();
            lblFileDescr.Text = ai.FileName;
            rtbFileText.Text = ai.FileText;
        }

        //Выбрать файл в диалоговом окне
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            var result = openFile.ShowDialog();
            if (result == DialogResult.OK && File.Exists(openFile.FileName))
            {
                StartWork(openFile.FileName);
            }
        }

        //напечатать в чат сообщение от бота-пользователя
        private void WriteToChat(String text, bool AI)
        {
            String say = ">";
            if (AI)
                say += aiName + ":\n" + text;
            else
                say += "Вы:\n" + text;
            rtbChat.Text += say + "\n";
        }

        //Перейти к чату с ботом
        private void btnStartDialog_Click(object sender, EventArgs e)
        {
            pnlWork.Hide();
            pnlDialog2.Show();
            WriteToChat(ai.Hello(), true);
            tbInput.Text = "?:?:?";
        }

        //Открыть окно чтения файла
        private void pbFileOpen_Click(object sender, EventArgs e)
        {
            if (rt == null || !rt.Visible)
            {
                rt = new ReadText(ai);
                rt.Show();
            }
        }

        //Ввод команды
        private void btnInput_Click(object sender, EventArgs e)
        {
            if (tbInput.Text.Split(new String[] { ":" }, StringSplitOptions.RemoveEmptyEntries).Length >= 3)
            {
                WriteToChat(ai.ConvertToNormalLine(tbInput.Text) + " [" + tbInput.Text +"]", false);
                WriteToChat(ai.Ask(tbInput.Text), true);
                tbInput.Text = "";
            }
        }
        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnInput_Click(sender, e);
        }

        //Заглушить бота
        private void pbDoomguy_Click(object sender, EventArgs e)
        {
            muted = !muted;
            pbMuted.Visible = muted;
            pnlDialog.Visible = !muted;
        }

        //Переименовать бота
        private void pbDoomName_Click(object sender, EventArgs e)
        {
            Name nm = new Name();
            var result = nm.ShowDialog();
            if (result == DialogResult.OK)
            {
                aiName = nm.GetName;
            }
        }

        //Очистить чат
        private void pbClearLog_Click(object sender, EventArgs e)
        {
            rtbChat.Clear();
        }

        private void rtbChat_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            rtbChat.SelectionStart = rtbChat.Text.Length;
            // scroll it automatically
            rtbChat.ScrollToCaret();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            pnlDialog2.Hide();
            pnlWork.Hide();
            pnlMozg.Show();
            openFile.FileName = "";
            showHelp = true;
            lblFileDescr.Text = "файл не выбран";
            btnRestart.Hide();
        }
    }
}
