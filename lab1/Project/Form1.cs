using System.Drawing;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.analyzeButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.dataGridViewOperators = new System.Windows.Forms.DataGridView();
            this.OperatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewOperands = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dictionaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperands)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(40, 123);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(170, 90);
            this.analyzeButton.TabIndex = 0;
            this.analyzeButton.Text = "Analyze";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(254, 41);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(805, 693);
            this.textBox.TabIndex = 1;
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(40, 249);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(170, 90);
            this.chooseFileButton.TabIndex = 3;
            this.chooseFileButton.Text = "Choose file";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // dataGridViewOperators
            // 
            this.dataGridViewOperators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOperators.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OperatorColumn,
            this.QuantityColumn});
            this.dataGridViewOperators.Location = new System.Drawing.Point(1106, 41);
            this.dataGridViewOperators.Name = "dataGridViewOperators";
            this.dataGridViewOperators.RowHeadersWidth = 51;
            this.dataGridViewOperators.RowTemplate.Height = 29;
            this.dataGridViewOperators.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOperators.Size = new System.Drawing.Size(300, 693);
            this.dataGridViewOperators.TabIndex = 4;
            // 
            // OperatorColumn
            // 
            this.OperatorColumn.Frozen = true;
            this.OperatorColumn.HeaderText = "Operator";
            this.OperatorColumn.MinimumWidth = 6;
            this.OperatorColumn.Name = "OperatorColumn";
            this.OperatorColumn.ReadOnly = true;
            this.OperatorColumn.Width = 125;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.MinimumWidth = 6;
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            this.QuantityColumn.Width = 125;
            // 
            // dataGridViewOperands
            // 
            this.dataGridViewOperands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOperands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewOperands.Location = new System.Drawing.Point(1433, 41);
            this.dataGridViewOperands.Name = "dataGridViewOperands";
            this.dataGridViewOperands.RowHeadersWidth = 51;
            this.dataGridViewOperands.RowTemplate.Height = 29;
            this.dataGridViewOperands.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOperands.Size = new System.Drawing.Size(300, 693);
            this.dataGridViewOperands.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Operand";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.volumeLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lengthLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dictionaryLabel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(40, 408);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 215);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // volumeLabel
            // 
            this.volumeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(126, 174);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(17, 20);
            this.volumeLabel.TabIndex = 5;
            this.volumeLabel.Text = "0";
            // 
            // lengthLabel
            // 
            this.lengthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(126, 105);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(17, 20);
            this.lengthLabel.TabIndex = 4;
            this.lengthLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "V";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "N";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "η ";
            // 
            // dictionaryLabel
            // 
            this.dictionaryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dictionaryLabel.AutoSize = true;
            this.dictionaryLabel.Location = new System.Drawing.Point(126, 28);
            this.dictionaryLabel.Name = "dictionaryLabel";
            this.dictionaryLabel.Size = new System.Drawing.Size(17, 20);
            this.dictionaryLabel.TabIndex = 3;
            this.dictionaryLabel.Text = "0";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1767, 767);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridViewOperands);
            this.Controls.Add(this.dataGridViewOperators);
            this.Controls.Add(this.chooseFileButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.analyzeButton);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperands)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private int dictionaryOfProgramm = 0;
        private int lengthOfProgramm = 0;

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            string code = textBox.Text;
            dictionaryOfProgramm = lengthOfProgramm = 0;
            ShowDictionaryInGridView(dataGridViewOperators, HolstedMetrics.FindOperators(code));
            ShowDictionaryInGridView(dataGridViewOperands, HolstedMetrics.FindOperands(code));
            ShowAdditionalMetrics();
        }

        private void ShowAdditionalMetrics()
        {
            dictionaryLabel.Text = dictionaryOfProgramm.ToString();
            lengthLabel.Text = lengthOfProgramm.ToString();
            volumeLabel.Text = (lengthOfProgramm * (int)Math.Ceiling(Math.Log2(dictionaryOfProgramm))).ToString();
        }

        

        private void ShowDictionaryInGridView(DataGridView view, Dictionary<string, int> dict) 
        {
            view.Rows.Clear();
            int sum = 0;
            foreach (var pair in dict)
            {
                addRow(view, pair.Key, pair.Value);
                sum += pair.Value;
            }

            if (view.Name.Equals("dataGridViewOperators")) addRow(view, "η1 = " + dict.Count, "N1 = " + sum);
            else addRow(view, "η2 = " + dict.Count, "N2 = " + sum);

            dictionaryOfProgramm += dict.Count;
            lengthOfProgramm += sum;
        }

        private void addRow(DataGridView view, object key, object value)
        {
            DataGridViewRow row = (DataGridViewRow)view.Rows[0].Clone();
            row.Cells[0].Value = key;
            row.Cells[1].Value = value;
            view.Rows.Add(row);
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CPP files|*.cpp";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    textBox.Text = text;
                }
                catch (IOException) { }
            }
        }
    }
}