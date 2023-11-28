using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hasher rcs = new Hasher();
        private void decodebut_Click(object sender, EventArgs e)
        {
            switch (hashtypecombo.Text)
            {
                case "Base64":
                    decryptbox.Text = rcs.base64Decode(hashbox.Text);
                    break;
                case "Hex":
                    decryptbox.Text = rcs.HexToString(hashbox.Text);
                    break;
            }
        }
        private void encodebut_Click(object sender, EventArgs e)
        {
            switch (hashtypecombo.Text)
            {
                case "Base64":
                hashbox.Text = rcs.base64Encode(decryptbox.Text);
                    break;
                case "Hex":
                    hashbox.Text = rcs.BytesToHex(Encoding.UTF8.GetBytes(decryptbox.Text));
                    break;
                case "MD5":
                    hashbox.Text = rcs.MD5Encode(decryptbox.Text);
                    break;
                case "SHA256":
                    hashbox.Text = rcs.SHA256Encode(decryptbox.Text);
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void hashtypecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
