using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SodBegir_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            int Number;
            Number = int.Parse(Profit_importer.Text);
            int Profitt;
            Profitt = int.Parse(Profit.Text);
            int sepordeh;
            sepordeh = int.Parse(seporde.Text);
            Years.Text = " سود سالانه = " + Number * Profitt / sepordeh + " ریال";
            // Number Empty If 
            if (Profit_importer.Text == "" || Profit.Text == "" || seporde.Text == "" )
            {
                Warning.Text = "لطفا اطلاعات را کامل کنید";
            }
        }
        private void ALi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.javadi.ws";
            AliSite(link);
        }
        private void AliSite(LinkLabel.Link link)
        {
            ALi.Links.Add(link);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //int Profit_import = int.Parse(Profit_importer.Text);


        }
        private void Years_Click(object sender, EventArgs e)
        {

        }

        private void Profit_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sepordeh_Click(object sender, EventArgs e)
        {

        }
    }
}
