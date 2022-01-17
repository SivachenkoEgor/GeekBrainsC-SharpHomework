
namespace GB_7._1
{
    partial class Game
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
            this.btnIncrement = new System.Windows.Forms.Button();
            this.btnMultiByTwo = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblTextForCurrentValue = new System.Windows.Forms.Label();
            this.lblTextForInputCounter = new System.Windows.Forms.Label();
            this.lblInputCount = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIncrement
            // 
            this.btnIncrement.Location = new System.Drawing.Point(250, 16);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(75, 23);
            this.btnIncrement.TabIndex = 0;
            this.btnIncrement.Text = "+1";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // btnMultiByTwo
            // 
            this.btnMultiByTwo.Location = new System.Drawing.Point(250, 72);
            this.btnMultiByTwo.Name = "btnMultiByTwo";
            this.btnMultiByTwo.Size = new System.Drawing.Size(75, 23);
            this.btnMultiByTwo.TabIndex = 1;
            this.btnMultiByTwo.Text = "x2";
            this.btnMultiByTwo.UseVisualStyleBackColor = true;
            this.btnMultiByTwo.Click += new System.EventHandler(this.btnMultiByTwo_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(250, 140);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(91, 21);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(13, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "0";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTextForCurrentValue
            // 
            this.lblTextForCurrentValue.AutoSize = true;
            this.lblTextForCurrentValue.Location = new System.Drawing.Point(12, 21);
            this.lblTextForCurrentValue.Name = "lblTextForCurrentValue";
            this.lblTextForCurrentValue.Size = new System.Drawing.Size(73, 13);
            this.lblTextForCurrentValue.TabIndex = 4;
            this.lblTextForCurrentValue.Text = "Current value:";
            // 
            // lblTextForInputCounter
            // 
            this.lblTextForInputCounter.AutoSize = true;
            this.lblTextForInputCounter.Location = new System.Drawing.Point(13, 72);
            this.lblTextForInputCounter.Name = "lblTextForInputCounter";
            this.lblTextForInputCounter.Size = new System.Drawing.Size(64, 13);
            this.lblTextForInputCounter.TabIndex = 5;
            this.lblTextForInputCounter.Text = "Input count:";
            // 
            // lblInputCount
            // 
            this.lblInputCount.AutoSize = true;
            this.lblInputCount.Location = new System.Drawing.Point(91, 72);
            this.lblInputCount.Name = "lblInputCount";
            this.lblInputCount.Size = new System.Drawing.Size(13, 13);
            this.lblInputCount.TabIndex = 6;
            this.lblInputCount.Text = "0";
            this.lblInputCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(250, 190);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 7;
            this.btnUndo.Text = "button1";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 311);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.lblInputCount);
            this.Controls.Add(this.lblTextForInputCounter);
            this.Controls.Add(this.lblTextForCurrentValue);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMultiByTwo);
            this.Controls.Add(this.btnIncrement);
            this.Name = "Game";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Button btnMultiByTwo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblTextForCurrentValue;
        private System.Windows.Forms.Label lblTextForInputCounter;
        private System.Windows.Forms.Label lblInputCount;
        private System.Windows.Forms.Button btnUndo;
    }
}

