using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieMaker
{
    public partial class form_movie_maker : Form
    {

        List<PictureBox> pBoxes;

        public form_movie_maker()
        {
            InitializeComponent();
            this.dg_import_image.FileOk += new CancelEventHandler(dg_import_image_FileOk);

            pBoxes = new List<PictureBox>();
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dg_import_image.ShowDialog();
        }

        private void dg_import_image_FileOk(object sender, EventArgs e)
        {
            PictureBox pBox = new PictureBox();
            pBox.Image = Image.FromFile(this.dg_import_image.FileName);
            pBox.Size = pBox.Image.Size;
            pBox.Location = new Point((int)(0.5f * (this.Width - pBox.Size.Width)), (int)(0.5f * (this.Height - pBox.Size.Height)));
            //pBox.Click += new EventHandler(pBox_Click);
            pBox.DragDrop += new DragEventHandler(pBox_DragDrop);
            this.pBoxes.Add(pBox);
            this.Controls.Add(pBox);
            pBox.BringToFront();
        }

        private void pBox_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pBox = (PictureBox)sender;
            //pBox.Location = MousePosition;
            this.Controls.Remove(pBox);
        }

        private void pBox_Click(object sender, EventArgs e)
        {
            if (MouseButtons.Right != 0)
            {
                PictureBox pBox = (PictureBox)sender;
                this.conmenu_image.Show(MousePosition);
            }
        }
    }
}
