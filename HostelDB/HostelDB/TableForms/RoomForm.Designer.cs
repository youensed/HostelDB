namespace HostelDB.TableForms
{
    partial class RoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonBackToMenu = new Button();
            delButton = new Button();
            buttonAdd = new Button();
            labelFloor = new Label();
            floorBox = new TextBox();
            labelDateOfBirth = new Label();
            capacityOfRoomBox = new TextBox();
            nameRes = new Label();
            roomNumbBox = new TextBox();
            RoomTable = new DataGridView();
            idBox = new TextBox();
            label2 = new Label();
            updateButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RoomTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(buttonBackToMenu);
            panel1.Controls.Add(delButton);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(labelFloor);
            panel1.Controls.Add(floorBox);
            panel1.Controls.Add(labelDateOfBirth);
            panel1.Controls.Add(capacityOfRoomBox);
            panel1.Controls.Add(nameRes);
            panel1.Controls.Add(roomNumbBox);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 404);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 176);
            panel1.TabIndex = 0;
            // 
            // buttonBackToMenu
            // 
            buttonBackToMenu.Location = new Point(904, 130);
            buttonBackToMenu.Name = "buttonBackToMenu";
            buttonBackToMenu.Size = new Size(187, 34);
            buttonBackToMenu.TabIndex = 10;
            buttonBackToMenu.Text = "Головне меню";
            buttonBackToMenu.UseVisualStyleBackColor = true;
            buttonBackToMenu.Click += buttonBackToMenu_Click;
            // 
            // delButton
            // 
            delButton.Location = new Point(516, 106);
            delButton.Name = "delButton";
            delButton.Size = new Size(262, 46);
            delButton.TabIndex = 9;
            delButton.Text = "Видалити запис";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(516, 37);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(262, 49);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Додати запис";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelFloor
            // 
            labelFloor.AutoSize = true;
            labelFloor.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelFloor.ForeColor = SystemColors.ButtonFace;
            labelFloor.Location = new Point(317, 20);
            labelFloor.Name = "labelFloor";
            labelFloor.Size = new Size(91, 26);
            labelFloor.TabIndex = 7;
            labelFloor.Text = "Поверх";
            // 
            // floorBox
            // 
            floorBox.Location = new Point(317, 49);
            floorBox.Name = "floorBox";
            floorBox.Size = new Size(178, 31);
            floorBox.TabIndex = 6;
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDateOfBirth.ForeColor = SystemColors.ButtonFace;
            labelDateOfBirth.Location = new Point(28, 92);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(119, 26);
            labelDateOfBirth.TabIndex = 3;
            labelDateOfBirth.Text = "Місткість";
            // 
            // capacityOfRoomBox
            // 
            capacityOfRoomBox.Location = new Point(28, 121);
            capacityOfRoomBox.Name = "capacityOfRoomBox";
            capacityOfRoomBox.Size = new Size(254, 31);
            capacityOfRoomBox.TabIndex = 2;
            // 
            // nameRes
            // 
            nameRes.AutoSize = true;
            nameRes.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameRes.ForeColor = SystemColors.ButtonFace;
            nameRes.Location = new Point(28, 20);
            nameRes.Name = "nameRes";
            nameRes.Size = new Size(176, 26);
            nameRes.TabIndex = 1;
            nameRes.Text = "Номер кімнати";
            // 
            // roomNumbBox
            // 
            roomNumbBox.Location = new Point(28, 49);
            roomNumbBox.Name = "roomNumbBox";
            roomNumbBox.Size = new Size(254, 31);
            roomNumbBox.TabIndex = 0;
            // 
            // RoomTable
            // 
            RoomTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RoomTable.BackgroundColor = SystemColors.Control;
            RoomTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RoomTable.Dock = DockStyle.Top;
            RoomTable.GridColor = SystemColors.Menu;
            RoomTable.Location = new Point(0, 0);
            RoomTable.Name = "RoomTable";
            RoomTable.RowHeadersWidth = 62;
            RoomTable.Size = new Size(1113, 406);
            RoomTable.TabIndex = 1;
            // 
            // idBox
            // 
            idBox.Location = new Point(860, 29);
            idBox.Name = "idBox";
            idBox.Size = new Size(178, 31);
            idBox.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(812, 31);
            label2.Name = "label2";
            label2.Size = new Size(42, 26);
            label2.TabIndex = 17;
            label2.Text = "Id:";
            // 
            // updateButton
            // 
            updateButton.Location = new Point(812, 69);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(279, 49);
            updateButton.TabIndex = 16;
            updateButton.Text = "Редагувати запис";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 580);
            Controls.Add(RoomTable);
            Controls.Add(panel1);
            Name = "RoomForm";
            Text = "Кімнати";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RoomTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView RoomTable;
        private TextBox roomNumbBox;
        private Label labelDateOfBirth;
        private TextBox capacityOfRoomBox;
        private Label nameRes;
        private Label labelFloor;
        private TextBox floorBox;
        private Button buttonAdd;
        private Button delButton;
        private Button buttonBackToMenu;
        private TextBox idBox;
        private Label label2;
        private Button updateButton;
    }
}