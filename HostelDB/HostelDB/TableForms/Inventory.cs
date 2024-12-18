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
    public partial class Inventory : Form
    {
        public Inventory()
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

                    string query = "SELECT * FROM Inventory";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        InventoryTable.DataSource = dataTable;
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
                MySqlCommand comm = new MySqlCommand("INSERT INTO Inventory (item_name, quantity, purchase_date , room_id) VALUES (@iN, @qV, @pD , @rI)", db.GetConnection());

                comm.Parameters.Add("@iN", MySqlDbType.VarChar).Value = itemNameBox.Text;
                comm.Parameters.Add("@qV", MySqlDbType.VarChar).Value = quantityBox.Text;
                comm.Parameters.Add("@pD", MySqlDbType.VarChar).Value = purchDateBox.Text;
                comm.Parameters.Add("@rI", MySqlDbType.VarChar).Value = roomNumbBox.Text;

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація додана успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    itemNameBox.Text = null;
                    quantityBox.Text = null;
                    purchDateBox.Text = null;
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
                MySqlCommand comm = new MySqlCommand("DELETE FROM Inventory WHERE item_name = @iN AND quantity = @qV AND purchase_date = @pD AND room_id = @rI", db.GetConnection());

                comm.Parameters.Add("@iN", MySqlDbType.VarChar).Value = itemNameBox.Text;
                comm.Parameters.Add("@qV", MySqlDbType.VarChar).Value = quantityBox.Text;
                comm.Parameters.Add("@pD", MySqlDbType.VarChar).Value = purchDateBox.Text;
                comm.Parameters.Add("@rI", MySqlDbType.VarChar).Value = roomNumbBox.Text;


                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація видалена успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    itemNameBox.Text = null;
                    quantityBox.Text = null;
                    purchDateBox.Text = null;
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
                MySqlCommand comm = new MySqlCommand("UPDATE Inventory SET item_name = @iN, quantity = @qV, purchase_date = @pD, room_id = @rI WHERE id = @ID", db.GetConnection());
                comm.Parameters.Add("@iN", MySqlDbType.VarChar).Value = itemNameBox.Text;
                comm.Parameters.Add("@qV", MySqlDbType.VarChar).Value = quantityBox.Text;
                comm.Parameters.Add("@pD", MySqlDbType.VarChar).Value = purchDateBox.Text;
                comm.Parameters.Add("@rI", MySqlDbType.VarChar).Value = roomNumbBox.Text;
                comm.Parameters.Add("@ID", MySqlDbType.VarChar).Value = idBox.Text;

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація змінена успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    itemNameBox.Text = null;
                    quantityBox.Text = null;
                    purchDateBox.Text = null;
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
