/*  Windows Drive Starter v1.0
 *
 *  TOC         2022-05-27 <> 2022-05-28
 *  DEV         Stephan Kammel
 *  LOC         178
 *  License:    created with MS Visual Studio 2019 community edition,
 *              this software may be used and distributed freely,
 *              authorship must be respected and acknowledged
 *
 *  #!!! Features/Purpose:
 *  Open all drives on your workstation except the system drive with
 *  a single click. Drives can be selected and deselected.
 *  Drives can be accessed all at once or individually.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace driveStarter
{
    public partial class driveStarter : Form
    {
        // globals

        List<string> directory = new List<string>();
        List<Button> btnDrvs = new List<Button>();
        List<CheckBox> cbxDrvs = new List<CheckBox>();

        DriveInfo[] allDrives = DriveInfo.GetDrives();
        Font font = new Font("Verdana", 12);
        Color backColor = Color.WhiteSmoke;
        Color fontColor = Color.DarkOrchid;

        int gigabyte = 1024 * 1024 * 1024;


        // methods

        public driveStarter()
        {
            InitializeComponent();
        }

        public void buildGuiElements(int count, DriveInfo d)
        {
            CheckBox cbxDrv = new CheckBox();
            cbxDrv.Name = String.Format("cbxDrv{0}", count);
            cbxDrv.Font = new Font("Verdana", 12);
            cbxDrv.Text = d.Name;

            if (cbxDrv.Text != @"C:\" && d.IsReady){
                cbxDrv.Checked = true;
            }

            cbxDrv.CheckedChanged += CbxDrv_CheckedChanged;

            directory.Add(d.Name);
            flpdrv.Controls.Add(cbxDrv);

            cbxDrvs.Add(cbxDrv);
        }

        public void buildSelectionButton(int count, DriveInfo d)
        {
            Button btnDrive = new Button();
            btnDrive.Name = String.Format("btnDrive{0}", count);
            btnDrive.Font = new Font("Verdana", 10);
            btnDrive.Size = new Size(200, 70);
            btnDrive.AutoSize = true;

            if (d.IsReady && d.Name != @"C:\")
            {
                btnDrive.Text = d.Name +
                "\n" + "Free Space in GB: " + d.TotalFreeSpace / gigabyte +
                "\n" + "Total Space in GB: " + d.TotalSize / gigabyte;
                btnDrive.TextAlign = ContentAlignment.TopLeft;
            }
            else
            {
                btnDrive.Enabled = false;
            }

            btnDrive.Click += BtnDrive_Click;
            flpButtons.Controls.Add(btnDrive);

            btnDrvs.Add(btnDrive);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < allDrives.Length; i++)
            {
                buildGuiElements(i, allDrives[i]);
                buildSelectionButton(i, allDrives[i]);
            }

            this.BackColor = backColor;
            this.ForeColor = fontColor;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            lblDrives.ForeColor = fontColor;
            lblDrives.Font = font;
            lblFunction.ForeColor = fontColor;
            lblFunction.Font = font;
            btnShowAll.Font = font;
        }


        // events

        private void BtnDrive_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < btnDrvs.Count; i++)
            {
                if (cbxDrvs[i].Checked)
                {
                    if (allDrives[i].IsReady && btnDrvs[i].Focused)
                    {
                        Process.Start("explorer.exe", allDrives[i].Name);
                    }
                    if (!allDrives[i].IsReady && btnDrvs[i].Focused)
                    {
                        MessageBox.Show("Drive not ready");
                    }
                }
            }
        }

        public void btnShowAll_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();

            for (int i = 0; i < allDrives.Length; i++)
            {
                if (cbxDrvs[i].Checked && allDrives[i].IsReady)
                {
                    Process.Start("explorer.exe", allDrives[i].Name);
               }
            }
        }

        private void CbxDrv_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cbxDrvs.Count; i++)
            {
                if (cbxDrvs[i].Checked && btnDrvs[i].Enabled == false)
                {
                    btnDrvs[i].Enabled = true;
                    if (allDrives[i].IsReady)
                    {
                        btnDrvs[i].Text = allDrives[i].Name +
                            "\n" + "Free Space in GB: " +
                            allDrives[i].TotalFreeSpace / gigabyte +
                            "\n" + "Total Space in GB: " +
                            allDrives[i].TotalSize / gigabyte;
                        btnDrvs[i].TextAlign = ContentAlignment.TopLeft;
                    }
                }

                if (!cbxDrvs[i].Checked)
                {
                    btnDrvs[i].Enabled = false;
                }
            }
        }
    }

