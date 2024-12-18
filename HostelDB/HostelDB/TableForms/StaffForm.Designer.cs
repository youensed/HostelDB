namespace HostelDB.TableForms
{
    partial class StaffForm
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
            positionList = new ListBox();
            buttonBackToMenu = new Button();
            delButton = new Button();
            buttonAdd = new Button();
            roomNumb = new Label();
            phoneBox = new TextBox();
            labelDateOfBirth = new Label();
            emailBox = new TextBox();
            nameOfRes = new Label();
            nameBox = new TextBox();
            StaffTable = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StaffTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(positionList);
            panel1.Controls.Add(buttonBackToMenu);
            panel1.Controls.Add(delButton);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(roomNumb);
            panel1.Controls.Add(phoneBox);
            panel1.Controls.Add(labelDateOfBirth);
            panel1.Controls.Add(emailBox);
            panel1.Controls.Add(nameOfRes);
            panel1.Controls.Add(nameBox);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 397);
            panel1.Name = "panel1";
            panel1.Size = new Size(1135, 176);
            panel1.TabIndex = 2;
            // 
            // idBox
            // 
            idBox.Location = new Point(884, 35);
            idBox.Name = "idBox";
            idBox.Size = new Size(178, 31);
            idBox.TabIndex = 15;

            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(836, 37);
            label2.Name = "label2";
            label2.Size = new Size(42, 26);
            label2.TabIndex = 14;
            label2.Text = "Id:";
            // 
            // updateButton
            // 
            updateButton.Location = new Point(836, 75);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(279, 49);
            updateButton.TabIndex = 13;
            updateButton.Text = "Редагувати запис";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(308, 19);
            label1.Name = "label1";
            label1.Size = new Size(90, 26);
            label1.TabIndex = 12;
            label1.Text = "Посада";
            // 
            // positionList
            // 
            positionList.FormattingEnabled = true;
            positionList.ItemHeight = 25;
            positionList.Items.AddRange(new object[] { "administrator", "master", "security", "watchman" });
            positionList.Location = new Point(310, 51);
            positionList.Name = "positionList";
            positionList.Size = new Size(178, 29);
            positionList.TabIndex = 11;
            // 
            // buttonBackToMenu
            // 
            buttonBackToMenu.Location = new Point(928, 130);
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
            delButton.Size = new Size(279, 46);
            delButton.TabIndex = 9;
            delButton.Text = "Видалити запис";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(516, 37);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(279, 49);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Додати запис";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // roomNumb
            // 
            roomNumb.AutoSize = true;
            roomNumb.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            roomNumb.ForeColor = SystemColors.ButtonFace;
            roomNumb.Location = new Point(310, 92);
            roomNumb.Name = "roomNumb";
            roomNumb.Size = new Size(190, 26);
            roomNumb.TabIndex = 7;
            roomNumb.Text = "Номер телефону";
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(310, 121);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(178, 31);
            phoneBox.TabIndex = 6;
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDateOfBirth.ForeColor = SystemColors.ButtonFace;
            labelDateOfBirth.Location = new Point(28, 92);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(218, 26);
            labelDateOfBirth.TabIndex = 3;
            labelDateOfBirth.Text = "Електронна пошта";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(28, 121);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(254, 31);
            emailBox.TabIndex = 2;
            // 
            // nameOfRes
            // 
            nameOfRes.AutoSize = true;
            nameOfRes.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameOfRes.ForeColor = SystemColors.ButtonFace;
            nameOfRes.Location = new Point(28, 20);
            nameOfRes.Name = "nameOfRes";
            nameOfRes.Size = new Size(190, 26);
            nameOfRes.TabIndex = 1;
            nameOfRes.Text = "Ім'я працівника";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(28, 49);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(254, 31);
            nameBox.TabIndex = 0;
            // 
            // StaffTable
            // 
            StaffTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StaffTable.BackgroundColor = SystemColors.Control;
            StaffTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StaffTable.Dock = DockStyle.Top;
            StaffTable.GridColor = SystemColors.Menu;
            StaffTable.Location = new Point(0, 0);
            StaffTable.Name = "StaffTable";
            StaffTable.RowHeadersWidth = 62;
            StaffTable.Size = new Size(1135, 406);
            StaffTable.TabIndex = 3;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 573);
            Controls.Add(StaffTable);
            Controls.Add(panel1);
            Name = "StaffForm";
            Text = "StaffForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StaffTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox idBox;
        private Label label2;
        private Button updateButton;
        private Label label1;
        private ListBox positionList;
        private Button buttonBackToMenu;
        private Button delButton;
        private Button buttonAdd;
        private Label roomNumb;
        private TextBox phoneBox;
        private Label labelDateOfBirth;
        private TextBox emailBox;
        private Label nameOfRes;
        private TextBox nameBox;
        private DataGridView StaffTable;
    }
}