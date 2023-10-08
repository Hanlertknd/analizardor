namespace Analizador_Lexico
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
            this.TOKEN_LEXEMA = new System.Windows.Forms.DataGridView();
            this.TOKEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LEXEMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TOKEN_LEXEMA)).BeginInit();
            this.SuspendLayout();
            // 
            // TOKEN_LEXEMA
            // 
            this.TOKEN_LEXEMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TOKEN_LEXEMA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TOKEN,
            this.LEXEMA});
            this.TOKEN_LEXEMA.Location = new System.Drawing.Point(345, 35);
            this.TOKEN_LEXEMA.Name = "TOKEN_LEXEMA";
            this.TOKEN_LEXEMA.RowHeadersWidth = 51;
            this.TOKEN_LEXEMA.RowTemplate.Height = 29;
            this.TOKEN_LEXEMA.Size = new System.Drawing.Size(339, 456);
            this.TOKEN_LEXEMA.TabIndex = 0;
            this.TOKEN_LEXEMA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TOKEN
            // 
            this.TOKEN.HeaderText = "TOKEN";
            this.TOKEN.MinimumWidth = 6;
            this.TOKEN.Name = "TOKEN";
            this.TOKEN.Width = 125;
            // 
            // LEXEMA
            // 
            this.LEXEMA.HeaderText = "LEXEMA";
            this.LEXEMA.MinimumWidth = 6;
            this.LEXEMA.Name = "LEXEMA";
            this.LEXEMA.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 456);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo para Analizar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(718, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(718, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Analizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(928, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TOKEN_LEXEMA);
            this.Name = "Form1";
            this.Text = "Analizador Léxico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TOKEN_LEXEMA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView TOKEN_LEXEMA;
        private DataGridViewTextBoxColumn TOKEN;
        private DataGridViewTextBoxColumn LEXEMA;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}