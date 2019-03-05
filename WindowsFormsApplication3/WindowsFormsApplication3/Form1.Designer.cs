namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label precioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listadeProductosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listadeCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadeProductosBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.listadeProductosBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.descripcionTextBox1 = new System.Windows.Forms.TextBox();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.precioTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productosBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productosBLDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            descripcionLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProductosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProductosBindingSource1BindingNavigator)).BeginInit();
            this.listadeProductosBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBLBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBLDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(33, 45);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 4;
            descripcionLabel.Text = "Descripcion:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(33, 70);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 6;
            idLabel.Text = "Id:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(33, 106);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 8;
            precioLabel.Text = "Precio:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listadeProductosBindingSource1, "CategoriaId", true));
            this.comboBox1.DataSource = this.listadeCategoriasBindingSource;
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Id";
            // 
            // listadeProductosBindingSource1
            // 
            this.listadeProductosBindingSource1.AllowNew = true;
            this.listadeProductosBindingSource1.DataSource = typeof(WindowsFormsApplication3.modelos.Producto);
            // 
            // listadeCategoriasBindingSource
            // 
            this.listadeCategoriasBindingSource.DataSource = typeof(WindowsFormsApplication3.modelos.Categoria);
            // 
            // listadeProductosBindingSource1BindingNavigator
            // 
            this.listadeProductosBindingSource1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listadeProductosBindingSource1BindingNavigator.BindingSource = this.listadeProductosBindingSource1;
            this.listadeProductosBindingSource1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listadeProductosBindingSource1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listadeProductosBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listadeProductosBindingSource1BindingNavigatorSaveItem});
            this.listadeProductosBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listadeProductosBindingSource1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listadeProductosBindingSource1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listadeProductosBindingSource1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listadeProductosBindingSource1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listadeProductosBindingSource1BindingNavigator.Name = "listadeProductosBindingSource1BindingNavigator";
            this.listadeProductosBindingSource1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listadeProductosBindingSource1BindingNavigator.Size = new System.Drawing.Size(692, 25);
            this.listadeProductosBindingSource1BindingNavigator.TabIndex = 1;
            this.listadeProductosBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // listadeProductosBindingSource1BindingNavigatorSaveItem
            // 
            this.listadeProductosBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listadeProductosBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listadeProductosBindingSource1BindingNavigatorSaveItem.Image")));
            this.listadeProductosBindingSource1BindingNavigatorSaveItem.Name = "listadeProductosBindingSource1BindingNavigatorSaveItem";
            this.listadeProductosBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listadeProductosBindingSource1BindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // descripcionTextBox1
            // 
            this.descripcionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeProductosBindingSource1, "Descripcion", true));
            this.descripcionTextBox1.Location = new System.Drawing.Point(105, 38);
            this.descripcionTextBox1.Name = "descripcionTextBox1";
            this.descripcionTextBox1.Size = new System.Drawing.Size(100, 20);
            this.descripcionTextBox1.TabIndex = 5;
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeProductosBindingSource1, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(105, 70);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(100, 20);
            this.idTextBox1.TabIndex = 7;
            // 
            // precioTextBox1
            // 
            this.precioTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeProductosBindingSource1, "Precio", true));
            this.precioTextBox1.Location = new System.Drawing.Point(105, 99);
            this.precioTextBox1.Name = "precioTextBox1";
            this.precioTextBox1.Size = new System.Drawing.Size(100, 20);
            this.precioTextBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Categoria";
            // 
            // productosBLBindingSource1
            // 
            this.productosBLBindingSource1.DataSource = typeof(WindowsFormsApplication3.BL.ProductosBL);
            // 
            // productosBLDataGridView
            // 
            this.productosBLDataGridView.AutoGenerateColumns = false;
            this.productosBLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosBLDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn});
            this.productosBLDataGridView.DataSource = this.listadeProductosBindingSource1;
            this.productosBLDataGridView.Location = new System.Drawing.Point(36, 179);
            this.productosBLDataGridView.Name = "productosBLDataGridView";
            this.productosBLDataGridView.Size = new System.Drawing.Size(482, 156);
            this.productosBLDataGridView.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "CategoriaId";
            this.categoriaDataGridViewTextBoxColumn.DataSource = this.listadeCategoriasBindingSource;
            this.categoriaDataGridViewTextBoxColumn.DisplayMember = "Descripcion";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categoriaDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(692, 467);
            this.Controls.Add(this.productosBLDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox1);
            this.Controls.Add(this.listadeProductosBindingSource1BindingNavigator);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadeProductosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeProductosBindingSource1BindingNavigator)).EndInit();
            this.listadeProductosBindingSource1BindingNavigator.ResumeLayout(false);
            this.listadeProductosBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBLBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBLDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productosBLBindingSource;
        private System.Windows.Forms.BindingSource categoriasBLBindingSource;
        private System.Windows.Forms.BindingSource listadeProductosBindingSource;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource listadeProductosBindingSource1;
        private System.Windows.Forms.BindingNavigator listadeProductosBindingSource1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listadeProductosBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox descripcionTextBox1;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox precioTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource listadeCategoriasBindingSource;
        private System.Windows.Forms.BindingSource productosBLBindingSource1;
        private System.Windows.Forms.DataGridView productosBLDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoriaDataGridViewTextBoxColumn;
    }
}

