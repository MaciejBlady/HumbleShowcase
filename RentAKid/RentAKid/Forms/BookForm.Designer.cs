namespace RentAKid
{
    partial class BookForm
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
            this.clientIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.childIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookButton = new System.Windows.Forms.Button();
            this.hoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // clientIDNumericUpDown
            // 
            this.clientIDNumericUpDown.Location = new System.Drawing.Point(160, 78);
            this.clientIDNumericUpDown.Name = "clientIDNumericUpDown";
            this.clientIDNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.clientIDNumericUpDown.TabIndex = 0;
            // 
            // childIDNumericUpDown
            // 
            this.childIDNumericUpDown.Location = new System.Drawing.Point(160, 104);
            this.childIDNumericUpDown.Name = "childIDNumericUpDown";
            this.childIDNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.childIDNumericUpDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nr klienta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nr dziecka";
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(160, 208);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(75, 23);
            this.bookButton.TabIndex = 4;
            this.bookButton.Text = "Wypożycz!";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // hoursNumericUpDown
            // 
            this.hoursNumericUpDown.Location = new System.Drawing.Point(160, 160);
            this.hoursNumericUpDown.Name = "hoursNumericUpDown";
            this.hoursNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.hoursNumericUpDown.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Liczba godzin";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 255);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Wróć";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 290);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hoursNumericUpDown);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.childIDNumericUpDown);
            this.Controls.Add(this.clientIDNumericUpDown);
            this.Name = "BookForm";
            this.Text = "BookForm";
            ((System.ComponentModel.ISupportInitialize)(this.clientIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown clientIDNumericUpDown;
        private System.Windows.Forms.NumericUpDown childIDNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.NumericUpDown hoursNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backButton;
    }
}