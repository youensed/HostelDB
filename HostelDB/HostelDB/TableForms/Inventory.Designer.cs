namespace HostelDB.TableForms
{
    partial class Inventory
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
            idBox = new TextBox();
            label2 = new Label();
            updateButton = new Button();
            label1 = new Label();
            roomNumbBox = new TextBox();
            buttonBackToMenu = new Button();
            delButton = new Button();
            buttonAdd = new Button();
            labelFloor = new Label();
            purchDateBox = new TextBox();
            labelDateOfBirth = new Label();
            quantityBox = new TextBox();
            nameRes = new Label();
            itemNameBox = new TextBox();
            InventoryTable = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InventoryTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(roomNumbBox);
            panel1.Controls.Add(buttonBackToMenu);
            panel1.Controls.Add(delButton);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(labelFloor);
            panel1.Controls.Add(purchDateBox);
            panel1.Controls.Add(labelDateOfBirth);
            panel1.Controls.Add(quantityBox);
            panel1.Controls.Add(nameRes);
            panel1.Controls.Add(itemNameBox);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 397);
            panel1.Name = "panel1";
            panel1.Size = new Size(1121, 176);
            panel1.TabIndex = 1;
            // 
            // idBox
            // 
            idBox.Location = new Point(860, 23);
            idBox.Name = "idBox";
            idBox.Size = new Size(178, 31);
            idBox.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(812, 25);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(317, 92);
            label1.Name = "label1";
            label1.Size = new Size(176, 26);
            label1.TabIndex = 12;
            label1.Text = "Номер кімнати";
            // 
            // roomNumbBox
            // 
            roomNumbBox.Location = new Point(317, 121);
            roomNumbBox.Name = "roomNumbBox";
            roomNumbBox.Size = new Size(178, 31);
            roomNumbBox.TabIndex = 11;
            // 
            // buttonBackToMenu
            // 
            buttonBackToMenu.Location = new Point(922, 130);
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
            delButton.Size = new Size(268, 46);
            delButton.TabIndex = 9;
            delButton.Text = "Видалити запис";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(516, 37);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(268, 49);
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
            labelFloor.Size = new Size(163, 26);
            labelFloor.TabIndex = 7;
            labelFloor.Text = "Дата покупки";
            // 
            // purchDateBox
            // 
            purchDateBox.Location = new Point(317, 49);
            purchDateBox.Name = "purchDateBox";
            purchDateBox.Size = new Size(178, 31);
            purchDateBox.TabIndex = 6;
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDateOfBirth.ForeColor = SystemColors.ButtonFace;
            labelDateOfBirth.Location = new Point(28, 92);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(116, 26);
            labelDateOfBirth.TabIndex = 3;
            labelDateOfBirth.Text = "Кількість";
            // 
            // quantityBox
            // 
            quantityBox.Location = new Point(28, 121);
            quantityBox.Name = "quantityBox";
            quantityBox.Size = new Size(254, 31);
            quantityBox.TabIndex = 2;
            // 
            // nameRes
            // 
            nameRes.AutoSize = true;
            nameRes.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameRes.ForeColor = SystemColors.ButtonFace;
            nameRes.Location = new Point(28, 20);
            nameRes.Name = "nameRes";
            nameRes.Size = new Size(189, 26);
            nameRes.TabIndex = 1;
            nameRes.Text = "Назва Предмету";
            // 
            // itemNameBox
            // 
            itemNameBox.Location = new Point(28, 49);
            itemNameBox.Name = "itemNameBox";
            itemNameBox.Size = new Size(254, 31);
            itemNameBox.TabIndex = 0;
            // 
            // InventoryTable
            // 
            InventoryTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InventoryTable.BackgroundColor = SystemColors.Control;
            InventoryTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryTable.Dock = DockStyle.Top;
            InventoryTable.GridColor = SystemColors.Menu;
            InventoryTable.Location = new Point(0, 0);
            InventoryTable.Name = "InventoryTable";
            InventoryTable.RowHeadersWidth = 62;
            InventoryTable.Size = new Size(1121, 406);
            InventoryTable.TabIndex = 2;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 573);
            Controls.Add(InventoryTable);
            Controls.Add(panel1);
            Name = "Inventory";
            Text = "Inventory";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InventoryTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonBackToMenu;
        private Button delButton;
        private Button buttonAdd;
        private Label labelFloor;
        private TextBox purchDateBox;
        private Label labelDateOfBirth;
        private TextBox quantityBox;
        private Label nameRes;
        private TextBox itemNameBox;
        private DataGridView InventoryTable;
        private Label label1;
        private TextBox roomNumbBox;
        private TextBox idBox;
        private Label label2;
        private Button updateButton;
    }
}