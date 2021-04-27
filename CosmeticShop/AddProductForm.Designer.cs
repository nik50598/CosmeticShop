
namespace CosmeticShop
{
    partial class AddProductForm
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
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label isActiveLabel;
            System.Windows.Forms.Label mainImagePathLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label manufacturerIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.mainImagePathTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerIDComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit_button = new System.Windows.Forms.Button();
            this.AddProduct_button = new System.Windows.Forms.Button();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            costLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            mainImagePathLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            manufacturerIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(98, 111);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(35, 14);
            costLabel.TabIndex = 1;
            costLabel.Text = "Цена";
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(139, 108);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(121, 22);
            this.costTextBox.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(62, 237);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 14);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Описание";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(139, 234);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(248, 120);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new System.Drawing.Point(80, 172);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(54, 14);
            isActiveLabel.TabIndex = 7;
            isActiveLabel.Text = "Активен";
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "IsActive", true));
            this.isActiveCheckBox.Location = new System.Drawing.Point(140, 162);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(121, 37);
            this.isActiveCheckBox.TabIndex = 8;
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // mainImagePathLabel
            // 
            mainImagePathLabel.AutoSize = true;
            mainImagePathLabel.Location = new System.Drawing.Point(7, 139);
            mainImagePathLabel.Name = "mainImagePathLabel";
            mainImagePathLabel.Size = new System.Drawing.Size(126, 14);
            mainImagePathLabel.TabIndex = 9;
            mainImagePathLabel.Text = "Путь к изображению";
            // 
            // mainImagePathTextBox
            // 
            this.mainImagePathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MainImagePath", true));
            this.mainImagePathTextBox.Location = new System.Drawing.Point(139, 136);
            this.mainImagePathTextBox.Name = "mainImagePathTextBox";
            this.mainImagePathTextBox.Size = new System.Drawing.Size(121, 22);
            this.mainImagePathTextBox.TabIndex = 10;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(74, 78);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(59, 14);
            titleLabel.TabIndex = 13;
            titleLabel.Text = "Название";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(139, 75);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(121, 22);
            this.titleTextBox.TabIndex = 14;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(CosmeticShop.Product);
            // 
            // manufacturerIDLabel
            // 
            manufacturerIDLabel.AutoSize = true;
            manufacturerIDLabel.Location = new System.Drawing.Point(11, 205);
            manufacturerIDLabel.Name = "manufacturerIDLabel";
            manufacturerIDLabel.Size = new System.Drawing.Size(123, 14);
            manufacturerIDLabel.TabIndex = 14;
            manufacturerIDLabel.Text = " ID Производителя :";
            // 
            // manufacturerIDComboBox
            // 
            this.manufacturerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "Manufacturer", true));
            this.manufacturerIDComboBox.DataSource = this.manufacturerBindingSource;
            this.manufacturerIDComboBox.DisplayMember = "Name";
            this.manufacturerIDComboBox.FormattingEnabled = true;
            this.manufacturerIDComboBox.Location = new System.Drawing.Point(140, 202);
            this.manufacturerIDComboBox.Name = "manufacturerIDComboBox";
            this.manufacturerIDComboBox.Size = new System.Drawing.Size(121, 22);
            this.manufacturerIDComboBox.TabIndex = 15;
            this.manufacturerIDComboBox.ValueMember = "ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AddProduct_button);
            this.panel2.Controls.Add(this.Exit_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 64);
            this.panel2.TabIndex = 16;
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(802, 12);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(87, 25);
            this.Exit_button.TabIndex = 3;
            this.Exit_button.Text = "Назад";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // AddProduct_button
            // 
            this.AddProduct_button.Location = new System.Drawing.Point(10, 12);
            this.AddProduct_button.Name = "AddProduct_button";
            this.AddProduct_button.Size = new System.Drawing.Size(75, 23);
            this.AddProduct_button.TabIndex = 4;
            this.AddProduct_button.Text = "Добавить";
            this.AddProduct_button.UseVisualStyleBackColor = true;
            this.AddProduct_button.Click += new System.EventHandler(this.AddProduct_button_Click);
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataSource = typeof(CosmeticShop.Manufacturer);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 473);
            this.Controls.Add(this.panel2);
            this.Controls.Add(manufacturerIDLabel);
            this.Controls.Add(this.manufacturerIDComboBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(isActiveLabel);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(mainImagePathLabel);
            this.Controls.Add(this.mainImagePathTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductForm";
            this.Text = "Add Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProduct_Closing);
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.TextBox mainImagePathTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ComboBox manufacturerIDComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button AddProduct_button;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
    }
}