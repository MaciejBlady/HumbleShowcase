namespace RentAKid
{
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bookChildRB = new System.Windows.Forms.RadioButton();
            this.addChildrenRB = new System.Windows.Forms.RadioButton();
            this.buttonNext = new System.Windows.Forms.Button();
            this.showKidsButton = new System.Windows.Forms.Button();
            this.showBookingsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bookChildRB);
            this.groupBox1.Controls.Add(this.addChildrenRB);
            this.groupBox1.Location = new System.Drawing.Point(134, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz funkcjonalność";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bookChildRB
            // 
            this.bookChildRB.AutoSize = true;
            this.bookChildRB.Location = new System.Drawing.Point(7, 66);
            this.bookChildRB.Name = "bookChildRB";
            this.bookChildRB.Size = new System.Drawing.Size(117, 17);
            this.bookChildRB.TabIndex = 1;
            this.bookChildRB.Text = "Zarezerwuj dziecko";
            this.bookChildRB.UseVisualStyleBackColor = true;
            // 
            // addChildrenRB
            // 
            this.addChildrenRB.AutoSize = true;
            this.addChildrenRB.Checked = true;
            this.addChildrenRB.Location = new System.Drawing.Point(6, 33);
            this.addChildrenRB.Name = "addChildrenRB";
            this.addChildrenRB.Size = new System.Drawing.Size(93, 17);
            this.addChildrenRB.TabIndex = 0;
            this.addChildrenRB.TabStop = true;
            this.addChildrenRB.Text = "Dodaj dziecko";
            this.addChildrenRB.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(430, 249);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Dalej";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // showKidsButton
            // 
            this.showKidsButton.Location = new System.Drawing.Point(12, 207);
            this.showKidsButton.Name = "showKidsButton";
            this.showKidsButton.Size = new System.Drawing.Size(114, 23);
            this.showKidsButton.TabIndex = 2;
            this.showKidsButton.Text = "Pokaż dzieci";
            this.showKidsButton.UseVisualStyleBackColor = true;
            this.showKidsButton.Click += new System.EventHandler(this.showKidsButton_Click);
            // 
            // showBookingsButton
            // 
            this.showBookingsButton.Location = new System.Drawing.Point(12, 249);
            this.showBookingsButton.Name = "showBookingsButton";
            this.showBookingsButton.Size = new System.Drawing.Size(114, 23);
            this.showBookingsButton.TabIndex = 3;
            this.showBookingsButton.Text = "Pokaż wypożyczenia";
            this.showBookingsButton.UseVisualStyleBackColor = true;
            this.showBookingsButton.Click += new System.EventHandler(this.showBookingsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 287);
            this.Controls.Add(this.showBookingsButton);
            this.Controls.Add(this.showKidsButton);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bookChildRB;
        private System.Windows.Forms.RadioButton addChildrenRB;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button showKidsButton;
        private System.Windows.Forms.Button showBookingsButton;
    }
}

