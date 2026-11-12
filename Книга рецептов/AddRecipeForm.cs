using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Книга_рецептов
{
    public partial class AddRecipeForm : Form
    {
        public AddRecipeForm()
        {
            InitializeComponent();
        }

        public string RecipeTitle =>  txtTitle.Text.Trim();
        public string RecipeCategory =>  cmbCategory.Text;
        public string RecipeIngredients => txtIngredients.Text.Trim();
        public string RecipeInstructions => txtInstructions.Text.Trim();
        public int RecipeCookingTime => (int)numCookingTime.Value;
        public int RecipeServings => (int)numServings.Value;

        public void LoadRecipe(
            string title,
            string category,
            string ingredients,
            string instructions,
            int cookingTime,
            int servings)
        {
            txtTitle.Text = title;
            cmbCategory.Text = category;
            txtIngredients.Text = ingredients;
            txtInstructions.Text = instructions;

            numCookingTime.Value = Math.Max(
                numCookingTime.Minimum,
                Math.Min(numCookingTime.Maximum, cookingTime));

            numServings.Value = Math.Max(
                numServings.Minimum,
                Math.Min(numServings.Maximum, servings));
        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Введите название блюда!");
                return;
}
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите категорию!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIngredients.Text))
            {
                MessageBox.Show("Введите ингридиенты!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtInstructions.Text))
            {
                MessageBox.Show("Введите способ приготовления");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


