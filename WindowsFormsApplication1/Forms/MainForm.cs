﻿using Google.Cloud.Translation.V2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using WindowsFormsApplication1;

public partial class MainForm : Form
{
    private LanguageService languageService;
    private WordService wordService;
    private TranslationDBService translationDBservice;
    private TranslationAPIService googleTranslate;
    private TranslationClient client;
    private DBClassesDataContext dataContext;
    private Language nativeLanguage;
    private IDictionary<String, String> titleToShortTitleMap;
    private bool isInternetAccess;

    public MainForm()
    {
        InitializeComponent();
        dataContext = new DBClassesDataContext();
        languageService = new LanguageService(dataContext);
        wordService = new WordService(dataContext);
        translationDBservice = new TranslationDBService(dataContext);
        titleToShortTitleMap = new Dictionary<String, String>();
        selectLanguageComboBox.SelectedItem = "All"; //default
        insertLanguageComboBox.SelectedItem = "Polish"; //default

        isInternetAccess = checkInternetConnection();
        if (isInternetAccess)
        {
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "C:\\Users\\julia\\Desktop\\git\\IP\\Inzenyria_programowania-ce5078cd8d32.json");
            client = TranslationClient.Create();
            googleTranslate = new TranslationAPIService(client);
            foreach (Google.Cloud.Translation.V2.Language language in client.ListLanguages("en"))
            {
                insertLanguageComboBox.Items.Add(language.Name);
                titleToShortTitleMap.Add(language.Name, language.Code);
            }
        }
        else
        {
            MessageBox.Show("Looks like you don't have internet connection, you can't add words, you can only exercise them.");
        }
    }

    private void MainApplicationForm_Shown(object sender, EventArgs e)
    {
        checkIfItIsFirstRun();
        ICollection<Word> wordList = wordService.getAll();
        /*foreach(Word w in wordList)
        {
            wordsFromDictionary.Items.Add(w.word1);
            //wordsFromDictionary.Items.Add(word1 + " — " + word2);
        }*/
        foreach (Translation t in translationDBservice.getAll())
        {
            String word1 = wordService.getWordById((int)t.word_id_1);
            String word2 = wordService.getWordById((int)t.word_id_2);
            wordsFromDictionary.Items.Add(word1 + " — " + word2);
        }
    }

    private void checkIfItIsFirstRun()
    {
        ICollection<Language> languageList = languageService.getAll();
        
        if (languageList.Count() == 0)
        {
            NativeLanguageSelectForm languageSelectForm = new NativeLanguageSelectForm(this, titleToShortTitleMap);
            languageSelectForm.ShowDialog();
            nativeLanguage.nativeUserLanguage = true;
            languageService.create(nativeLanguage);
            filterLanguageComboBox.Items.Add(nativeLanguage.title);
        }
        else
        {
            nativeLanguage = languageService.getNativeLanguage();
            foreach (Language language in languageList)
            {
                filterLanguageComboBox.Items.Add(language.title);
                selectLanguageComboBox.Items.Add(language.title);
            }
        }
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        //AddButton.ForeColor = Color.Gold;
        String translatedWordString = googleTranslate.translateWord(insertWordTextBox.Text, nativeLanguage.shortTitle);
        if (translatedWordString.Equals(insertWordTextBox.Text))
        {
            MessageBox.Show("Looks like you've inserted wrong word, please add another word.");
            return;
        }
        Word wordToTranslate = new Word();
        wordToTranslate.word1 = insertWordTextBox.Text;
        wordToTranslate.language_id = languageService.getIdByTitle(selectLanguageComboBox.SelectedItem.ToString());

        Word translatedWord = new Word();
        translatedWord.word1 = googleTranslate.translateWord(wordToTranslate.word1, nativeLanguage.shortTitle);
        translatedWord.language_id = nativeLanguage.Id;

        if (!wordService.checkIfWordsExistInDb(wordToTranslate.word1, translatedWord.word1))
        {
            MessageBox.Show("Looks like you already have the same word in your dictionary, please add another word.");
            return;
        }
        wordsFromDictionary.Items.Add(wordToTranslate.word1+" — "+ translatedWord.word1);
        wordService.batchCreate(new List<Word> { wordToTranslate, translatedWord });
        Translation t = new Translation();
        t.word_id_1 = wordToTranslate.Id;
        t.word_id_2 = translatedWord.Id;
        translationDBservice.create(t);
    }

    public void setNativeLanguage(Language language)
    {
        this.nativeLanguage = language;
    }

    private void AddLanguageButton_Click(object sender, EventArgs e)
    {
        if (insertLanguageComboBox.SelectedItem != null)
        {
            String selectedLanguage = insertLanguageComboBox.SelectedItem.ToString();
            if (!languageService.checkIfLanguageExistsInDB(selectedLanguage))
            {
                MessageBox.Show("Look's like you already have that language in DB, please add another language.");
                return;
            }
            Language language = new Language();
            language.title = insertLanguageComboBox.SelectedItem.ToString();
            language.shortTitle = titleToShortTitleMap[language.title];
            languageService.create(language);
            selectLanguageComboBox.Items.Add(language.title);
            filterLanguageComboBox.Items.Add(language.title);
        }
        selectLanguageComboBox.SelectedItem = "Polish"; //default
    }

    private void homeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        tabControl1.SelectedIndex = 0;
    }

    private void dictionaryToolStripMenuItem_Click(object sender, EventArgs e)
    {
        tabControl1.SelectedIndex = 1;
    }

    private void exercisesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        tabControl1.SelectedIndex = 2;
    }

    private void languagesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        tabControl1.SelectedIndex = 3;
    }

    private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        tabControl1.SelectedIndex = 4;
    }

    private void filterLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        wordsFromDictionary.Items.Clear();
        String selectedLanguage = filterLanguageComboBox.SelectedItem.ToString();
        if (selectedLanguage.Equals("All"))
        {
            foreach (Translation t in translationDBservice.getAll())
            {
                String word1 = wordService.getWordById((int)t.word_id_1);
                String word2 = wordService.getWordById((int)t.word_id_2);
                wordsFromDictionary.Items.Add(word1 + " — " + word2);
            }
        }
        else
        {
            ICollection<Word> wordCollection = wordService.getWordsByLanguageId(languageService.getIdByTitle(filterLanguageComboBox.SelectedItem.ToString()));
            foreach (Word w in wordCollection)
            {
                wordsFromDictionary.Items.Add(w.word1);
            }
        }
    }
    private bool checkInternetConnection()
    {
        try
        {
            Ping myPing = new Ping();
            String host = "google.com";
            byte[] buffer = new byte[32];
            int timeout = 1000;
            PingOptions pingOptions = new PingOptions();
            PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
            return (reply.Status == IPStatus.Success);
        }
        catch (Exception)
        {
            return false;
        }
    }

    private void insertWordTextBox_Click(object sender, EventArgs e)
    {
        insertWordTextBox.Clear();
        insertWordTextBox.ForeColor = Color.Black;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        ExerciseForm newForm = new ExerciseForm();
        newForm.Show();
    }
}

