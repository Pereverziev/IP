using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1;

public partial class ExerciseForm : Form
    {
        private WordService wordService;
        private TranslationDBService translationDBservice;
        private DBClassesDataContext dataContext;
        private ApplicationSettingsService applicationSettingsService;
        private KeyValuePair<String, String> wordToTranslatePair;
        private Translation rightTranslation;
        private Timer timer;
        private bool isClickeable = true;

        public ExerciseForm(WordService wordService, DBClassesDataContext dataContext, TranslationDBService translationDBService, ApplicationSettingsService applicationSettingsService)
        {
            InitializeComponent();

            this.applicationSettingsService = applicationSettingsService;
            this.dataContext = dataContext;
            this.wordService = wordService;
            this.translationDBservice = translationDBService;
            timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += new EventHandler(setClickeable);

            generateWords();
        }

        private void checkWord(Button clickedButton)
        {
            setProperColorsOnButtons();
            isClickeable = false;
            timer.Enabled = true;
            if (clickedButton.Text == wordToTranslatePair.Value)
            {
                rightTranslation.retry_count = (short)(rightTranslation.retry_count - 1);
                
            } else
            {
                rightTranslation.retry_count = (short)(rightTranslation.retry_count + 1);
                applicationSettingsService.incrementMistakeCounterByOne();
            }
            rightTranslation.last_attempt_timestamp = DateTime.Now;
            translationDBservice.update(rightTranslation);
        }

        private void generateWords()
        {
            Random random = new Random();
            List<Translation> translationForTestList = translationDBservice.getWordsForMatchTest();
            if (translationForTestList.Count() < 4)
            {
                MessageBox.Show("You don't have words in your dictionary to exercise, please add some.");
                this.Close();
                return;
            } 
            IDictionary<String, String> wordsDictionary = new Dictionary<String, String>();
            foreach (Translation t in translationForTestList)
            {
                String word1 = dataContext.Words.Where(word => word.Id == t.word_id_1).First().word1;
                String word2 = dataContext.Words.Where(word => word.Id == t.word_id_2).First().word1;
                wordsDictionary.Add(word1, word2);
            }
            Translation randomTranslation = translationForTestList.ElementAt(random.Next(0, 4));
            while (rightTranslation != null && randomTranslation.word_id_1 == rightTranslation.word_id_1 && randomTranslation.word_id_2 == rightTranslation.word_id_2)
            {
                randomTranslation = translationForTestList.ElementAt(random.Next(0, 4));
            }
            rightTranslation = randomTranslation;
            wordToTranslatePair = new KeyValuePair<String, String>(wordService.getWordById(rightTranslation.word_id_1), wordService.getWordById(rightTranslation.word_id_2));
            labelWordToTranslate.Text = wordService.getWordById(rightTranslation.word_id_1);
            setWordsOnButtons(wordsDictionary);
        }

        private void btTranslate1_Click_1(object sender, EventArgs e)
        {
            if (isClickeable)
            {
                checkWord(sender as Button);
            }
        }

        private void btTranslate2_Click(object sender, EventArgs e)
        {
            if (isClickeable)
            {
                checkWord(sender as Button);
            }
    }

        private void btTranslate3_Click(object sender, EventArgs e)
        {
            if (isClickeable)
            {
                checkWord(sender as Button);
            }
    }

        private void btTranslate4_Click(object sender, EventArgs e)
        {
            if (isClickeable)
            {
                checkWord(sender as Button);
            }
    }

        private void buttonQuit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setWordsOnButtons(IDictionary<String,String> wordsMap) 
        {
            btTranslate1.Text = wordsMap.ElementAt(0).Value;
            btTranslate2.Text = wordsMap.ElementAt(1).Value;
            btTranslate3.Text = wordsMap.ElementAt(2).Value;
            btTranslate4.Text = wordsMap.ElementAt(3).Value;
        }

        private void setClickeable(object sender, EventArgs e)
        {
            isClickeable = true;
            generateWords();
            makeButtonsWhite();
            timer.Enabled = false;
        }

        private void makeButtonsWhite()
        {
            btTranslate1.ForeColor = Color.Black;
            btTranslate2.ForeColor = Color.Black;
            btTranslate3.ForeColor = Color.Black;
            btTranslate4.ForeColor = Color.Black;
        }

        private void setProperColorsOnButtons()
        {
            if (btTranslate1.Text == wordToTranslatePair.Value)
            {
                btTranslate1.ForeColor = Color.Green;
            } else
            {
                //btTranslate1.BackColor = Color.Red;
                btTranslate1.ForeColor = Color.Red;
        }
            if (btTranslate2.Text == wordToTranslatePair.Value)
            {
                btTranslate2.ForeColor = Color.Green;
            }
            else
            {
                //btTranslate2.BackColor = Color.Red;
                btTranslate2.ForeColor = Color.Red;
        }
            if (btTranslate3.Text == wordToTranslatePair.Value)
            {
                btTranslate3.ForeColor = Color.Green;
            }
            else
            {
                btTranslate3.ForeColor = Color.Red;
        }
            if (btTranslate4.Text == wordToTranslatePair.Value)
            {   
                btTranslate4.ForeColor = Color.Green;
            }
            else
            {
                btTranslate4.ForeColor = Color.Red;
        }
    }

}

