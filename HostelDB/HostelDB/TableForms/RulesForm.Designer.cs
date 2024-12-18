namespace HostelDB.TableForms
{
    partial class RulesForm
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
            buttonBackToMenu = new Button();
            delButton = new Button();
            buttonAdd = new Button();
            nameRes = new Label();
            ruleDesBox = new TextBox();
            RulesTable = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RulesTable).BeginInit();
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
            panel1.Controls.Add(nameRes);
            panel1.Controls.Add(ruleDesBox);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 386);
            panel1.Name = "panel1";
            panel1.Size = new Size(1127, 176);
            panel1.TabIndex = 3;
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
            // nameRes
            // 
            nameRes.AutoSize = true;
            nameRes.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameRes.ForeColor = SystemColors.ButtonFace;
            nameRes.Location = new Point(28, 20);
            nameRes.Name = "nameRes";
            nameRes.Size = new Size(169, 26);
            nameRes.TabIndex = 1;
            nameRes.Text = "Текст правила";
            // 
            // ruleDesBox
            // 
            ruleDesBox.Location = new Point(28, 49);
            ruleDesBox.Name = "ruleDesBox";
            ruleDesBox.Size = new Size(451, 31);
            ruleDesBox.TabIndex = 0;
            // 
            // RulesTable
            // 
            RulesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RulesTable.BackgroundColor = SystemColors.Control;
            RulesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RulesTable.Dock = DockStyle.Top;
            RulesTable.GridColor = SystemColors.Menu;
            RulesTable.Location = new Point(0, 0);
            RulesTable.Name = "RulesTable";
            RulesTable.RowHeadersWidth = 62;
            RulesTable.Size = new Size(1127, 406);
            RulesTable.TabIndex = 4;
            // 
            // RulesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 562);
            Controls.Add(RulesTable);
            Controls.Add(panel1);
            Name = "RulesForm";
            Text = "RoolsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RulesTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox idBox;
        private Label label2;
        private Button updateButton;
        private Button buttonBackToMenu;
        private Button delButton;
        private Button buttonAdd;
        private Label nameRes;
        private TextBox ruleDesBox;
        private DataGridView RulesTable;
    }
}