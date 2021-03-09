namespace ComputerShop
{
    partial class frmLaptop
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
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label ramLabel;
            System.Windows.Forms.Label speedLabel;
            System.Windows.Forms.Label hdLabel;
            System.Windows.Forms.Label screenLabel;
            System.Windows.Forms.Label priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaptop));
            this.st01DataSet = new ComputerShop.St01DataSet();
            this.laptopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laptopTableAdapter = new ComputerShop.St01DataSetTableAdapters.LaptopTableAdapter();
            this.tableAdapterManager = new ComputerShop.St01DataSetTableAdapters.TableAdapterManager();
            this.laptopBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.laptopBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.ramTextBox = new System.Windows.Forms.TextBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.hdTextBox = new System.Windows.Forms.TextBox();
            this.screenTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            codeLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            ramLabel = new System.Windows.Forms.Label();
            speedLabel = new System.Windows.Forms.Label();
            hdLabel = new System.Windows.Forms.Label();
            screenLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.st01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopBindingNavigator)).BeginInit();
            this.laptopBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(102, 130);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(34, 13);
            codeLabel.TabIndex = 1;
            codeLabel.Text = "code:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(98, 157);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(38, 13);
            modelLabel.TabIndex = 3;
            modelLabel.Text = "model:";
            // 
            // ramLabel
            // 
            ramLabel.AutoSize = true;
            ramLabel.Location = new System.Drawing.Point(109, 190);
            ramLabel.Name = "ramLabel";
            ramLabel.Size = new System.Drawing.Size(27, 13);
            ramLabel.TabIndex = 5;
            ramLabel.Text = "ram:";
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Location = new System.Drawing.Point(97, 221);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new System.Drawing.Size(39, 13);
            speedLabel.TabIndex = 7;
            speedLabel.Text = "speed:";
            // 
            // hdLabel
            // 
            hdLabel.AutoSize = true;
            hdLabel.Location = new System.Drawing.Point(114, 249);
            hdLabel.Name = "hdLabel";
            hdLabel.Size = new System.Drawing.Size(22, 13);
            hdLabel.TabIndex = 9;
            hdLabel.Text = "hd:";
            // 
            // screenLabel
            // 
            screenLabel.AutoSize = true;
            screenLabel.Location = new System.Drawing.Point(94, 306);
            screenLabel.Name = "screenLabel";
            screenLabel.Size = new System.Drawing.Size(42, 13);
            screenLabel.TabIndex = 11;
            screenLabel.Text = "screen:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(103, 279);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(33, 13);
            priceLabel.TabIndex = 13;
            priceLabel.Text = "price:";
            // 
            // st01DataSet
            // 
            this.st01DataSet.DataSetName = "St01DataSet";
            this.st01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // laptopBindingSource
            // 
            this.laptopBindingSource.DataMember = "Laptop";
            this.laptopBindingSource.DataSource = this.st01DataSet;
            // 
            // laptopTableAdapter
            // 
            this.laptopTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LaptopTableAdapter = this.laptopTableAdapter;
            this.tableAdapterManager.PCTableAdapter = null;
            this.tableAdapterManager.PrinterTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ComputerShop.St01DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // laptopBindingNavigator
            // 
            this.laptopBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.laptopBindingNavigator.BindingSource = this.laptopBindingSource;
            this.laptopBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.laptopBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.laptopBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.laptopBindingNavigatorSaveItem});
            this.laptopBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.laptopBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.laptopBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.laptopBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.laptopBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.laptopBindingNavigator.Name = "laptopBindingNavigator";
            this.laptopBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.laptopBindingNavigator.Size = new System.Drawing.Size(347, 25);
            this.laptopBindingNavigator.TabIndex = 0;
            this.laptopBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // laptopBindingNavigatorSaveItem
            // 
            this.laptopBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.laptopBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("laptopBindingNavigatorSaveItem.Image")));
            this.laptopBindingNavigatorSaveItem.Name = "laptopBindingNavigatorSaveItem";
            this.laptopBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.laptopBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.laptopBindingNavigatorSaveItem.Click += new System.EventHandler(this.laptopBindingNavigatorSaveItem_Click);
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laptopBindingSource, "code", true));
            this.codeTextBox.Location = new System.Drawing.Point(142, 127);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeTextBox.TabIndex = 2;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laptopBindingSource, "model", true));
            this.modelTextBox.Location = new System.Drawing.Point(142, 157);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 4;
            // 
            // ramTextBox
            // 
            this.ramTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laptopBindingSource, "ram", true));
            this.ramTextBox.Location = new System.Drawing.Point(142, 187);
            this.ramTextBox.Name = "ramTextBox";
            this.ramTextBox.Size = new System.Drawing.Size(100, 20);
            this.ramTextBox.TabIndex = 6;
            // 
            // speedTextBox
            // 
            this.speedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laptopBindingSource, "speed", true));
            this.speedTextBox.Location = new System.Drawing.Point(142, 218);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedTextBox.TabIndex = 8;
            // 
            // hdTextBox
            // 
            this.hdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laptopBindingSource, "hd", true));
            this.hdTextBox.Location = new System.Drawing.Point(142, 246);
            this.hdTextBox.Name = "hdTextBox";
            this.hdTextBox.Size = new System.Drawing.Size(100, 20);
            this.hdTextBox.TabIndex = 10;
            // 
            // screenTextBox
            // 
            this.screenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laptopBindingSource, "screen", true));
            this.screenTextBox.Location = new System.Drawing.Point(142, 303);
            this.screenTextBox.Name = "screenTextBox";
            this.screenTextBox.Size = new System.Drawing.Size(100, 20);
            this.screenTextBox.TabIndex = 12;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laptopBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(142, 276);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(138, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ноутбуки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.DarkBlue;
            this.button7.Location = new System.Drawing.Point(88, 401);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(167, 23);
            this.button7.TabIndex = 29;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.DarkBlue;
            this.button6.Location = new System.Drawing.Point(180, 371);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 28;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.DarkBlue;
            this.button5.Location = new System.Drawing.Point(88, 371);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.DarkBlue;
            this.button4.Location = new System.Drawing.Point(262, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.DarkBlue;
            this.button3.Location = new System.Drawing.Point(180, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Следующая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(88, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(6, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLaptop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 434);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(screenLabel);
            this.Controls.Add(this.screenTextBox);
            this.Controls.Add(hdLabel);
            this.Controls.Add(this.hdTextBox);
            this.Controls.Add(speedLabel);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(ramLabel);
            this.Controls.Add(this.ramTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(codeLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.laptopBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLaptop";
            this.Text = "Ноутбуки";
            this.Load += new System.EventHandler(this.frmLaptop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.st01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopBindingNavigator)).EndInit();
            this.laptopBindingNavigator.ResumeLayout(false);
            this.laptopBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private St01DataSet st01DataSet;
        private System.Windows.Forms.BindingSource laptopBindingSource;
        private St01DataSetTableAdapters.LaptopTableAdapter laptopTableAdapter;
        private St01DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator laptopBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton laptopBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox ramTextBox;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.TextBox hdTextBox;
        private System.Windows.Forms.TextBox screenTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}