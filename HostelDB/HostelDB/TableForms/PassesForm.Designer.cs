namespace HostelDB.TableForms
{
    partial class PassesForm
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
            passTypeBox = new ListBox();
            idBox = new TextBox();
            label2 = new Label();
            updateButton = new Button();
            label1 = new Label();
            expDateBox = new TextBox();
            buttonBackToMenu = new Button();
            delButton = new Button();
            buttonAdd = new Button();
            labelFloor = new Label();
            labelDateOfBirth = new Label();
            issueDateBox = new TextBox();
            nameRes = new Label();
            personIDBox = new TextBox();
            PassesTable = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PassesTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(passTypeBox);
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(expDateBox);
            panel1.Controls.Add(buttonBackToMenu);
            panel1.Controls.Add(delButton);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(labelFloor);
            panel1.Controls.Add(labelDateOfBirth);
            panel1.Controls.Add(issueDateBox);
            panel1.Controls.Add(nameRes);
            panel1.Controls.Add(personIDBox);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 400);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 176);
            panel1.TabIndex = 2;
            // 
            // passTypeBox
            // 
            passTypeBox.FormattingEnabled = true;
            passTypeBox.ItemHeight = 25;
            passTypeBox.Items.AddRange(new object[] { "temporary", "permanent" });
            passTypeBox.Location = new Point(317, 49);
            passTypeBox.Name = "passTypeBox";
            passTypeBox.Size = new Size(180, 29);
            passTypeBox.TabIndex = 19;
            // 
            // idBox
            // 
            idBox.Location = new Point(931, 25);
            idBox.Name = "idBox";
            idBox.Size = new Size(178, 31);
            idBox.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(804, 27);
            label2.Name = "label2";
            label2.Size = new Size(121, 26);
            label2.TabIndex = 17;
            label2.Text = "Id запису:";
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
            label1.Location = new Point(299, 92);
            label1.Name = "label1";
            label1.Size = new Size(84, 26);
            label1.TabIndex = 12;
            label1.Text = "Діє до:";
            // 
            // expDateBox
            // 
            expDateBox.Location = new Point(299, 121);
            expDateBox.Name = "expDateBox";
            expDateBox.Size = new Size(196, 31);
            expDateBox.TabIndex = 11;
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
            labelFloor.Size = new Size(54, 26);
            labelFloor.TabIndex = 7;
            labelFloor.Text = "Вид";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDateOfBirth.ForeColor = SystemColors.ButtonFace;
            labelDateOfBirth.Location = new Point(28, 92);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(70, 26);
            labelDateOfBirth.TabIndex = 3;
            labelDateOfBirth.Text = "Діє з:";
            // 
            // issueDateBox
            // 
            issueDateBox.Location = new Point(28, 121);
            issueDateBox.Name = "issueDateBox";
            issueDateBox.Size = new Size(201, 31);
            issueDateBox.TabIndex = 2;
            // 
            // nameRes
            // 
            nameRes.AutoSize = true;
            nameRes.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameRes.ForeColor = SystemColors.ButtonFace;
            nameRes.Location = new Point(28, 20);
            nameRes.Name = "nameRes";
            nameRes.Size = new Size(159, 26);
            nameRes.TabIndex = 1;
            nameRes.Text = "ID мешканця";
            // 
            // personIDBox
            // 
            personIDBox.Location = new Point(28, 49);
            personIDBox.Name = "personIDBox";
            personIDBox.Size = new Size(254, 31);
            personIDBox.TabIndex = 0;
            // 
            // PassesTable
            // 
            PassesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PassesTable.BackgroundColor = SystemColors.Control;
            PassesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PassesTable.Dock = DockStyle.Top;
            PassesTable.GridColor = SystemColors.Menu;
            PassesTable.Location = new Point(0, 0);
            PassesTable.Name = "PassesTable";
            PassesTable.RowHeadersWidth = 62;
            PassesTable.Size = new Size(1130, 406);
            PassesTable.TabIndex = 3;
            // 
            // PassesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 576);
            Controls.Add(PassesTable);
            Controls.Add(panel1);
            Name = "PassesForm";
            Text = "PassesForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PassesTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox idBox;
        private Label label2;
        private Button updateButton;
        private Label label1;
        private TextBox expDateBox;
        private Button buttonBackToMenu;
        private Button delButton;
        private Button buttonAdd;
        private Label labelFloor;
        private TextBox purchDateBox;
        private Label labelDateOfBirth;
        private TextBox issueDateBox;
        private Label nameRes;
        private TextBox personIDBox;
        private DataGridView PassesTable;
        private ListBox passTypeBox;
    }
}