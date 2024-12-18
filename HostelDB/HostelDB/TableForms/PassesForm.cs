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
    public partial class PassesForm : Form
    {
        public PassesForm()
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

                    string query = "SELECT * FROM passes";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        PassesTable.DataSource = dataTable;
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
                MySqlCommand comm = new MySqlCommand("INSERT INTO passes (resident_id, pass_type, issue_date , expiration_date) VALUES (@rI, @pT, @iD , @eD)", db.GetConnection());

                comm.Parameters.Add("@rI", MySqlDbType.VarChar).Value = personIDBox.Text;
                comm.Parameters.Add("@pT", MySqlDbType.VarChar).Value = passTypeBox.SelectedItem?.ToString();
                comm.Parameters.Add("@iD", MySqlDbType.VarChar).Value = issueDateBox.Text;
                comm.Parameters.Add("@eD", MySqlDbType.VarChar).Value = expDateBox.Text;

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація додана успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    personIDBox.Text = null;
                    passTypeBox.SelectedIndex = 0;
                    issueDateBox.Text = null;
                    expDateBox.Text = null;
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
                MySqlCommand comm = new MySqlCommand("DELETE FROM passes WHERE resident_id = @rI AND pass_type = @pT AND issue_date = @iD AND expiration_date = @eD", db.GetConnection());

                comm.Parameters.Add("@rI", MySqlDbType.VarChar).Value = personIDBox.Text;
                comm.Parameters.Add("@pT", MySqlDbType.VarChar).Value = passTypeBox.SelectedItem?.ToString();
                comm.Parameters.Add("@iD", MySqlDbType.VarChar).Value = issueDateBox.Text;
                comm.Parameters.Add("@eD", MySqlDbType.VarChar).Value = expDateBox.Text;


                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація видалена успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    personIDBox.Text = null;
                    passTypeBox.SelectedIndex = 0;
                    issueDateBox.Text = null;
                    expDateBox.Text = null;
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
                MySqlCommand comm = new MySqlCommand("UPDATE passes SET resident_id = @rI, pass_type = @pT, issue_date = @isD, expiration_date = @eD WHERE id = @ID", db.GetConnection());
                comm.Parameters.Add("@rI", MySqlDbType.VarChar).Value = personIDBox.Text;
                comm.Parameters.Add("@pT", MySqlDbType.VarChar).Value = passTypeBox.SelectedItem?.ToString();
                comm.Parameters.Add("@isD", MySqlDbType.VarChar).Value = issueDateBox.Text;
                comm.Parameters.Add("@eD", MySqlDbType.VarChar).Value = expDateBox.Text;
                comm.Parameters.Add("@ID", MySqlDbType.VarChar).Value = idBox.Text;

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація змінена успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    personIDBox.Text = null;
                    passTypeBox.SelectedIndex = 0;
                    issueDateBox.Text = null;
                    expDateBox.Text = null;
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

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }
    }
}
