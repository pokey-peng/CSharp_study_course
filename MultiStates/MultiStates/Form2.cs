using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiStates.DAL;

namespace MultiStates
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == null)
            {
                MessageBox.Show("图层名称不能为空");
                return;
            }
            string LayerName = NameTextBox.Text;
            LayerService.layerName = LayerName;
            DatabaseAcess acess = new DatabaseAcess();
            GeometryInfoTable currentLayer = LayerService.getTableFromLayer();
            acess.Insert(currentLayer);
            LayerService.isSave = true;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            LayerService.isSave = false;
            this.Close();
        }
    }
}
