
namespace GB_7._2
{
    partial class InputForm
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
            this.txtbxInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxInput
            // 
            this.txtbxInput.Location = new System.Drawing.Point(102, 25);
            this.txtbxInput.Name = "txtbxInput";
            this.txtbxInput.Size = new System.Drawing.Size(100, 20);
            this.txtbxInput.TabIndex = 0;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 28);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(84, 13);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Введите число:";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(102, 63);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "Ввод";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 107);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtbxInput);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnInput;
    }
}