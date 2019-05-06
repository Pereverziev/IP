namespace WindowsFormsApplication1
{
    partial class ExerciseForm
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
            this.wordButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btTranslate1 = new System.Windows.Forms.Button();
            this.btTranslate2 = new System.Windows.Forms.Button();
            this.btTranslate3 = new System.Windows.Forms.Button();
            this.btTranslate4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wordButton
            // 
            this.wordButton.Location = new System.Drawing.Point(134, 57);
            this.wordButton.Name = "wordButton";
            this.wordButton.Size = new System.Drawing.Size(162, 50);
            this.wordButton.TabIndex = 0;
            this.wordButton.Text = "word";
            this.wordButton.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(260, 338);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(162, 50);
            this.button6.TabIndex = 5;
            this.button6.Text = "OK";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btTranslate1
            // 
            this.btTranslate1.Location = new System.Drawing.Point(363, 57);
            this.btTranslate1.Name = "btTranslate1";
            this.btTranslate1.Size = new System.Drawing.Size(162, 50);
            this.btTranslate1.TabIndex = 1;
            this.btTranslate1.Text = "translate1";
            this.btTranslate1.UseVisualStyleBackColor = true;
            this.btTranslate1.Click += new System.EventHandler(this.btTranslate1_Click);
            // 
            // btTranslate2
            // 
            this.btTranslate2.Location = new System.Drawing.Point(363, 113);
            this.btTranslate2.Name = "btTranslate2";
            this.btTranslate2.Size = new System.Drawing.Size(162, 50);
            this.btTranslate2.TabIndex = 6;
            this.btTranslate2.Text = "translate2";
            this.btTranslate2.UseVisualStyleBackColor = true;
            this.btTranslate2.Click += new System.EventHandler(this.btTranslate2_Click);
            // 
            // btTranslate3
            // 
            this.btTranslate3.Location = new System.Drawing.Point(363, 169);
            this.btTranslate3.Name = "btTranslate3";
            this.btTranslate3.Size = new System.Drawing.Size(162, 50);
            this.btTranslate3.TabIndex = 7;
            this.btTranslate3.Text = "translate3";
            this.btTranslate3.UseVisualStyleBackColor = true;
            this.btTranslate3.Click += new System.EventHandler(this.btTranslate3_Click);
            // 
            // btTranslate4
            // 
            this.btTranslate4.Location = new System.Drawing.Point(363, 225);
            this.btTranslate4.Name = "btTranslate4";
            this.btTranslate4.Size = new System.Drawing.Size(162, 50);
            this.btTranslate4.TabIndex = 8;
            this.btTranslate4.Text = "translate4";
            this.btTranslate4.UseVisualStyleBackColor = true;
            this.btTranslate4.Click += new System.EventHandler(this.btTranslate4_Click);
            // 
            // ExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btTranslate4);
            this.Controls.Add(this.btTranslate3);
            this.Controls.Add(this.btTranslate2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.wordButton);
            this.Controls.Add(this.btTranslate1);
            this.Name = "ExerciseForm";
            this.Text = "ExerciseForm";
            this.Load += new System.EventHandler(this.ExerciseForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wordButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btTranslate1;
        private System.Windows.Forms.Button btTranslate2;
        private System.Windows.Forms.Button btTranslate3;
        private System.Windows.Forms.Button btTranslate4;
    }
}