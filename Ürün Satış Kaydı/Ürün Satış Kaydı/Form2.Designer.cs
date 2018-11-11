namespace Ürün_Satış_Kaydı
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.alicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satislarDataSet = new Ürün_Satış_Kaydı.satislarDataSet();
            this.alicilarTableAdapter = new Ürün_Satış_Kaydı.satislarDataSetTableAdapters.alicilarTableAdapter();
            this.satislarDataSet1 = new Ürün_Satış_Kaydı.satislarDataSet1();
            this.alicilarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.alicilarTableAdapter1 = new Ürün_Satış_Kaydı.satislarDataSet1TableAdapters.alicilarTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alicilarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satislarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satislarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alicilarBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // alicilarBindingSource
            // 
            this.alicilarBindingSource.DataMember = "alicilar";
            this.alicilarBindingSource.DataSource = this.satislarDataSet;
            // 
            // satislarDataSet
            // 
            this.satislarDataSet.DataSetName = "satislarDataSet";
            this.satislarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alicilarTableAdapter
            // 
            this.alicilarTableAdapter.ClearBeforeFill = true;
            // 
            // satislarDataSet1
            // 
            this.satislarDataSet1.DataSetName = "satislarDataSet1";
            this.satislarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alicilarBindingSource1
            // 
            this.alicilarBindingSource1.DataMember = "alicilar";
            this.alicilarBindingSource1.DataSource = this.satislarDataSet1;
            // 
            // alicilarTableAdapter1
            // 
            this.alicilarTableAdapter1.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(676, 267);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 167;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E-posta";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 232;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 267);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Satışlar";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alicilarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satislarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satislarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alicilarBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private satislarDataSet satislarDataSet;
        private System.Windows.Forms.BindingSource alicilarBindingSource;
        private satislarDataSetTableAdapters.alicilarTableAdapter alicilarTableAdapter;
        private satislarDataSet1 satislarDataSet1;
        private System.Windows.Forms.BindingSource alicilarBindingSource1;
        private satislarDataSet1TableAdapters.alicilarTableAdapter alicilarTableAdapter1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
    }
}