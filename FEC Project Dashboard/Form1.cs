using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FEC_Project_Dashboard
{
    public partial class Form1 : Form
    {
        bool ChangeLocationEnable = false;
        int xPos;//记录x坐标: 
        int yPos;//记录y坐标: 
        bool MoveFlag;//记录是否按下鼠标:
        private int SelectedPanelIndex = 0;
        //FrameControl fc;//边框控件
        List<System.Windows.Forms.Panel> List_Panels = new List<System.Windows.Forms.Panel>();
        List<System.Windows.Forms.ComboBox> List_ComboBox_Teams = new List<System.Windows.Forms.ComboBox>();
        List<System.Windows.Forms.ComboBox> List_ComboBox_Status = new List<System.Windows.Forms.ComboBox>();
        List<System.Windows.Forms.TextBox> List_txt_ProjectNames = new List<System.Windows.Forms.TextBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Sort_Click(object sender, EventArgs e)
        {
            if (btn_Sort.Text == "排 序")
            {
                ChangeLocationEnable = true;
                btn_Sort.Text = "完 成";
            }
            else
            {
                ChangeLocationEnable = false;
                //自动规整位置

                btn_Sort.Text = "排 序";
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Panel panel_Item = new Panel();
            List_Panels.Add(panel_Item);
            panel_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            panel_Item.Location = new System.Drawing.Point(0, 30 * (List_Panels.Count - 1));
            panel_Item.Name = "panel_ItemDemo";
            panel_Item.Size = new System.Drawing.Size(320, 36);

            System.Windows.Forms.ComboBox comboBox_Team = new ComboBox();
            comboBox_Team.Dock = System.Windows.Forms.DockStyle.Right;
            comboBox_Team.FormattingEnabled = true;
            comboBox_Team.Items.AddRange(new object[] {
            "AMI",
            "ELA",
            "GI",
            "FP",
            "PI and LT",
            "Others"});
            comboBox_Team.Location = new System.Drawing.Point(142, 0);
            comboBox_Team.Name = "ComboBox_Team";
            comboBox_Team.Size = new System.Drawing.Size(88, 37);
            comboBox_Team.TabIndex = 2;
            
            System.Windows.Forms.ComboBox comboBox_Status = new ComboBox();
            comboBox_Status.Dock = System.Windows.Forms.DockStyle.Right;
            comboBox_Status.FormattingEnabled = true;
            comboBox_Status.Items.AddRange(new object[] {
            "进行中",
            "未启动",
            "已完成"});
            comboBox_Status.Location = new System.Drawing.Point(230, 0);
            comboBox_Status.Name = "ComboBox_Status";
            comboBox_Status.Size = new System.Drawing.Size(90, 37);
            comboBox_Status.Sorted = true;
            comboBox_Status.TabIndex = 1;

            System.Windows.Forms.TextBox txt_Team_ProjectName = new TextBox();
            txt_Team_ProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_Team_ProjectName.Location = new System.Drawing.Point(0, 0);
            txt_Team_ProjectName.Name = "txt_Team_ProjectName";
            txt_Team_ProjectName.Size = new System.Drawing.Size(142, 34);
            txt_Team_ProjectName.TabIndex = 3;
            txt_Team_ProjectName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Txt_ProjectName_MouseDown);
            txt_Team_ProjectName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Txt_ProjectName_MouseMove);
            txt_Team_ProjectName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Txt_ProjectName_MouseUp);
            List_txt_ProjectNames.Add(txt_Team_ProjectName);

            List_Panels[List_Panels.Count - 1].Controls.Add(txt_Team_ProjectName);
            List_Panels[List_Panels.Count - 1].Controls.Add(comboBox_Team);
            List_Panels[List_Panels.Count - 1].Controls.Add(comboBox_Status);

            this.panel_Paint.Controls.Add(List_Panels[List_Panels.Count - 1]);
        
        }

        private void Txt_ProjectName_MouseDown(object sender, MouseEventArgs e)
        {
            if (true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    MoveFlag = true;//已经按下.
                    xPos = e.X;//当前x坐标.
                    yPos = e.Y;//当前y坐标.
                    for (int i = 0; i < List_txt_ProjectNames.Count; i++)
                    {
                        if (sender.Equals(List_txt_ProjectNames[i]))
                        {
                            SelectedPanelIndex = i;
                            List_Panels[i].Parent.Refresh();
                            List_Panels[i].BringToFront();
                            //fc = new FrameControl(panelCamArray[i]);
                            //panelCamArray[i].Parent.Controls.Add(fc);
                            //fc.Visible = true;
                            //fc.Draw();
                        }
                    }
                }
            }
        }

        private void Txt_ProjectName_MouseMove(object sender, MouseEventArgs e)
        {
            if (ChangeLocationEnable)
            {
                if (e.Button == MouseButtons.Left)
                {
                    for (int i = 0; i < List_txt_ProjectNames.Count; i++)
                    {
                        if (sender.Equals(List_txt_ProjectNames[i]))
                        {
                            if (MoveFlag)
                            {
                                List_Panels[i].Left += Convert.ToInt16(e.X - xPos);//设置x坐标.
                                List_Panels[i].Top += Convert.ToInt16(e.Y - yPos);//设置y坐标.
                                //if (fc != null)
                                //{
                                //    fc.Visible = false;

                                //}
                            }
                        }
                    }
                }
            }
        }

        private void Txt_ProjectName_MouseUp(object sender, MouseEventArgs e)
        {
            if (ChangeLocationEnable)
            {
                if (e.Button == MouseButtons.Left)
                {
                    MoveFlag = false;
                    //for (int i = 0; i < List_txt_Team_ProjectNames.Count; i++)
                    //{
                    //    if (sender.Equals(List_txt_Team_ProjectNames[i]))
                    //    {
                    //        if (fc != null)
                    //        {
                    //            fc = new FrameControl(panelCamArray[i]);
                    //            panelCamArray[i].Parent.Controls.Add(fc);
                    //            fc.Visible = true;
                    //            fc.Draw();
                    //        }
                    //    }
                    //}
                    panel_Paint.Refresh();
                }
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            this.panel_Paint.Controls.Remove(List_Panels[SelectedPanelIndex]);
        }
    }
}
