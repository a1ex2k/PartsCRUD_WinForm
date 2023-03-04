namespace PartsSearcher.Forms
{
    partial class MainForm : Form
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
			this.propertyGrid = new System.Windows.Forms.PropertyGrid();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGrid = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.flangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addButton = new System.Windows.Forms.Button();
			this.resetButton = new System.Windows.Forms.Button();
			this.loadAllButton = new System.Windows.Forms.Button();
			this.emptyLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// propertyGrid
			// 
			this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.propertyGrid.HelpVisible = false;
			this.propertyGrid.LineColor = System.Drawing.SystemColors.ControlLight;
			this.propertyGrid.Location = new System.Drawing.Point(9, 66);
			this.propertyGrid.Name = "propertyGrid";
			this.propertyGrid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
			this.propertyGrid.Size = new System.Drawing.Size(284, 483);
			this.propertyGrid.TabIndex = 4;
			this.propertyGrid.ToolbarVisible = false;
			this.propertyGrid.ViewBackColor = System.Drawing.Color.White;
			this.propertyGrid.ViewBorderColor = System.Drawing.SystemColors.ControlLight;
			this.propertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid_PropertyValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Фильтр";
			// 
			// dataGrid
			// 
			this.dataGrid.AllowUserToAddRows = false;
			this.dataGrid.AllowUserToDeleteRows = false;
			this.dataGrid.AllowUserToOrderColumns = true;
			this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGrid.BackgroundColor = System.Drawing.Color.White;
			this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGrid.GridColor = System.Drawing.SystemColors.ControlLight;
			this.dataGrid.Location = new System.Drawing.Point(329, 66);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.RowHeadersVisible = false;
			this.dataGrid.RowTemplate.Height = 25;
			this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGrid.Size = new System.Drawing.Size(643, 483);
			this.dataGrid.TabIndex = 9;
			this.dataGrid.VirtualMode = true;
			this.dataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_CellMouseDoubleClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(329, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Результаты";
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablesToolStripMenuItem,
            this.userToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(984, 24);
			this.menuStrip.TabIndex = 10;
			this.menuStrip.Text = "menuStrip1";
			// 
			// tablesToolStripMenuItem
			// 
			this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flangesToolStripMenuItem});
			this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
			this.tablesToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
			this.tablesToolStripMenuItem.Text = "Таблицы";
			// 
			// flangesToolStripMenuItem
			// 
			this.flangesToolStripMenuItem.Name = "flangesToolStripMenuItem";
			this.flangesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.flangesToolStripMenuItem.Text = "Фланцы";
			this.flangesToolStripMenuItem.Click += new System.EventHandler(this.flangesToolStripMenuItem_Click);
			// 
			// userToolStripMenuItem
			// 
			this.userToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usernameToolStripMenuItem,
            this.roleToolStripMenuItem});
			this.userToolStripMenuItem.Name = "userToolStripMenuItem";
			this.userToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
			this.userToolStripMenuItem.Text = "Пользователь";
			// 
			// usernameToolStripMenuItem
			// 
			this.usernameToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
			this.usernameToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.usernameToolStripMenuItem.Text = "username";
			// 
			// roleToolStripMenuItem
			// 
			this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
			this.roleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.roleToolStripMenuItem.Text = " role";
			// 
			// addButton
			// 
			this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addButton.Location = new System.Drawing.Point(737, 37);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(96, 23);
			this.addButton.TabIndex = 11;
			this.addButton.Text = "Добавить";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(175, 37);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(118, 23);
			this.resetButton.TabIndex = 12;
			this.resetButton.Text = "Сбросить фильтр";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// loadAllButton
			// 
			this.loadAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.loadAllButton.Location = new System.Drawing.Point(839, 37);
			this.loadAllButton.Name = "loadAllButton";
			this.loadAllButton.Size = new System.Drawing.Size(133, 23);
			this.loadAllButton.TabIndex = 11;
			this.loadAllButton.Text = "Загрузить все";
			this.loadAllButton.UseVisualStyleBackColor = true;
			this.loadAllButton.Click += new System.EventHandler(this.loadAllButton_Click);
			// 
			// emptyLabel
			// 
			this.emptyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.emptyLabel.AutoSize = true;
			this.emptyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.emptyLabel.Location = new System.Drawing.Point(726, 250);
			this.emptyLabel.Name = "emptyLabel";
			this.emptyLabel.Size = new System.Drawing.Size(236, 34);
			this.emptyLabel.TabIndex = 13;
			this.emptyLabel.Text = "Отсутствуют данные,\r\nудовлетворяющие условиям поиска";
			this.emptyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.emptyLabel.UseMnemonic = false;
			this.emptyLabel.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.emptyLabel);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.loadAllButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.dataGrid);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.propertyGrid);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.MinimumSize = new System.Drawing.Size(800, 400);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "База деталей";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private PropertyGrid propertyGrid;
        private Label label2;
        private DataGridView dataGrid;
        private Label label3;
		private MenuStrip menuStrip;
		private ToolStripMenuItem tablesToolStripMenuItem;
		private ToolStripMenuItem flangesToolStripMenuItem;
		private ToolStripMenuItem userToolStripMenuItem;
		private ToolStripMenuItem usernameToolStripMenuItem;
		private ToolStripMenuItem roleToolStripMenuItem;
		private Button addButton;
		private Button resetButton;
		private Button loadAllButton;
		private Label emptyLabel;
	}
}