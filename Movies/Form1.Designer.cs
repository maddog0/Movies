namespace Movies
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.MovieTitle = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.Length = new System.Windows.Forms.TextBox();
            this.Director = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesDataSet = new Movies.MoviesDataSet();
            this.moviesTableAdapter = new Movies.MoviesDataSetTableAdapters.MoviesTableAdapter();
            this.tableAdapterManager = new Movies.MoviesDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieTitle
            // 
            this.MovieTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "Movie Title", true));
            this.MovieTitle.Location = new System.Drawing.Point(12, 12);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(176, 20);
            this.MovieTitle.TabIndex = 0;
            this.MovieTitle.Text = "Movie Title";
            this.MovieTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(12, 92);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(100, 20);
            this.Year.TabIndex = 1;
            this.Year.Text = "Year";
            this.Year.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(12, 53);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(100, 20);
            this.Length.TabIndex = 2;
            this.Length.Text = "Length (min)";
            this.Length.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Director
            // 
            this.Director.Location = new System.Drawing.Point(12, 132);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(100, 20);
            this.Director.TabIndex = 3;
            this.Director.Text = "Director";
            this.Director.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Genre
            // 
            this.Genre.Location = new System.Drawing.Point(12, 175);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(100, 20);
            this.Genre.TabIndex = 4;
            this.Genre.Text = "Genre";
            this.Genre.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add Movie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(257, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "View Movies";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(160, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Get info from IMDB (DOESN\'T WORK)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.moviesDataSet;
            // 
            // moviesDataSet
            // 
            this.moviesDataSet.DataSetName = "MoviesDataSet";
            this.moviesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MoviesTableAdapter = this.moviesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Movies.MoviesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 277);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Director);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.MovieTitle);
            this.Name = "Form1";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MovieTitle;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.TextBox Director;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private MoviesDataSet moviesDataSet;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private MoviesDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private MoviesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}