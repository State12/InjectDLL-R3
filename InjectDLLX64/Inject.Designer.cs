
namespace InjectDLLX64
{
    partial class Inject
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SELECT_GROUP_BOX = new System.Windows.Forms.GroupBox();
            this.SELECT_PROCESS_BUTTON = new System.Windows.Forms.Button();
            this.PROCESS_COMBO_BOX = new System.Windows.Forms.ComboBox();
            this.SELECT_PROCESS_LABEL = new System.Windows.Forms.Label();
            this.LOG_TEXT_BOX = new System.Windows.Forms.TextBox();
            this.LOG_GROUP_BOX = new System.Windows.Forms.GroupBox();
            this.SELECT_DLL_FILE_GROUP = new System.Windows.Forms.GroupBox();
            this.SELECT_DLL_PATH_LABEL = new System.Windows.Forms.Label();
            this.DLL_PATH_TEXT_BOX = new System.Windows.Forms.TextBox();
            this.SELECT_DLL_BUTTON = new System.Windows.Forms.Button();
            this.SELECT_FILE_DIALOG = new System.Windows.Forms.OpenFileDialog();
            this.SELECT_INJECT_WAY_LABEL = new System.Windows.Forms.Label();
            this.INJECT_WAY_COMBOX = new System.Windows.Forms.ComboBox();
            this.INJECT_OK_BUTTON = new System.Windows.Forms.Button();
            this.SELECT_GROUP_BOX.SuspendLayout();
            this.LOG_GROUP_BOX.SuspendLayout();
            this.SELECT_DLL_FILE_GROUP.SuspendLayout();
            this.SuspendLayout();
            // 
            // SELECT_GROUP_BOX
            // 
            this.SELECT_GROUP_BOX.Controls.Add(this.SELECT_PROCESS_BUTTON);
            this.SELECT_GROUP_BOX.Controls.Add(this.PROCESS_COMBO_BOX);
            this.SELECT_GROUP_BOX.Controls.Add(this.SELECT_PROCESS_LABEL);
            this.SELECT_GROUP_BOX.Location = new System.Drawing.Point(12, 12);
            this.SELECT_GROUP_BOX.Name = "SELECT_GROUP_BOX";
            this.SELECT_GROUP_BOX.Size = new System.Drawing.Size(387, 60);
            this.SELECT_GROUP_BOX.TabIndex = 0;
            this.SELECT_GROUP_BOX.TabStop = false;
            this.SELECT_GROUP_BOX.Text = "进程";
            // 
            // SELECT_PROCESS_BUTTON
            // 
            this.SELECT_PROCESS_BUTTON.Location = new System.Drawing.Point(284, 17);
            this.SELECT_PROCESS_BUTTON.Name = "SELECT_PROCESS_BUTTON";
            this.SELECT_PROCESS_BUTTON.Size = new System.Drawing.Size(97, 33);
            this.SELECT_PROCESS_BUTTON.TabIndex = 2;
            this.SELECT_PROCESS_BUTTON.Text = "选择进程";
            this.SELECT_PROCESS_BUTTON.UseVisualStyleBackColor = true;
            this.SELECT_PROCESS_BUTTON.Click += new System.EventHandler(this.SELECT_PROCESS_BUTTON_Click);
            // 
            // PROCESS_COMBO_BOX
            // 
            this.PROCESS_COMBO_BOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PROCESS_COMBO_BOX.FormattingEnabled = true;
            this.PROCESS_COMBO_BOX.Location = new System.Drawing.Point(115, 23);
            this.PROCESS_COMBO_BOX.Name = "PROCESS_COMBO_BOX";
            this.PROCESS_COMBO_BOX.Size = new System.Drawing.Size(146, 20);
            this.PROCESS_COMBO_BOX.TabIndex = 1;
            this.PROCESS_COMBO_BOX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PROCESS_COMBO_BOX_MouseClick);
            // 
            // SELECT_PROCESS_LABEL
            // 
            this.SELECT_PROCESS_LABEL.AutoSize = true;
            this.SELECT_PROCESS_LABEL.Location = new System.Drawing.Point(9, 27);
            this.SELECT_PROCESS_LABEL.Name = "SELECT_PROCESS_LABEL";
            this.SELECT_PROCESS_LABEL.Size = new System.Drawing.Size(71, 12);
            this.SELECT_PROCESS_LABEL.TabIndex = 0;
            this.SELECT_PROCESS_LABEL.Text = "请选择进程:";
            // 
            // LOG_TEXT_BOX
            // 
            this.LOG_TEXT_BOX.Location = new System.Drawing.Point(10, 19);
            this.LOG_TEXT_BOX.Multiline = true;
            this.LOG_TEXT_BOX.Name = "LOG_TEXT_BOX";
            this.LOG_TEXT_BOX.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LOG_TEXT_BOX.Size = new System.Drawing.Size(371, 134);
            this.LOG_TEXT_BOX.TabIndex = 1;
            // 
            // LOG_GROUP_BOX
            // 
            this.LOG_GROUP_BOX.Controls.Add(this.LOG_TEXT_BOX);
            this.LOG_GROUP_BOX.Location = new System.Drawing.Point(12, 249);
            this.LOG_GROUP_BOX.Name = "LOG_GROUP_BOX";
            this.LOG_GROUP_BOX.Size = new System.Drawing.Size(387, 160);
            this.LOG_GROUP_BOX.TabIndex = 2;
            this.LOG_GROUP_BOX.TabStop = false;
            this.LOG_GROUP_BOX.Text = "日志区";
            // 
            // SELECT_DLL_FILE_GROUP
            // 
            this.SELECT_DLL_FILE_GROUP.Controls.Add(this.INJECT_OK_BUTTON);
            this.SELECT_DLL_FILE_GROUP.Controls.Add(this.INJECT_WAY_COMBOX);
            this.SELECT_DLL_FILE_GROUP.Controls.Add(this.SELECT_INJECT_WAY_LABEL);
            this.SELECT_DLL_FILE_GROUP.Controls.Add(this.SELECT_DLL_BUTTON);
            this.SELECT_DLL_FILE_GROUP.Controls.Add(this.DLL_PATH_TEXT_BOX);
            this.SELECT_DLL_FILE_GROUP.Controls.Add(this.SELECT_DLL_PATH_LABEL);
            this.SELECT_DLL_FILE_GROUP.Location = new System.Drawing.Point(12, 85);
            this.SELECT_DLL_FILE_GROUP.Name = "SELECT_DLL_FILE_GROUP";
            this.SELECT_DLL_FILE_GROUP.Size = new System.Drawing.Size(387, 154);
            this.SELECT_DLL_FILE_GROUP.TabIndex = 3;
            this.SELECT_DLL_FILE_GROUP.TabStop = false;
            this.SELECT_DLL_FILE_GROUP.Text = "DLL区";
            // 
            // SELECT_DLL_PATH_LABEL
            // 
            this.SELECT_DLL_PATH_LABEL.AutoSize = true;
            this.SELECT_DLL_PATH_LABEL.Location = new System.Drawing.Point(9, 26);
            this.SELECT_DLL_PATH_LABEL.Name = "SELECT_DLL_PATH_LABEL";
            this.SELECT_DLL_PATH_LABEL.Size = new System.Drawing.Size(95, 12);
            this.SELECT_DLL_PATH_LABEL.TabIndex = 4;
            this.SELECT_DLL_PATH_LABEL.Text = "请选择DLL目录：";
            // 
            // DLL_PATH_TEXT_BOX
            // 
            this.DLL_PATH_TEXT_BOX.Location = new System.Drawing.Point(11, 50);
            this.DLL_PATH_TEXT_BOX.Multiline = true;
            this.DLL_PATH_TEXT_BOX.Name = "DLL_PATH_TEXT_BOX";
            this.DLL_PATH_TEXT_BOX.Size = new System.Drawing.Size(250, 26);
            this.DLL_PATH_TEXT_BOX.TabIndex = 5;
            // 
            // SELECT_DLL_BUTTON
            // 
            this.SELECT_DLL_BUTTON.Location = new System.Drawing.Point(275, 42);
            this.SELECT_DLL_BUTTON.Name = "SELECT_DLL_BUTTON";
            this.SELECT_DLL_BUTTON.Size = new System.Drawing.Size(102, 36);
            this.SELECT_DLL_BUTTON.TabIndex = 6;
            this.SELECT_DLL_BUTTON.Text = "选择文件";
            this.SELECT_DLL_BUTTON.UseVisualStyleBackColor = true;
            this.SELECT_DLL_BUTTON.Click += new System.EventHandler(this.SELECT_DLL_BUTTON_Click);
            // 
            // SELECT_INJECT_WAY_LABEL
            // 
            this.SELECT_INJECT_WAY_LABEL.AutoSize = true;
            this.SELECT_INJECT_WAY_LABEL.Location = new System.Drawing.Point(9, 90);
            this.SELECT_INJECT_WAY_LABEL.Name = "SELECT_INJECT_WAY_LABEL";
            this.SELECT_INJECT_WAY_LABEL.Size = new System.Drawing.Size(107, 12);
            this.SELECT_INJECT_WAY_LABEL.TabIndex = 7;
            this.SELECT_INJECT_WAY_LABEL.Text = "请选择注入的方式:";
            // 
            // INJECT_WAY_COMBOX
            // 
            this.INJECT_WAY_COMBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.INJECT_WAY_COMBOX.FormattingEnabled = true;
            this.INJECT_WAY_COMBOX.Location = new System.Drawing.Point(11, 118);
            this.INJECT_WAY_COMBOX.Name = "INJECT_WAY_COMBOX";
            this.INJECT_WAY_COMBOX.Size = new System.Drawing.Size(121, 20);
            this.INJECT_WAY_COMBOX.TabIndex = 8;
            this.INJECT_WAY_COMBOX.SelectedIndexChanged += new System.EventHandler(this.INJECT_WAY_COMBOX_SelectedIndexChanged);
            this.INJECT_WAY_COMBOX.TextUpdate += new System.EventHandler(this.INJECT_WAY_COMBOX_TextUpdate);
            // 
            // INJECT_OK_BUTTON
            // 
            this.INJECT_OK_BUTTON.Location = new System.Drawing.Point(172, 111);
            this.INJECT_OK_BUTTON.Name = "INJECT_OK_BUTTON";
            this.INJECT_OK_BUTTON.Size = new System.Drawing.Size(89, 33);
            this.INJECT_OK_BUTTON.TabIndex = 9;
            this.INJECT_OK_BUTTON.Text = "注入";
            this.INJECT_OK_BUTTON.UseVisualStyleBackColor = true;
            this.INJECT_OK_BUTTON.Click += new System.EventHandler(this.INJECT_OK_BUTTON_Click);
            // 
            // Inject
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 409);
            this.Controls.Add(this.SELECT_DLL_FILE_GROUP);
            this.Controls.Add(this.LOG_GROUP_BOX);
            this.Controls.Add(this.SELECT_GROUP_BOX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Inject";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Inject_DragEnter);
            this.SELECT_GROUP_BOX.ResumeLayout(false);
            this.SELECT_GROUP_BOX.PerformLayout();
            this.LOG_GROUP_BOX.ResumeLayout(false);
            this.LOG_GROUP_BOX.PerformLayout();
            this.SELECT_DLL_FILE_GROUP.ResumeLayout(false);
            this.SELECT_DLL_FILE_GROUP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SELECT_GROUP_BOX;
        private System.Windows.Forms.Label SELECT_PROCESS_LABEL;
        private System.Windows.Forms.Button SELECT_PROCESS_BUTTON;
        private System.Windows.Forms.ComboBox PROCESS_COMBO_BOX;
        private System.Windows.Forms.TextBox LOG_TEXT_BOX;
        private System.Windows.Forms.GroupBox LOG_GROUP_BOX;
        private System.Windows.Forms.GroupBox SELECT_DLL_FILE_GROUP;
        private System.Windows.Forms.Label SELECT_DLL_PATH_LABEL;
        private System.Windows.Forms.Button SELECT_DLL_BUTTON;
        private System.Windows.Forms.TextBox DLL_PATH_TEXT_BOX;
        private System.Windows.Forms.OpenFileDialog SELECT_FILE_DIALOG;
        private System.Windows.Forms.Label SELECT_INJECT_WAY_LABEL;
        private System.Windows.Forms.Button INJECT_OK_BUTTON;
        private System.Windows.Forms.ComboBox INJECT_WAY_COMBOX;
    }
}

