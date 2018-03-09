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
            this.SuspendLayout();
            // 
            // FirstDate
            // 
            this.FirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FirstDate.Location = new System.Drawing.Point(73, 60);
            this.FirstDate.Name = "FirstDate";
            this.FirstDate.Size = new System.Drawing.Size(85, 20);
            this.FirstDate.TabIndex = 0;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(167, 63);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(20, 13);
            this.ToLabel.TabIndex = 1;
            this.ToLabel.Text = "To";
            // 
            // SecondDate
            // 
            this.SecondDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SecondDate.Location = new System.Drawing.Point(194, 60);
            this.SecondDate.Name = "SecondDate";
            this.SecondDate.Size = new System.Drawing.Size(79, 20);
            this.SecondDate.TabIndex = 2;
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(35, 63);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(30, 13);
            this.FromLabel.TabIndex = 3;
            this.FromLabel.Text = "From";
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Location = new System.Drawing.Point(35, 28);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(210, 13);
            this.SelectLabel.TabIndex = 4;
            this.SelectLabel.Text = "Select the dates to calculate the difference";
            // 
            // DifferenceLabel
            // 
            this.DifferenceLabel.AutoSize = true;
            this.DifferenceLabel.Location = new System.Drawing.Point(35, 102);
            this.DifferenceLabel.Name = "DifferenceLabel";
            this.DifferenceLabel.Size = new System.Drawing.Size(59, 13);
            this.DifferenceLabel.TabIndex = 5;
            this.DifferenceLabel.Text = "Difference:";
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(35, 133);
            this.ResultText.Name = "ResultText";
            this.ResultText.ReadOnly = true;
            this.ResultText.Size = new System.Drawing.Size(238, 20);
            this.ResultText.TabIndex = 6;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(198, 181);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // DateCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 246);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.DifferenceLabel);
            this.Controls.Add(this.SelectLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.SecondDate);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FirstDate);
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
    }
}

