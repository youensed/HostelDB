namespace HostelDB.TableForms
{
    partial class ResidentsForm
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
            genderList = new ListBox();
            buttonBackToMenu = new Button();
            delButton = new Button();
            buttonAdd = new Button();
            roomNumb = new Label();
            roomNumbBox = new TextBox();
            labelDateOfBirth = new Label();
            dateOfBirthBox = new TextBox();
            nameOfRes = new Label();
            nameBox = new TextBox();
            ResidentsTable = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ResidentsTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(genderList);
            panel1.Controls.Add(buttonBackToMenu);
            panel1.Controls.Add(delButton);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(roomNumb);
            panel1.Controls.Add(roomNumbBox);
            panel1.Controls.Add(labelDateOfBirth);
            panel1.Controls.Add(dateOfBirthBox);
            panel1.Controls.Add(nameOfRes);
            panel1.Controls.Add(nameBox);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 390);
            panel1.Name = "panel1";
            panel1.Size = new Size(1127, 176);
            panel1.TabIndex = 1;
            // 
            // idBox
            // 
            idBox.Location = new Point(884, 35);
            idBox.Name = "idBox";
            idBox.Size = new Size(178, 31);
            idBox.TabIndex = 15;
            // 
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

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(308, 19);
            label1.Name = "label1";
            label1.Size = new Size(74, 26);
            label1.TabIndex = 12;
            label1.Text = "Стать";
            // 
            // genderList
            // 
            genderList.FormattingEnabled = true;
            genderList.ItemHeight = 25;
            genderList.Items.AddRange(new object[] { "male", "female", "other" });
            genderList.Location = new Point(310, 51);
            genderList.Name = "genderList";
            genderList.Size = new Size(178, 29);
            genderList.TabIndex = 11;
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
            roomNumb.Size = new Size(176, 26);
            roomNumb.TabIndex = 7;
            roomNumb.Text = "Номер кімнати";
            // 
            // roomNumbBox
            // 
            roomNumbBox.Location = new Point(310, 121);
            roomNumbBox.Name = "roomNumbBox";
            roomNumbBox.Size = new Size(178, 31);
            roomNumbBox.TabIndex = 6;
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDateOfBirth.ForeColor = SystemColors.ButtonFace;
            labelDateOfBirth.Location = new Point(28, 92);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(200, 26);
            labelDateOfBirth.TabIndex = 3;
            labelDateOfBirth.Text = "Дата народження";
            // 
            // dateOfBirthBox
            // 
            dateOfBirthBox.Location = new Point(28, 121);
            dateOfBirthBox.Name = "dateOfBirthBox";
            dateOfBirthBox.Size = new Size(254, 31);
            dateOfBirthBox.TabIndex = 2;
            // 
            // nameOfRes
            // 
            nameOfRes.AutoSize = true;
            nameOfRes.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameOfRes.ForeColor = SystemColors.ButtonFace;
            nameOfRes.Location = new Point(28, 20);
            nameOfRes.Name = "nameOfRes";
            nameOfRes.Size = new Size(178, 26);
            nameOfRes.TabIndex = 1;
            nameOfRes.Text = "Ім'я мешканця";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(28, 49);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(254, 31);
            nameBox.TabIndex = 0;
            // 
            // ResidentsTable
            // 
            ResidentsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ResidentsTable.BackgroundColor = SystemColors.Control;
            ResidentsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResidentsTable.Dock = DockStyle.Top;
            ResidentsTable.GridColor = SystemColors.Menu;
            ResidentsTable.Location = new Point(0, 0);
            ResidentsTable.Name = "ResidentsTable";
            ResidentsTable.RowHeadersWidth = 62;
            ResidentsTable.Size = new Size(1127, 406);
            ResidentsTable.TabIndex = 2;
            // 
            // ResidentsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 566);
            Controls.Add(ResidentsTable);
            Controls.Add(panel1);
            Name = "ResidentsForm";
            Text = "ResidentsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ResidentsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonBackToMenu;
        private Button delButton;
        private Button buttonAdd;
        private Label roomNumb;
        private TextBox roomNumbBox;
        private Label labelDateOfBirth;
        private TextBox dateOfBirthBox;
        private Label nameOfRes;
        private TextBox nameBox;
        private DataGridView ResidentsTable;
        private Label label1;
        private ListBox genderList;
        private Label label2;
        private Button updateButton;
        private TextBox idBox;
    }
}