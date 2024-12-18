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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HostelDB.TableForms
{
    public partial class ResidentsForm : Form
    {
        public ResidentsForm()
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

                    string query = "SELECT * FROM Residents";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        ResidentsTable.DataSource = dataTable;
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
                MySqlCommand comm = new MySqlCommand("INSERT INTO Residents (full_name, date_of_birth, gender , room_id) VALUES (@fN, @dB, @gV , @rI)", db.GetConnection());

                comm.Parameters.Add("@fN", MySqlDbType.VarChar).Value = nameBox.Text;
                comm.Parameters.Add("@dB", MySqlDbType.VarChar).Value = dateOfBirthBox.Text;
                comm.Parameters.Add("@gV", MySqlDbType.VarChar).Value = genderList.SelectedItem.ToString();
                comm.Parameters.Add("@rI", MySqlDbType.VarChar).Value = roomNumbBox.Text;

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація додана успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    nameBox.Text = null;
                    dateOfBirthBox.Text = null;
                    genderList.SelectedIndex = 0;
                    roomNumbBox.Text = null;
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
                MySqlCommand comm = new MySqlCommand("DELETE FROM Residents WHERE full_name = @fN AND date_of_birth = @dB AND gender = @gV AND room_id = @rI", db.GetConnection());

                comm.Parameters.Add("@fN", MySqlDbType.VarChar).Value = nameBox.Text;
                comm.Parameters.Add("@dB", MySqlDbType.VarChar).Value = dateOfBirthBox.Text;
                comm.Parameters.Add("@gV", MySqlDbType.VarChar).Value = genderList.SelectedItem.ToString();
                comm.Parameters.Add("@rI", MySqlDbType.VarChar).Value = roomNumbBox.Text;

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація видалена успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    nameBox.Text = null;
                    dateOfBirthBox.Text = null;
                    genderList.SelectedIndex = 0;
                    roomNumbBox.Text = null;
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                MySqlCommand comm = new MySqlCommand("UPDATE Residents SET full_name = @fN, date_of_birth = @dB, gender = @gV, room_id = @rI WHERE id = @ID", db.GetConnection());
                comm.Parameters.Add("@fN", MySqlDbType.VarChar).Value = nameBox.Text;
                comm.Parameters.Add("@dB", MySqlDbType.VarChar).Value = dateOfBirthBox.Text;
                comm.Parameters.Add("@gV", MySqlDbType.VarChar).Value = genderList.SelectedItem?.ToString();
                comm.Parameters.Add("@rI", MySqlDbType.VarChar).Value = roomNumbBox.Text;
                comm.Parameters.Add("@ID", MySqlDbType.VarChar).Value = idBox.Text;

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація змінена успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    nameBox.Text = null;
                    dateOfBirthBox.Text = null;
                    genderList.SelectedIndex = 0;
                    roomNumbBox.Text = null;
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
        }


    }
}
