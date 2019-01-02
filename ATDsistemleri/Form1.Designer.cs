namespace ATDsistemleri
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.personelTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atdSistemleriDatabaseDataSet = new ATDsistemleri.AtdSistemleriDatabaseDataSet();
            this.personelTablosuTableAdapter = new ATDsistemleri.AtdSistemleriDatabaseDataSetTableAdapters.PersonelTablosuTableAdapter();
            this.tableAdapterManager = new ATDsistemleri.AtdSistemleriDatabaseDataSetTableAdapters.TableAdapterManager();
            this.personelTablosuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personelTablosuBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personelTablosuBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bnt1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.personelTablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atdSistemleriDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTablosuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTablosuBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTablosuBindingSource3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // personelTablosuBindingSource
            // 
            this.personelTablosuBindingSource.DataMember = "PersonelTablosu";
            this.personelTablosuBindingSource.DataSource = this.atdSistemleriDatabaseDataSet;
            // 
            // atdSistemleriDatabaseDataSet
            // 
            this.atdSistemleriDatabaseDataSet.DataSetName = "AtdSistemleriDatabaseDataSet";
            this.atdSistemleriDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelTablosuTableAdapter
            // 
            this.personelTablosuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Adetler2TableAdapter = null;
            this.tableAdapterManager.Adetler3TableAdapter = null;
            this.tableAdapterManager.Adetler4TableAdapter = null;
            this.tableAdapterManager.AdetlerTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoglarTableAdapter = null;
            this.tableAdapterManager.PersonelTablosuTableAdapter = this.personelTablosuTableAdapter;
            this.tableAdapterManager.UpdateOrder = ATDsistemleri.AtdSistemleriDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personelTablosuBindingSource1
            // 
            this.personelTablosuBindingSource1.DataMember = "PersonelTablosu";
            this.personelTablosuBindingSource1.DataSource = this.atdSistemleriDatabaseDataSet;
            // 
            // personelTablosuBindingSource2
            // 
            this.personelTablosuBindingSource2.DataMember = "PersonelTablosu";
            this.personelTablosuBindingSource2.DataSource = this.atdSistemleriDatabaseDataSet;
            // 
            // personelTablosuBindingSource3
            // 
            this.personelTablosuBindingSource3.DataMember = "PersonelTablosu";
            this.personelTablosuBindingSource3.DataSource = this.atdSistemleriDatabaseDataSet;
            // 
            // txtGiris
            // 
            this.txtGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGiris.Location = new System.Drawing.Point(110, 77);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.PasswordChar = '*';
            this.txtGiris.Size = new System.Drawing.Size(286, 38);
            this.txtGiris.TabIndex = 0;
            this.txtGiris.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtGiris.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.txtGiris);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(431, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GİRİŞ YAPINIZ";
            // 
            // bnt1
            // 
            this.bnt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bnt1.Location = new System.Drawing.Point(431, 232);
            this.bnt1.Name = "bnt1";
            this.bnt1.Size = new System.Drawing.Size(93, 81);
            this.bnt1.TabIndex = 4;
            this.bnt1.Text = "1";
            this.bnt1.UseVisualStyleBackColor = true;
            this.bnt1.Click += new System.EventHandler(this.bnt1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.Location = new System.Drawing.Point(638, 232);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(93, 81);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(845, 597);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(93, 81);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.Location = new System.Drawing.Point(845, 232);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(93, 81);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.Location = new System.Drawing.Point(431, 354);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(93, 81);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn7.Location = new System.Drawing.Point(431, 479);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(93, 81);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn5.Location = new System.Drawing.Point(638, 357);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(93, 81);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn6.Location = new System.Drawing.Point(845, 354);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(93, 81);
            this.btn6.TabIndex = 4;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn8.Location = new System.Drawing.Point(638, 479);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(93, 81);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn9.Location = new System.Drawing.Point(845, 479);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(93, 81);
            this.btn9.TabIndex = 4;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn0.Location = new System.Drawing.Point(638, 597);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(93, 81);
            this.btn0.TabIndex = 4;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox2.Location = new System.Drawing.Point(323, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 481);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.bnt1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.personelTablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atdSistemleriDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTablosuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTablosuBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTablosuBindingSource3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AtdSistemleriDatabaseDataSet atdSistemleriDatabaseDataSet;
        private System.Windows.Forms.BindingSource personelTablosuBindingSource;
        private AtdSistemleriDatabaseDataSetTableAdapters.PersonelTablosuTableAdapter personelTablosuTableAdapter;
        private AtdSistemleriDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource personelTablosuBindingSource1;
        private System.Windows.Forms.BindingSource personelTablosuBindingSource2;
        private System.Windows.Forms.BindingSource personelTablosuBindingSource3;
        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bnt1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

