using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorCOLOR
{
    public partial class ColorChenger : Form
     
    {
        

        public ColorChenger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           

            
        }

        private void ColorChenger_MouseMove(object sender, MouseEventArgs e)
        {
            int LocationX = Cursor.Position.X;
            int LocationY = Cursor.Position.Y;
            int LocationZ = LocationX - LocationY;
            if (LocationX > 255)
            {
                LocationX = 255;
            }
            if (LocationY > 255)
            {
                LocationY = 255;
            }
            if (LocationZ > 255)
            {
                LocationZ = 255;
            }
            if (LocationZ < 0)
            {
                LocationZ = 0;
            }
            //int BlueValue = Int32.Parse(Bluebox.Text);
            this.BackColor = Color.FromArgb(LocationX, LocationY, LocationZ);
            label1.Text = "x:" + LocationX;
            label2.Text = "y:" + LocationY;
            label3.Text = "x:" + LocationZ;


        }
    }
}
