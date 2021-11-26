using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace InjectDLLX64
{
    public partial class Inject : Form
    {
        static uint ProcessId = 0;

        static string ProcessName = "";

        static Font font;

        public Inject()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗口加载完毕
        /// </summary>
        /// <param name="sender">null</param>
        /// <param name="e">null</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //禁止窗口最大化
            this.MaximizeBox = false;

            //设置全局字体，方便全局使用
            Inject.font = new Font("黑体", 11,SELECT_PROCESS_LABEL.Font.Style & ~FontStyle.Italic);
            //标签
            SELECT_PROCESS_LABEL.Font = Inject.font;
            SELECT_DLL_PATH_LABEL.Font = Inject.font;
            SELECT_INJECT_WAY_LABEL.Font = Inject.font;

            //组合框
            PROCESS_COMBO_BOX.Font = Inject.font;
            //选择进程的按钮
            SELECT_PROCESS_BUTTON.Font = Inject.font;
            //提示框
            SELECT_GROUP_BOX.Font = Inject.font;
            LOG_GROUP_BOX.Font = Inject.font;
            SELECT_GROUP_BOX.Font = Inject.font;
            SELECT_DLL_FILE_GROUP.Font = Inject.font;
           


            //选择DLL按钮
            SELECT_DLL_BUTTON.Font = Inject.font;
            //DLL目录编辑框
            DLL_PATH_TEXT_BOX.Font = Inject.font;
            DLL_PATH_TEXT_BOX.ReadOnly = true;

            //日志编辑框
            LOG_TEXT_BOX.ReadOnly = true;
            LOG_TEXT_BOX.Font = Inject.font;

            INJECT_WAY_COMBOX.Items.Add("线程注入");
            INJECT_WAY_COMBOX.Items.Add("内存注入");
            INJECT_WAY_COMBOX.SelectedIndex = 0;
            UpdateToLog("初始化完毕!");

        }

        /// <summary>
        ///  填充Combo的内容
        /// </summary>
        /// <param name="sender">NULL</param>
        /// <param name="e">NULL</param>
        private void PROCESS_COMBO_BOX_MouseClick(object sender, MouseEventArgs e)
        {
            //清空上一次枚举的进程
            PROCESS_COMBO_BOX.Items.Clear();

            Process[] processes = Process.GetProcesses();
            foreach(Process result in processes)
            {
                PROCESS_COMBO_BOX.Items.Add(result.ProcessName+":"+result.Id);
            }
        }

        private void SELECT_PROCESS_BUTTON_Click(object sender, EventArgs e)
        {
            if(PROCESS_COMBO_BOX.Text.CompareTo("") == 0)
            {
                MessageBox.Show("请选择进程!!!","ERROR:",MessageBoxButtons.OK);
                goto __falied;
            }
            else
            {
                Inject.ProcessId = Convert.ToUInt32(PROCESS_COMBO_BOX.Text.Substring(PROCESS_COMBO_BOX.Text.IndexOf(':') + 0x1));
                Inject.ProcessName = PROCESS_COMBO_BOX.Text.Substring(0, PROCESS_COMBO_BOX.Text.IndexOf(':'));
                Inject.ProcessName += ".exe";
                this.Text = "你已经选择:" + Inject.ProcessName;
                UpdateToLog("选择:" + Inject.ProcessName);
                goto __success;
            }
            __falied:
            PROCESS_COMBO_BOX.Focus();
            __success:
            return;
        }

        private void Inject_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void SELECT_DLL_BUTTON_Click(object sender, EventArgs e)
        {
            SELECT_FILE_DIALOG.Multiselect = false;
            SELECT_FILE_DIALOG.InitialDirectory = Environment.CurrentDirectory;
            SELECT_FILE_DIALOG.Filter = "DLL (*.dll)|*.dll";
            SELECT_FILE_DIALOG.Title = "选择DLL文件";
            if(DialogResult.OK == SELECT_FILE_DIALOG.ShowDialog())
            {
                var DLLpath= SELECT_FILE_DIALOG.FileName;
                DLL_PATH_TEXT_BOX.Text = DLLpath;
                UpdateToLog("DLL:"+DLL_PATH_TEXT_BOX.Text);
                //去掉文件目录
                SELECT_FILE_DIALOG.FileName = "";
            }
            
        }

        //注入
        private void INJECT_OK_BUTTON_Click(object sender, EventArgs e)
        {
            string Path = DLL_PATH_TEXT_BOX.Text;
            if(Inject.ProcessName.CompareTo("") == 0)
            {
                MessageBox.Show("请选择进程", "ERROR:", MessageBoxButtons.OK);
                return;
            }
            if(Path.CompareTo("") == 0)
            {
                MessageBox.Show("请选择DLL文件!","ERROR:",MessageBoxButtons.OK);
                return;
            }

            //判断注入方式
            var Way= INJECT_WAY_COMBOX.Text;
            if(Way.CompareTo("线程注入") == 0)
            {
                try
                {
                   
                    int result = MyApi.ThreadInject(Inject.ProcessId, Path, Path.Length * 2);
                    if(result == 0)
                    {
                        UpdateToLog("线程注入成功!!!!");
                    }
                    else
                    {
                        UpdateToLog("线程注入失败!!!!");
                    }
                  
                }
                catch
                {
                    UpdateToLog("WayX64.DLL无法加载成功!!!");
                    return;
                }
                
            }  
            else if(Way.CompareTo("内存注入") == 0)
            {
                try
                {
                    int result = MyApi.MemoryInject(Inject.ProcessId, Path, Path.Length * 2);
                    if (result == 0)
                    {
                        UpdateToLog("内存注入成功!!!!");
                    }
                    else
                    {
                        UpdateToLog("内存注入失败!!!!");
                    }
                }
                catch
                {
                    UpdateToLog("WayX64.DLL无法加载成功!!!");
                }
                
               
            }

        }

        private void UpdateToLog(string text)
        {
            string OldTime = "";
            //OldTime = DateTime.Now.ToLongDateString();
            //OldTime += " ";
            OldTime += DateTime.Now.ToLongTimeString();
            OldTime += "\r\n>>[";
            OldTime += text + "]";
            OldTime += "\r\n";
           
            LOG_TEXT_BOX.Text += OldTime;
        }

        private void INJECT_WAY_COMBOX_TextUpdate(object sender, EventArgs e)
        {
            UpdateToLog("选择:"+INJECT_WAY_COMBOX.Text);
        }

        private void INJECT_WAY_COMBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateToLog("选择:" + INJECT_WAY_COMBOX.Text);
        }
    }
}
