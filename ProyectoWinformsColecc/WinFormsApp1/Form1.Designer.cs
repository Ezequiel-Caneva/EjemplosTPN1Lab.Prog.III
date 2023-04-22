namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGenerar = new Button();
            btnRemover = new Button();
            panelNum = new Panel();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.PaleGreen;
            btnGenerar.Location = new Point(81, 48);
            btnGenerar.Margin = new Padding(4, 5, 4, 5);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(223, 63);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Gerenerar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += BtnGenerar;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(192, 64, 0);
            btnRemover.Location = new Point(370, 48);
            btnRemover.Margin = new Padding(4, 5, 4, 5);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(189, 63);
            btnRemover.TabIndex = 1;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += BtnRemover;
            // 
            // panelCalc
            // 
            panelNum.BackColor = SystemColors.ActiveCaption;
            panelNum.Location = new Point(17, 122);
            panelNum.Margin = new Padding(4, 5, 4, 5);
            panelNum.Name = "panelCalc";
            panelNum.Size = new Size(1014, 521);
            panelNum.TabIndex = 2;
            panelNum.Paint += panelCalc_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(panelNum);
            Controls.Add(btnRemover);
            Controls.Add(btnGenerar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnGenerar;
        private Button btnRemover;
        private Panel panelNum;
    }
}