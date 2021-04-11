
namespace ZdalnaSzkola
{
    partial class ListaNauczycieli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaNauczycieli));
            this.nauczycielBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.nauczycielBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.nauczycielBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nauczycielDataGridView = new System.Windows.Forms.DataGridView();
            this.rokZatrudnieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czlowiekSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stazPracyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocenaSemestralnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocenaStudentaSetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nauczycielBindingNavigator)).BeginInit();
            this.nauczycielBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nauczycielBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nauczycielDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nauczycielBindingNavigator
            // 
            this.nauczycielBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nauczycielBindingNavigator.BindingSource = this.nauczycielBindingSource;
            this.nauczycielBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nauczycielBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nauczycielBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.nauczycielBindingNavigatorSaveItem});
            this.nauczycielBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nauczycielBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nauczycielBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nauczycielBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nauczycielBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nauczycielBindingNavigator.Name = "nauczycielBindingNavigator";
            this.nauczycielBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nauczycielBindingNavigator.Size = new System.Drawing.Size(902, 25);
            this.nauczycielBindingNavigator.TabIndex = 0;
            this.nauczycielBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            // 
            // nauczycielBindingSource
            // 
            this.nauczycielBindingSource.DataSource = typeof(ZdalnaSzkola.czlowiekSet_nauczyciel);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
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
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // nauczycielBindingNavigatorSaveItem
            // 
            this.nauczycielBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nauczycielBindingNavigatorSaveItem.Enabled = false;
            this.nauczycielBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nauczycielBindingNavigatorSaveItem.Image")));
            this.nauczycielBindingNavigatorSaveItem.Name = "nauczycielBindingNavigatorSaveItem";
            this.nauczycielBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.nauczycielBindingNavigatorSaveItem.Text = "Zapisz dane";
            // 
            // nauczycielDataGridView
            // 
            this.nauczycielDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nauczycielDataGridView.AutoGenerateColumns = false;
            this.nauczycielDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nauczycielDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rokZatrudnieniaDataGridViewTextBoxColumn,
            this.colImie,
            this.czlowiekSet,
            this.stazPracyDataGridViewTextBoxColumn,
            this.ocenaSemestralnaDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.ocenaStudentaSetDataGridViewTextBoxColumn});
            this.nauczycielDataGridView.DataSource = this.nauczycielBindingSource;
            this.nauczycielDataGridView.Location = new System.Drawing.Point(12, 28);
            this.nauczycielDataGridView.Name = "nauczycielDataGridView";
            this.nauczycielDataGridView.Size = new System.Drawing.Size(836, 199);
            this.nauczycielDataGridView.TabIndex = 1;
            // 
            // rokZatrudnieniaDataGridViewTextBoxColumn
            // 
            this.rokZatrudnieniaDataGridViewTextBoxColumn.DataPropertyName = "RokZatrudnienia";
            this.rokZatrudnieniaDataGridViewTextBoxColumn.HeaderText = "RokZatrudnienia";
            this.rokZatrudnieniaDataGridViewTextBoxColumn.Name = "rokZatrudnieniaDataGridViewTextBoxColumn";
            // 
            // colImie
            // 
            this.colImie.DataPropertyName = "czlowiekSet.imie";
            this.colImie.HeaderText = "Imie";
            this.colImie.Name = "colImie";
            // 
            // czlowiekSet
            // 
            this.czlowiekSet.DataPropertyName = "czlowiekSet";
            this.czlowiekSet.HeaderText = "czlowiekSet";
            this.czlowiekSet.Name = "czlowiekSet";
            // 
            // stazPracyDataGridViewTextBoxColumn
            // 
            this.stazPracyDataGridViewTextBoxColumn.DataPropertyName = "StazPracy";
            this.stazPracyDataGridViewTextBoxColumn.HeaderText = "StazPracy";
            this.stazPracyDataGridViewTextBoxColumn.Name = "stazPracyDataGridViewTextBoxColumn";
            // 
            // ocenaSemestralnaDataGridViewTextBoxColumn
            // 
            this.ocenaSemestralnaDataGridViewTextBoxColumn.DataPropertyName = "OcenaSemestralna";
            this.ocenaSemestralnaDataGridViewTextBoxColumn.HeaderText = "OcenaSemestralna";
            this.ocenaSemestralnaDataGridViewTextBoxColumn.Name = "ocenaSemestralnaDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // ocenaStudentaSetDataGridViewTextBoxColumn
            // 
            this.ocenaStudentaSetDataGridViewTextBoxColumn.DataPropertyName = "OcenaStudentaSet";
            this.ocenaStudentaSetDataGridViewTextBoxColumn.HeaderText = "OcenaStudentaSet";
            this.ocenaStudentaSetDataGridViewTextBoxColumn.Name = "ocenaStudentaSetDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(769, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "czlowiekSet";
            this.dataGridViewTextBoxColumn1.HeaderText = "czlowiekSet";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "czlowiekSet";
            this.dataGridViewTextBoxColumn2.HeaderText = "czlowiekSet";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Nowy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListaNauczycieli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(902, 350);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nauczycielDataGridView);
            this.Controls.Add(this.nauczycielBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(918, 389);
            this.MinimumSize = new System.Drawing.Size(918, 389);
            this.Name = "ListaNauczycieli";
            this.Text = "Lista Nauczycieli";
            ((System.ComponentModel.ISupportInitialize)(this.nauczycielBindingNavigator)).EndInit();
            this.nauczycielBindingNavigator.ResumeLayout(false);
            this.nauczycielBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nauczycielBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nauczycielDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource nauczycielBindingSource;
        private System.Windows.Forms.BindingNavigator nauczycielBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton nauczycielBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView nauczycielDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokZatrudnieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImie;
        private System.Windows.Forms.DataGridViewTextBoxColumn czlowiekSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn stazPracyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocenaSemestralnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocenaStudentaSetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button2;
    }
}