namespace Projet_Gestion_de_Banque
{
    partial class Form8
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
            System.Windows.Forms.TabPage Historiquedesvirements;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Historiquedesversement = new System.Windows.Forms.TabPage();
            this.Historiquedesretraits = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.consulter = new System.Windows.Forms.Button();
            Historiquedesvirements = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Historiquedesversement.SuspendLayout();
            this.Historiquedesretraits.SuspendLayout();
            Historiquedesvirements.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Historiquedesversement);
            this.tabControl1.Controls.Add(this.Historiquedesretraits);
            this.tabControl1.Controls.Add(Historiquedesvirements);
            this.tabControl1.Location = new System.Drawing.Point(62, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(734, 417);
            this.tabControl1.TabIndex = 1;
            // 
            // Historiquedesversement
            // 
            this.Historiquedesversement.Controls.Add(this.panel1);
            this.Historiquedesversement.Location = new System.Drawing.Point(4, 22);
            this.Historiquedesversement.Name = "Historiquedesversement";
            this.Historiquedesversement.Padding = new System.Windows.Forms.Padding(3);
            this.Historiquedesversement.Size = new System.Drawing.Size(726, 391);
            this.Historiquedesversement.TabIndex = 0;
            this.Historiquedesversement.Text = "Historique des versement";
            this.Historiquedesversement.UseVisualStyleBackColor = true;
            // 
            // Historiquedesretraits
            // 
            this.Historiquedesretraits.Controls.Add(this.consulter);
            this.Historiquedesretraits.Controls.Add(this.dataGridView2);
            this.Historiquedesretraits.Location = new System.Drawing.Point(4, 22);
            this.Historiquedesretraits.Name = "Historiquedesretraits";
            this.Historiquedesretraits.Padding = new System.Windows.Forms.Padding(3);
            this.Historiquedesretraits.Size = new System.Drawing.Size(726, 391);
            this.Historiquedesretraits.TabIndex = 1;
            this.Historiquedesretraits.Text = "Historique des retraits";
            this.Historiquedesretraits.UseVisualStyleBackColor = true;
            this.Historiquedesretraits.Click += new System.EventHandler(this.Historiquedesretraits_Click);
            // 
            // Historiquedesvirements
            // 
            Historiquedesvirements.Controls.Add(this.dataGridView3);
            Historiquedesvirements.Location = new System.Drawing.Point(4, 22);
            Historiquedesvirements.Name = "Historiquedesvirements";
            Historiquedesvirements.Padding = new System.Windows.Forms.Padding(3);
            Historiquedesvirements.Size = new System.Drawing.Size(726, 391);
            Historiquedesvirements.TabIndex = 2;
            Historiquedesvirements.Text = "Historique des virements";
            Historiquedesvirements.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 383);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Montant,
            this.date_});
            this.dataGridView1.Location = new System.Drawing.Point(25, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(423, 203);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Montant
            // 
            this.Montant.HeaderText = "Montant";
            this.Montant.Name = "Montant";
            // 
            // date_
            // 
            this.date_.HeaderText = "Date";
            this.date_.Name = "date_";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(49, 44);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(423, 203);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Montant";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView3.Location = new System.Drawing.Point(16, 25);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(423, 203);
            this.dataGridView3.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Montant";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "consulter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // consulter
            // 
            this.consulter.Location = new System.Drawing.Point(364, 290);
            this.consulter.Name = "consulter";
            this.consulter.Size = new System.Drawing.Size(75, 23);
            this.consulter.TabIndex = 2;
            this.consulter.Text = "button2";
            this.consulter.UseVisualStyleBackColor = true;
            this.consulter.Click += new System.EventHandler(this.consulter_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 516);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form8";
            this.Text = "Form8";
            this.tabControl1.ResumeLayout(false);
            this.Historiquedesversement.ResumeLayout(false);
            this.Historiquedesretraits.ResumeLayout(false);
            Historiquedesvirements.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Historiquedesversement;
        private System.Windows.Forms.TabPage Historiquedesretraits;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button consulter;
    }
}