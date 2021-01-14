
namespace csharp_vathmologoumeni_2
{
    partial class Form2
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
            this.shapes = new csharp_vathmologoumeni_2.Shapes();
            this.shapesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapesTableAdapter = new csharp_vathmologoumeni_2.ShapesTableAdapters.ShapesTableAdapter();
            this.tableAdapterManager = new csharp_vathmologoumeni_2.ShapesTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.database1DataSet1 = new csharp_vathmologoumeni_2.database1DataSet1();
            this.shapesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shapesTableAdapter1 = new csharp_vathmologoumeni_2.database1DataSet1TableAdapters.ShapesTableAdapter();
            this.tableAdapterManager1 = new csharp_vathmologoumeni_2.database1DataSet1TableAdapters.TableAdapterManager();
            this.shapesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.shapes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shapes
            // 
            this.shapes.DataSetName = "Shapes";
            this.shapes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shapesBindingSource
            // 
            this.shapesBindingSource.DataMember = "Shapes";
            this.shapesBindingSource.DataSource = this.shapes;
            // 
            // shapesTableAdapter
            // 
            this.shapesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ShapesTableAdapter = this.shapesTableAdapter;
            this.tableAdapterManager.UpdateOrder = csharp_vathmologoumeni_2.ShapesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "← Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shapesBindingSource1
            // 
            this.shapesBindingSource1.DataMember = "Shapes";
            this.shapesBindingSource1.DataSource = this.database1DataSet1;
            // 
            // shapesTableAdapter1
            // 
            this.shapesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ShapesTableAdapter = this.shapesTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = csharp_vathmologoumeni_2.database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // shapesDataGridView
            // 
            this.shapesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shapesDataGridView.AutoGenerateColumns = false;
            this.shapesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shapesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.shapesDataGridView.DataSource = this.shapesBindingSource1;
            this.shapesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.shapesDataGridView.Name = "shapesDataGridView";
            this.shapesDataGridView.Size = new System.Drawing.Size(1175, 564);
            this.shapesDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date_Created";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date_Created";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Time_Created";
            this.dataGridViewTextBoxColumn4.HeaderText = "Time_Created";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn5.HeaderText = "Color";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Pen_Size";
            this.dataGridViewTextBoxColumn6.HeaderText = "Pen_Size";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1199, 633);
            this.Controls.Add(this.shapesDataGridView);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Modify Drawing Database";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shapes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Shapes shapes;
        private System.Windows.Forms.BindingSource shapesBindingSource;
        private ShapesTableAdapters.ShapesTableAdapter shapesTableAdapter;
        private ShapesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource shapesBindingSource1;
        private database1DataSet1TableAdapters.ShapesTableAdapter shapesTableAdapter1;
        private database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView shapesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}