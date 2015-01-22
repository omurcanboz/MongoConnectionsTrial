namespace MongoDB
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
            this.btnadd = new System.Windows.Forms.Button();
            this.cmbsex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.textcep = new System.Windows.Forms.TextBox();
            this.txtarama = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.btndel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.gbfilter = new System.Windows.Forms.GroupBox();
            this.cbkadın = new System.Windows.Forms.CheckBox();
            this.cberkek = new System.Windows.Forms.CheckBox();
            this.cbcep = new System.Windows.Forms.CheckBox();
            this.cbsoyad = new System.Windows.Forms.CheckBox();
            this.cbad = new System.Windows.Forms.CheckBox();
            this.btnall = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.gbfilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(87, 193);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(105, 43);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cmbsex
            // 
            this.cmbsex.FormattingEnabled = true;
            this.cmbsex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbsex.Location = new System.Drawing.Point(87, 147);
            this.cmbsex.Name = "cmbsex";
            this.cmbsex.Size = new System.Drawing.Size(104, 21);
            this.cmbsex.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "cinsiyet";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(16, 108);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(39, 13);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "cep tel";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(15, 76);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(35, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "soyad";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(15, 34);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(19, 13);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "ad";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(93, 33);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(97, 20);
            this.txtad.TabIndex = 6;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(92, 75);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(84, 20);
            this.txtsoyad.TabIndex = 7;
            // 
            // textcep
            // 
            this.textcep.Location = new System.Drawing.Point(92, 104);
            this.textcep.Name = "textcep";
            this.textcep.Size = new System.Drawing.Size(83, 20);
            this.textcep.TabIndex = 8;
            // 
            // txtarama
            // 
            this.txtarama.Location = new System.Drawing.Point(239, 35);
            this.txtarama.Name = "txtarama";
            this.txtarama.Size = new System.Drawing.Size(312, 20);
            this.txtarama.TabIndex = 9;
            this.txtarama.TextChanged += new System.EventHandler(this.txtarama_TextChanged);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(249, 93);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(625, 200);
            this.grid.TabIndex = 10;
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(87, 251);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(103, 23);
            this.btndel.TabIndex = 11;
            this.btndel.Text = "delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(85, 291);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(105, 23);
            this.btnupdate.TabIndex = 12;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // gbfilter
            // 
            this.gbfilter.Controls.Add(this.cbkadın);
            this.gbfilter.Controls.Add(this.cberkek);
            this.gbfilter.Controls.Add(this.cbcep);
            this.gbfilter.Controls.Add(this.cbsoyad);
            this.gbfilter.Controls.Add(this.cbad);
            this.gbfilter.Location = new System.Drawing.Point(880, 33);
            this.gbfilter.Name = "gbfilter";
            this.gbfilter.Size = new System.Drawing.Size(200, 300);
            this.gbfilter.TabIndex = 13;
            this.gbfilter.TabStop = false;
            this.gbfilter.Text = "Filter";
            // 
            // cbkadın
            // 
            this.cbkadın.AutoSize = true;
            this.cbkadın.Location = new System.Drawing.Point(25, 208);
            this.cbkadın.Name = "cbkadın";
            this.cbkadın.Size = new System.Drawing.Size(52, 17);
            this.cbkadın.TabIndex = 4;
            this.cbkadın.Text = "kadın";
            this.cbkadın.UseVisualStyleBackColor = true;
            // 
            // cberkek
            // 
            this.cberkek.AutoSize = true;
            this.cberkek.Location = new System.Drawing.Point(25, 172);
            this.cberkek.Name = "cberkek";
            this.cberkek.Size = new System.Drawing.Size(53, 17);
            this.cberkek.TabIndex = 3;
            this.cberkek.Text = "erkek";
            this.cberkek.UseVisualStyleBackColor = true;
            // 
            // cbcep
            // 
            this.cbcep.AutoSize = true;
            this.cbcep.Location = new System.Drawing.Point(25, 130);
            this.cbcep.Name = "cbcep";
            this.cbcep.Size = new System.Drawing.Size(58, 17);
            this.cbcep.TabIndex = 2;
            this.cbcep.Text = "cep tel";
            this.cbcep.UseVisualStyleBackColor = true;
            // 
            // cbsoyad
            // 
            this.cbsoyad.AutoSize = true;
            this.cbsoyad.Location = new System.Drawing.Point(25, 90);
            this.cbsoyad.Name = "cbsoyad";
            this.cbsoyad.Size = new System.Drawing.Size(54, 17);
            this.cbsoyad.TabIndex = 1;
            this.cbsoyad.Text = "soyad";
            this.cbsoyad.UseVisualStyleBackColor = true;
            // 
            // cbad
            // 
            this.cbad.AutoSize = true;
            this.cbad.Location = new System.Drawing.Point(25, 44);
            this.cbad.Name = "cbad";
            this.cbad.Size = new System.Drawing.Size(38, 17);
            this.cbad.TabIndex = 0;
            this.cbad.Text = "ad";
            this.cbad.UseVisualStyleBackColor = true;
            // 
            // btnall
            // 
            this.btnall.Location = new System.Drawing.Point(249, 310);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(75, 23);
            this.btnall.TabIndex = 14;
            this.btnall.Text = "Show All";
            this.btnall.UseVisualStyleBackColor = true;
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Chartreuse;
            this.progressBar1.Location = new System.Drawing.Point(392, 310);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(382, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(85, 331);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 16;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 366);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnall);
            this.Controls.Add(this.gbfilter);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.txtarama);
            this.Controls.Add(this.textcep);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbsex);
            this.Controls.Add(this.btnadd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.gbfilter.ResumeLayout(false);
            this.gbfilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox cmbsex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox textcep;
        private System.Windows.Forms.TextBox txtarama;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.GroupBox gbfilter;
        private System.Windows.Forms.CheckBox cbkadın;
        private System.Windows.Forms.CheckBox cberkek;
        private System.Windows.Forms.CheckBox cbcep;
        private System.Windows.Forms.CheckBox cbsoyad;
        private System.Windows.Forms.CheckBox cbad;
        private System.Windows.Forms.Button btnall;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnsave;
    }
}

