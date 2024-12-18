using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelDB.TableForms
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
            LoadCategoriesData();
        }
        private void LoadCategoriesData()
        {
            string connectionString = "server=localhost;port=3306;username=root;password=1234;database=HostelDB;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM staff";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        StaffTable.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка завантаження даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                MySqlCommand comm = new MySqlCommand("INSERT INTO staff (full_name, position, phone , email) VALUES (@fN, @pS, @pH , @eM)", db.GetConnection());

                comm.Parameters.Add("@fN", MySqlDbType.VarChar).Value = nameBox.Text;
                comm.Parameters.Add("@pS", MySqlDbType.VarChar).Value = positionList.SelectedItem?.ToString();
                comm.Parameters.Add("@pH", MySqlDbType.VarChar).Value = phoneBox.Text;
                comm.Parameters.Add("@eM", MySqlDbType.VarChar).Value = emailBox.Text;

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація додана успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    nameBox.Text = null;
                    positionList.SelectedItem = null;
                    phoneBox.Text = null;
                    emailBox.Text = null;
                }
                else
                    MessageBox.Show("Відхилено!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                db.closeConnection();
            }
            catch (FormatException)
            {
                MessageBox.Show("Не вірно введений формат данних!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка завантаження даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                MySqlCommand comm = new MySqlCommand("DELETE FROM staff WHERE full_name = @fN AND position = @pS AND phone = @pH AND email = @eM", db.GetConnection());

                comm.Parameters.Add("@fN", MySqlDbType.VarChar).Value = nameBox.Text;
                comm.Parameters.Add("@pS", MySqlDbType.VarChar).Value = positionList.SelectedItem?.ToString();
                comm.Parameters.Add("@pH", MySqlDbType.VarChar).Value = phoneBox.Text;
                comm.Parameters.Add("@eM", MySqlDbType.VarChar).Value = emailBox.Text;


                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація видалена успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    nameBox.Text = null;
                    positionList.SelectedItem = null;
                    phoneBox.Text = null;
                    emailBox.Text = null;
                }
                else
                    MessageBox.Show("Відхилено!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                db.closeConnection();
            }
            catch (FormatException)
            {
                MessageBox.Show("Не вірно введений формат данних!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка видалення даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                MySqlCommand comm = new MySqlCommand("UPDATE staff SET full_name = @fN, position = @pS, phone = @pH, email = @eM WHERE id = @ID", db.GetConnection());
                comm.Parameters.Add("@fN", MySqlDbType.VarChar).Value = nameBox.Text;
                comm.Parameters.Add("@pS", MySqlDbType.VarChar).Value = positionList.SelectedItem?.ToString();
                comm.Parameters.Add("@pH", MySqlDbType.VarChar).Value = phoneBox.Text;
                comm.Parameters.Add("@eM", MySqlDbType.VarChar).Value = emailBox.Text;
                comm.Parameters.Add("@ID", MySqlDbType.VarChar).Value = idBox.Text;

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація змінена успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    nameBox.Text = null;
                    positionList.SelectedItem = null;
                    phoneBox.Text = null;
                    emailBox.Text = null;
                    idBox.Text = null;
                }
                else
                    MessageBox.Show("Відхилено!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                db.closeConnection();
            }
            catch (FormatException)
            {
                MessageBox.Show("Не вірно введений формат данних!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка видалення даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }


    }
}
