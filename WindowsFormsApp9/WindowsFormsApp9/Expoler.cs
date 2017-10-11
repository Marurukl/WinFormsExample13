using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp9
{
    public partial class Expoler : Form
    {
        public Expoler()
        {
            InitializeComponent();
            foreach (DriveInfo d in DriveInfo.GetDrives())
            {
                TreeNode driveNode = new TreeNode { Text = d.Name };
                string[] directories = Directory.GetDirectories(d.Name);
                foreach (string director in directories)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = director.Remove(0, director.LastIndexOf("\\") + 1);
                    driveNode.Nodes.Add(dirNode);
                }
                treeView1.Nodes.Add(driveNode);
            }
        }

        
    }
}
