using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ExerciseForm : Form
    {
        private WordService wordService;
        private TranslationDBService translationDBservice;
        private IDictionary<int, int> exerciseDict = new Dictionary<int, int>();

        private DBClassesDataContext dataContext;
        Button[] b;
        public ExerciseForm()
        {
            InitializeComponent();

            dataContext = new DBClassesDataContext();
            wordService = new WordService(dataContext);
            translationDBservice = new TranslationDBService(dataContext);

            generating_words(4);
        }

        private void checkWord(string s)
        {
            //string word1 = wordButton.Text;
            int idWordButton = wordService.getIdByWord((string)wordButton.Text);
            int idTranslateButton = wordService.getIdByWord(s);
            int idWordButton_T = translationDBservice.getIdTByWord(idWordButton);
            int idTranslateButton_T = translationDBservice.getIdTByWord(idTranslateButton);
            if (idWordButton_T == idTranslateButton_T)
            {
                MessageBox.Show("Right word!!!!");
                exerciseDict.Add(idTranslateButton_T, translationDBservice.getRetryCountTByID(idTranslateButton_T)+1);
            }
            else
            {
                exerciseDict.Add(idTranslateButton_T, translationDBservice.getRetryCountTByID(idTranslateButton_T)-1);
                exerciseDict.Add(idWordButton_T, translationDBservice.getRetryCountTByID(idWordButton_T)-1);

            }

        }

        private void ExerciseForm_Load(object sender, EventArgs e)
        {

        }
        private void generating_words(int words_count)
        {
            this.b = new Button[words_count];
            //Translation t in translationDBservice.getAll()
            /*for (int j = translationDBservice.getRecordsForExercise[]; j < words_count; j++)
            {
                Button bt = new Button();
                //bt.Click += bt_Click;
                bt.Size = new Size(160, 50);
                bt.Location = new Point(1, j * 50);
                this.panel1.Controls.Add(bt);
                this.b[j] = bt;
            }*/



           
          int j = 0;

            //List<Translation> words = new List<Translation>();
            //words = translationDBservice.getRecordsForExercise(4).ToList();
            List<string> words = new List<string>();
            String word1 = "";
            //numbers.Insert(0, 666);
            /*for(int i = 0; i<4; i++) придумать как рандомно выводить на кнопки
            {

            }
            words.Sort()
            words.Reverse()*/
            foreach (Translation t in translationDBservice.getRecordsForExercise(4)) ///получение списка слов для вывода на баттн, записать в лист
            {
                String word2 = wordService.getWordById((int)t.word_id_2);
                words.Add(word2);

                word1 = wordService.getWordById((int)t.word_id_1);
                

                /*Button bt = new Button();
                //bt.Click += bt_Click;
                bt.Size = new Size(160, 50);
                bt.Location = new Point(1, j * 50);

                String word1 = wordService.getWordById((int)t.word_id_1);
                wordButton.Text = word1;


                String word2 = wordService.getWordById((int)t.word_id_2);
                bt.Text= word2;
                this.panel1.Controls.Add(bt);
                this.b[j] = bt;
                j++;
                //bt.Items.Add(word2);*/
            }
            wordButton.Text = word1;
            btTranslate1.Text = words[0];
            btTranslate2.Text = words[1];
            btTranslate3.Text = words[2];
            btTranslate4.Text = words[3];

        }

        private void btTranslate1_Click(object sender, EventArgs e)
        {
            checkWord(btTranslate1.Text);
        }

        private void btTranslate2_Click(object sender, EventArgs e)
        {
            checkWord(btTranslate2.Text);
        }

        private void btTranslate3_Click(object sender, EventArgs e)
        {
            checkWord(btTranslate3.Text);
        }

        private void btTranslate4_Click(object sender, EventArgs e)
        {
            checkWord(btTranslate4.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Translation t = new Translation();
            foreach (KeyValuePair<int, int> i in exerciseDict)
            {
                t.Id = i.Key;
                t.retry_count = (short)i.Value;
                translationDBservice.update(t);
            }
            
            ///вызов generating;
            
        }
    }
}
