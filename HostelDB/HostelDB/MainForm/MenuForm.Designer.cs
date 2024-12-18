
namespace HostelDB
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            buttonRooms = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonRools = new Button();
            buttonPayments = new Button();
            buttonMaintance = new Button();
            buttonStaff = new Button();
            buttonPasses = new Button();
            buttonRegestration = new Button();
            buttonInventory = new Button();
            buttonResidents = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(625, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 581);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(67, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(426, 439);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonRooms
            // 
            buttonRooms.Cursor = Cursors.Hand;
            buttonRooms.Dock = DockStyle.Fill;
            buttonRooms.Location = new Point(3, 3);
            buttonRooms.Name = "buttonRooms";
            buttonRooms.Size = new Size(258, 92);
            buttonRooms.TabIndex = 1;
            buttonRooms.Text = "Кімнати";
            buttonRooms.UseVisualStyleBackColor = true;
            buttonRooms.Click += buttonRooms_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonRools, 0, 4);
            tableLayoutPanel1.Controls.Add(buttonPayments, 0, 3);
            tableLayoutPanel1.Controls.Add(buttonMaintance, 0, 3);
            tableLayoutPanel1.Controls.Add(buttonStaff, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonPasses, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonRegestration, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonInventory, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonResidents, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonRooms, 0, 0);
            tableLayoutPanel1.Location = new Point(34, 57);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(527, 484);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonRools
            // 
            buttonRools.BackColor = SystemColors.ButtonHighlight;
            buttonRools.Cursor = Cursors.Hand;
            buttonRools.Dock = DockStyle.Fill;
            buttonRools.Location = new Point(3, 397);
            buttonRools.Name = "buttonRools";
            buttonRools.Size = new Size(258, 84);
            buttonRools.TabIndex = 9;
            buttonRools.Text = "Правила";
            buttonRools.UseVisualStyleBackColor = false;
            buttonRools.Click += buttonRools_Click;
            // 
            // buttonPayments
            // 
            buttonPayments.BackColor = SystemColors.ButtonHighlight;
            buttonPayments.Cursor = Cursors.Hand;
            buttonPayments.Dock = DockStyle.Fill;
            buttonPayments.Location = new Point(3, 295);
            buttonPayments.Name = "buttonPayments";
            buttonPayments.Size = new Size(258, 96);
            buttonPayments.TabIndex = 8;
            buttonPayments.Text = "Платежі";
            buttonPayments.UseVisualStyleBackColor = false;
            buttonPayments.Click += buttonPayments_Click;
            // 
            // buttonMaintance
            // 
            buttonMaintance.BackColor = SystemColors.ButtonHighlight;
            buttonMaintance.Cursor = Cursors.Hand;
            buttonMaintance.Dock = DockStyle.Fill;
            buttonMaintance.Location = new Point(267, 295);
            buttonMaintance.Name = "buttonMaintance";
            buttonMaintance.Size = new Size(257, 96);
            buttonMaintance.TabIndex = 7;
            buttonMaintance.Text = "Скарги";
            buttonMaintance.UseVisualStyleBackColor = false;
            buttonMaintance.Click += buttonMaintance_Click;
            // 
            // buttonStaff
            // 
            buttonStaff.BackColor = SystemColors.ButtonHighlight;
            buttonStaff.Cursor = Cursors.Hand;
            buttonStaff.Dock = DockStyle.Fill;
            buttonStaff.Location = new Point(267, 197);
            buttonStaff.Name = "buttonStaff";
            buttonStaff.Size = new Size(257, 92);
            buttonStaff.TabIndex = 6;
            buttonStaff.Text = "Працівники";
            buttonStaff.UseVisualStyleBackColor = false;
            buttonStaff.Click += buttonStaff_Click;
            // 
            // buttonPasses
            // 
            buttonPasses.Cursor = Cursors.Hand;
            buttonPasses.Dock = DockStyle.Fill;
            buttonPasses.Location = new Point(3, 197);
            buttonPasses.Name = "buttonPasses";
            buttonPasses.Size = new Size(258, 92);
            buttonPasses.TabIndex = 5;
            buttonPasses.Text = "Перепустки";
            buttonPasses.UseVisualStyleBackColor = true;
            buttonPasses.Click += buttonPasses_Click;
            // 
            // buttonRegestration
            // 
            buttonRegestration.Cursor = Cursors.Hand;
            buttonRegestration.Dock = DockStyle.Fill;
            buttonRegestration.Location = new Point(267, 101);
            buttonRegestration.Name = "buttonRegestration";
            buttonRegestration.Size = new Size(257, 90);
            buttonRegestration.TabIndex = 4;
            buttonRegestration.Text = "Таблиця заселень";
            buttonRegestration.UseVisualStyleBackColor = true;
            buttonRegestration.Click += buttonRegestration_Click;
            // 
            // buttonInventory
            // 
            buttonInventory.Cursor = Cursors.Hand;
            buttonInventory.Dock = DockStyle.Fill;
            buttonInventory.Location = new Point(3, 101);
            buttonInventory.Name = "buttonInventory";
            buttonInventory.Size = new Size(258, 90);
            buttonInventory.TabIndex = 3;
            buttonInventory.Text = "Інвентар";
            buttonInventory.UseVisualStyleBackColor = true;
            buttonInventory.Click += buttonInventory_Click;
            // 
            // buttonResidents
            // 
            buttonResidents.Cursor = Cursors.Hand;
            buttonResidents.Dock = DockStyle.Fill;
            buttonResidents.Location = new Point(267, 3);
            buttonResidents.Name = "buttonResidents";
            buttonResidents.Size = new Size(257, 92);
            buttonResidents.TabIndex = 2;
            buttonResidents.Text = "Мешканці";
            buttonResidents.UseVisualStyleBackColor = true;
            buttonResidents.Click += buttonResidents_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 32);
            label1.TabIndex = 3;
            label1.Text = "Головне меню";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1164, 581);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "MenuForm";
            Text = "MainMenu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Panel panel1;
        private Button buttonRooms;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonInventory;
        private Button buttonPayments;
        private Button buttonMaintance;
        private Button buttonStaff;
        private Button buttonPasses;
        private Button buttonRools;
        private Button buttonRegestration;
        private Button buttonResidents;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
