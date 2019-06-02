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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelWordToTranslate = new System.Windows.Forms.Label();
            this.checkWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(186, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 75);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(186, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 42);
            this.panel2.TabIndex = 0;
            // 
            // labelWordToTranslate
            // 
            this.labelWordToTranslate.AutoSize = true;
            this.labelWordToTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWordToTranslate.Location = new System.Drawing.Point(339, 76);
            this.labelWordToTranslate.Name = "labelWordToTranslate";
            this.labelWordToTranslate.Size = new System.Drawing.Size(52, 24);
            this.labelWordToTranslate.TabIndex = 1;
            this.labelWordToTranslate.Text = "word";
            // 
            // checkWord
            // 
            this.checkWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkWord.Location = new System.Drawing.Point(321, 330);
            this.checkWord.Name = "checkWord";
            this.checkWord.Size = new System.Drawing.Size(152, 49);
            this.checkWord.TabIndex = 2;
            this.checkWord.Text = "OK";
            this.checkWord.UseVisualStyleBackColor = true;
            this.checkWord.Click += new System.EventHandler(this.checkWord_Click_1);
            // 
            // WordConstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}