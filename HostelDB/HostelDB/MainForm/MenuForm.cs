using HostelDB.TableForms;

namespace HostelDB
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private void buttonRooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomForm roomForm = new RoomForm();
            roomForm.Show();
        }

        private void buttonResidents_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResidentsForm residentForm = new ResidentsForm();
            residentForm.Show();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory inventory = new Inventory();
            inventory.Show();
        }

        private void buttonRegestration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegestrationsForm regestrationsForm = new RegestrationsForm();
            regestrationsForm.Show();
        }

        private void buttonPasses_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassesForm passesForm = new PassesForm();
            passesForm.Show();

        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffForm staffForm = new StaffForm();
            staffForm.Show();
        }

        private void buttonPayments_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentsForm paymentsForm = new PaymentsForm();
            paymentsForm.Show();
        }

        private void buttonMaintance_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaintanceForm maintanceForm = new MaintanceForm();
            maintanceForm.Show();

        }

        private void buttonRools_Click(object sender, EventArgs e)
        {
            this.Hide();
            RulesForm rulesForm = new RulesForm();
            rulesForm.Show();
        }
    }
}
