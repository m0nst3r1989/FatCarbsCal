namespace Fat_gram_Calculator
{
    partial class Form1
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
            this.convertorButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calFrmFat = new System.Windows.Forms.Label();
            this.calFrmCarbs = new System.Windows.Forms.Label();
            this.carbsGramsText = new System.Windows.Forms.TextBox();
            this.fatGramsText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertorButton
            // 
            this.convertorButton.AccessibleName = "fatCabConvertor";
            this.convertorButton.Location = new System.Drawing.Point(231, 259);
            this.convertorButton.Name = "convertorButton";
            this.convertorButton.Size = new System.Drawing.Size(75, 23);
            this.convertorButton.TabIndex = 0;
            this.convertorButton.Text = "Convert";
            this.convertorButton.UseVisualStyleBackColor = true;
            this.convertorButton.Click += new System.EventHandler(this.Convert_Click);
            // 
            // clearButton
            // 
            this.clearButton.AccessibleName = "numClear";
            this.clearButton.Location = new System.Drawing.Point(381, 259);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Exit
            // 
            this.Exit.AccessibleName = "exit";
            this.Exit.Location = new System.Drawing.Point(531, 259);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AccessibleName = "fatGrams";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fat Grams:";
            // 
            // label2
            // 
            this.label2.AccessibleName = "carbsGram";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Carbs Grams";
            // 
            // calFrmFat
            // 
            this.calFrmFat.AccessibleName = "fatConvertor";
            this.calFrmFat.AutoSize = true;
            this.calFrmFat.Location = new System.Drawing.Point(378, 157);
            this.calFrmFat.Name = "calFrmFat";
            this.calFrmFat.Size = new System.Drawing.Size(0, 20);
            this.calFrmFat.TabIndex = 5;
            // 
            // calFrmCarbs
            // 
            this.calFrmCarbs.AccessibleName = "carbConvertor";
            this.calFrmCarbs.AutoSize = true;
            this.calFrmCarbs.Location = new System.Drawing.Point(378, 203);
            this.calFrmCarbs.Name = "calFrmCarbs";
            this.calFrmCarbs.Size = new System.Drawing.Size(0, 20);
            this.calFrmCarbs.TabIndex = 6;
            // 
            // carbsGramsText
            // 
            this.carbsGramsText.AccessibleName = "carbsGramsText";
            this.carbsGramsText.Location = new System.Drawing.Point(381, 109);
            this.carbsGramsText.Name = "carbsGramsText";
            this.carbsGramsText.Size = new System.Drawing.Size(100, 22);
            this.carbsGramsText.TabIndex = 7;
            // 
            // fatGramsText
            // 
            this.fatGramsText.AccessibleName = "fatGramsText";
            this.fatGramsText.Location = new System.Drawing.Point(381, 62);
            this.fatGramsText.Name = "fatGramsText";
            this.fatGramsText.Size = new System.Drawing.Size(100, 22);
            this.fatGramsText.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Calories from Fat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Calories from Carbs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fatGramsText);
            this.Controls.Add(this.carbsGramsText);
            this.Controls.Add(this.calFrmCarbs);
            this.Controls.Add(this.calFrmFat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertorButton);
            this.Name = "Form1";
            this.Text = "Calories Convertor";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertorButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label calFrmFat;
        private System.Windows.Forms.Label calFrmCarbs;
        private System.Windows.Forms.TextBox carbsGramsText;
        private System.Windows.Forms.TextBox fatGramsText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

