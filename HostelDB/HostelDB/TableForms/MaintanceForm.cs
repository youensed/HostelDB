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
    public partial class MaintanceForm : Form
    {
        public MaintanceForm()
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

                    string query = "SELECT * FROM Maintenance";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        MaintanceTable.DataSource = dataTable;
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
                MySqlCommand comm = new MySqlCommand("INSERT INTO Maintenance (room_number, staff_id, request_date , completion_date , status) VALUES (@rN, @sI, @rD , @cD , @sT)", db.GetConnection());

                comm.Parameters.Add("@rN", MySqlDbType.VarChar).Value = roomNumbBox.Text;
                comm.Parameters.Add("@sI", MySqlDbType.VarChar).Value = staffIDBox.Text;
                comm.Parameters.Add("@rD", MySqlDbType.VarChar).Value = dateInBox.Text;
                comm.Parameters.Add("@cD", MySqlDbType.VarChar).Value = dateOutBox.Text;
                comm.Parameters.Add("@sT", MySqlDbType.VarChar).Value = statusList.SelectedItem?.ToString();


                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація додана успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    roomNumb.Text = null;
                    staffIDBox.Text = null;
                    dateInBox.Text = null;
                    dateOutBox.Text = null;
                    statusList.SelectedIndex = 0;
                    
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
                MySqlCommand comm = new MySqlCommand("DELETE FROM Maintenance WHERE room_number = @rN AND staff_id = @sI AND request_date = @rD AND completion_date = @cD AND status = @sT", db.GetConnection());

                comm.Parameters.Add("@rN", MySqlDbType.VarChar).Value = roomNumbBox.Text;
                comm.Parameters.Add("@sI", MySqlDbType.VarChar).Value = staffIDBox.Text;
                comm.Parameters.Add("@rD", MySqlDbType.VarChar).Value = dateInBox.Text;
                comm.Parameters.Add("@cD", MySqlDbType.VarChar).Value = dateOutBox.Text;
                comm.Parameters.Add("@sT", MySqlDbType.VarChar).Value = statusList.SelectedItem?.ToString();

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація видалена успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    roomNumb.Text = null;
                    staffIDBox.Text = null;
                    dateInBox.Text = null;
                    dateOutBox.Text = null;
                    statusList.SelectedIndex = 0;
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
                MySqlCommand comm = new MySqlCommand("UPDATE Maintenance SET room_number = @rN, staff_id = @sI , request_date = @rD , completion_date = @cD , status = @sT", db.GetConnection());
                comm.Parameters.Add("@rN", MySqlDbType.VarChar).Value = roomNumbBox.Text;
                comm.Parameters.Add("@sI", MySqlDbType.VarChar).Value = staffIDBox.Text;
                comm.Parameters.Add("@rD", MySqlDbType.VarChar).Value = dateInBox.Text;
                comm.Parameters.Add("@cD", MySqlDbType.VarChar).Value = dateOutBox.Text;
                comm.Parameters.Add("@sT", MySqlDbType.VarChar).Value = statusList.SelectedItem?.ToString();
                comm.Parameters.Add("@ID", MySqlDbType.VarChar).Value = idBox.Text;

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація змінена успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    roomNumb.Text = null;
                    staffIDBox.Text = null;
                    dateInBox.Text = null;
                    dateOutBox.Text = null;
                    statusList.SelectedIndex = 0;
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
