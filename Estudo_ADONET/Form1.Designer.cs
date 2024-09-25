namespace Estudo_ADONET
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
            btnSqlServer = new Button();
            label1 = new Label();
            btnListar = new Button();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            btnDataset = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSqlServer
            // 
            btnSqlServer.Location = new Point(107, 65);
            btnSqlServer.Name = "btnSqlServer";
            btnSqlServer.Size = new Size(274, 58);
            btnSqlServer.TabIndex = 0;
            btnSqlServer.Text = "Conexão";
            btnSqlServer.UseVisualStyleBackColor = true;
            btnSqlServer.Click += btnSqlServer_Click;
            // 
            // label1
            // 
            label1.AccessibleName = "";
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "ADO.NET";
            // 
            // btnListar
            // 
            btnListar.Location = new Point(387, 65);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(274, 58);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(107, 129);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(554, 144);
            listBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(107, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(554, 188);
            dataGridView1.TabIndex = 4;
            // 
            // btnDataset
            // 
            btnDataset.Location = new Point(107, 473);
            btnDataset.Name = "btnDataset";
            btnDataset.Size = new Size(554, 58);
            btnDataset.TabIndex = 5;
            btnDataset.Text = "Listar (DataSet)";
            btnDataset.UseVisualStyleBackColor = true;
            btnDataset.Click += btnDataset_Click;
            // 
            // button1
            // 
            button1.Location = new Point(107, 573);
            button1.Name = "button1";
            button1.Size = new Size(554, 64);
            button1.TabIndex = 6;
            button1.Text = "Formulario 2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 745);
            Controls.Add(button1);
            Controls.Add(btnDataset);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(btnListar);
            Controls.Add(label1);
            Controls.Add(btnSqlServer);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSqlServer;
        private Label label1;
        private Button btnListar;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Button btnDataset;
        private Button button1;
    }
}
