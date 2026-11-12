namespace Книга_рецептов
{
    partial class AddRecipeForm
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
            this.iblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.txtIngredients = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.lblCookingTime = new System.Windows.Forms.Label();
            this.numCookingTime = new System.Windows.Forms.NumericUpDown();
            this.lblServings = new System.Windows.Forms.Label();
            this.numServings = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCookingTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServings)).BeginInit();
            this.SuspendLayout();
            // 
            // iblTitle
            // 
            this.iblTitle.AutoSize = true;
            this.iblTitle.Location = new System.Drawing.Point(24, 26);
            this.iblTitle.Name = "iblTitle";
            this.iblTitle.Size = new System.Drawing.Size(92, 13);
            this.iblTitle.TabIndex = 0;
            this.iblTitle.Text = "Название блюда";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(27, 61);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(163, 26);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(60, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Категория";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Завтрак",
            "Обед",
            "Ужин",
            "Десерт",
            "Напитки",
            "Выпечка"});
            this.cmbCategory.Location = new System.Drawing.Point(149, 61);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 3;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(306, 26);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(75, 13);
            this.lblIngredients.TabIndex = 4;
            this.lblIngredients.Text = "Ингридиенты";
            // 
            // txtIngredients
            // 
            this.txtIngredients.Location = new System.Drawing.Point(298, 62);
            this.txtIngredients.Multiline = true;
            this.txtIngredients.Name = "txtIngredients";
            this.txtIngredients.Size = new System.Drawing.Size(100, 20);
            this.txtIngredients.TabIndex = 5;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(452, 26);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(123, 13);
            this.lblInstructions.TabIndex = 6;
            this.lblInstructions.Text = "Способ приготовления";
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(455, 61);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(100, 20);
            this.txtInstructions.TabIndex = 7;
            // 
            // lblCookingTime
            // 
            this.lblCookingTime.AutoSize = true;
            this.lblCookingTime.Location = new System.Drawing.Point(27, 155);
            this.lblCookingTime.Name = "lblCookingTime";
            this.lblCookingTime.Size = new System.Drawing.Size(151, 13);
            this.lblCookingTime.TabIndex = 8;
            this.lblCookingTime.Text = "Время приготовления (мин.)";
            // 
            // numCookingTime
            // 
            this.numCookingTime.Location = new System.Drawing.Point(45, 197);
            this.numCookingTime.Name = "numCookingTime";
            this.numCookingTime.Size = new System.Drawing.Size(120, 20);
            this.numCookingTime.TabIndex = 9;
            // 
            // lblServings
            // 
            this.lblServings.AutoSize = true;
            this.lblServings.Location = new System.Drawing.Point(226, 155);
            this.lblServings.Name = "lblServings";
            this.lblServings.Size = new System.Drawing.Size(105, 13);
            this.lblServings.TabIndex = 10;
            this.lblServings.Text = "Количество порций";
            // 
            // numServings
            // 
            this.numServings.Location = new System.Drawing.Point(211, 197);
            this.numServings.Name = "numServings";
            this.numServings.Size = new System.Drawing.Size(120, 20);
            this.numServings.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(89, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(269, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 611);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numServings);
            this.Controls.Add(this.lblServings);
            this.Controls.Add(this.numCookingTime);
            this.Controls.Add(this.lblCookingTime);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtIngredients);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.iblTitle);
            this.Name = "AddRecipeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление рецепта";
            ((System.ComponentModel.ISupportInitialize)(this.numCookingTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label iblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.TextBox txtIngredients;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Label lblCookingTime;
        private System.Windows.Forms.NumericUpDown numCookingTime;
        private System.Windows.Forms.Label lblServings;
        private System.Windows.Forms.NumericUpDown numServings;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}