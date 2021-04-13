
namespace Brewery
{
    partial class AddForm
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
            this.sortsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.Tara = new System.Windows.Forms.ComboBox();
            this.Volume = new System.Windows.Forms.ComboBox();
            this.Sort = new System.Windows.Forms.ComboBox();
            this.sortsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.breweryDataSet14 = new Brewery.BreweryDataSet14();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Price2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imya = new System.Windows.Forms.TextBox();
            this.breweryDataSet13 = new Brewery.BreweryDataSet13();
            this.sortsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.sortsTableAdapter = new Brewery.BreweryDataSet13TableAdapters.SortsTableAdapter();
            this.sortsTableAdapter1 = new Brewery.BreweryDataSet14TableAdapters.SortsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sortsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breweryDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breweryDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortsBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // sortsBindingSource3
            // 
            this.sortsBindingSource3.DataMember = "sorts";
            // 
            // Tara
            // 
            this.Tara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tara.FormattingEnabled = true;
            this.Tara.Items.AddRange(new object[] {
            "Скло",
            "Метал",
            "Пластик"});
            this.Tara.Location = new System.Drawing.Point(178, 147);
            this.Tara.Name = "Tara";
            this.Tara.Size = new System.Drawing.Size(217, 23);
            this.Tara.TabIndex = 32;
            // 
            // Volume
            // 
            this.Volume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Volume.FormattingEnabled = true;
            this.Volume.Items.AddRange(new object[] {
            "0,33",
            "0,5",
            "0,75",
            "1,5",
            "2,5"});
            this.Volume.Location = new System.Drawing.Point(178, 102);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(217, 23);
            this.Volume.TabIndex = 31;
            // 
            // Sort
            // 
            this.Sort.DataSource = this.sortsBindingSource;
            this.Sort.DisplayMember = "sort_id";
            this.Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sort.FormattingEnabled = true;
            this.Sort.Location = new System.Drawing.Point(178, 60);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(217, 23);
            this.Sort.TabIndex = 30;
            // 
            // sortsBindingSource
            // 
            this.sortsBindingSource.DataMember = "Sorts";
            this.sortsBindingSource.DataSource = this.breweryDataSet14;
            // 
            // breweryDataSet14
            // 
            this.breweryDataSet14.DataSetName = "BreweryDataSet14";
            this.breweryDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(206, 296);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(189, 27);
            this.button_Cancel.TabIndex = 29;
            this.button_Cancel.Text = "Відмінити";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.White;
            this.button_OK.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.button_OK.FlatAppearance.BorderSize = 2;
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OK.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.ForeColor = System.Drawing.Color.DarkOrange;
            this.button_OK.Location = new System.Drawing.Point(15, 296);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(184, 27);
            this.button_OK.TabIndex = 28;
            this.button_OK.Text = "Ок";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Ціна за ящик";
            // 
            // Price2
            // 
            this.Price2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Price2.Location = new System.Drawing.Point(178, 247);
            this.Price2.Name = "Price2";
            this.Price2.Size = new System.Drawing.Size(217, 16);
            this.Price2.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Наявність(ящиків)";
            // 
            // Amount
            // 
            this.Amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Amount.Location = new System.Drawing.Point(178, 199);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(217, 16);
            this.Amount.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Тара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Об\'єм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID сорту";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Найменування товару";
            // 
            // imya
            // 
            this.imya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imya.Location = new System.Drawing.Point(178, 23);
            this.imya.Name = "imya";
            this.imya.Size = new System.Drawing.Size(217, 16);
            this.imya.TabIndex = 19;
            // 
            // breweryDataSet13
            // 
            this.breweryDataSet13.DataSetName = "BreweryDataSet13";
            this.breweryDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sortsBindingSource4
            // 
            this.sortsBindingSource4.DataMember = "Sorts";
            this.sortsBindingSource4.DataSource = this.breweryDataSet13;
            // 
            // sortsTableAdapter
            // 
            this.sortsTableAdapter.ClearBeforeFill = true;
            // 
            // sortsTableAdapter1
            // 
            this.sortsTableAdapter1.ClearBeforeFill = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 346);
            this.Controls.Add(this.Tara);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Price2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imya);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sortsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breweryDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breweryDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortsBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sortsBindingSource3;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BreweryDataSet13 breweryDataSet13;
        private System.Windows.Forms.BindingSource sortsBindingSource4;
        private BreweryDataSet13TableAdapters.SortsTableAdapter sortsTableAdapter;
        private BreweryDataSet14 breweryDataSet14;
        private System.Windows.Forms.BindingSource sortsBindingSource;
        private BreweryDataSet14TableAdapters.SortsTableAdapter sortsTableAdapter1;
        public System.Windows.Forms.ComboBox Tara;
        public System.Windows.Forms.ComboBox Volume;
        public System.Windows.Forms.ComboBox Sort;
        public System.Windows.Forms.TextBox Price2;
        public System.Windows.Forms.TextBox Amount;
        public System.Windows.Forms.TextBox imya;
    }
}