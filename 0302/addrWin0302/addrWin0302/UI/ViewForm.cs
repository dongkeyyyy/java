using adressTest0218.control;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addrWin0302.UI
{
    public partial class ViewForm : MaterialForm
    {
        public ViewForm()
        {
            InitializeComponent();
            initListView();
        }

        private void initListView()
        {
            for (int i = 0; i < StudentHandler.getInst().getList().Count; i++)
            {
                listView.Items.Add(new ListViewItem(new string[]
                {
                         (i + 1).ToString(), StudentHandler.getInst().getList()[i].Name,
                        StudentHandler.getInst().getList()[i].Tel,
                        StudentHandler.getInst().getList()[i].Address,
                        StudentHandler.getInst().getList()[i].Email
                }
                    ));

            }

            setRowColor(listView, Color.White, Color.LightGray);
            int index = listView.Items.Count - 1;
            listView.Items[index].Selected = true;
            listView.Items[index].Focused = true;
            listView.EnsureVisible(index);
        }

        private void setRowColor(ListView list, Color color1, Color color2)
        {
            foreach (ListViewItem item in list.Items)
            {
                if ((item.Index % 2) == 0)
                {
                    item.BackColor = color1;
                }
                else
                {
                    item.BackColor = color2;
                }
            }
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            initListView();
            initGridView();
        }

        private void initGridView()
        {
            for (int i = 0; i < StudentHandler.getInst().getList().Count; i++)
            {
                gridView.Rows.Add(new string[]
                {
                         (i + 1).ToString(), StudentHandler.getInst().getList()[i].Name,
                        StudentHandler.getInst().getList()[i].Tel,
                        StudentHandler.getInst().getList()[i].Address,
                        StudentHandler.getInst().getList()[i].Email
                }
                    );
            }
            int count = gridView.Rows.Count - 1;
            if (count == 0)
            {
                return;
            }

            gridView.FirstDisplayedScrollingRowIndex =
                count;
            gridView.CurrentCell =
                gridView.Rows[count - 1].Cells[0];
        }
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cxFlatRoundButton1_Click(object sender, EventArgs e)
        {

        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
