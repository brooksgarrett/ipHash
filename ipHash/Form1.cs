using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ipHash
{
    /// <summary>
    /// This is the main windows form for hashing and reverse hashing IP Addresses as 
    /// outlined in http://ipinfodb.com/ip_database.php. It is comprised of two text boxes and two buttons. 
    /// Tabbing between fields is supported as is pressing Enter from the Text Boxes.
    /// </summary>
    public partial class MainWindow : Form
    {
        private IPAddress ipAddress = new IPAddress();
        Int16 tipTimeout = 5000;

        public MainWindow()
        {
            InitializeComponent();
            hashErrorTip.SetToolTip(hashTB, "Please enter a Hash to reverse.");
            ipErrorTip.SetToolTip(ipTB, "Please enter an IP Address");
        }

        private void ipTB_KeyUp(object sender, KeyEventArgs e)
        {
            ipErrorTip.Hide(this.ipTB);
            hashErrorTip.Hide(this.hashTB);
            if (e.KeyCode == Keys.Enter) hashBTN.PerformClick();
        }

        private void hashTB_KeyUp(object sender, KeyEventArgs e)
        {
            ipErrorTip.Hide(this.ipTB);
            hashErrorTip.Hide(this.hashTB);
            if (e.KeyCode == Keys.Enter) reverseBTN.PerformClick();
        }

        private void ipBTN_Click(object sender, EventArgs e)
        {
            try
            {
                ipAddress.IP = (ipTB.Text);
                hashTB.Text = ipAddress.hash().ToString();
            }
            catch (Exception ex)
            {

                ipErrorTip.Show(ex.Message, this.ipTB, this.ipTB.Size.Width / 3, this.ipTB.Size.Height, tipTimeout);

            }
        }

        private void hashBTN_Click(object sender, EventArgs e)
        {
            try
            {
                ipAddress.IPHash = hashTB.Text;
                ipTB.Text = ipAddress.reverseHash();
            }
            catch (Exception ex)
            {
                hashErrorTip.Show(ex.Message, this.hashTB, this.hashTB.Size.Width / 3, this.hashTB.Size.Height, tipTimeout);
            }
        }

        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            /**
            if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("Really exit?", "Exit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                { Environment.Exit(0); }
            }
             **/
        }

    }
}
