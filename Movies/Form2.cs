using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void moviesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.moviesBindingSource.EndEdit();
                this.moviesTableAdapter.Update(this.moviesDataSet.Movies);
                MessageBox.Show("Update sucessful");
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Update failed");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moviesDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.moviesDataSet.Movies);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
