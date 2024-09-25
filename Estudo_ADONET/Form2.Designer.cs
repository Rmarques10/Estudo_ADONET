namespace Estudo_ADONET
{
    partial class Form2
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
            label1 = new Label();
            btnBuscar = new Button();
            btnIncluir = new Button();
            btnAlterar = new Button();
            btnDeletar = new Button();
            btnAll = new Button();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            txtTelefone = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(719, 100);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "LISTA DE DADOS";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(70, 198);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(303, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(70, 244);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(303, 29);
            btnIncluir.TabIndex = 2;
            btnIncluir.Text = "INCLUIR";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(70, 290);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(303, 29);
            btnAlterar.TabIndex = 3;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(70, 340);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(303, 29);
            btnDeletar.TabIndex = 4;
            btnDeletar.Text = "DELETAR";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnAll
            // 
            btnAll.Location = new Point(70, 388);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(303, 29);
            btnAll.TabIndex = 5;
            btnAll.Text = "BUSCAR TODOS";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(559, 45);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(719, 45);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(874, 45);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(559, 9);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 9;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(719, 9);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 10;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(874, 9);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 11;
            label4.Text = "Email";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(379, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(765, 394);
            dataGridView1.TabIndex = 12;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(1031, 45);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(125, 27);
            txtTelefone.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1031, 9);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 14;
            label5.Text = "Telefone";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 736);
            Controls.Add(label5);
            Controls.Add(txtTelefone);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(btnAll);
            Controls.Add(btnDeletar);
            Controls.Add(btnAlterar);
            Controls.Add(btnIncluir);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBuscar;
        private Button btnIncluir;
        private Button btnAlterar;
        private Button btnDeletar;
        private Button btnAll;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private TextBox txtTelefone;
        private Label label5;
    }
}