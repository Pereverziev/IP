namespace WindowsFormsApplication1.Forms
{
    partial class WordConstructorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordConstructorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelWordToTranslate = new System.Windows.Forms.Label();
            this.checkWord = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(153, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 43);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(153, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 49);
            this.panel2.TabIndex = 0;
            // 
            // labelWordToTranslate
            // 
            this.labelWordToTranslate.AutoSize = true;
            this.labelWordToTranslate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWordToTranslate.Location = new System.Drawing.Point(285, 68);
            this.labelWordToTranslate.Name = "labelWordToTranslate";
            this.labelWordToTranslate.Size = new System.Drawing.Size(173, 18);
            this.labelWordToTranslate.TabIndex = 1;
            this.labelWordToTranslate.Text = "Word To Translate";
            // 
            // checkWord
            // 
            this.checkWord.BackColor = System.Drawing.Color.CornflowerBlue;
            this.checkWord.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkWord.ForeColor = System.Drawing.Color.Transparent;
            this.checkWord.Location = new System.Drawing.Point(153, 309);
            this.checkWord.Name = "checkWord";
            this.checkWord.Size = new System.Drawing.Size(216, 49);
            this.checkWord.TabIndex = 2;
            this.checkWord.Text = "Check";
            this.checkWord.UseVisualStyleBackColor = false;
            this.checkWord.Click += new System.EventHandler(this.checkWord_Click_1);
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonQuit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonQuit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonQuit.Location = new System.Drawing.Point(410, 309);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(201, 50);
            this.buttonQuit.TabIndex = 14;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // WordConstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.checkWord);
            this.Controls.Add(this.labelWordToTranslate);
            this.Controls.Add(this.panel1);
            this.Name = "WordConstructorForm";
            this.Text = "WordConstructorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelWordToTranslate;
        private System.Windows.Forms.Button checkWord;
        private System.Windows.Forms.Button buttonQuit;
    }
}