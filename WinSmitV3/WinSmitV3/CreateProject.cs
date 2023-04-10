using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinSmitV3
{
    

    public partial class CreateProject : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        

        public  CreateProject()
        {
            InitializeComponent();
                         
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result= folderBrowserDialog1.ShowDialog();
            if (result==DialogResult.OK)
            {
                location.Text = folderBrowserDialog1.SelectedPath;
            }
            
        }
        
        private void cancel_button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_button2_Click(object sender, EventArgs e)
        {
            if(name_textBox1.Text.Length<= 0)
            {
                MessageBox.Show("Please enter a project name", "Project Name is missing", MessageBoxButtons.OK,MessageBoxIcon.Error );
                return;
            }
            if (location.Text.Length <= 0)
            {
                MessageBox.Show("Please select a location", "Location is missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (solution_textBox3.Text.Length <= 0)
            {
                MessageBox.Show("Please enter a solution name", "Solution Name is missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // all fields are entered lets create a project
            //Current_Project = new Project();
            _Current_Project.Directory = location.Text;
            _Current_Project.Name = name_textBox1.Text;
            _Current_Project.Solution_Name = solution_textBox3.Text;


        }
       
        //public Project CurrentProject
        //{
        //    get
        //    {
        //        return _Current_Project ;
        //    }
        //    set
        //    {
        //        _Current_Project = value;
        //    }
        //}

       
        private void CreateProject_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}