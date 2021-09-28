using LAB03_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03
{
    public partial class frmMain : Form
    {
        LAB03DB db;
        long theDateTimePicker1, theDateTimePicker2;
        List<Order> groupedList;
        public frmMain()
        {
            InitializeComponent();
            db = new LAB03DB();
            List<Order> orders = db.Order.ToList();
            groupedList = orders.GroupBy(o => o.InvoiceNo).Select(od => new Order
            {
                InvoiceNo = od.First().InvoiceNo,
                Price = od.Sum(c => c.Price * c.Quantity),
                Invoice = od.First().Invoice,
            }).ToList();

            
        }

        private void FillDataDGV(List<Order> list)
        {
            dgv.Rows.Clear();
            int i = 0;
            foreach (var item in list)
            {
                i++;
                int index = dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = i.ToString();
                dgv.Rows[index].Cells[1].Value = item.InvoiceNo;
                dgv.Rows[index].Cells[2].Value = item.Invoice.OrderDate.ToString("dd-MM-yyyy");
                dgv.Rows[index].Cells[3].Value = item.Invoice.DeliveryDate.ToString("dd-MM-yyyy");
                dgv.Rows[index].Cells[4].Value = item.Price;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            theDateTimePicker1 = dateTimePicker1.Value.Ticks;
            checkDate(groupedList);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            theDateTimePicker2 = dateTimePicker2.Value.Ticks;
            checkDate(groupedList);
        }

        private bool checkTicks(long orderDateTicks, long deliveryDateTicks)
        {
            if ((orderDateTicks - theDateTimePicker1) > 0)
                if((deliveryDateTicks - theDateTimePicker2) < 0)
                    return true;
            return false;

        }
        private void checkDate(List<Order> list)
        {
            dgv.Rows.Clear();
            int i = 0;
            foreach (var item in list)
            {
                if (checkTicks(item.Invoice.OrderDate.Ticks, item.Invoice.DeliveryDate.Ticks))
                {
                    i++;
                    int index = dgv.Rows.Add();
                    dgv.Rows[index].Cells[0].Value = i.ToString();
                    dgv.Rows[index].Cells[1].Value = item.InvoiceNo;
                    dgv.Rows[index].Cells[2].Value = item.Invoice.OrderDate.ToString("dd-MM-yyyy");
                    dgv.Rows[index].Cells[3].Value = item.Invoice.DeliveryDate.ToString("dd-MM-yyyy");
                    dgv.Rows[index].Cells[4].Value = item.Price;
                };

            }
        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                FillDataDGV(groupedList);
            }
            else
            {
                dgv.DataSource = null;
                dgv.Rows.Clear();
            }
        }
    }
}
