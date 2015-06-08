using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlokSites
{
    public partial class Form1 : Form
    {
        Controls con;
        public Form1()
        {
            InitializeComponent();
            con = new Controls();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSite.Text)){
                blockSiteAddToList(txtSite.Text,"");
            }
        }

        private void lstBlockSites_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete){
                if (lstBlockSites.SelectedItem!=null){
                    // deblock the site
                    con.deBlockSite(lstBlockSites.SelectedItem.ToString(),true);
                    // remove from list
                    lstBlockSites.Items.RemoveAt(lstBlockSites.SelectedIndex);
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine(lstBlockSites.Items.Count);
            for(int a=0; a<lstBlockSites.Items.Count; a++){
                con.deBlockSite(lstBlockSites.Items[a].ToString(), true);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(open.FileName.ToString());
                lslList.Items.Add(open.SafeFileName);
                while((line = file.ReadLine()) != null)
                {
                    blockSiteAddToList(line,open.SafeFileName);
                }
                file.Close();
            }
        }

        private void blockSiteAddToList(String siteString, String list)
        {
            Site site = new Site(siteString, list);
            // add to list
            lstBlockSites.Items.Add(site);
            // block site
            con.blockSite(site.getSiteName());
        }
        
        private void lslList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ArrayList sites = new ArrayList();
                for (int a = 0; a < lstBlockSites.Items.Count; a++)
                {
                    // get all the sites that have the list that is selected
                    Site site = (Site)lstBlockSites.Items[a];
                    if (site.getList() == lslList.SelectedItem.ToString())
                    {
                        sites.Add(site);
                    }
                }
                foreach (Site site in sites)
                {
                    con.deBlockSite(site.getSiteName(), true);
                    lstBlockSites.Items.Remove(site);
                }
                lslList.Items.RemoveAt(lslList.SelectedIndex);
            }
        }
    }
}
