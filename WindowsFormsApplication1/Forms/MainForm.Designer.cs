
partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.Dictionary = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wordsFromDictionary = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.insertWordTextBox = new System.Windows.Forms.TextBox();
            this.Exercises = new System.Windows.Forms.TabPage();
            this.Languages = new System.Windows.Forms.TabPage();
            this.AddLanguageButton = new System.Windows.Forms.Button();
            this.insertLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.Options = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Dictionary.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Exercises.SuspendLayout();
            this.Languages.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.Dictionary);
            this.tabControl1.Controls.Add(this.Exercises);
            this.tabControl1.Controls.Add(this.Languages);
            this.tabControl1.Controls.Add(this.Options);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.ItemSize = new System.Drawing.Size(132, 5);
            this.tabControl1.Location = new System.Drawing.Point(0, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 403);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 4;
            // 
            // Home
            // 
            this.Home.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Home.Location = new System.Drawing.Point(4, 9);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(636, 390);
            this.Home.TabIndex = 4;
            this.Home.UseVisualStyleBackColor = true;
            // 
            // Dictionary
            // 
            this.Dictionary.BackColor = System.Drawing.Color.Transparent;
            this.Dictionary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dictionary.Controls.Add(this.panel2);
            this.Dictionary.Controls.Add(this.panel1);
            this.Dictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dictionary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dictionary.Location = new System.Drawing.Point(4, 9);
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.Padding = new System.Windows.Forms.Padding(3);
            this.Dictionary.Size = new System.Drawing.Size(636, 390);
            this.Dictionary.TabIndex = 0;
            this.Dictionary.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.wordsFromDictionary);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 262);
            this.panel2.TabIndex = 1;
            // 
            // wordsFromDictionary
            // 
            this.wordsFromDictionary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wordsFromDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordsFromDictionary.FormattingEnabled = true;
            this.wordsFromDictionary.ItemHeight = 16;
            this.wordsFromDictionary.Location = new System.Drawing.Point(0, 0);
            this.wordsFromDictionary.Name = "wordsFromDictionary";
            this.wordsFromDictionary.Size = new System.Drawing.Size(628, 262);
            this.wordsFromDictionary.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.filterLanguageComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.selectLanguageComboBox);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.insertWordTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 120);
            this.panel1.TabIndex = 0;
            // 
            // filterLanguageComboBox
            // 
            this.filterLanguageComboBox.FormattingEnabled = true;
            this.filterLanguageComboBox.Items.AddRange(new object[] {
            "All"});
            this.filterLanguageComboBox.Location = new System.Drawing.Point(243, 81);
            this.filterLanguageComboBox.Name = "filterLanguageComboBox";
            this.filterLanguageComboBox.Size = new System.Drawing.Size(121, 24);
            this.filterLanguageComboBox.TabIndex = 6;
            this.filterLanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.filterLanguageComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Show words from language(s):";
            // 
            // selectLanguageComboBox
            // 
            this.selectLanguageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectLanguageComboBox.FormattingEnabled = true;
            this.selectLanguageComboBox.Location = new System.Drawing.Point(226, 41);
            this.selectLanguageComboBox.Name = "selectLanguageComboBox";
            this.selectLanguageComboBox.Size = new System.Drawing.Size(152, 24);
            this.selectLanguageComboBox.TabIndex = 4;
            this.selectLanguageComboBox.Text = "Choose Language";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddButton.Location = new System.Drawing.Point(402, 38);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(134, 27);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // insertWordTextBox
            // 
            this.insertWordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertWordTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.insertWordTextBox.Location = new System.Drawing.Point(25, 43);
            this.insertWordTextBox.Name = "insertWordTextBox";
            this.insertWordTextBox.Size = new System.Drawing.Size(185, 22);
            this.insertWordTextBox.TabIndex = 0;
            this.insertWordTextBox.Text = "Type here word to insert";
            this.insertWordTextBox.Click += new System.EventHandler(this.insertWordTextBox_Click);
            // 
            // Exercises
            // 
            this.Exercises.Controls.Add(this.button2);
            this.Exercises.Controls.Add(this.button1);
            this.Exercises.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exercises.Location = new System.Drawing.Point(4, 9);
            this.Exercises.Name = "Exercises";
            this.Exercises.Padding = new System.Windows.Forms.Padding(3);
            this.Exercises.Size = new System.Drawing.Size(636, 390);
            this.Exercises.TabIndex = 1;
            this.Exercises.UseVisualStyleBackColor = true;
            // 
            // Languages
            // 
            this.Languages.Controls.Add(this.AddLanguageButton);
            this.Languages.Controls.Add(this.insertLanguageComboBox);
            this.Languages.Location = new System.Drawing.Point(4, 9);
            this.Languages.Name = "Languages";
            this.Languages.Size = new System.Drawing.Size(636, 390);
            this.Languages.TabIndex = 3;
            this.Languages.UseVisualStyleBackColor = true;
            // 
            // AddLanguageButton
            // 
            this.AddLanguageButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AddLanguageButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddLanguageButton.Location = new System.Drawing.Point(208, 44);
            this.AddLanguageButton.Name = "AddLanguageButton";
            this.AddLanguageButton.Size = new System.Drawing.Size(174, 28);
            this.AddLanguageButton.TabIndex = 1;
            this.AddLanguageButton.Text = "Add language";
            this.AddLanguageButton.UseVisualStyleBackColor = false;
            this.AddLanguageButton.Click += new System.EventHandler(this.AddLanguageButton_Click);
            // 
            // insertLanguageComboBox
            // 
            this.insertLanguageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertLanguageComboBox.FormattingEnabled = true;
            this.insertLanguageComboBox.Location = new System.Drawing.Point(208, 78);
            this.insertLanguageComboBox.Name = "insertLanguageComboBox";
            this.insertLanguageComboBox.Size = new System.Drawing.Size(174, 24);
            this.insertLanguageComboBox.TabIndex = 0;
            // 
            // Options
            // 
            this.Options.Location = new System.Drawing.Point(4, 9);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(636, 390);
            this.Options.TabIndex = 2;
            this.Options.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.dictionaryToolStripMenuItem,
            this.exercisesToolStripMenuItem,
            this.languagesToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 78);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.AutoSize = false;
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.homeToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.home_icon_silhouette_1_;
            this.homeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(132, 70);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // dictionaryToolStripMenuItem
            // 
            this.dictionaryToolStripMenuItem.AutoSize = false;
            this.dictionaryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dictionaryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.dictionaryToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.book;
            this.dictionaryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dictionaryToolStripMenuItem.Name = "dictionaryToolStripMenuItem";
            this.dictionaryToolStripMenuItem.ShowShortcutKeys = false;
            this.dictionaryToolStripMenuItem.Size = new System.Drawing.Size(122, 70);
            this.dictionaryToolStripMenuItem.Text = "Dictionary";
            this.dictionaryToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.dictionaryToolStripMenuItem.Click += new System.EventHandler(this.dictionaryToolStripMenuItem_Click);
            // 
            // exercisesToolStripMenuItem
            // 
            this.exercisesToolStripMenuItem.AutoSize = false;
            this.exercisesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exercisesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.exercisesToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.barbell;
            this.exercisesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exercisesToolStripMenuItem.Name = "exercisesToolStripMenuItem";
            this.exercisesToolStripMenuItem.Size = new System.Drawing.Size(132, 70);
            this.exercisesToolStripMenuItem.Text = "Exercises";
            this.exercisesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.exercisesToolStripMenuItem.Click += new System.EventHandler(this.exercisesToolStripMenuItem_Click);
            // 
            // languagesToolStripMenuItem
            // 
            this.languagesToolStripMenuItem.AutoSize = false;
            this.languagesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.languagesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.languagesToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.language_1_;
            this.languagesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.languagesToolStripMenuItem.Name = "languagesToolStripMenuItem";
            this.languagesToolStripMenuItem.Size = new System.Drawing.Size(120, 70);
            this.languagesToolStripMenuItem.Text = "Languages";
            this.languagesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.languagesToolStripMenuItem.Click += new System.EventHandler(this.languagesToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.AutoSize = false;
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.optionsToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.screwdriver_and_wrench_crossed;
            this.optionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(120, 70);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 118);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 118);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 481);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Application";
            this.Shown += new System.EventHandler(this.MainApplicationForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.Dictionary.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Exercises.ResumeLayout(false);
            this.Languages.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage Dictionary;
    private System.Windows.Forms.TabPage Exercises;
    private System.Windows.Forms.TabPage Options;
    private System.Windows.Forms.TabPage Languages;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.ListBox wordsFromDictionary;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox insertWordTextBox;
    private System.Windows.Forms.Button AddButton;
    private System.Windows.Forms.ComboBox selectLanguageComboBox;
    private System.Windows.Forms.Button AddLanguageButton;
    private System.Windows.Forms.ComboBox insertLanguageComboBox;
    private System.Windows.Forms.TabPage Home;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem dictionaryToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exercisesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem languagesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox filterLanguageComboBox;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
}
