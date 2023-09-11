namespace Evaluacion1RamonTorres
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textname = new TextBox();
            textrut = new TextBox();
            textage = new TextBox();
            textheight = new TextBox();
            textweight = new TextBox();
            textwaist = new TextBox();
            texthip = new TextBox();
            dateb = new DateTimePicker();
            grilla = new DataGridView();
            btnicc = new Button();
            btnimc = new Button();
            btnsave = new Button();
            btnclear = new Button();
            ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 52);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 100);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "Rut:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 150);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 203);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 256);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 4;
            label5.Text = "Estatura";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 317);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 5;
            label6.Text = "Peso";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 371);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 6;
            label7.Text = "Tamaño de Cintura:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 424);
            label8.Name = "label8";
            label8.Size = new Size(108, 15);
            label8.TabIndex = 7;
            label8.Text = "Tamaño de Cadera:";
            // 
            // textname
            // 
            textname.Location = new Point(38, 70);
            textname.Name = "textname";
            textname.Size = new Size(100, 23);
            textname.TabIndex = 8;
            // 
            // textrut
            // 
            textrut.Location = new Point(38, 124);
            textrut.Name = "textrut";
            textrut.Size = new Size(100, 23);
            textrut.TabIndex = 9;
            // 
            // textage
            // 
            textage.Location = new Point(38, 168);
            textage.Name = "textage";
            textage.Size = new Size(100, 23);
            textage.TabIndex = 10;
            // 
            // textheight
            // 
            textheight.Location = new Point(38, 274);
            textheight.Name = "textheight";
            textheight.Size = new Size(100, 23);
            textheight.TabIndex = 11;
            // 
            // textweight
            // 
            textweight.Location = new Point(38, 335);
            textweight.Name = "textweight";
            textweight.Size = new Size(100, 23);
            textweight.TabIndex = 12;
            // 
            // textwaist
            // 
            textwaist.Location = new Point(38, 389);
            textwaist.Name = "textwaist";
            textwaist.Size = new Size(100, 23);
            textwaist.TabIndex = 13;
            // 
            // texthip
            // 
            texthip.Location = new Point(38, 451);
            texthip.Name = "texthip";
            texthip.Size = new Size(100, 23);
            texthip.TabIndex = 14;
            // 
            // dateb
            // 
            dateb.Location = new Point(38, 221);
            dateb.Name = "dateb";
            dateb.Size = new Size(200, 23);
            dateb.TabIndex = 15;
            // 
            // grilla
            // 
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grilla.Location = new Point(281, 67);
            grilla.Name = "grilla";
            grilla.RowTemplate.Height = 25;
            grilla.Size = new Size(626, 551);
            grilla.TabIndex = 16;
            // 
            // btnicc
            // 
            btnicc.Location = new Point(38, 527);
            btnicc.Name = "btnicc";
            btnicc.Size = new Size(75, 36);
            btnicc.TabIndex = 17;
            btnicc.Text = "ICC";
            btnicc.UseVisualStyleBackColor = true;
            btnicc.Click += ICC_Click;
            // 
            // btnimc
            // 
            btnimc.Location = new Point(153, 527);
            btnimc.Name = "btnimc";
            btnimc.Size = new Size(75, 36);
            btnimc.TabIndex = 18;
            btnimc.Text = "IMC";
            btnimc.UseVisualStyleBackColor = true;
            btnimc.Click += btnimc_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(38, 578);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(75, 40);
            btnsave.TabIndex = 19;
            btnsave.Text = "Guardar";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(153, 578);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(75, 40);
            btnclear.TabIndex = 20;
            btnclear.Text = "Limpiar";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 630);
            Controls.Add(btnclear);
            Controls.Add(btnsave);
            Controls.Add(btnimc);
            Controls.Add(btnicc);
            Controls.Add(grilla);
            Controls.Add(dateb);
            Controls.Add(texthip);
            Controls.Add(textwaist);
            Controls.Add(textweight);
            Controls.Add(textheight);
            Controls.Add(textage);
            Controls.Add(textrut);
            Controls.Add(textname);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textname;
        private TextBox textrut;
        private TextBox textage;
        private TextBox textheight;
        private TextBox textweight;
        private TextBox textwaist;
        private TextBox texthip;
        private DateTimePicker dateb;
        private DataGridView grilla;
        private Button btnicc;
        private Button btnimc;
        private Button btnsave;
        private Button btnclear;
    }
}