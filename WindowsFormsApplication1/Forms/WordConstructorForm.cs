using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Forms
{
    public partial class WordConstructorForm : Form
    {
        private WordService wordService;
        private TranslationDBService translationDBservice;
        private DBClassesDataContext dataContext;
        private KeyValuePair<String, String> wordToTranslatePair;
        private Translation translationForTestList;
        private Timer timer;
        private bool isClickeable = true;

        string word = "";
        private const int sizeOfButton = 30;
        Button[] buttonArray;
        bool if_word_is_correct = true;
        public static int counter = 0;


        public WordConstructorForm(WordService wordService, DBClassesDataContext dataContext, TranslationDBService translationDBService)
        {
            InitializeComponent();
            this.dataContext = dataContext;
            this.wordService = wordService;
            this.translationDBservice = translationDBService;
            timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += new EventHandler(setClickeable);

            generateWords();
        }

        private void setClickeable(object sender, EventArgs e)
        {
            isClickeable = true;
            counter = 0;
            Array.Clear(buttonArray, 0, buttonArray.Length);
            panel2.Controls.Clear();
            panel1.Controls.Clear();
            generateWords();
            makePanelEnable();
            timer.Enabled = false;
        }
        private void makePanelEnable()
        {
            panel2.BackColor = Color.LightSteelBlue;
        }

        private void generateWords()
        {
            Random random = new Random();
            translationForTestList = translationDBservice.getWordForConstructorTest();
            if (translationForTestList==null) //checking for empty dictionary 
            {
                MessageBox.Show("You don't have words in your dictionary to exercise, please add some.");
                this.Close();
                return;
            }

            labelWordToTranslate.Text = wordService.getWordById(translationForTestList.word_id_1);
            setLettersOnButtons();
        }

        private void setLettersOnButtons()
        {
            string wordOnLettrs = wordService.getWordById(translationForTestList.word_id_2);
            int n = wordOnLettrs.Length;
            this.buttonArray = new Button[n];
            char[] chars = wordOnLettrs.ToCharArray();
            for (int j = 0; j < n; j++)
            {
                Button bt = new Button();
                bt.Click += bt_Click;
                bt.Size = new Size(sizeOfButton, sizeOfButton);
                bt.Location = new Point(j * 30, 1);
                bt.Text = chars[j].ToString();
                bt.Name = chars[j].ToString();
                this.panel1.Controls.Add(bt);
                this.buttonArray[j] = bt;
            }

            for (int j = 0; j < n; j++)
            {
                buttonArray[j].Name = chars[j].ToString();
            }

        }
        void bt_Click(object sender, EventArgs e)
        {
            string wordOnLettrs = wordService.getWordById(translationForTestList.word_id_2);
            Button b = sender as Button;
            this.buttonArray[counter] = b;

            b.Location = new Point(counter * 30, 1);
            b.Enabled = false;
            counter++;
            this.panel2.Controls.Add(b);

        }

        private void checkWord_Click_1(object sender, EventArgs e)
        {
            isClickeable = false;
            timer.Enabled = true;
            string wordOnLettrs = wordService.getWordById(translationForTestList.word_id_2);
            int n = wordOnLettrs.Length;
            char[] chars = wordOnLettrs.ToCharArray();

            for (int i = 0; i < n; i++)
            {
                
                if (chars[i].ToString() != buttonArray[i].Text)
                {
                    panel2.BackColor = Color.Red;
                    if_word_is_correct = false;
                    return;
                }
            }
            if (if_word_is_correct)
            {
                panel2.BackColor = Color.Green;
                translationForTestList.retry_count = (short)(translationForTestList.retry_count + 1);
            }
            //else
                //translationForTestList.retry_count = (short)(translationForTestList.retry_count + 1);

            translationForTestList.last_attempt_timestamp = DateTime.Now;
            translationDBservice.update(translationForTestList);
            if_word_is_correct = true;
        }
    }
}
