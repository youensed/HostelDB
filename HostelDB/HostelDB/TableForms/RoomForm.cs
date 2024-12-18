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
    public partial class RoomForm : Form
    {
        public RoomForm()
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

                    string query = "SELECT * FROM Rooms";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        RoomTable.DataSource = dataTable;
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
                MySqlCommand comm = new MySqlCommand("INSERT INTO Rooms (room_number, capacity, floor) VALUES (@rN, @cR, @fN)", db.GetConnection());

                comm.Parameters.Add("@rN", MySqlDbType.VarChar).Value = roomNumbBox.Text;
                comm.Parameters.Add("@cR", MySqlDbType.VarChar).Value = capacityOfRoomBox.Text;
                comm.Parameters.Add("@fN", MySqlDbType.VarChar).Value = floorBox.Text;

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація додана успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    roomNumbBox.Text = null;
                    capacityOfRoomBox.Text = null;
                    floorBox.Text = null;
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
            {
                try
                {
                    DB db = new DB();
                    MySqlCommand comm = new MySqlCommand("DELETE FROM Rooms WHERE room_number = @rN AND capacity = @cR AND floor = @fN", db.GetConnection());

                    comm.Parameters.Add("@rN", MySqlDbType.VarChar).Value = roomNumbBox.Text;
                    comm.Parameters.Add("@cR", MySqlDbType.VarChar).Value = capacityOfRoomBox.Text;
                    comm.Parameters.Add("@fN", MySqlDbType.VarChar).Value = floorBox.Text;

                    db.openConnection();

                    if (comm.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Інформація видалена успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCategoriesData();
                        roomNumbBox.Text = null;
                        capacityOfRoomBox.Text = null;
                        floorBox.Text = null;
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
                MySqlCommand comm = new MySqlCommand("UPDATE rooms SET room_number = @rN, capacity = @cA, floor = @fL WHERE id = @ID", db.GetConnection());
                comm.Parameters.Add("@rN", MySqlDbType.VarChar).Value = roomNumbBox.Text;
                comm.Parameters.Add("@cA", MySqlDbType.VarChar).Value = capacityOfRoomBox.Text;
                comm.Parameters.Add("@fL", MySqlDbType.VarChar).Value = floorBox.Text;
                comm.Parameters.Add("@ID", MySqlDbType.VarChar).Value = idBox.Text;

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація змінена успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoriesData();
                    roomNumbBox.Text = null;
                    capacityOfRoomBox.Text = null;
                    floorBox.Text = null;
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
