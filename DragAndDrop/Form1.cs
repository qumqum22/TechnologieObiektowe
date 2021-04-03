using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class Form1 : Form
    {
        object dragDropSource = null;

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 10; ++i)
            {
                listBox1.Items.Add("lista 1, pozycja " + i.ToString());
                listBox2.Items.Add("lista 2, pozycja " + i.ToString());
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lbSender = sender as ListBox;
            dragDropSource = sender; //przechowanie referencji dla DragOver
            
            if(e.Button == MouseButtons.Left && lbSender.SelectedIndices.Count > 0)
            {
                DragDropEffects operacja = lbSender.DoDragDrop(lbSender.SelectedItems, DragDropEffects.Copy | DragDropEffects.Move);

                if(operacja == DragDropEffects.Move)
                {
                    for (int i = lbSender.SelectedItems.Count - 1; i >= 0; i--)
                        lbSender.Items.Remove(lbSender.SelectedItems[i]);
                }
            }
            dragDropSource = null;
        }

        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            if(sender == dragDropSource)
                e.Effect = DragDropEffects.None;
                else
                if ((e.KeyState & 8) == 8)
                    e.Effect = DragDropEffects.Copy; // Ctrl + Z
                    else
                    e.Effect = DragDropEffects.Move;
            
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            ListBox lbSender = sender as ListBox;
            ListBox lbSource = dragDropSource as ListBox;
            int indeks = lbSender.IndexFromPoint(lbSender.PointToClient(new Point(e.X, e.Y)));
            if (indeks == -1) indeks = lbSender.Items.Count;
            for (int i = lbSource.SelectedItems.Count - 1; i >= 0; i--)
                lbSender.Items.Insert(indeks, lbSource.Items[lbSource.SelectedIndices[i]]);
        }


    }
}
