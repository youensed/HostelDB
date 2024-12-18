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
    public partial class PaymentsForm : Form
    {
        public PaymentsForm()
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

                    string query = "SELECT * FROM payments";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        PaymentsTable.DataSource = dataTable;
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
                MySqlCommand comm = new MySqlCommand("INSERT INTO payments (resident_id, amount, payment_date , payment_method) VALUES (@rI, @aM, @pD , @pM)", db.GetConnection());

                comm.Parameters.Add("@rI", MySqlDbType.VarChar).Value = personIDBox.Text;
                comm.Parameters.Add("@aM", MySqlDbType.VarChar).Value = amountBox.Text;
                comm.Parameters.Add("@pD", MySqlDbType.VarChar).Value = paymentDateBox.Text;
                comm.Parameters.Add("@pM", MySqlDbType.VarChar).Value = methodList.SelectedItem?.ToString(); 

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація додана успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    personIDBox.Text = null;
                    methodList.SelectedItem = null;
                    paymentDateBox.Text = null;
                    amountBox.Text = null;
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
                MySqlCommand comm = new MySqlCommand("DELETE FROM payments WHERE resident_id = @rI AND amount = @aM AND payment_date = @pD AND payment_method = @pM", db.GetConnection());

                comm.Parameters.Add("@rI", MySqlDbType.VarChar).Value = personIDBox.Text;
                comm.Parameters.Add("@aM", MySqlDbType.VarChar).Value = amountBox.Text;
                comm.Parameters.Add("@pD", MySqlDbType.VarChar).Value = paymentDateBox.Text;
                comm.Parameters.Add("@pM", MySqlDbType.VarChar).Value = methodList.SelectedItem?.ToString();


                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація видалена успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    personIDBox.Text = null;
                    methodList.SelectedItem = null;
                    paymentDateBox.Text = null;
                    amountBox.Text = null;
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                MySqlCommand comm = new MySqlCommand("UPDATE payments SET resident_id = @rI, amount = @aM, payment_date = @pD, payment_method = @pM WHERE id = @ID", db.GetConnection());
                comm.Parameters.Add("@rI", MySqlDbType.VarChar).Value = personIDBox.Text;
                comm.Parameters.Add("@aM", MySqlDbType.VarChar).Value = amountBox.Text;
                comm.Parameters.Add("@pD", MySqlDbType.VarChar).Value = paymentDateBox.Text;
                comm.Parameters.Add("@pM", MySqlDbType.VarChar).Value = methodList.SelectedItem?.ToString();
                comm.Parameters.Add("@ID", MySqlDbType.VarChar).Value = idBox.Text;

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація змінена успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    personIDBox.Text = null;
                    methodList.SelectedItem = null;
                    paymentDateBox.Text = null;
                    amountBox.Text = null;
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
