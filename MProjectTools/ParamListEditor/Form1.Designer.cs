namespace ParamListEditor
{
    partial class form_param_list_editor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.but_clear = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.but_save_as = new System.Windows.Forms.Button();
            this.but_save = new System.Windows.Forms.Button();
            this.but_load = new System.Windows.Forms.Button();
            this.table_properties = new System.Windows.Forms.DataGridView();
            this.dg_open = new System.Windows.Forms.OpenFileDialog();
            this.dg_save_as = new System.Windows.Forms.SaveFileDialog();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_delete_rows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(54, 10);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(176, 20);
            this.tb_name.TabIndex = 4;
            // 
            // tb_value
            // 
            this.tb_value.Location = new System.Drawing.Point(54, 63);
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(176, 20);
            this.tb_value.TabIndex = 5;
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(79, 89);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(151, 20);
            this.tb_desc.TabIndex = 6;
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Int",
            "Float",
            "Boolean",
            "String"});
            this.cb_type.Location = new System.Drawing.Point(54, 36);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(121, 21);
            this.cb_type.TabIndex = 7;
            // 
            // but_clear
            // 
            this.but_clear.Location = new System.Drawing.Point(155, 115);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(75, 23);
            this.but_clear.TabIndex = 8;
            this.but_clear.Text = "Clear";
            this.but_clear.UseVisualStyleBackColor = true;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(74, 115);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(75, 23);
            this.but_add.TabIndex = 9;
            this.but_add.Text = "Add";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // but_save_as
            // 
            this.but_save_as.Location = new System.Drawing.Point(74, 291);
            this.but_save_as.Name = "but_save_as";
            this.but_save_as.Size = new System.Drawing.Size(156, 23);
            this.but_save_as.TabIndex = 10;
            this.but_save_as.Text = "Save As...";
            this.but_save_as.UseVisualStyleBackColor = true;
            this.but_save_as.Click += new System.EventHandler(this.but_save_as_Click);
            // 
            // but_save
            // 
            this.but_save.Location = new System.Drawing.Point(74, 262);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(156, 23);
            this.but_save.TabIndex = 11;
            this.but_save.Text = "Save";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // but_load
            // 
            this.but_load.Location = new System.Drawing.Point(74, 233);
            this.but_load.Name = "but_load";
            this.but_load.Size = new System.Drawing.Size(156, 23);
            this.but_load.TabIndex = 12;
            this.but_load.Text = "Load jData";
            this.but_load.UseVisualStyleBackColor = true;
            this.but_load.Click += new System.EventHandler(this.but_load_Click);
            // 
            // table_properties
            // 
            this.table_properties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_properties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_name,
            this.col_type,
            this.col_value,
            this.col_desc});
            this.table_properties.Location = new System.Drawing.Point(250, 10);
            this.table_properties.Name = "table_properties";
            this.table_properties.Size = new System.Drawing.Size(504, 304);
            this.table_properties.TabIndex = 13;
            // 
            // col_name
            // 
            this.col_name.HeaderText = "Name";
            this.col_name.Name = "col_name";
            // 
            // col_type
            // 
            this.col_type.HeaderText = "Type";
            this.col_type.Name = "col_type";
            // 
            // col_value
            // 
            this.col_value.HeaderText = "Value";
            this.col_value.Name = "col_value";
            // 
            // col_desc
            // 
            this.col_desc.HeaderText = "Description";
            this.col_desc.Name = "col_desc";
            // 
            // but_delete_rows
            // 
            this.but_delete_rows.Location = new System.Drawing.Point(74, 204);
            this.but_delete_rows.Name = "but_delete_rows";
            this.but_delete_rows.Size = new System.Drawing.Size(156, 23);
            this.but_delete_rows.TabIndex = 14;
            this.but_delete_rows.Text = "Delete selected row/s";
            this.but_delete_rows.UseVisualStyleBackColor = true;
            this.but_delete_rows.Click += new System.EventHandler(this.but_delete_rows_Click);
            // 
            // form_param_list_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 326);
            this.Controls.Add(this.but_delete_rows);
            this.Controls.Add(this.table_properties);
            this.Controls.Add(this.but_load);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.but_save_as);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.but_clear);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.tb_value);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_param_list_editor";
            this.Text = "Parameter List Editor";
            ((System.ComponentModel.ISupportInitialize)(this.table_properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_value;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button but_save_as;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Button but_load;
        private System.Windows.Forms.DataGridView table_properties;
        private System.Windows.Forms.OpenFileDialog dg_open;
        private System.Windows.Forms.SaveFileDialog dg_save_as;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_desc;
        private System.Windows.Forms.Button but_delete_rows;
    }
}

