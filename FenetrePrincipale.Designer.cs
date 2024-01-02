namespace GestionTicket
{
    partial class FenetrePrincipale
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
            ToolStripMenuItem menuToolStripMenuItem;
            menuStrip1 = new MenuStrip();
            aProposToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            buttonReserver = new Button();
            gridSpectacle = new DataGridView();
            reservation = new DataGridViewCheckBoxColumn();
            nom = new DataGridViewTextBoxColumn();
            lieu = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonSpectacle = new Button();
            buttonTicket = new Button();
            menuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridSpectacle).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(58, 20);
            menuToolStripMenuItem.Text = "Accueil";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, aProposToolStripMenuItem, quitterToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aProposToolStripMenuItem
            // 
            aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            aProposToolStripMenuItem.Size = new Size(67, 20);
            aProposToolStripMenuItem.Text = "A propos";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(56, 20);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(gridSpectacle);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 320);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonReserver);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 248);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 72);
            panel2.TabIndex = 1;
            // 
            // buttonReserver
            // 
            buttonReserver.Dock = DockStyle.Fill;
            buttonReserver.FlatStyle = FlatStyle.Flat;
            buttonReserver.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReserver.Location = new Point(0, 0);
            buttonReserver.Name = "buttonReserver";
            buttonReserver.Size = new Size(800, 72);
            buttonReserver.TabIndex = 0;
            buttonReserver.Text = "Réserver";
            buttonReserver.UseVisualStyleBackColor = true;
            buttonReserver.Click += boutonReserver_Click;
            // 
            // gridSpectacle
            // 
            gridSpectacle.AllowUserToAddRows = false;
            gridSpectacle.AllowUserToDeleteRows = false;
            gridSpectacle.AllowUserToOrderColumns = true;
            gridSpectacle.AllowUserToResizeColumns = false;
            gridSpectacle.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            gridSpectacle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridSpectacle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSpectacle.Columns.AddRange(new DataGridViewColumn[] { reservation, nom, lieu, date });
            gridSpectacle.Location = new Point(12, 6);
            gridSpectacle.MultiSelect = false;
            gridSpectacle.Name = "gridSpectacle";
            gridSpectacle.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gridSpectacle.RowTemplate.Height = 25;
            gridSpectacle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridSpectacle.Size = new Size(776, 236);
            gridSpectacle.TabIndex = 0;
            gridSpectacle.SelectionChanged += gridSpectacle_SelectionChanged;
            // 
            // reservation
            // 
            reservation.HeaderText = "Réservation";
            reservation.Name = "reservation";
            // 
            // nom
            // 
            nom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nom.HeaderText = "Nom";
            nom.Name = "nom";
            nom.ReadOnly = true;
            // 
            // lieu
            // 
            lieu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lieu.HeaderText = "Lieu";
            lieu.Name = "lieu";
            lieu.ReadOnly = true;
            // 
            // date
            // 
            date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            date.HeaderText = "Date";
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonSpectacle, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonTicket, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 106);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // buttonSpectacle
            // 
            buttonSpectacle.BackColor = SystemColors.Control;
            buttonSpectacle.Dock = DockStyle.Fill;
            buttonSpectacle.FlatStyle = FlatStyle.Flat;
            buttonSpectacle.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSpectacle.Location = new Point(3, 3);
            buttonSpectacle.Name = "buttonSpectacle";
            buttonSpectacle.Size = new Size(394, 100);
            buttonSpectacle.TabIndex = 0;
            buttonSpectacle.Text = "Les spectacles";
            buttonSpectacle.UseVisualStyleBackColor = true;
            buttonSpectacle.Click += sectionSpectacle_Click;
            // 
            // buttonTicket
            // 
            buttonTicket.Dock = DockStyle.Fill;
            buttonTicket.FlatStyle = FlatStyle.Flat;
            buttonTicket.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTicket.Location = new Point(403, 3);
            buttonTicket.Name = "buttonTicket";
            buttonTicket.Size = new Size(394, 100);
            buttonTicket.TabIndex = 1;
            buttonTicket.Text = "Vos tickets";
            buttonTicket.UseVisualStyleBackColor = true;
            buttonTicket.Click += sectionVideo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridSpectacle).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private Panel panel1;
        private DataGridView gridSpectacle;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private ToolStripMenuItem aProposToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private Panel panel2;
        private Button buttonReserver;
        private DataGridViewTextBoxColumn id;
        private Button buttonSpectacle;
        private Button buttonTicket;
        private DataGridViewCheckBoxColumn reservation;
        private DataGridViewTextBoxColumn nom;
        private DataGridViewTextBoxColumn lieu;
        private DataGridViewTextBoxColumn date;
    }
}
