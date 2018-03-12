namespace DifferenceBetweenDates
{
    partial class DateCalculation
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
            this.FirstDate = new System.Windows.Forms.DateTimePicker();
            this.ToLabel = new System.Windows.Forms.Label();
            this.SecondDate = new System.Windows.Forms.DateTimePicker();
            this.FromLabel = new System.Windows.Forms.Label();
            this.SelectLabel = new System.Windows.Forms.Label();
            this.DifferenceLabel = new System.Windows.Forms.Label();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstDate
            // 
            this.FirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FirstDate.Location = new System.Drawing.Point(97, 74);
            this.FirstDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FirstDate.Name = "FirstDate";
            this.FirstDate.Size = new System.Drawing.Size(112, 22);
            this.FirstDate.TabIndex = 0;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(223, 78);
            this.ToLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(25, 17);
            this.ToLabel.TabIndex = 1;
            this.ToLabel.Text = "To";
            // 
            // SecondDate
            // 
            this.SecondDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SecondDate.Location = new System.Drawing.Point(259, 74);
            this.SecondDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SecondDate.Name = "SecondDate";
            this.SecondDate.Size = new System.Drawing.Size(104, 22);
            this.SecondDate.TabIndex = 2;
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(47, 78);
            this.FromLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(40, 17);
            this.FromLabel.TabIndex = 3;
            this.FromLabel.Text = "From";
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Location = new System.Drawing.Point(47, 34);
            this.SelectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(277, 17);
            this.SelectLabel.TabIndex = 4;
            this.SelectLabel.Text = "Select the dates to calculate the difference";
            // 
            // DifferenceLabel
            // 
            this.DifferenceLabel.AutoSize = true;
            this.DifferenceLabel.Location = new System.Drawing.Point(47, 126);
            this.DifferenceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DifferenceLabel.Name = "DifferenceLabel";
            this.DifferenceLabel.Size = new System.Drawing.Size(77, 17);
            this.DifferenceLabel.TabIndex = 5;
            this.DifferenceLabel.Text = "Difference:";
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(47, 164);
            this.ResultText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultText.Name = "ResultText";
            this.ResultText.ReadOnly = true;
            this.ResultText.Size = new System.Drawing.Size(316, 22);
            this.ResultText.TabIndex = 6;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(264, 223);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(100, 28);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.InformationLabel.Location = new System.Drawing.Point(47, 274);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(299, 17);
            this.InformationLabel.TabIndex = 8;
            this.InformationLabel.Text = "*Dates needs to be on format Month Day Year";
            // 
            // DateCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 329);
            this.Controls.Add(this.InformationLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.DifferenceLabel);
            this.Controls.Add(this.SelectLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.SecondDate);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FirstDate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DateCalculation";
            this.Text = "Date Calculation";
            this.Load += new System.EventHandler(this.DateCalculation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FirstDate;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.DateTimePicker SecondDate;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label SelectLabel;
        private System.Windows.Forms.Label DifferenceLabel;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label InformationLabel;
    }
}

