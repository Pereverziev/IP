using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public partial class NativeLanguageSelectForm : Form
{
    private MainForm mainForm;
    private IDictionary<String, String> titleToShortTitleMap;

    public NativeLanguageSelectForm(MainForm mainForm, IDictionary<String, String> titleToShortTitleMap)
    {
        InitializeComponent();
        this.titleToShortTitleMap = titleToShortTitleMap;
        this.mainForm = mainForm;
        String[] languageTitleArray = titleToShortTitleMap.Keys.ToArray();

        for (int a = 0; a != titleToShortTitleMap.Count(); a++)
        {
            comboBox1.Items.Insert(a, languageTitleArray[a]);
        }
        //comboBox1.SelectedIndex = 0; ///default
        comboBox1.SelectedItem = "English";

    }

    private void button1_Click(object sender, EventArgs e)
    {
        Language nativeLanguage = new Language();
        String title = comboBox1.SelectedItem.ToString();
        nativeLanguage.title = title;
        nativeLanguage.shortTitle = titleToShortTitleMap[title];
        mainForm.setNativeLanguage(nativeLanguage);
        this.Close();
    }
}

