namespace RentAKid
{
    partial class ShowBookingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowBookingsForm));
            this.theRAKDatabaseDataSet = new RentAKid.TheRAKDatabaseDataSet();
            this.wypozyczeniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypozyczeniaTableAdapter = new RentAKid.TheRAKDatabaseDataSetTableAdapters.WypozyczeniaTableAdapter();
            this.tableAdapterManager = new RentAKid.TheRAKDatabaseDataSetTableAdapters.TableAdapterManager();
            this.wypozyczeniaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.wypozyczeniaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.wypozyczeniaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.theRAKDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniaBindingNavigator)).BeginInit();
            this.wypozyczeniaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // theRAKDatabaseDataSet
            // 
            this.theRAKDatabaseDataSet.DataSetName = "TheRAKDatabaseDataSet";
            this.theRAKDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wypozyczeniaBindingSource
            // 
            this.wypozyczeniaBindingSource.DataMember = "Wypozyczenia";
            this.wypozyczeniaBindingSource.DataSource = this.theRAKDatabaseDataSet;
            // 
            // wypozyczeniaTableAdapter
            // 
            this.wypozyczeniaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DzieciTableAdapter = null;
            this.tableAdapterManager.KlienciLokujacyTableAdapter = null;
            this.tableAdapterManager.KlienciPodejmujacyTableAdapter = null;
            this.tableAdapterManager.KlienciTableAdapter = null;
            this.tableAdapterManager.KomunikatyTableAdapter = null;
            this.tableAdapterManager.NianieTableAdapter = null;
            this.tableAdapterManager.OgledzinyTableAdapter = null;
            this.tableAdapterManager.SupernianieTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentAKid.TheRAKDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WypozyczeniaTableAdapter = this.wypozyczeniaTableAdapter;
            // 
            // wypozyczeniaBindingNavigator
            // 
            this.wypozyczeniaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.wypozyczeniaBindingNavigator.BindingSource = this.wypozyczeniaBindingSource;
            this.wypozyczeniaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.wypozyczeniaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.wypozyczeniaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.wypozyczeniaBindingNavigatorSaveItem});
            this.wypozyczeniaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.wypozyczeniaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.wypozyczeniaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.wypozyczeniaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.wypozyczeniaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.wypozyczeniaBindingNavigator.Name = "wypozyczeniaBindingNavigator";
            this.wypozyczeniaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.wypozyczeniaBindingNavigator.Size = new System.Drawing.Size(743, 25);
            this.wypozyczeniaBindingNavigator.TabIndex = 0;
            this.wypozyczeniaBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // wypozyczeniaBindingNavigatorSaveItem
            // 
            this.wypozyczeniaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wypozyczeniaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("wypozyczeniaBindingNavigatorSaveItem.Image")));
            this.wypozyczeniaBindingNavigatorSaveItem.Name = "wypozyczeniaBindingNavigatorSaveItem";
            this.wypozyczeniaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.wypozyczeniaBindingNavigatorSaveItem.Text = "Save Data";
            this.wypozyczeniaBindingNavigatorSaveItem.Click += new System.EventHandler(this.wypozyczeniaBindingNavigatorSaveItem_Click);
            // 
            // wypozyczeniaDataGridView
            // 
            this.wypozyczeniaDataGridView.AutoGenerateColumns = false;
            this.wypozyczeniaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wypozyczeniaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.wypozyczeniaDataGridView.DataSource = this.wypozyczeniaBindingSource;
            this.wypozyczeniaDataGridView.Location = new System.Drawing.Point(0, 28);
            this.wypozyczeniaDataGridView.Name = "wypozyczeniaDataGridView";
            this.wypozyczeniaDataGridView.Size = new System.Drawing.Size(766, 220);
            this.wypozyczeniaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDWypozyczenia";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDWypozyczenia";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDDziecka";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDDziecka";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDKlientaPodejmujacego";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDKlientaPodejmujacego";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Komentarz";
            this.dataGridViewTextBoxColumn5.HeaderText = "Komentarz";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Godziny";
            this.dataGridViewTextBoxColumn6.HeaderText = "Godziny";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn7.HeaderText = "Status";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 254);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Wróć";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ShowBookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 286);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.wypozyczeniaDataGridView);
            this.Controls.Add(this.wypozyczeniaBindingNavigator);
            this.Name = "ShowBookingsForm";
            this.Text = "ShowBookingsForm";
            this.Load += new System.EventHandler(this.ShowBookingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theRAKDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniaBindingNavigator)).EndInit();
            this.wypozyczeniaBindingNavigator.ResumeLayout(false);
            this.wypozyczeniaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TheRAKDatabaseDataSet theRAKDatabaseDataSet;
        private System.Windows.Forms.BindingSource wypozyczeniaBindingSource;
        private TheRAKDatabaseDataSetTableAdapters.WypozyczeniaTableAdapter wypozyczeniaTableAdapter;
        private TheRAKDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator wypozyczeniaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton wypozyczeniaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView wypozyczeniaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button backButton;
    }
}