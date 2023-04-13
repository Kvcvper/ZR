using System.Windows.Forms;

namespace DataGrid
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
            dataGridView1 = new DataGridView();
            A = new DataGridViewTextBoxColumn();
            B = new DataGridViewTextBoxColumn();
            C = new DataGridViewTextBoxColumn();
            D = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { A, B, C, D });
            dataGridView1.Location = new Point(12, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 417);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.Rows[0].ReadOnly = true;

            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
            // 
            // A
            // 
            A.HeaderText = "A";
            A.Name = "A";
            // 
            // B
            // 
            B.HeaderText = "B";
            B.Name = "B";
            // 
            // C
            // 
            C.HeaderText = "C";
            C.Name = "C";
            // 
            // D
            // 
            D.HeaderText = "D";
            D.Name = "D";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out int value) || value < 0 || value > 1000)
            {
                MessageBox.Show($"Podana wartosc nie jest prawidłowa. Wprowadź liczbe z przedziału <0, 1000>", "Błędna wartość", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                dataGridView1.CancelEdit();
            }


            dataGridView1.Rows[0].Cells[e.ColumnIndex].Value = dataGridView1.Rows.Cast<DataGridViewRow>()
                .Select(x => x.Cells[e.ColumnIndex])
                .Skip(1)
                .Sum(x => Convert.ToInt32(x.Value));
        }


        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn A;
        private DataGridViewTextBoxColumn B;
        private DataGridViewTextBoxColumn C;
        private DataGridViewTextBoxColumn D;
    }
}