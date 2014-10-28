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
    public partial class Form1 : Form
    {
        private string Title;
        private string Len;
        private string Direct;
        private string Date;
        private string Gen;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Date = Year.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Len = Length.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Direct = Director.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Gen=Genre.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Title = MovieTitle.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.moviesTableAdapter.AddMovie(Title,Len,Direct,Date,Gen);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //TODO: get use movie title to read in and populate form with IMDB info of movie
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moviesDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.moviesDataSet.Movies);

        }
    }
}
