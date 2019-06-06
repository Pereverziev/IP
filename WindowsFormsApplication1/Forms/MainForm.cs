using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using WindowsFormsApplication1;
using WindowsFormsApplication1.Forms;

public partial class MainForm : Form
{
    private LanguageService languageService;
    private WordService wordService;
    private TranslationDBService translationDBservice;
    private TranslationAPIService googleTranslate;
    private ApplicationSettingsService applicationSettingsService; 
    private Google.Cloud.Translation.V2.TranslationClient client;
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
        applicationSettingsService = new ApplicationSettingsService(dataContext);
        titleToShortTitleMap = new Dictionary<String, String>();
        selectLanguageComboBox.SelectedItem = "All"; //default
        insertLanguageComboBox.SelectedItem = "Polish"; //default

        isInternetAccess = checkInternetConnection();
        if (isInternetAccess)
        {
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "C:\\Programming\\IPNew\\IPV\\IP\\Inzenyria_programowania-ce5078cd8d32.json");
            client = Google.Cloud.Translation.V2.TranslationClient.Create();
            googleTranslate = new TranslationAPIService(client);
            foreach (Google.Cloud.Translation.V2.Language language in client.ListLanguages("en"))
            {
                if (languageService.checkIfLanguageExistsInDB(language.Name))
                {
                    insertLanguageComboBox.Items.Add(language.Name);
                    titleToShortTitleMap.Add(language.Name, language.Code);
                }
            }
        }
        else
        {
            MessageBox.Show("Looks like you don't have internet connection, you can't add words, you can only exercise them.");
        }
    }

    private void MainApplicationForm_Shown(object sender, EventArgs e)
    {
        hiLabel.Font = new Font(hiLabel.Font.FontFamily, 20);
        time1Label.Font = new Font(time1Label.Font.FontFamily, 20);
        time2Label.Font = new Font(time2Label.Font.FontFamily, 20);
        wordsCounterLabel1.Font = new Font(wordsCounterLabel1.Font.FontFamily, 20);
        wordsCounterLabel2.Font = new Font(wordsCounterLabel2.Font.FontFamily, 20);
        wordsCounterLabel3.Font = new Font(wordsCounterLabel3.Font.FontFamily, 20);
        mistakeLabel1.Font = new Font(mistakeLabel1.Font.FontFamily, 20);
        mistakeLabel2.Font = new Font(mistakeLabel2.Font.FontFamily, 20);
        mistakeLabel3.Font = new Font(mistakeLabel3.Font.FontFamily, 20);
        label42.Font = new Font(label42.Font.FontFamily, 20);
        checkIfItIsFirstRun();
        initializeLanguageListBox();
        ICollection<Word> wordList = wordService.getAll();
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
            time2Label.Text = "It's your first run";
            wordsCounterLabel2.Text = "0";
            mistakeLabel2.Text = "0";
            applicationSettingsService.createMainRecords();
            NativeLanguageSelectForm languageSelectForm = new NativeLanguageSelectForm(this, titleToShortTitleMap);
            languageSelectForm.ShowDialog();
            nativeLanguage.nativeUserLanguage = true;
            languageService.create(nativeLanguage);
            filterLanguageComboBox.Items.Add(nativeLanguage.title);
        }
        else
        {
            setPropertiesFromDBtoLabels();
            nativeLanguage = languageService.getNativeLanguage();
            foreach (Language language in languageList)
            {
                filterLanguageComboBox.Items.Add(language.title);
                selectLanguageComboBox.Items.Add(language.title);
            }
        }
        applicationSettingsService.setLastVisitTimeToNow();
    }

    private void initializeLanguageListBox()
    {
        foreach(Language lg in languageService.getAll())
        {
            listBoxLanguages.Items.Add(lg.title);
        }
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        if (!isInternetAccess)
        {
            MessageBox.Show("Looks like you don't have internet connection, please try later.");
            return;
        }
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
        t.retry_count = (Int16) applicationSettingsService.getRetryCounter(); 
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
            listBoxLanguages.Items.Add(language.title);
            insertLanguageComboBox.Items.Remove(insertLanguageComboBox.SelectedItem.ToString());
        }
        selectLanguageComboBox.SelectedItem = "Polish"; //default
    }

    private void homeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        tabControl1.SelectedIndex = 0;
        wordsCounterLabel2.Text = applicationSettingsService.getLearnedWordsCounter().ToString();
        mistakeLabel2.Text = applicationSettingsService.getMistakeCounter().ToString();
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

    private void buttonMatch_Click(object sender, EventArgs e)
    {
        List<Translation> translationForTestList = translationDBservice.getWordsForMatchTest();
        if (translationForTestList.Count() < 4)
        {
            MessageBox.Show("You don't have words in your dictionary to exercise, please add some.");
            return;
        }
        ExerciseForm newForm = new ExerciseForm(wordService, dataContext, translationDBservice, applicationSettingsService);
        newForm.Show();
    }

    private void buttonConstruct_Click(object sender, EventArgs e)
    {
        List<Translation> translationForTestList = translationDBservice.getWordsForMatchTest();
        if (translationForTestList.Count() < 1)
        {
            MessageBox.Show("You don't have words in your dictionary to exercise, please add some.");
            return;
        }
        WordConstructorForm newForm = new WordConstructorForm(wordService, dataContext, translationDBservice);
        newForm.Show();
    }

    private String getDifferenceBetweenDays(DateTime dateTime)
    {
        DateTime lastVisitTime = applicationSettingsService.getLastVisitTime();
        int minutesDifference = (lastVisitTime - DateTime.Now).Minutes;
        if (minutesDifference < 1)
        {
            return "1 minute ago";
        } else if (minutesDifference < 60)
        {
            return minutesDifference + "minutes ago";
        } else if (minutesDifference < 1440)
        {
            return minutesDifference / 60 + "hours ago";
        } else
        {
            return minutesDifference / 1440 + "days ago";
        }
    }

    private void setPropertiesFromDBtoLabels()
    {
        String[] response = getDifferenceBetweenDays(applicationSettingsService.getLastVisitTime()).Split(' ');
        time2Label.Text = response[0];
        label42.Text = response[1] + " " + response[2];
        wordsCounterLabel2.Text = applicationSettingsService.getLearnedWordsCounter().ToString();
        mistakeLabel2.Text = applicationSettingsService.getMistakeCounter().ToString();
    }
}

