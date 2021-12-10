
namespace Avtosalon
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label iD_FirmaLabel;
            System.Windows.Forms.Label firma_NameLabel;
            System.Windows.Forms.Label stranaLabel;
            System.Windows.Forms.Label gorodLabel;
            System.Windows.Forms.Label ulicaLabel;
            System.Windows.Forms.Label domLabel;
            this.dataSet1 = new Avtosalon.DataSet1();
            this.firmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmaTableAdapter = new Avtosalon.DataSet1TableAdapters.FirmaTableAdapter();
            this.tableAdapterManager = new Avtosalon.DataSet1TableAdapters.TableAdapterManager();
            this.firmaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.firmaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.firmaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_FirmaTextBox = new System.Windows.Forms.TextBox();
            this.firma_NameTextBox = new System.Windows.Forms.TextBox();
            this.stranaTextBox = new System.Windows.Forms.TextBox();
            this.gorodTextBox = new System.Windows.Forms.TextBox();
            this.ulicaTextBox = new System.Windows.Forms.TextBox();
            this.domTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.avtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtoTableAdapter = new Avtosalon.DataSet1TableAdapters.AvtoTableAdapter();
            iD_FirmaLabel = new System.Windows.Forms.Label();
            firma_NameLabel = new System.Windows.Forms.Label();
            stranaLabel = new System.Windows.Forms.Label();
            gorodLabel = new System.Windows.Forms.Label();
            ulicaLabel = new System.Windows.Forms.Label();
            domLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingNavigator)).BeginInit();
            this.firmaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmaBindingSource
            // 
            this.firmaBindingSource.DataMember = "Firma";
            this.firmaBindingSource.DataSource = this.dataSet1;
            // 
            // firmaTableAdapter
            // 
            this.firmaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Avto_ProdajiTableAdapter = null;
            this.tableAdapterManager.AvtoTableAdapter = this.avtoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Firma_AvtoTableAdapter = null;
            this.tableAdapterManager.FirmaTableAdapter = this.firmaTableAdapter;
            this.tableAdapterManager.PersTableAdapter = null;
            this.tableAdapterManager.PokupTableAdapter = null;
            this.tableAdapterManager.Prodaji_PokupTableAdapter = null;
            this.tableAdapterManager.ProdajiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Avtosalon.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // firmaBindingNavigator
            // 
            this.firmaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.firmaBindingNavigator.BindingSource = this.firmaBindingSource;
            this.firmaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.firmaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.firmaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.firmaBindingNavigatorSaveItem});
            this.firmaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.firmaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.firmaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.firmaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.firmaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.firmaBindingNavigator.Name = "firmaBindingNavigator";
            this.firmaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.firmaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.firmaBindingNavigator.TabIndex = 0;
            this.firmaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // firmaBindingNavigatorSaveItem
            // 
            this.firmaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.firmaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("firmaBindingNavigatorSaveItem.Image")));
            this.firmaBindingNavigatorSaveItem.Name = "firmaBindingNavigatorSaveItem";
            this.firmaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.firmaBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.firmaBindingNavigatorSaveItem.Click += new System.EventHandler(this.firmaBindingNavigatorSaveItem_Click);
            // 
            // firmaDataGridView
            // 
            this.firmaDataGridView.AutoGenerateColumns = false;
            this.firmaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firmaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.firmaDataGridView.DataSource = this.firmaBindingSource;
            this.firmaDataGridView.Location = new System.Drawing.Point(0, 28);
            this.firmaDataGridView.Name = "firmaDataGridView";
            this.firmaDataGridView.Size = new System.Drawing.Size(644, 68);
            this.firmaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Firma";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Firma";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Firma_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Firma_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Strana";
            this.dataGridViewTextBoxColumn3.HeaderText = "Strana";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gorod";
            this.dataGridViewTextBoxColumn4.HeaderText = "Gorod";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ulica";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ulica";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Dom";
            this.dataGridViewTextBoxColumn6.HeaderText = "Dom";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // iD_FirmaLabel
            // 
            iD_FirmaLabel.AutoSize = true;
            iD_FirmaLabel.Location = new System.Drawing.Point(59, 112);
            iD_FirmaLabel.Name = "iD_FirmaLabel";
            iD_FirmaLabel.Size = new System.Drawing.Size(49, 13);
            iD_FirmaLabel.TabIndex = 2;
            iD_FirmaLabel.Text = "ID Firma:";
            // 
            // iD_FirmaTextBox
            // 
            this.iD_FirmaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmaBindingSource, "ID_Firma", true));
            this.iD_FirmaTextBox.Location = new System.Drawing.Point(131, 109);
            this.iD_FirmaTextBox.Name = "iD_FirmaTextBox";
            this.iD_FirmaTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_FirmaTextBox.TabIndex = 3;
            // 
            // firma_NameLabel
            // 
            firma_NameLabel.AutoSize = true;
            firma_NameLabel.Location = new System.Drawing.Point(59, 138);
            firma_NameLabel.Name = "firma_NameLabel";
            firma_NameLabel.Size = new System.Drawing.Size(66, 13);
            firma_NameLabel.TabIndex = 4;
            firma_NameLabel.Text = "Firma Name:";
            // 
            // firma_NameTextBox
            // 
            this.firma_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmaBindingSource, "Firma_Name", true));
            this.firma_NameTextBox.Location = new System.Drawing.Point(131, 135);
            this.firma_NameTextBox.Name = "firma_NameTextBox";
            this.firma_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firma_NameTextBox.TabIndex = 5;
            // 
            // stranaLabel
            // 
            stranaLabel.AutoSize = true;
            stranaLabel.Location = new System.Drawing.Point(59, 164);
            stranaLabel.Name = "stranaLabel";
            stranaLabel.Size = new System.Drawing.Size(41, 13);
            stranaLabel.TabIndex = 6;
            stranaLabel.Text = "Strana:";
            // 
            // stranaTextBox
            // 
            this.stranaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmaBindingSource, "Strana", true));
            this.stranaTextBox.Location = new System.Drawing.Point(131, 161);
            this.stranaTextBox.Name = "stranaTextBox";
            this.stranaTextBox.Size = new System.Drawing.Size(100, 20);
            this.stranaTextBox.TabIndex = 7;
            // 
            // gorodLabel
            // 
            gorodLabel.AutoSize = true;
            gorodLabel.Location = new System.Drawing.Point(59, 190);
            gorodLabel.Name = "gorodLabel";
            gorodLabel.Size = new System.Drawing.Size(39, 13);
            gorodLabel.TabIndex = 8;
            gorodLabel.Text = "Gorod:";
            // 
            // gorodTextBox
            // 
            this.gorodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmaBindingSource, "Gorod", true));
            this.gorodTextBox.Location = new System.Drawing.Point(131, 187);
            this.gorodTextBox.Name = "gorodTextBox";
            this.gorodTextBox.Size = new System.Drawing.Size(100, 20);
            this.gorodTextBox.TabIndex = 9;
            // 
            // ulicaLabel
            // 
            ulicaLabel.AutoSize = true;
            ulicaLabel.Location = new System.Drawing.Point(59, 216);
            ulicaLabel.Name = "ulicaLabel";
            ulicaLabel.Size = new System.Drawing.Size(34, 13);
            ulicaLabel.TabIndex = 10;
            ulicaLabel.Text = "Ulica:";
            // 
            // ulicaTextBox
            // 
            this.ulicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmaBindingSource, "Ulica", true));
            this.ulicaTextBox.Location = new System.Drawing.Point(131, 213);
            this.ulicaTextBox.Name = "ulicaTextBox";
            this.ulicaTextBox.Size = new System.Drawing.Size(100, 20);
            this.ulicaTextBox.TabIndex = 11;
            // 
            // domLabel
            // 
            domLabel.AutoSize = true;
            domLabel.Location = new System.Drawing.Point(59, 242);
            domLabel.Name = "domLabel";
            domLabel.Size = new System.Drawing.Size(32, 13);
            domLabel.TabIndex = 12;
            domLabel.Text = "Dom:";
            // 
            // domTextBox
            // 
            this.domTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmaBindingSource, "Dom", true));
            this.domTextBox.Location = new System.Drawing.Point(131, 239);
            this.domTextBox.Name = "domTextBox";
            this.domTextBox.Size = new System.Drawing.Size(100, 20);
            this.domTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "New record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(695, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // avtoBindingSource
            // 
            this.avtoBindingSource.DataMember = "Avto";
            this.avtoBindingSource.DataSource = this.dataSet1;
            // 
            // avtoTableAdapter
            // 
            this.avtoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_FirmaLabel);
            this.Controls.Add(this.iD_FirmaTextBox);
            this.Controls.Add(firma_NameLabel);
            this.Controls.Add(this.firma_NameTextBox);
            this.Controls.Add(stranaLabel);
            this.Controls.Add(this.stranaTextBox);
            this.Controls.Add(gorodLabel);
            this.Controls.Add(this.gorodTextBox);
            this.Controls.Add(ulicaLabel);
            this.Controls.Add(this.ulicaTextBox);
            this.Controls.Add(domLabel);
            this.Controls.Add(this.domTextBox);
            this.Controls.Add(this.firmaDataGridView);
            this.Controls.Add(this.firmaBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingNavigator)).EndInit();
            this.firmaBindingNavigator.ResumeLayout(false);
            this.firmaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource firmaBindingSource;
        private DataSet1TableAdapters.FirmaTableAdapter firmaTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator firmaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton firmaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView firmaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox iD_FirmaTextBox;
        private System.Windows.Forms.TextBox firma_NameTextBox;
        private System.Windows.Forms.TextBox stranaTextBox;
        private System.Windows.Forms.TextBox gorodTextBox;
        private System.Windows.Forms.TextBox ulicaTextBox;
        private System.Windows.Forms.TextBox domTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DataSet1TableAdapters.AvtoTableAdapter avtoTableAdapter;
        private System.Windows.Forms.BindingSource avtoBindingSource;
    }
}

