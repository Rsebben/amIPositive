
namespace amIPositive
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
            this.inputAInteger = new System.Windows.Forms.Label();
            this.intergerInput = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.positiveOrNegative = new System.Windows.Forms.Label();
            this.divisible = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputAInteger
            // 
            this.inputAInteger.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAInteger.Location = new System.Drawing.Point(164, 94);
            this.inputAInteger.Name = "inputAInteger";
            this.inputAInteger.Size = new System.Drawing.Size(129, 35);
            this.inputAInteger.TabIndex = 0;
            this.inputAInteger.Text = "Input an interger";
            // 
            // intergerInput
            // 
            this.intergerInput.Location = new System.Drawing.Point(334, 94);
            this.intergerInput.Name = "intergerInput";
            this.intergerInput.Size = new System.Drawing.Size(70, 22);
            this.intergerInput.TabIndex = 1;
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(334, 144);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(70, 60);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // positiveOrNegative
            // 
            this.positiveOrNegative.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positiveOrNegative.Location = new System.Drawing.Point(168, 321);
            this.positiveOrNegative.Name = "positiveOrNegative";
            this.positiveOrNegative.Size = new System.Drawing.Size(193, 23);
            this.positiveOrNegative.TabIndex = 3;
            // 
            // divisible
            // 
            this.divisible.Location = new System.Drawing.Point(171, 375);
            this.divisible.Name = "divisible";
            this.divisible.Size = new System.Drawing.Size(190, 23);
            this.divisible.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.divisible);
            this.Controls.Add(this.positiveOrNegative);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.intergerInput);
            this.Controls.Add(this.inputAInteger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputAInteger;
        private System.Windows.Forms.TextBox intergerInput;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label positiveOrNegative;
        private System.Windows.Forms.Label divisible;
    }
}

