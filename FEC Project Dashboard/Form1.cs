using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FEC_Project_Dashboard
{
    public partial class Form1 : Form
    {
        bool ChangeLocationEnable = false;
        int xPos;//记录x坐标: 
        int yPos;//记录y坐标: 
        int startY;
        bool MoveFlag;//记录是否按下鼠标:
        private int SelectedPanelIndex = -1;
        //FrameControl fc;//边框控件
        List<int> Ys = new List<int>();
        List<int> Ys_Sort;
        List<int> idx;
        List<System.Windows.Forms.Panel> List_Panels = new List<System.Windows.Forms.Panel>();
        //List<System.Windows.Forms.ComboBox> List_ComboBox_Teams = new List<System.Windows.Forms.ComboBox>();
        //List<System.Windows.Forms.ComboBox> List_ComboBox_Status = new List<System.Windows.Forms.ComboBox>();
        List<System.Windows.Forms.TextBox> List_txt_ProjectNames = new List<System.Windows.Forms.TextBox>();
        public Form1()
        {
            InitializeComponent();
        }
        
        public void ExportToCSV()
        {
            string line = string.Empty;
            const string LOG_DIR = "logs";
            string csvFilePath = Path.Combine(LOG_DIR, DateTime.Now.ToString("yyyy-MM-dd") + ".csv");
            if (!Directory.Exists(LOG_DIR)) Directory.CreateDirectory(LOG_DIR);

            if (File.Exists(csvFilePath))
            {
                File.Delete(csvFilePath);
            }
            //写入表头
            using (StreamWriter csvFile = new StreamWriter(csvFilePath, true, Encoding.UTF8))
            {
                line = "No.,ProjectName,Team,Status";
                csvFile.WriteLine(line);
            }
            int mNo = 1;          
            using (StreamWriter csvFile = new StreamWriter(csvFilePath, true, Encoding.UTF8))
            {
                for (int i = 0; i < panel_Paint.Controls.Count; i++)
                {
                    if (panel_Paint.Controls[i].Visible)
                    {
                        line = mNo++.ToString() + "," + panel_Paint.Controls[idx[i]].Controls[0].Text
                            + "," + panel_Paint.Controls[idx[i]].Controls[1].Text
                            + "," + panel_Paint.Controls[idx[i]].Controls[2].Text;
                        csvFile.WriteLine(line);
                    }
                }
                
            }

        }

        //排序后输出
        public void SortByY()
        {
            Ys = new List<int>();
            for (int i = 0; i < panel_Paint.Controls.Count; i++)
            {
                Ys.Add(panel_Paint.Controls[i].Top);
            }
            var sorted = Ys
                .Select((x, i) => new KeyValuePair<int, int>(x, i))
                .OrderBy(x => x.Key)
                .ToList();
            Ys_Sort = sorted.Select(x => x.Key).ToList();
            idx = sorted.Select(x => x.Value).ToList();
        }

        //筛选已完成&分行业
        public void Filter() 
        {
            //SortByY();//排序后输出
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            for (int i = 0; i < idx.Count; i++)
            {
                if (panel_Paint.Controls[idx[i]].Controls[2].Text == "Finished")
                {
                    listBox7.Items.Add(panel_Paint.Controls[idx[i]].Controls[1].Text + "-" + panel_Paint.Controls[idx[i]].Controls[0].Text);
                }
                switch (panel_Paint.Controls[idx[i]].Controls[1].Text)
                {
                    case "AMI":
                        listBox1.Items.Add(panel_Paint.Controls[idx[i]].Controls[0].Text);
                        break;
                    case "ELA":
                        listBox2.Items.Add(panel_Paint.Controls[idx[i]].Controls[0].Text);
                        break;
                    case "GI":
                        listBox3.Items.Add(panel_Paint.Controls[idx[i]].Controls[0].Text);
                        break;
                    case "FP":
                        listBox4.Items.Add(panel_Paint.Controls[idx[i]].Controls[0].Text);
                        break;
                    case "PI&LT":
                        listBox5.Items.Add(panel_Paint.Controls[idx[i]].Controls[0].Text);
                        break;
                    case "Others":
                        listBox6.Items.Add(panel_Paint.Controls[idx[i]].Controls[0].Text);
                        break;
                    default:
                        break;
                }
            }  
        }

        private void MoveUp(Panel m_Panel, int destinationY)
        {
            foreach (Panel item in panel_Paint.Controls)
            {                
                if (item.Top == destinationY)
                {
                    MoveUp(item, destinationY + 34);
                }
            }
            m_Panel.Left = 28;
            m_Panel.Top = destinationY;
        }

        private void MoveDown(Panel m_Panel, int destinationY)
        {
            foreach (Panel item in panel_Paint.Controls)
            {
                if (item.Top == destinationY)
                {
                    MoveDown(item, destinationY - 34);
                }
            }
            m_Panel.Left = 28;
            m_Panel.Top = destinationY;
        }

        private void Btn_Sort_Click(object sender, EventArgs e)
        {
            if (btn_Sort.Text == "Sort")
            {
                ChangeLocationEnable = true;
                btn_Add.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Sort.Text = "Done";
            }
            else
            {
                ChangeLocationEnable = false;
                SortByY();
                Filter();
                List_Panels = new List<Panel>();
                List_txt_ProjectNames = new List<TextBox>();
                for (int i = 0; i < idx.Count; i++)
                {
                    List_Panels.Add((Panel)panel_Paint.Controls[idx[i]]);
                    List_txt_ProjectNames.Add((TextBox)panel_Paint.Controls[idx[i]].Controls[0]);
                }
                ExportToCSV();
                btn_Add.Enabled = true;
                btn_Delete.Enabled = true;
                btn_Sort.Text = "Sort";
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (SelectedPanelIndex==-1)
            {
                System.Windows.Forms.Panel panel_Item = new Panel();
                List_Panels.Add(panel_Item);
                panel_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
                panel_Item.Location = new System.Drawing.Point(28, 34 * (panel_Paint.Controls.Count) + 2);
                panel_Item.Name = "panel_ItemDemo";
                panel_Item.Size = new System.Drawing.Size(panel_Paint.Width - 30, 36);

                System.Windows.Forms.ComboBox comboBox_Team = new ComboBox();
                comboBox_Team.Dock = System.Windows.Forms.DockStyle.Right;
                comboBox_Team.FormattingEnabled = true;
                comboBox_Team.Items.AddRange(new object[] {
                "AMI",
                "ELA",
                "GI",
                "FP",
                "PI&LT",
                "Others"});
                comboBox_Team.Location = new System.Drawing.Point(142, 0);
                comboBox_Team.Name = "ComboBox_Team";
                comboBox_Team.Size = new System.Drawing.Size(80, 37);
                comboBox_Team.TabIndex = 2;

                System.Windows.Forms.ComboBox comboBox_Status = new ComboBox();
                comboBox_Status.Dock = System.Windows.Forms.DockStyle.Right;
                comboBox_Status.FormattingEnabled = true;
                comboBox_Status.Items.AddRange(new object[] {
                "Not started",
                "In progress",
                "Finished",
                "In evaluation"});
                comboBox_Status.Location = new System.Drawing.Point(230, 0);
                comboBox_Status.Name = "ComboBox_Status";
                comboBox_Status.Size = new System.Drawing.Size(125, 37);
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
            else
            {
                //MessageBox.Show(SelectedPanelIndex.ToString()+":"+List_txt_ProjectNames[SelectedPanelIndex].Text);
                System.Windows.Forms.Panel panel_Item = new Panel();
                List_Panels.Add(panel_Item);
                panel_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
                panel_Item.Location = new System.Drawing.Point(28, 34 * (SelectedPanelIndex + 1) + 2);
                panel_Item.Name = "panel_ItemDemo";
                panel_Item.Size = new System.Drawing.Size(panel_Paint.Width - 30, 36);

                System.Windows.Forms.ComboBox comboBox_Team = new ComboBox();
                comboBox_Team.Dock = System.Windows.Forms.DockStyle.Right;
                comboBox_Team.FormattingEnabled = true;
                comboBox_Team.Items.AddRange(new object[] {
            "AMI",
            "ELA",
            "GI",
            "FP",
            "PI&LT",
            "Others"});
                comboBox_Team.Location = new System.Drawing.Point(142, 0);
                comboBox_Team.Name = "ComboBox_Team";
                comboBox_Team.Size = new System.Drawing.Size(88, 37);
                comboBox_Team.TabIndex = 2;

                System.Windows.Forms.ComboBox comboBox_Status = new ComboBox();
                comboBox_Status.Dock = System.Windows.Forms.DockStyle.Right;
                comboBox_Status.FormattingEnabled = true;
                comboBox_Status.Items.AddRange(new object[] {
                "Not started",
                "In progress",
                "Finished",
                "In evaluation"});
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

                foreach (Panel item in panel_Paint.Controls)
                {
                    if (item.Top >= 34 * (SelectedPanelIndex + 1) + 2)
                    {
                        item.Top += 34;
                    }
                }
                this.panel_Paint.Controls.Add(List_Panels[List_Panels.Count - 1]);
            }
            SortByY();
            List_Panels = new List<Panel>();
            List_txt_ProjectNames = new List<TextBox>();
            for (int i = 0; i < idx.Count; i++)
            {
                List_Panels.Add((Panel)panel_Paint.Controls[idx[i]]);
                List_txt_ProjectNames.Add((TextBox)panel_Paint.Controls[idx[i]].Controls[0]);
            }
        }

        private void Txt_ProjectName_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ChangeLocationEnable)
                {
                    MoveFlag = true;//已经按下.
                    xPos = e.X;//当前x坐标.
                    yPos = e.Y;//当前y坐标.
                }
                //MessageBox.Show(sender.ToString());
                for (int i = 0; i < List_txt_ProjectNames.Count; i++)
                {
                    if (sender.Equals(List_txt_ProjectNames[i]))
                    {
                        SelectedPanelIndex = i;
                        startY = List_Panels[i].Top;
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
                                int destination_X = List_Panels[i].Left + Convert.ToInt16(e.X - xPos);//设置x坐标.
                                int destination_Y = List_Panels[i].Top + Convert.ToInt16(e.Y - yPos);//设置y坐标.
                                //for (int j = 0; j < List_Panels.Count; j++)
                                //{
                                //    if (List_Panels[j].Top < List_Panels[i].Top && List_Panels[j].Top > destination_Y)
                                //    {
                                //        List_Panels[j].Top += List_Panels[j].Height;
                                //    }
                                //}
                                List_Panels[i].Left = destination_X;
                                List_Panels[i].Top = destination_Y;
                                ////if (fc != null)
                                ////{
                                ////    fc.Visible = false;

                                ////}
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
                    for (int i = 0; i < List_txt_ProjectNames.Count; i++)
                    {
                        if (sender.Equals(List_txt_ProjectNames[i]))
                        {
                            if (List_Panels[i].Top > startY)
                            {
                                //move down
                                if (List_Panels[i].Top < 36)
                                {
                                    List_Panels[i].Left = 28;
                                    List_Panels[i].Top = 2;
                                }
                                else
                                {
                                    if (List_Panels[i].Top >= 34 * (panel_Paint.Controls.Count - 1) + 2)
                                    {
                                        MoveDown(List_Panels[i], 34 * (panel_Paint.Controls.Count - 1) + 2);
                                    }
                                    else
                                    {
                                        for (int j = 1; j < panel_Paint.Controls.Count - 1; j++)
                                        {
                                            if (List_Panels[i].Top >= 36 + (j - 1) * 34 && List_Panels[i].Top < 36 + j * 34)
                                            {
                                                MoveDown(List_Panels[i], 36 + (j - 1) * 34);
                                            }
                                        }
                                    }
                                }
                            }
                            else if (List_Panels[i].Top < startY)
                            {
                                //move up
                                if (List_Panels[i].Top >= 34 * (panel_Paint.Controls.Count - 1) + 2)
                                {
                                    List_Panels[i].Left = 28;
                                    List_Panels[i].Top = 34 * (panel_Paint.Controls.Count - 1) + 2;
                                }
                                else
                                {
                                    if (List_Panels[i].Top < 36)
                                    {
                                        MoveUp(List_Panels[i], 2);
                                    }
                                    else
                                    {
                                        for (int j = 1; j < panel_Paint.Controls.Count - 1; j++)
                                        {
                                            if (List_Panels[i].Top >= 36 + (j - 1) * 34 && List_Panels[i].Top < 36 + j * 34)
                                            {
                                                MoveUp(List_Panels[i], 36 + (j - 1) * 34);
                                            }
                                        }
                                    }
                                }
                            }
                            
                        }
                    }
                    
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
            int CurY = List_Panels[SelectedPanelIndex].Top;
            this.panel_Paint.Controls.Remove(List_Panels[SelectedPanelIndex]);
            //List_txt_ProjectNames.RemoveAt(SelectedPanelIndex);
            //List_Panels.RemoveAt(SelectedPanelIndex);
            foreach (Panel item in panel_Paint.Controls)
            {
                if (item.Top > CurY)
                {
                    item.Top -= 34;
                }
            }
            SortByY();
            List_Panels = new List<Panel>();
            List_txt_ProjectNames = new List<TextBox>();
            for (int i = 0; i < idx.Count; i++)
            {
                List_Panels.Add((Panel)panel_Paint.Controls[idx[i]]);
                List_txt_ProjectNames.Add((TextBox)panel_Paint.Controls[idx[i]].Controls[0]);
            }
        }

        private void Btn_Import_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader read = new StreamReader(openFileDialog1.FileName, true))
                {
                    string aLine;
                    int Index_Line = 0;
                    while ((aLine = read.ReadLine()) != null)
                    {
                        if (Index_Line!=0)
                        {
                            Btn_Add_Click(sender, e);
                            panel_Paint.Controls[panel_Paint.Controls.Count - 1].Controls[0].Text = aLine.Split(',')[1];
                            panel_Paint.Controls[panel_Paint.Controls.Count - 1].Controls[1].Text = aLine.Split(',')[2];
                            panel_Paint.Controls[panel_Paint.Controls.Count - 1].Controls[2].Text = aLine.Split(',')[3];
                        }
                        else
                        {
                            panel_Paint.Controls.Clear();
                        }
                        Index_Line++;
                    }
                }             
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileInfo[] ArrayFileInfo;
            //DirectoryInfo pDirectoryInfo = new DirectoryInfo(System.IO.Directory.GetCurrentDirectory()+"\\logs");
            DirectoryInfo pDirectoryInfo = new DirectoryInfo("logs");
            ArrayFileInfo = pDirectoryInfo.GetFiles();
            DateTime mLastTime;
            int LastIndex = 0;
            if (ArrayFileInfo.Length >= 1)
            {
                mLastTime = ArrayFileInfo[0].CreationTime;
                LastIndex = 0;
                for (int i = 0; i < ArrayFileInfo.Length; i++)
                {
                    if (ArrayFileInfo[i].CreationTime > mLastTime)
                    {
                        mLastTime = ArrayFileInfo[i].CreationTime;
                        LastIndex = i;
                    }
                }
            }            
            using (StreamReader read = new StreamReader(pDirectoryInfo.GetFiles()[LastIndex].FullName, true))
            {
                string aLine;
                int Index_Line = 0;
                while ((aLine = read.ReadLine()) != null)
                {
                    if (Index_Line != 0)
                    {
                        Btn_Add_Click(sender, e);
                        panel_Paint.Controls[panel_Paint.Controls.Count - 1].Controls[0].Text = aLine.Split(',')[1];
                        panel_Paint.Controls[panel_Paint.Controls.Count - 1].Controls[1].Text = aLine.Split(',')[2];
                        panel_Paint.Controls[panel_Paint.Controls.Count - 1].Controls[2].Text = aLine.Split(',')[3];
                    }
                    else
                    {
                        panel_Paint.Controls.Clear();
                    }
                    Index_Line++;
                }
            }
            SortByY();
            Filter();
        }

        private void panel_Paint_MouseDown(object sender, MouseEventArgs e)
        {
            SelectedPanelIndex = -1;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            foreach (Panel item in panel_Paint.Controls)
            {
                item.Size = new System.Drawing.Size(panel_Paint.Width - 30, 36);
            }
        }

        private void tsMenuItem_Import_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader read = new StreamReader(openFileDialog1.FileName, true))
                {
                    string aLine;
                    int Index_Line = 0;
                    while ((aLine = read.ReadLine()) != null)
                    {
                        if (Index_Line != 0)
                        {
                            Btn_Add_Click(sender, e);
                            panel_Paint.Controls[panel_Paint.Controls.Count - 1].Controls[0].Text = aLine.Split(',')[1];
                            panel_Paint.Controls[panel_Paint.Controls.Count - 1].Controls[1].Text = aLine.Split(',')[2];
                            panel_Paint.Controls[panel_Paint.Controls.Count - 1].Controls[2].Text = aLine.Split(',')[3];
                        }
                        else
                        {
                            panel_Paint.Controls.Clear();
                        }
                        Index_Line++;
                    }
                }
            }
        }

        private void tsMenuItem_Export_Click(object sender, EventArgs e)
        {
            string line = string.Empty;
            const string LOG_DIR = "logs";
            string csvFilePath = Path.Combine(LOG_DIR, DateTime.Now.ToString("yyyy-MM-dd") + ".csv");
            if (!Directory.Exists(LOG_DIR)) Directory.CreateDirectory(LOG_DIR);

            if (File.Exists(csvFilePath))
            {
                File.Delete(csvFilePath);
            }
            //写入表头
            using (StreamWriter csvFile = new StreamWriter(csvFilePath, true, Encoding.UTF8))
            {
                line = "No.,ProjectName,Team,Status,StartFrom,Duration,ClosingDate";
                csvFile.WriteLine(line);
            }
            int mNo = 1;
            using (StreamWriter csvFile = new StreamWriter(csvFilePath, true, Encoding.UTF8))
            {
                for (int i = 0; i < panel_Paint.Controls.Count; i++)
                {
                    if (panel_Paint.Controls[i].Visible)
                    {
                        line = mNo++.ToString() + "," + panel_Paint.Controls[idx[i]].Controls[0].Text
                            + "," + panel_Paint.Controls[idx[i]].Controls[1].Text
                            + "," + panel_Paint.Controls[idx[i]].Controls[2].Text;
                        csvFile.WriteLine(line);
                    }
                }

            }
        }

        private void tsbtn_AddNew_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
           
            
        }

        private int GetRowFromPoint(int x, int y)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                Rectangle rec = dataGridView1.GetRowDisplayRectangle(i, false);

                if (dataGridView1.RectangleToScreen(rec).Contains(x, y))
                    return i;
            }

            return -1;
        }

        private void DataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Clicks < 2) && (e.Button == MouseButtons.Left))
            {
                if ((e.ColumnIndex == -1) && (e.RowIndex > -1))
                    dataGridView1.DoDragDrop(dataGridView1.Rows[e.RowIndex], DragDropEffects.Move);
            }
        }

        int selectionIdx;
        private void DataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            int idx = GetRowFromPoint(e.X, e.Y);

            if (idx < 0) return;

            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
            {
                DataGridViewRow row = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));
                dataGridView1.Rows.Remove(row);
                dataGridView1.Rows.Insert(idx, row);
                selectionIdx = idx;
            }
        }

        private void DataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
                selectionIdx = e.RowIndex;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if ((dataGridView1.Rows.Count > 0) && (dataGridView1.SelectedRows.Count > 0) && (dataGridView1.SelectedRows[0].Index != selectionIdx))
            {
                if (dataGridView1.Rows.Count <= selectionIdx)
                    selectionIdx = dataGridView1.Rows.Count - 1;
                dataGridView1.Rows[selectionIdx].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[selectionIdx].Cells[0];
            }
        }

        private void DataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
