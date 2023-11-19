namespace Lab5
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
            trackBar1 = new TrackBar();
            label2 = new Label();
            trackValue = new Label();
            label4 = new Label();
            startButton = new Button();
            pauseButton = new Button();
            listBoxProcesses = new ListView();
            label5 = new Label();
            numericUpDownExecutionTime = new NumericUpDown();
            label6 = new Label();
            button3 = new Button();
            quantumNumeric = new NumericUpDown();
            resumeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownExecutionTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantumNumeric).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(310, 31);
            label1.TabIndex = 0;
            label1.Text = "Цилкическое планирование";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 96);
            trackBar1.Minimum = 2;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(176, 56);
            trackBar1.TabIndex = 1;
            trackBar1.Value = 2;
            trackBar1.ValueChanged += track_Changed;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 58);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 2;
            label2.Text = "Количество задач";
            // 
            // trackValue
            // 
            trackValue.AutoSize = true;
            trackValue.Location = new Point(205, 96);
            trackValue.Name = "trackValue";
            trackValue.Size = new Size(17, 20);
            trackValue.TabIndex = 3;
            trackValue.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 458);
            label4.Name = "label4";
            label4.Size = new Size(0, 31);
            label4.TabIndex = 4;
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.Location = new Point(21, 313);
            startButton.Name = "startButton";
            startButton.Size = new Size(101, 37);
            startButton.TabIndex = 5;
            startButton.Text = "Старт";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += start_Click;
            // 
            // pauseButton
            // 
            pauseButton.Enabled = false;
            pauseButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            pauseButton.Location = new Point(136, 313);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(111, 37);
            pauseButton.TabIndex = 6;
            pauseButton.Text = "Пауза";
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += stop_Click;
            // 
            // listBoxProcesses
            // 
            listBoxProcesses.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxProcesses.Location = new Point(442, 9);
            listBoxProcesses.Name = "listBoxProcesses";
            listBoxProcesses.Size = new Size(391, 347);
            listBoxProcesses.TabIndex = 7;
            listBoxProcesses.UseCompatibleStateImageBehavior = false;
            listBoxProcesses.View = View.List;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 155);
            label5.Name = "label5";
            label5.Size = new Size(135, 25);
            label5.TabIndex = 8;
            label5.Text = "Квант времени";
            // 
            // numericUpDownExecutionTime
            // 
            numericUpDownExecutionTime.Location = new Point(216, 195);
            numericUpDownExecutionTime.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownExecutionTime.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownExecutionTime.Name = "numericUpDownExecutionTime";
            numericUpDownExecutionTime.Size = new Size(150, 27);
            numericUpDownExecutionTime.TabIndex = 11;
            numericUpDownExecutionTime.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(216, 155);
            label6.Name = "label6";
            label6.Size = new Size(170, 25);
            label6.TabIndex = 10;
            label6.Text = "Время выполнения";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(21, 260);
            button3.Name = "button3";
            button3.Size = new Size(226, 38);
            button3.TabIndex = 12;
            button3.Text = "Добавить в очередь";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnAddProcess_Click;
            // 
            // quantumNumeric
            // 
            quantumNumeric.Location = new Point(21, 195);
            quantumNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            quantumNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantumNumeric.Name = "quantumNumeric";
            quantumNumeric.Size = new Size(150, 27);
            quantumNumeric.TabIndex = 13;
            quantumNumeric.Value = new decimal(new int[] { 100, 0, 0, 0 });
            quantumNumeric.ValueChanged += Quantum_ValueChanged;
            // 
            // resumeButton
            // 
            resumeButton.Enabled = false;
            resumeButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            resumeButton.Location = new Point(21, 366);
            resumeButton.Name = "resumeButton";
            resumeButton.Size = new Size(226, 38);
            resumeButton.TabIndex = 14;
            resumeButton.Text = "Продолжить";
            resumeButton.UseVisualStyleBackColor = true;
            resumeButton.Click += resume_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 421);
            Controls.Add(resumeButton);
            Controls.Add(quantumNumeric);
            Controls.Add(button3);
            Controls.Add(numericUpDownExecutionTime);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(listBoxProcesses);
            Controls.Add(pauseButton);
            Controls.Add(startButton);
            Controls.Add(label4);
            Controls.Add(trackValue);
            Controls.Add(label2);
            Controls.Add(trackBar1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownExecutionTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantumNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TrackBar trackBar1;
        private Label label2;
        private Label trackValue;
        private Label label4;
        private Button startButton;
        private Button pauseButton;
        private ListView listBoxProcesses;
        private Label label5;
        private NumericUpDown numericUpDownExecutionTime;
        private Label label6;
        private Button button3;
        private NumericUpDown quantumNumeric;
        private Button resumeButton;
    }
}