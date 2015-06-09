namespace RentAKid
{
    partial class ShowKidsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowKidsForm));
            this.backButton = new System.Windows.Forms.Button();
            this.theRAKDatabaseDataSet = new RentAKid.TheRAKDatabaseDataSet();
            this.dzieciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dzieciTableAdapter = new RentAKid.TheRAKDatabaseDataSetTableAdapters.DzieciTableAdapter();
            this.tableAdapterManager = new RentAKid.TheRAKDatabaseDataSetTableAdapters.TableAdapterManager();
            this.dzieciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dzieciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dzieciDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.theRAKDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dzieciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dzieciBindingNavigator)).BeginInit();
            this.dzieciBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dzieciDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(0, 264);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Wróć";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // theRAKDatabaseDataSet
            // 
            this.theRAKDatabaseDataSet.DataSetName = "TheRAKDatabaseDataSet";
            this.theRAKDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dzieciBindingSource
            // 
            this.dzieciBindingSource.DataMember = "Dzieci";
            this.dzieciBindingSource.DataSource = this.theRAKDatabaseDataSet;
            // 
            // dzieciTableAdapter
            // 
            this.dzieciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DzieciTableAdapter = this.dzieciTableAdapter;
            this.tableAdapterManager.KlienciLokujacyTableAdapter = null;
            this.tableAdapterManager.KlienciPodejmujacyTableAdapter = null;
            this.tableAdapterManager.KlienciTableAdapter = null;
            this.tableAdapterManager.KomunikatyTableAdapter = null;
            this.tableAdapterManager.NianieTableAdapter = null;
            this.tableAdapterManager.OgledzinyTableAdapter = null;
            this.tableAdapterManager.SupernianieTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentAKid.TheRAKDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WypozyczeniaTableAdapter = null;
            // 
            // dzieciBindingNavigator
            // 
            this.dzieciBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dzieciBindingNavigator.BindingSource = this.dzieciBindingSource;
            this.dzieciBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dzieciBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dzieciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dzieciBindingNavigatorSaveItem});
            this.dzieciBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dzieciBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dzieciBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dzieciBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dzieciBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dzieciBindingNavigator.Name = "dzieciBindingNavigator";
            this.dzieciBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dzieciBindingNavigator.Size = new System.Drawing.Size(643, 25);
            this.dzieciBindingNavigator.TabIndex = 2;
            this.dzieciBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dzieciBindingNavigatorSaveItem
            // 
            this.dzieciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dzieciBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dzieciBindingNavigatorSaveItem.Image")));
            this.dzieciBindingNavigatorSaveItem.Name = "dzieciBindingNavigatorSaveItem";
            this.dzieciBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dzieciBindingNavigatorSaveItem.Text = "Save Data";
            this.dzieciBindingNavigatorSaveItem.Click += new System.EventHandler(this.dzieciBindingNavigatorSaveItem_Click);
            // 
            // dzieciDataGridView
            // 
            this.dzieciDataGridView.AutoGenerateColumns = false;
            this.dzieciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dzieciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dzieciDataGridView.DataSource = this.dzieciBindingSource;
            this.dzieciDataGridView.Location = new System.Drawing.Point(0, 28);
            this.dzieciDataGridView.Name = "dzieciDataGridView";
            this.dzieciDataGridView.Size = new System.Drawing.Size(649, 220);
            this.dzieciDataGridView.TabIndex = 3;
            this.dzieciDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dzieciDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDDziecka";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDDziecka";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDKlienta";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDKlienta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Imie";
            this.dataGridViewTextBoxColumn3.HeaderText = "Imie";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nazwisko";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Plec";
            this.dataGridViewTextBoxColumn5.HeaderText = "Plec";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SredniaOcena";
            this.dataGridViewTextBoxColumn6.HeaderText = "SredniaOcena";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ShowKidsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 293);
            this.Controls.Add(this.dzieciDataGridView);
            this.Controls.Add(this.dzieciBindingNavigator);
            this.Controls.Add(this.backButton);
            this.Name = "ShowKidsForm";
            this.Text = "ShowKidsForm";
            this.Load += new System.EventHandler(this.ShowKidsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theRAKDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dzieciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dzieciBindingNavigator)).EndInit();
            this.dzieciBindingNavigator.ResumeLayout(false);
            this.dzieciBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dzieciDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private TheRAKDatabaseDataSet theRAKDatabaseDataSet;
        private System.Windows.Forms.BindingSource dzieciBindingSource;
        private TheRAKDatabaseDataSetTableAdapters.DzieciTableAdapter dzieciTableAdapter;
        private TheRAKDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dzieciBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dzieciBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dzieciDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}