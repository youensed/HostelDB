namespace HostelDB.TableForms
{
    partial class MaintanceForm
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
            statusList = new ListBox();
            buttonBackToMenu = new Button();
            delButton = new Button();
            buttonAdd = new Button();
            roomNumb = new Label();
            dateInBox = new TextBox();
            labelDateOfBirth = new Label();
            staffIDBox = new TextBox();
            nameOfRes = new Label();
            roomNumbBox = new TextBox();
            MaintanceTable = new DataGridView();
            label3 = new Label();
            dateOutBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MaintanceTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateOutBox);
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(statusList);
            panel1.Controls.Add(buttonBackToMenu);
            panel1.Controls.Add(delButton);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(roomNumb);
            panel1.Controls.Add(dateInBox);
            panel1.Controls.Add(labelDateOfBirth);
            panel1.Controls.Add(staffIDBox);
            panel1.Controls.Add(nameOfRes);
            panel1.Controls.Add(roomNumbBox);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 409);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 176);
            panel1.TabIndex = 3;
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
            updateButton.Click += updateButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(308, 19);
            label1.Name = "label1";
            label1.Size = new Size(84, 26);
            label1.TabIndex = 12;
            label1.Text = "Статус";
            // 
            // statusList
            // 
            statusList.FormattingEnabled = true;
            statusList.ItemHeight = 25;
            statusList.Items.AddRange(new object[] { "pending", "completed", "in_progress" });
            statusList.Location = new Point(310, 51);
            statusList.Name = "statusList";
            statusList.Size = new Size(154, 29);
            statusList.TabIndex = 11;
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
            delButton.Location = new Point(626, 106);
            delButton.Name = "delButton";
            delButton.Size = new Size(169, 46);
            delButton.TabIndex = 9;
            delButton.Text = "Видалити запис";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(626, 37);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(169, 49);
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
            roomNumb.Location = new Point(308, 92);
            roomNumb.Name = "roomNumb";
            roomNumb.Size = new Size(144, 26);
            roomNumb.TabIndex = 7;
            roomNumb.Text = "Дата скарги";
            // 
            // dateInBox
            // 
            dateInBox.Location = new Point(310, 121);
            dateInBox.Name = "dateInBox";
            dateInBox.Size = new Size(142, 31);
            dateInBox.TabIndex = 6;
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDateOfBirth.ForeColor = SystemColors.ButtonFace;
            labelDateOfBirth.Location = new Point(28, 92);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(171, 26);
            labelDateOfBirth.TabIndex = 3;
            labelDateOfBirth.Text = "ID працівника";
            // 
            // staffIDBox
            // 
            staffIDBox.Location = new Point(28, 121);
            staffIDBox.Name = "staffIDBox";
            staffIDBox.Size = new Size(254, 31);
            staffIDBox.TabIndex = 2;
            // 
            // nameOfRes
            // 
            nameOfRes.AutoSize = true;
            nameOfRes.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameOfRes.ForeColor = SystemColors.ButtonFace;
            nameOfRes.Location = new Point(28, 20);
            nameOfRes.Name = "nameOfRes";
            nameOfRes.Size = new Size(176, 26);
            nameOfRes.TabIndex = 1;
            nameOfRes.Text = "Номер кімнати";
            // 
            // roomNumbBox
            // 
            roomNumbBox.Location = new Point(28, 49);
            roomNumbBox.Name = "roomNumbBox";
            roomNumbBox.Size = new Size(254, 31);
            roomNumbBox.TabIndex = 0;
            // 
            // MaintanceTable
            // 
            MaintanceTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MaintanceTable.BackgroundColor = SystemColors.Control;
            MaintanceTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MaintanceTable.Dock = DockStyle.Top;
            MaintanceTable.GridColor = SystemColors.Menu;
            MaintanceTable.Location = new Point(0, 0);
            MaintanceTable.Name = "MaintanceTable";
            MaintanceTable.RowHeadersWidth = 62;
            MaintanceTable.Size = new Size(1134, 406);
            MaintanceTable.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(458, 92);
            label3.Name = "label3";
            label3.Size = new Size(162, 26);
            label3.TabIndex = 17;
            label3.Text = "Дата рішення";
            // 
            // dateOutBox
            // 
            dateOutBox.Location = new Point(466, 121);
            dateOutBox.Name = "dateOutBox";
            dateOutBox.Size = new Size(146, 31);
            dateOutBox.TabIndex = 16;
            // 
            // MaintanceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 585);
            Controls.Add(MaintanceTable);
            Controls.Add(panel1);
            Name = "MaintanceForm";
            Text = "MaintanceForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MaintanceTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox idBox;
        private Label label2;
        private Button updateButton;
        private Label label1;
        private ListBox statusList;
        private Button buttonBackToMenu;
        private Button delButton;
        private Button buttonAdd;
        private Label roomNumb;
        private TextBox dateInBox;
        private Label labelDateOfBirth;
        private TextBox staffIDBox;
        private Label nameOfRes;
        private TextBox roomNumbBox;
        private DataGridView MaintanceTable;
        private Label label3;
        private TextBox dateOutBox;
    }
}