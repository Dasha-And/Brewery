
namespace Brewery
{
    partial class EditForm
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
            this.sortsTableAdapter1 = new Brewery.BreweryDataSet14TableAdapters.SortsTableAdapter();
            this.breweryDataSet14 = new Brewery.BreweryDataSet14();
            this.Tara = new System.Windows.Forms.ComboBox();
            this.Volume = new System.Windows.Forms.ComboBox();
            this.sortsTableAdapter = new Brewery.BreweryDataSet13TableAdapters.SortsTableAdapter();
            this.sortsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.breweryDataSet13 = new Brewery.BreweryDataSet13();
            this.sortsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sort = new System.Windows.Forms.ComboBox();
            this.sortsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.breweryDataSet16 = new Brewery.BreweryDataSet16();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.Price2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sortsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.breweryDataSet15 = new Brewery.BreweryDataSet15();
            this.productsTableAdapter = new Brewery.BreweryDataSet15TableAdapters.ProductsTableAdapter();
            this.sortsTableAdapter2 = new Brewery.BreweryDataSet16TableAdapters.SortsTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.breweryDataSet22 = new Brewery.BreweryDataSet22();
            this.sortsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sortsTableAdapter3 = new Brewery.BreweryDataSet22TableAdapters.SortsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.breweryDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breweryDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breweryDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breweryDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breweryDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // sortsTableAdapter1
            // 
            this.sortsTableAdapter1.ClearBeforeFill = true;
            // 
            // breweryDataSet14
            // 
            this.breweryDataSet14.DataSetName = "BreweryDataSet14";
            this.breweryDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tara
            // 
            this.Tara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tara.FormattingEnabled = true;
            this.Tara.Items.AddRange(new object[] {
            "Скло",
            "Метал",
            "Пластик"});
            this.Tara.Location = new System.Drawing.Point(238, 194);
            this.Tara.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tara.Name = "Tara";
            this.Tara.Size = new System.Drawing.Size(287, 26);
            this.Tara.TabIndex = 46;
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
            this.Volume.Location = new System.Drawing.Point(238, 132);
            this.Volume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(287, 26);
            this.Volume.TabIndex = 45;
            // 
            // sortsTableAdapter
            // 
            this.sortsTableAdapter.ClearBeforeFill = true;
            // 
            // sortsBindingSource4
            // 
            this.sortsBindingSource4.DataMember = "Sorts";
            this.sortsBindingSource4.DataSource = this.breweryDataSet13;
            // 
            // breweryDataSet13
            // 
            this.breweryDataSet13.DataSetName = "BreweryDataSet13";
            this.breweryDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sortsBindingSource
            // 
            this.sortsBindingSource.DataMember = "Sorts";
            this.sortsBindingSource.DataSource = this.breweryDataSet14;
            // 
            // Sort
            // 
            this.Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sort.FormattingEnabled = true;
            this.Sort.Location = new System.Drawing.Point(238, 73);
            this.Sort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(287, 26);
            this.Sort.TabIndex = 44;
            // 
            // sortsBindingSource1
            // 
            this.sortsBindingSource1.DataMember = "Sorts";
            this.sortsBindingSource1.DataSource = this.breweryDataSet16;
            // 
            // breweryDataSet16
            // 
            this.breweryDataSet16.DataSetName = "BreweryDataSet16";
            this.breweryDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cancel.Location = new System.Drawing.Point(274, 400);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(251, 37);
            this.button_Cancel.TabIndex = 43;
            this.button_Cancel.Text = "Відмінити";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.button_OK.FlatAppearance.BorderSize = 2;
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OK.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.ForeColor = System.Drawing.Color.DarkOrange;
            this.button_OK.Location = new System.Drawing.Point(19, 400);
            this.button_OK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(246, 37);
            this.button_OK.TabIndex = 42;
            this.button_OK.Text = "Ок";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Price2
            // 
            this.Price2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Price2.Location = new System.Drawing.Point(238, 332);
            this.Price2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Price2.Name = "Price2";
            this.Price2.Size = new System.Drawing.Size(287, 18);
            this.Price2.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Наявність(ящиків)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Тара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Об\'єм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID сорту";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Найменування товару";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            // 
            // sortsBindingSource3
            // 
            this.sortsBindingSource3.DataMember = "sorts";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(16, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "Ціна за ящик";
            // 
            // Amount
            // 
            this.Amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Amount.Location = new System.Drawing.Point(238, 266);
            this.Amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(287, 18);
            this.Amount.TabIndex = 38;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.breweryDataSet15;
            // 
            // breweryDataSet15
            // 
            this.breweryDataSet15.DataSetName = "BreweryDataSet15";
            this.breweryDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // sortsTableAdapter2
            // 
            this.sortsTableAdapter2.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(238, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 18);
            this.textBox1.TabIndex = 47;
            // 
            // breweryDataSet22
            // 
            this.breweryDataSet22.DataSetName = "BreweryDataSet22";
            this.breweryDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sortsBindingSource2
            // 
            this.sortsBindingSource2.DataMember = "Sorts";
            this.sortsBindingSource2.DataSource = this.breweryDataSet22;
            // 
            // sortsTableAdapter3
            // 
            this.sortsTableAdapter3.ClearBeforeFill = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 464);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Tara);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.Price2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Amount);
            this.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditForm";
            this.Text = "Редагування товару";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.breweryDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breweryDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breweryDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breweryDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breweryDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BreweryDataSet14TableAdapters.SortsTableAdapter sortsTableAdapter1;
        private BreweryDataSet14 breweryDataSet14;
        private BreweryDataSet13TableAdapters.SortsTableAdapter sortsTableAdapter;
        private System.Windows.Forms.BindingSource sortsBindingSource4;
        private BreweryDataSet13 breweryDataSet13;
        private System.Windows.Forms.BindingSource sortsBindingSource;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource sortsBindingSource3;
        private System.Windows.Forms.Label label7;
        private BreweryDataSet15 breweryDataSet15;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private BreweryDataSet15TableAdapters.ProductsTableAdapter productsTableAdapter;
        private BreweryDataSet16 breweryDataSet16;
        private System.Windows.Forms.BindingSource sortsBindingSource1;
        private BreweryDataSet16TableAdapters.SortsTableAdapter sortsTableAdapter2;
        public System.Windows.Forms.ComboBox Tara;
        public System.Windows.Forms.ComboBox Volume;
        public System.Windows.Forms.ComboBox Sort;
        public System.Windows.Forms.TextBox Price2;
        public System.Windows.Forms.TextBox Amount;
        public System.Windows.Forms.TextBox textBox1;
        private BreweryDataSet22 breweryDataSet22;
        private System.Windows.Forms.BindingSource sortsBindingSource2;
        private BreweryDataSet22TableAdapters.SortsTableAdapter sortsTableAdapter3;
    }
}