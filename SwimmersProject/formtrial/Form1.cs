using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmersProject
{
    public partial class Form1 : Form
    {
        Orderer orderer = new Orderer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SwimmersCache.loadCache();
          
            listSwimmers.Clear();
            listOrdered.Clear();
            listSwimmers.View = View.Details;
            listSwimmers.Columns.Add("Swimmer Names").Width = 370;
            listSwimmers.GridLines = true;
            //listSwimmers.HeaderStyle = ColumnHeaderStyle.None;
            foreach ( Swimmer swimmer in SwimmersCache.getAllSwimmers()) {
                listSwimmers.Items.Add(new ListViewItem(new string[] {swimmer.name}));
            }
        }

        private void btnBestGroup1_Click(object sender, EventArgs e)
        {
            listOrdered.Clear();
            listOrdered.View = View.Details;
            listOrdered.Columns.Add("Name");
            listOrdered.Columns.Add("Best Time");
            listOrdered.Columns.Add("Age");
            listOrdered.Columns.Add("Gender");
            listOrdered.Columns.Add("Organisation").Width = 130;
            listOrdered.GridLines = true;
            foreach (Swimmer swimmer in orderer.orderByAgeGroup(1))
            {
                listOrdered.Items.Add(new ListViewItem(new string[] { swimmer.name,swimmer.bestTime.ToString(),swimmer.age.ToString(),swimmer.sex, swimmer.organisation }));
            }
        }

        private void btnBestGroup2_Click(object sender, EventArgs e)
        {
            listOrdered.Clear();
            listOrdered.View = View.Details;
            listOrdered.Columns.Add("Name");
            listOrdered.Columns.Add("Best Time");
            listOrdered.Columns.Add("Age");
            listOrdered.Columns.Add("Gender");
            listOrdered.Columns.Add("Organisation").Width = 130;
            listSwimmers.GridLines = true;
            foreach (Swimmer swimmer in orderer.orderByAgeGroup(2))
            {
                listOrdered.Items.Add(new ListViewItem(new string[] { swimmer.name, swimmer.bestTime.ToString(), swimmer.age.ToString(), swimmer.sex, swimmer.organisation }));
            }
        }

        private void btnBestGroup3_Click(object sender, EventArgs e)
        {
            listOrdered.Clear();
            listOrdered.View = View.Details;
            listOrdered.Columns.Add("Name");
            listOrdered.Columns.Add("Best Time");
            listOrdered.Columns.Add("Age");
            listOrdered.Columns.Add("Gender");
            listOrdered.Columns.Add("Organisation").Width = 130;
            listSwimmers.GridLines = true;
            foreach (Swimmer swimmer in orderer.orderByAgeGroup(3))
            {
                listOrdered.Items.Add(new ListViewItem(new string[] { swimmer.name, swimmer.bestTime.ToString(), swimmer.age.ToString(), swimmer.sex, swimmer.organisation }));
            }
        }

        private void btnBestTimers_Click(object sender, EventArgs e)
        {
            listOrdered.Clear();
            listOrdered.View = View.Details;
            listOrdered.Columns.Add("Name").Width = 100;
            listOrdered.Columns.Add("Best Time");
            listOrdered.Columns.Add("Age Group").Width = 100;
            listSwimmers.GridLines = true;
            foreach (Swimmer swimmer in orderer.orderByTime())
            {
                listOrdered.Items.Add(new ListViewItem(new string[] { swimmer.name, swimmer.bestTime.ToString(), swimmer.groupIdentifier }));
            }
        }

        private void btnSwimmerAge_Click(object sender, EventArgs e)
        {
            listOrdered.Clear();
            listOrdered.View = View.Details;
            listOrdered.Columns.Add("Name").Width = 100;
            listOrdered.Columns.Add("Age");
            listOrdered.Columns.Add("Best Time");
            listSwimmers.GridLines = true;
            foreach (Swimmer swimmer in orderer.orderByAge())
            {
                listOrdered.Items.Add(new ListViewItem(new string[] { swimmer.name, swimmer.age.ToString(), swimmer.bestTime.ToString() }));
            }
        }

        private void btnFemales_Click(object sender, EventArgs e)
        {
            listOrdered.Clear();
            listOrdered.View = View.Details;
            listOrdered.Columns.Add("Name").Width = 100;
            listOrdered.Columns.Add("Age Group").Width = 100;
            listOrdered.Columns.Add("Best Time");
            listSwimmers.GridLines = true;
            foreach (Swimmer swimmer in orderer.orderBySex(1))
            {
                listOrdered.Items.Add(new ListViewItem(new string[] { swimmer.name, swimmer.groupIdentifier, swimmer.bestTime.ToString() }));
            }
        }

        private void btnMales_Click(object sender, EventArgs e)
        {
            listOrdered.Clear();
            listOrdered.View = View.Details;
            listOrdered.Columns.Add("Name").Width = 100;
            listOrdered.Columns.Add("Age Group").Width = 100;
            listOrdered.Columns.Add("Best Time");
            listSwimmers.GridLines = true;
            foreach (Swimmer swimmer in orderer.orderBySex(2))
            {
                listOrdered.Items.Add(new ListViewItem(new string[] { swimmer.name, swimmer.groupIdentifier, swimmer.bestTime.ToString() }));
            }
        }
    }
}
