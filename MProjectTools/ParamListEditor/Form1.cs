using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace ParamListEditor
{
    public partial class form_param_list_editor : Form
    {
        string filePath = "test.jdata";

        public form_param_list_editor()
        {
            InitializeComponent();
            this.dg_open.FileOk += new CancelEventHandler(dg_open_FileOk);
            this.dg_save_as.FileOk += new CancelEventHandler(dg_save_as_FileOk);
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            this.table_properties.Rows.Add(this.tb_name.Text,
                                            this.cb_type.Text,
                                            this.tb_value.Text,
                                            this.tb_desc.Text);
        }

        private void but_clear_Click(object sender, EventArgs e)
        {
            this.tb_name.Clear();
            this.cb_type.Text = "Int";
            this.tb_value.Clear();
            this.tb_desc.Clear();
        }

        private void but_load_Click(object sender, EventArgs e)
        {
            this.dg_open.ShowDialog();
        }

        private void dg_open_FileOk(object sender, EventArgs e)
        {
            this.filePath = this.dg_open.FileName;

            StreamReader reader = new StreamReader(this.filePath);
            string jsonStr = reader.ReadToEnd();
            reader.Close();

            List<Prop> jsonData = JsonConvert.DeserializeObject<List<Prop>>(jsonStr);
            this.table_properties.Rows.Clear();
            foreach (Prop prop in jsonData)
            {
                this.table_properties.Rows.Add(prop.Name, prop.Type, prop.Value, prop.Description);
            }
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            this.SaveJsonData();
        }

        private void SaveJsonData()
        {
            StreamWriter writer = new StreamWriter(this.filePath, false);
            writer.Write(this.GetJsonString());
            writer.Close();
        }

        private string GetJsonString()
        {
            List<Prop> jsonData = new List<Prop>();
            foreach (DataGridViewRow row in this.table_properties.Rows)
            {
                if (row.Cells[0].Value != null) jsonData.Add(new Prop(row.Cells[0].Value.ToString(),
                                                                      row.Cells[1].Value.ToString(),
                                                                      row.Cells[2].Value.ToString(),
                                                                      row.Cells[3].Value.ToString()));
            }
            return JsonConvert.SerializeObject(jsonData, Formatting.Indented);
        }

        private void but_save_as_Click(object sender, EventArgs e)
        {
            this.dg_save_as.ShowDialog();
        }

        private void dg_save_as_FileOk(object sender, EventArgs e)
        {
            this.filePath = this.dg_save_as.FileName;
            this.SaveJsonData();
        }

        private void but_delete_rows_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.table_properties.SelectedRows)
            {
                this.table_properties.Rows.Remove(row);
            }
        }
    }

    public class Prop
    {
        public string Name;
        public string Type;
        public string Value;
        public string Description;
        public Prop(string Name, string Type, string Value, string Description)
        {
            this.Name = Name;
            this.Type = Type;
            this.Value = Value;
            this.Description = Description;
        }
    }
}
