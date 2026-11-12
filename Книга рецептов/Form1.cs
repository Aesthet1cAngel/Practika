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
    public partial class Form1 : Form
    {
        private string userRole;

        public Form1() : this("Администратор")
        {
        }
            
        public Form1(string role)
        {

            InitializeComponent();

            userRole = role;

            recipesTableAdapter.Fill(recipesDataSet.Recipes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "recipesDataSet.Recipes". При необходимости она может быть перемещена или удалена.
            this.recipesTableAdapter.Fill(this.recipesDataSet.Recipes);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddRecipeForm form = new AddRecipeForm())
            { 
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        recipesTableAdapter.Insert(
                            form.RecipeTitle,
                            form.RecipeCategory,
                            form.RecipeIngredients,
                            form.RecipeInstructions,
                            form.RecipeCookingTime,
                            form.RecipeServings
                            );

                        recipesTableAdapter.Fill(recipesDataSet.Recipes);

                        MessageBox.Show("Рецепт успешно добавлен!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка:" + ex.Message);
                    }

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRecipes.CurrentRow == null)
            {
                MessageBox.Show("Выберите рецепт для удаления!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить выбранный рецепт?",
                "Потверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes )
            {
                try
                {
                    int id = Convert.ToInt32(
                        dgvRecipes.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value
                        );

                    recipesTableAdapter.DeleteQuery(id);

                    recipesTableAdapter.Fill(recipesDataSet.Recipes);

                    MessageBox.Show("Рецепт успешно удалён!");
                }
                catch (Exception ex ) 
                {
                    MessageBox.Show(
                            "Ошибка удаления:" + ex.Message
                        );
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    recipesBindingSource.RemoveFilter();
                }
                else
                {
                    string safeText = searchText.Replace("'", "''");

                    recipesBindingSource.Filter =
                        "[Title] LIKE '%" + safeText + "%'";

                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRecipes.CurrentCell == null)
        {
            MessageBox.Show("Выберите рецепт для изменения!");
            return;
        }

        try
        {
                int rowIndex = dgvRecipes.CurrentCell.RowIndex;

        DataRowView selectedRow =
            dgvRecipes.Rows[rowIndex].DataBoundItem as DataRowView;

        if (selectedRow == null)
        {
            MessageBox.Show("Не удалось получить данные рецепта!");
            return;
            }
                using (AddRecipeForm form = new AddRecipeForm())
                {
                    form.LoadRecipe(
                        Convert.ToString(selectedRow["Title"]),
                        Convert.ToString(selectedRow["Category"]),
                        Convert.ToString(selectedRow["Ingredients"]),
                        Convert.ToString(selectedRow["Instructions"]),
                        Convert.ToInt32(selectedRow["CookingTime"]),
                        Convert.ToInt32(selectedRow["Servings"])
                        );
                    
                    if (form.ShowDialog() == DialogResult.OK) 
                    {
                        selectedRow["Title"] = form.RecipeTitle;
                        selectedRow["Category"] = form.RecipeCategory;
                        selectedRow["Ingredients"] = form.RecipeIngredients;
                        selectedRow["Instructions"] = form.RecipeInstructions;
                        selectedRow["CookingTime"] = form.RecipeCookingTime;
                        selectedRow["Servings"] = form.RecipeServings;

                        recipesTableAdapter.Update(recipesDataSet.Recipes);
                        recipesTableAdapter.Fill(recipesDataSet.Recipes);

                        MessageBox.Show("Рецепт успешно изменён");
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ошибка изменения:" + ex.Message);





            }
    }

    }
}
