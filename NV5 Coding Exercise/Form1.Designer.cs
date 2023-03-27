namespace NV5_Coding_Exercise
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
            this.loadQueriesButton = new System.Windows.Forms.Button();
            this.QueriesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.QueriesSelectButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BuildingsSelectButton = new System.Windows.Forms.Button();
            this.BuildingsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.debugBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadQueriesButton
            // 
            this.loadQueriesButton.Location = new System.Drawing.Point(26, 99);
            this.loadQueriesButton.Name = "loadQueriesButton";
            this.loadQueriesButton.Size = new System.Drawing.Size(97, 23);
            this.loadQueriesButton.TabIndex = 0;
            this.loadQueriesButton.Text = "Load Queries";
            this.loadQueriesButton.UseVisualStyleBackColor = true;
            this.loadQueriesButton.Click += new System.EventHandler(this.LoadQueriesButton_Click);
            // 
            // QueriesTextBox
            // 
            this.QueriesTextBox.Location = new System.Drawing.Point(107, 58);
            this.QueriesTextBox.Name = "QueriesTextBox";
            this.QueriesTextBox.ReadOnly = true;
            this.QueriesTextBox.Size = new System.Drawing.Size(494, 23);
            this.QueriesTextBox.TabIndex = 1;
            this.QueriesTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Query File Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 310);
            this.dataGridView1.TabIndex = 3;
            // 
            // QueriesSelectButton
            // 
            this.QueriesSelectButton.Location = new System.Drawing.Point(26, 58);
            this.QueriesSelectButton.Name = "QueriesSelectButton";
            this.QueriesSelectButton.Size = new System.Drawing.Size(75, 23);
            this.QueriesSelectButton.TabIndex = 4;
            this.QueriesSelectButton.Text = "Select";
            this.QueriesSelectButton.UseVisualStyleBackColor = true;
            this.QueriesSelectButton.Click += new System.EventHandler(this.QueriesSelectButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BuildingsSelectButton
            // 
            this.BuildingsSelectButton.Location = new System.Drawing.Point(26, 20);
            this.BuildingsSelectButton.Name = "BuildingsSelectButton";
            this.BuildingsSelectButton.Size = new System.Drawing.Size(75, 23);
            this.BuildingsSelectButton.TabIndex = 5;
            this.BuildingsSelectButton.Text = "Select";
            this.BuildingsSelectButton.UseVisualStyleBackColor = true;
            this.BuildingsSelectButton.Click += new System.EventHandler(this.BuildingsSelectButton_Click);
            // 
            // BuildingsTextBox
            // 
            this.BuildingsTextBox.Location = new System.Drawing.Point(107, 20);
            this.BuildingsTextBox.Name = "BuildingsTextBox";
            this.BuildingsTextBox.ReadOnly = true;
            this.BuildingsTextBox.Size = new System.Drawing.Size(494, 23);
            this.BuildingsTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buildings File Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // debugBox
            // 
            this.debugBox.Location = new System.Drawing.Point(536, 97);
            this.debugBox.Name = "debugBox";
            this.debugBox.Size = new System.Drawing.Size(252, 23);
            this.debugBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.debugBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuildingsTextBox);
            this.Controls.Add(this.BuildingsSelectButton);
            this.Controls.Add(this.QueriesSelectButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QueriesTextBox);
            this.Controls.Add(this.loadQueriesButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loadQueriesButton;
        private TextBox QueriesTextBox;
        private Label label1;
        private DataGridView dataGridView1;
        private Button QueriesSelectButton;
        private OpenFileDialog openFileDialog1;
        private Button BuildingsSelectButton;
        private TextBox BuildingsTextBox;
        private Label label2;
        private TextBox debugBox;
    }
}