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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtn = new TextBox();
            txtm = new TextBox();
            dgvMass = new DataGridView();
            cmdStart = new Button();
            cmdExit = new Button();
            txtRez = new TextBox();
            cmdClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMass).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 30);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 0;
            label1.Text = "количество строк n=";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 120);
            label2.Name = "label2";
            label2.Size = new Size(184, 20);
            label2.TabIndex = 1;
            label2.Text = "количество столбцов m=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 213);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Результат:";
            // 
            // txtn
            // 
            txtn.Location = new Point(41, 63);
            txtn.Name = "txtn";
            txtn.Size = new Size(184, 27);
            txtn.TabIndex = 3;
            // 
            // txtm
            // 
            txtm.Location = new Point(41, 154);
            txtm.Name = "txtm";
            txtm.Size = new Size(184, 27);
            txtm.TabIndex = 4;
            // 
            // dgvMass
            // 
            dgvMass.AllowUserToOrderColumns = true;
            dgvMass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMass.Location = new Point(303, 12);
            dgvMass.Name = "dgvMass";
            dgvMass.RowHeadersWidth = 51;
            dgvMass.RowTemplate.Height = 29;
            dgvMass.Size = new Size(485, 338);
            dgvMass.TabIndex = 6;
            // 
            // cmdStart
            // 
            cmdStart.Location = new Point(84, 370);
            cmdStart.Name = "cmdStart";
            cmdStart.Size = new Size(159, 55);
            cmdStart.TabIndex = 7;
            cmdStart.Text = "Вичислить";
            cmdStart.UseVisualStyleBackColor = true;
            cmdStart.Click += cmdStart_Click;
            // 
            // cmdExit
            // 
            cmdExit.Location = new Point(582, 370);
            cmdExit.Name = "cmdExit";
            cmdExit.Size = new Size(184, 55);
            cmdExit.TabIndex = 8;
            cmdExit.Text = "Завершить";
            cmdExit.UseVisualStyleBackColor = true;
            cmdExit.Click += cmdExit_Click;
            // 
            // txtRez
            // 
            txtRez.Location = new Point(41, 236);
            txtRez.Multiline = true;
            txtRez.Name = "txtRez";
            txtRez.Size = new Size(256, 114);
            txtRez.TabIndex = 9;
            // 
            // cmdClear
            // 
            cmdClear.Location = new Point(322, 373);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(162, 48);
            cmdClear.TabIndex = 10;
            cmdClear.Text = "Очистить";
            cmdClear.UseVisualStyleBackColor = true;
            cmdClear.Click += cmdClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdClear);
            Controls.Add(txtRez);
            Controls.Add(cmdExit);
            Controls.Add(cmdStart);
            Controls.Add(dgvMass);
            Controls.Add(txtm);
            Controls.Add(txtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvMass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtn;
        private TextBox txtm;
        private DataGridView dgvMass;
        private Button cmdStart;
        private Button cmdExit;
        private TextBox txtRez;
        private Button cmdClear;
    }
}