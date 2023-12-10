using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TantClient.Forms
{
    public partial class InputAmountForm : Form
    {
        public decimal Amount { get; private set; }
        public InputAmountForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                Amount = amount;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Некорректный ввод. Пожалуйста, проверьте правильность ввода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

