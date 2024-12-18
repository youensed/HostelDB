namespace HostelDB.TableForms
{
    partial class PaymentsForm
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
            methodList = new ListBox();
            buttonBackToMenu = new Button();
            delButton = new Button();
            buttonAdd = new Button();
            roomNumb = new Label();
            amountBox = new TextBox();
            labelDateOfBirth = new Label();
            paymentDateBox = new TextBox();
            nameOfRes = new Label();
            personIDBox = new TextBox();
            PaymentsTable = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentsTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(methodList);
            panel1.Controls.Add(buttonBackToMenu);
            panel1.Controls.Add(delButton);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(roomNumb);
            panel1.Controls.Add(amountBox);
            panel1.Controls.Add(labelDateOfBirth);
            panel1.Controls.Add(paymentDateBox);
            panel1.Controls.Add(nameOfRes);
            panel1.Controls.Add(personIDBox);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 386);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 176);
            panel1.TabIndex = 3;
            // 
            // idBox
            // 
            idBox.Location = new Point(943, 35);
            idBox.Name = "idBox";
            idBox.Size = new Size(178, 31);
            idBox.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(825, 37);
            label2.Name = "label2";
            label2.Size = new Size(121, 26);
            label2.TabIndex = 14;
            label2.Text = "Id запису:";
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
            label1.Size = new Size(161, 26);
            label1.TabIndex = 12;
            label1.Text = "Метод оплати";
            // 
            // methodList
            // 
            methodList.FormattingEnabled = true;
            methodList.ItemHeight = 25;
            methodList.Items.AddRange(new object[] { "cash", "card" });
            methodList.Location = new Point(310, 51);
            methodList.Name = "methodList";
            methodList.Size = new Size(178, 29);
            methodList.TabIndex = 11;
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
            roomNumb.Size = new Size(68, 26);
            roomNumb.TabIndex = 7;
            roomNumb.Text = "Сума";
            // 
            // amountBox
            // 
            amountBox.Location = new Point(310, 121);
            amountBox.Name = "amountBox";
            amountBox.Size = new Size(178, 31);
            amountBox.TabIndex = 6;
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDateOfBirth.ForeColor = SystemColors.ButtonFace;
            labelDateOfBirth.Location = new Point(28, 92);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(158, 26);
            labelDateOfBirth.TabIndex = 3;
            labelDateOfBirth.Text = "Дата платежу";
            // 
            // paymentDateBox
            // 
            paymentDateBox.Location = new Point(28, 121);
            paymentDateBox.Name = "paymentDateBox";
            paymentDateBox.Size = new Size(254, 31);
            paymentDateBox.TabIndex = 2;
            // 
            // nameOfRes
            // 
            nameOfRes.AutoSize = true;
            nameOfRes.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameOfRes.ForeColor = SystemColors.ButtonFace;
            nameOfRes.Location = new Point(28, 20);
            nameOfRes.Name = "nameOfRes";
            nameOfRes.Size = new Size(159, 26);
            nameOfRes.TabIndex = 1;
            nameOfRes.Text = "ID мешканця";
            // 
            // personIDBox
            // 
            personIDBox.Location = new Point(28, 49);
            personIDBox.Name = "personIDBox";
            personIDBox.Size = new Size(254, 31);
            personIDBox.TabIndex = 0;
            // 
            // PaymentsTable
            // 
            PaymentsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PaymentsTable.BackgroundColor = SystemColors.Control;
            PaymentsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaymentsTable.Dock = DockStyle.Top;
            PaymentsTable.GridColor = SystemColors.Menu;
            PaymentsTable.Location = new Point(0, 0);
            PaymentsTable.Name = "PaymentsTable";
            PaymentsTable.RowHeadersWidth = 62;
            PaymentsTable.Size = new Size(1133, 406);
            PaymentsTable.TabIndex = 4;
            // 
            // PaymentsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 562);
            Controls.Add(PaymentsTable);
            Controls.Add(panel1);
            Name = "PaymentsForm";
            Text = "PaymentsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox idBox;
        private Label label2;
        private Button updateButton;
        private Label label1;
        private ListBox methodList;
        private Button buttonBackToMenu;
        private Button delButton;
        private Button buttonAdd;
        private Label roomNumb;
        private TextBox amountBox;
        private Label labelDateOfBirth;
        private TextBox paymentDateBox;
        private Label nameOfRes;
        private TextBox personIDBox;
        private DataGridView PaymentsTable;
    }
}