namespace 扫地机
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_test = new System.Windows.Forms.Button();
            this.btn_version = new System.Windows.Forms.Button();
            this.btn_downsensor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.btn_frontsensor = new System.Windows.Forms.Button();
            this.btn_gyro = new System.Windows.Forms.Button();
            this.btn_dust_etc = new System.Windows.Forms.Button();
            this.btn_startbrush_weak = new System.Windows.Forms.Button();
            this.btn_stopbrush = new System.Windows.Forms.Button();
            this.btn_startwheel_left = new System.Windows.Forms.Button();
            this.btn_startwheel_right = new System.Windows.Forms.Button();
            this.btn_stopwheel_left = new System.Windows.Forms.Button();
            this.btn_stopwheel_right = new System.Windows.Forms.Button();
            this.btn_startbrush_strong = new System.Windows.Forms.Button();
            this.btn_startfan = new System.Windows.Forms.Button();
            this.btn_stopfan = new System.Windows.Forms.Button();
            this.btn_startmainbrush = new System.Windows.Forms.Button();
            this.btn_stopmainbrush = new System.Windows.Forms.Button();
            this.btn_wheelspeed_left = new System.Windows.Forms.Button();
            this.btn_wheelcurrent_left = new System.Windows.Forms.Button();
            this.btn_wheelspeed_right = new System.Windows.Forms.Button();
            this.btn_wheelcurrent_right = new System.Windows.Forms.Button();
            this.groupBox_control = new System.Windows.Forms.GroupBox();
            this.btn_outtest = new System.Windows.Forms.Button();
            this.groupBox_state = new System.Windows.Forms.GroupBox();
            this.btn_batterypara = new System.Windows.Forms.Button();
            this.btn_fanspeed = new System.Windows.Forms.Button();
            this.btn_mainbrushcurrent = new System.Windows.Forms.Button();
            this.btn_brushcurrent = new System.Windows.Forms.Button();
            this.tbx_detail = new System.Windows.Forms.TextBox();
            this.groupBox_details = new System.Windows.Forms.GroupBox();
            this.btn_opencomm = new System.Windows.Forms.Button();
            this.btn_scancomm = new System.Windows.Forms.Button();
            this.btn_cleandetail = new System.Windows.Forms.Button();
            this.rdb_showstring = new System.Windows.Forms.RadioButton();
            this.rdb_shownumber = new System.Windows.Forms.RadioButton();
            this.btn_defaultcommand = new System.Windows.Forms.Button();
            this.btn_customcommand = new System.Windows.Forms.Button();
            this.groupBox_control.SuspendLayout();
            this.groupBox_state.SuspendLayout();
            this.groupBox_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(20, 39);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(128, 34);
            this.btn_test.TabIndex = 1;
            this.btn_test.Text = "进入测试模式";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.Btn_test_Click);
            // 
            // btn_version
            // 
            this.btn_version.Location = new System.Drawing.Point(20, 79);
            this.btn_version.Name = "btn_version";
            this.btn_version.Size = new System.Drawing.Size(128, 34);
            this.btn_version.TabIndex = 2;
            this.btn_version.Text = "测试程序版本";
            this.btn_version.UseVisualStyleBackColor = true;
            this.btn_version.Click += new System.EventHandler(this.Btn_version_Click);
            // 
            // btn_downsensor
            // 
            this.btn_downsensor.Location = new System.Drawing.Point(20, 119);
            this.btn_downsensor.Name = "btn_downsensor";
            this.btn_downsensor.Size = new System.Drawing.Size(128, 34);
            this.btn_downsensor.TabIndex = 5;
            this.btn_downsensor.Text = "下视传感器值";
            this.btn_downsensor.UseVisualStyleBackColor = true;
            this.btn_downsensor.Click += new System.EventHandler(this.Btn_downsensor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "串口号";
            // 
            // cbCom
            // 
            this.cbCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(383, 104);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(128, 26);
            this.cbCom.TabIndex = 13;
            // 
            // btn_frontsensor
            // 
            this.btn_frontsensor.Location = new System.Drawing.Point(20, 159);
            this.btn_frontsensor.Name = "btn_frontsensor";
            this.btn_frontsensor.Size = new System.Drawing.Size(128, 34);
            this.btn_frontsensor.TabIndex = 16;
            this.btn_frontsensor.Text = "前视传感器值";
            this.btn_frontsensor.UseVisualStyleBackColor = true;
            this.btn_frontsensor.Click += new System.EventHandler(this.Btn_frontsensor_Click);
            // 
            // btn_gyro
            // 
            this.btn_gyro.Location = new System.Drawing.Point(20, 199);
            this.btn_gyro.Name = "btn_gyro";
            this.btn_gyro.Size = new System.Drawing.Size(128, 34);
            this.btn_gyro.TabIndex = 17;
            this.btn_gyro.Text = "陀螺仪转角值";
            this.btn_gyro.UseVisualStyleBackColor = true;
            this.btn_gyro.Click += new System.EventHandler(this.Btn_gyro_Click);
            // 
            // btn_dust_etc
            // 
            this.btn_dust_etc.Location = new System.Drawing.Point(20, 239);
            this.btn_dust_etc.Name = "btn_dust_etc";
            this.btn_dust_etc.Size = new System.Drawing.Size(128, 34);
            this.btn_dust_etc.TabIndex = 18;
            this.btn_dust_etc.Text = "尘盒碰撞跌落";
            this.btn_dust_etc.UseVisualStyleBackColor = true;
            this.btn_dust_etc.Click += new System.EventHandler(this.Btn_dust_etc_Click);
            // 
            // btn_startbrush_weak
            // 
            this.btn_startbrush_weak.Location = new System.Drawing.Point(20, 39);
            this.btn_startbrush_weak.Name = "btn_startbrush_weak";
            this.btn_startbrush_weak.Size = new System.Drawing.Size(128, 34);
            this.btn_startbrush_weak.TabIndex = 19;
            this.btn_startbrush_weak.Text = "启动边刷-弱";
            this.btn_startbrush_weak.UseVisualStyleBackColor = true;
            this.btn_startbrush_weak.Click += new System.EventHandler(this.Btn_startbrush_weak_Click);
            // 
            // btn_stopbrush
            // 
            this.btn_stopbrush.Location = new System.Drawing.Point(20, 119);
            this.btn_stopbrush.Name = "btn_stopbrush";
            this.btn_stopbrush.Size = new System.Drawing.Size(128, 34);
            this.btn_stopbrush.TabIndex = 20;
            this.btn_stopbrush.Text = "停止边刷";
            this.btn_stopbrush.UseVisualStyleBackColor = true;
            this.btn_stopbrush.Click += new System.EventHandler(this.Btn_stopbrush_Click);
            // 
            // btn_startwheel_left
            // 
            this.btn_startwheel_left.Location = new System.Drawing.Point(20, 159);
            this.btn_startwheel_left.Name = "btn_startwheel_left";
            this.btn_startwheel_left.Size = new System.Drawing.Size(128, 34);
            this.btn_startwheel_left.TabIndex = 21;
            this.btn_startwheel_left.Text = "启动左边轮";
            this.btn_startwheel_left.UseVisualStyleBackColor = true;
            this.btn_startwheel_left.Click += new System.EventHandler(this.Btn_startwheel_left_Click);
            // 
            // btn_startwheel_right
            // 
            this.btn_startwheel_right.Location = new System.Drawing.Point(20, 199);
            this.btn_startwheel_right.Name = "btn_startwheel_right";
            this.btn_startwheel_right.Size = new System.Drawing.Size(128, 34);
            this.btn_startwheel_right.TabIndex = 22;
            this.btn_startwheel_right.Text = "启动右边轮";
            this.btn_startwheel_right.UseVisualStyleBackColor = true;
            this.btn_startwheel_right.Click += new System.EventHandler(this.Btn_startwheel_right_Click);
            // 
            // btn_stopwheel_left
            // 
            this.btn_stopwheel_left.Location = new System.Drawing.Point(20, 239);
            this.btn_stopwheel_left.Name = "btn_stopwheel_left";
            this.btn_stopwheel_left.Size = new System.Drawing.Size(128, 34);
            this.btn_stopwheel_left.TabIndex = 23;
            this.btn_stopwheel_left.Text = "停止左边轮";
            this.btn_stopwheel_left.UseVisualStyleBackColor = true;
            this.btn_stopwheel_left.Click += new System.EventHandler(this.Btn_stopwheel_left_Click);
            // 
            // btn_stopwheel_right
            // 
            this.btn_stopwheel_right.Location = new System.Drawing.Point(20, 279);
            this.btn_stopwheel_right.Name = "btn_stopwheel_right";
            this.btn_stopwheel_right.Size = new System.Drawing.Size(128, 34);
            this.btn_stopwheel_right.TabIndex = 24;
            this.btn_stopwheel_right.Text = "停止右边轮";
            this.btn_stopwheel_right.UseVisualStyleBackColor = true;
            this.btn_stopwheel_right.Click += new System.EventHandler(this.Btn_stopwheel_right_Click);
            // 
            // btn_startbrush_strong
            // 
            this.btn_startbrush_strong.Location = new System.Drawing.Point(20, 79);
            this.btn_startbrush_strong.Name = "btn_startbrush_strong";
            this.btn_startbrush_strong.Size = new System.Drawing.Size(128, 34);
            this.btn_startbrush_strong.TabIndex = 25;
            this.btn_startbrush_strong.Text = "启动边刷-强";
            this.btn_startbrush_strong.UseVisualStyleBackColor = true;
            this.btn_startbrush_strong.Click += new System.EventHandler(this.Btn_startbrush_strong_Click);
            // 
            // btn_startfan
            // 
            this.btn_startfan.Location = new System.Drawing.Point(20, 319);
            this.btn_startfan.Name = "btn_startfan";
            this.btn_startfan.Size = new System.Drawing.Size(128, 34);
            this.btn_startfan.TabIndex = 26;
            this.btn_startfan.Text = "启动风机";
            this.btn_startfan.UseVisualStyleBackColor = true;
            this.btn_startfan.Click += new System.EventHandler(this.Btn_startfan_Click);
            // 
            // btn_stopfan
            // 
            this.btn_stopfan.Location = new System.Drawing.Point(20, 359);
            this.btn_stopfan.Name = "btn_stopfan";
            this.btn_stopfan.Size = new System.Drawing.Size(128, 34);
            this.btn_stopfan.TabIndex = 27;
            this.btn_stopfan.Text = "停止风机";
            this.btn_stopfan.UseVisualStyleBackColor = true;
            this.btn_stopfan.Click += new System.EventHandler(this.Btn_stopfan_Click);
            // 
            // btn_startmainbrush
            // 
            this.btn_startmainbrush.Location = new System.Drawing.Point(20, 399);
            this.btn_startmainbrush.Name = "btn_startmainbrush";
            this.btn_startmainbrush.Size = new System.Drawing.Size(128, 34);
            this.btn_startmainbrush.TabIndex = 28;
            this.btn_startmainbrush.Text = "启动滚刷";
            this.btn_startmainbrush.UseVisualStyleBackColor = true;
            this.btn_startmainbrush.Click += new System.EventHandler(this.Btn_startmainbrush_Click);
            // 
            // btn_stopmainbrush
            // 
            this.btn_stopmainbrush.Location = new System.Drawing.Point(20, 439);
            this.btn_stopmainbrush.Name = "btn_stopmainbrush";
            this.btn_stopmainbrush.Size = new System.Drawing.Size(128, 34);
            this.btn_stopmainbrush.TabIndex = 29;
            this.btn_stopmainbrush.Text = "停止滚刷";
            this.btn_stopmainbrush.UseVisualStyleBackColor = true;
            this.btn_stopmainbrush.Click += new System.EventHandler(this.Btn_stopmainbrush_Click);
            // 
            // btn_wheelspeed_left
            // 
            this.btn_wheelspeed_left.Location = new System.Drawing.Point(20, 279);
            this.btn_wheelspeed_left.Name = "btn_wheelspeed_left";
            this.btn_wheelspeed_left.Size = new System.Drawing.Size(128, 34);
            this.btn_wheelspeed_left.TabIndex = 30;
            this.btn_wheelspeed_left.Text = "左边轮转速";
            this.btn_wheelspeed_left.UseVisualStyleBackColor = true;
            this.btn_wheelspeed_left.Click += new System.EventHandler(this.Btn_wheelspeed_left_Click);
            // 
            // btn_wheelcurrent_left
            // 
            this.btn_wheelcurrent_left.Location = new System.Drawing.Point(20, 319);
            this.btn_wheelcurrent_left.Name = "btn_wheelcurrent_left";
            this.btn_wheelcurrent_left.Size = new System.Drawing.Size(128, 34);
            this.btn_wheelcurrent_left.TabIndex = 31;
            this.btn_wheelcurrent_left.Text = "左边轮电流";
            this.btn_wheelcurrent_left.UseVisualStyleBackColor = true;
            this.btn_wheelcurrent_left.Click += new System.EventHandler(this.Btn_wheelcurrent_left_Click);
            // 
            // btn_wheelspeed_right
            // 
            this.btn_wheelspeed_right.Location = new System.Drawing.Point(20, 359);
            this.btn_wheelspeed_right.Name = "btn_wheelspeed_right";
            this.btn_wheelspeed_right.Size = new System.Drawing.Size(128, 34);
            this.btn_wheelspeed_right.TabIndex = 32;
            this.btn_wheelspeed_right.Text = "右边轮转速";
            this.btn_wheelspeed_right.UseVisualStyleBackColor = true;
            this.btn_wheelspeed_right.Click += new System.EventHandler(this.Btn_wheelspeed_right_Click);
            // 
            // btn_wheelcurrent_right
            // 
            this.btn_wheelcurrent_right.Location = new System.Drawing.Point(20, 399);
            this.btn_wheelcurrent_right.Name = "btn_wheelcurrent_right";
            this.btn_wheelcurrent_right.Size = new System.Drawing.Size(128, 34);
            this.btn_wheelcurrent_right.TabIndex = 33;
            this.btn_wheelcurrent_right.Text = "右边轮电流";
            this.btn_wheelcurrent_right.UseVisualStyleBackColor = true;
            this.btn_wheelcurrent_right.Click += new System.EventHandler(this.Btn_wheelcurrent_right_Click);
            // 
            // groupBox_control
            // 
            this.groupBox_control.Controls.Add(this.btn_outtest);
            this.groupBox_control.Controls.Add(this.btn_startbrush_weak);
            this.groupBox_control.Controls.Add(this.btn_startbrush_strong);
            this.groupBox_control.Controls.Add(this.btn_stopbrush);
            this.groupBox_control.Controls.Add(this.btn_startwheel_left);
            this.groupBox_control.Controls.Add(this.btn_startwheel_right);
            this.groupBox_control.Controls.Add(this.btn_stopmainbrush);
            this.groupBox_control.Controls.Add(this.btn_stopwheel_left);
            this.groupBox_control.Controls.Add(this.btn_startmainbrush);
            this.groupBox_control.Controls.Add(this.btn_stopwheel_right);
            this.groupBox_control.Controls.Add(this.btn_stopfan);
            this.groupBox_control.Controls.Add(this.btn_startfan);
            this.groupBox_control.Location = new System.Drawing.Point(201, 28);
            this.groupBox_control.Name = "groupBox_control";
            this.groupBox_control.Size = new System.Drawing.Size(173, 619);
            this.groupBox_control.TabIndex = 34;
            this.groupBox_control.TabStop = false;
            this.groupBox_control.Text = "控制指令";
            // 
            // btn_outtest
            // 
            this.btn_outtest.Location = new System.Drawing.Point(20, 479);
            this.btn_outtest.Name = "btn_outtest";
            this.btn_outtest.Size = new System.Drawing.Size(128, 34);
            this.btn_outtest.TabIndex = 30;
            this.btn_outtest.Text = "退出测试模式";
            this.btn_outtest.UseVisualStyleBackColor = true;
            this.btn_outtest.Click += new System.EventHandler(this.Btn_outtest_Click);
            // 
            // groupBox_state
            // 
            this.groupBox_state.Controls.Add(this.btn_batterypara);
            this.groupBox_state.Controls.Add(this.btn_fanspeed);
            this.groupBox_state.Controls.Add(this.btn_mainbrushcurrent);
            this.groupBox_state.Controls.Add(this.btn_brushcurrent);
            this.groupBox_state.Controls.Add(this.btn_version);
            this.groupBox_state.Controls.Add(this.btn_wheelcurrent_right);
            this.groupBox_state.Controls.Add(this.btn_downsensor);
            this.groupBox_state.Controls.Add(this.btn_wheelspeed_right);
            this.groupBox_state.Controls.Add(this.btn_frontsensor);
            this.groupBox_state.Controls.Add(this.btn_wheelcurrent_left);
            this.groupBox_state.Controls.Add(this.btn_test);
            this.groupBox_state.Controls.Add(this.btn_gyro);
            this.groupBox_state.Controls.Add(this.btn_wheelspeed_left);
            this.groupBox_state.Controls.Add(this.btn_dust_etc);
            this.groupBox_state.Location = new System.Drawing.Point(22, 28);
            this.groupBox_state.Name = "groupBox_state";
            this.groupBox_state.Size = new System.Drawing.Size(173, 619);
            this.groupBox_state.TabIndex = 35;
            this.groupBox_state.TabStop = false;
            this.groupBox_state.Text = "状态指令";
            // 
            // btn_batterypara
            // 
            this.btn_batterypara.Location = new System.Drawing.Point(20, 559);
            this.btn_batterypara.Name = "btn_batterypara";
            this.btn_batterypara.Size = new System.Drawing.Size(128, 34);
            this.btn_batterypara.TabIndex = 37;
            this.btn_batterypara.Text = "电池参数";
            this.btn_batterypara.UseVisualStyleBackColor = true;
            this.btn_batterypara.Click += new System.EventHandler(this.Btn_batterypara_Click);
            // 
            // btn_fanspeed
            // 
            this.btn_fanspeed.Location = new System.Drawing.Point(20, 519);
            this.btn_fanspeed.Name = "btn_fanspeed";
            this.btn_fanspeed.Size = new System.Drawing.Size(128, 34);
            this.btn_fanspeed.TabIndex = 36;
            this.btn_fanspeed.Text = "风机转速";
            this.btn_fanspeed.UseVisualStyleBackColor = true;
            this.btn_fanspeed.Click += new System.EventHandler(this.Btn_fanspeed_Click);
            // 
            // btn_mainbrushcurrent
            // 
            this.btn_mainbrushcurrent.Location = new System.Drawing.Point(20, 479);
            this.btn_mainbrushcurrent.Name = "btn_mainbrushcurrent";
            this.btn_mainbrushcurrent.Size = new System.Drawing.Size(128, 34);
            this.btn_mainbrushcurrent.TabIndex = 35;
            this.btn_mainbrushcurrent.Text = "滚刷电流";
            this.btn_mainbrushcurrent.UseVisualStyleBackColor = true;
            this.btn_mainbrushcurrent.Click += new System.EventHandler(this.Btn_mainbrushcurrent_Click);
            // 
            // btn_brushcurrent
            // 
            this.btn_brushcurrent.Location = new System.Drawing.Point(20, 439);
            this.btn_brushcurrent.Name = "btn_brushcurrent";
            this.btn_brushcurrent.Size = new System.Drawing.Size(128, 34);
            this.btn_brushcurrent.TabIndex = 34;
            this.btn_brushcurrent.Text = "边刷电流";
            this.btn_brushcurrent.UseVisualStyleBackColor = true;
            this.btn_brushcurrent.Click += new System.EventHandler(this.Btn_brushcurrent_Click);
            // 
            // tbx_detail
            // 
            this.tbx_detail.Location = new System.Drawing.Point(0, 24);
            this.tbx_detail.Multiline = true;
            this.tbx_detail.Name = "tbx_detail";
            this.tbx_detail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_detail.Size = new System.Drawing.Size(446, 571);
            this.tbx_detail.TabIndex = 36;
            // 
            // groupBox_details
            // 
            this.groupBox_details.Controls.Add(this.tbx_detail);
            this.groupBox_details.Location = new System.Drawing.Point(539, 52);
            this.groupBox_details.Name = "groupBox_details";
            this.groupBox_details.Size = new System.Drawing.Size(446, 595);
            this.groupBox_details.TabIndex = 37;
            this.groupBox_details.TabStop = false;
            this.groupBox_details.Text = "详细信息";
            // 
            // btn_opencomm
            // 
            this.btn_opencomm.Location = new System.Drawing.Point(383, 200);
            this.btn_opencomm.Name = "btn_opencomm";
            this.btn_opencomm.Size = new System.Drawing.Size(128, 34);
            this.btn_opencomm.TabIndex = 30;
            this.btn_opencomm.Text = "打开串口";
            this.btn_opencomm.UseVisualStyleBackColor = true;
            this.btn_opencomm.Click += new System.EventHandler(this.Btn_opencomm_Click);
            // 
            // btn_scancomm
            // 
            this.btn_scancomm.Location = new System.Drawing.Point(383, 147);
            this.btn_scancomm.Name = "btn_scancomm";
            this.btn_scancomm.Size = new System.Drawing.Size(128, 34);
            this.btn_scancomm.TabIndex = 38;
            this.btn_scancomm.Text = "扫描串口";
            this.btn_scancomm.UseVisualStyleBackColor = true;
            this.btn_scancomm.Click += new System.EventHandler(this.Btn_scancomm_Click);
            // 
            // btn_cleandetail
            // 
            this.btn_cleandetail.Location = new System.Drawing.Point(383, 251);
            this.btn_cleandetail.Name = "btn_cleandetail";
            this.btn_cleandetail.Size = new System.Drawing.Size(128, 34);
            this.btn_cleandetail.TabIndex = 39;
            this.btn_cleandetail.Text = "清除窗口";
            this.btn_cleandetail.UseVisualStyleBackColor = true;
            this.btn_cleandetail.Click += new System.EventHandler(this.Btn_cleandetail_Click);
            // 
            // rdb_showstring
            // 
            this.rdb_showstring.AutoSize = true;
            this.rdb_showstring.Location = new System.Drawing.Point(383, 313);
            this.rdb_showstring.Name = "rdb_showstring";
            this.rdb_showstring.Size = new System.Drawing.Size(105, 22);
            this.rdb_showstring.TabIndex = 41;
            this.rdb_showstring.TabStop = true;
            this.rdb_showstring.Text = "字符显示";
            this.rdb_showstring.UseVisualStyleBackColor = true;
            this.rdb_showstring.CheckedChanged += new System.EventHandler(this.Rdb_showstring_CheckedChanged);
            // 
            // rdb_shownumber
            // 
            this.rdb_shownumber.AutoSize = true;
            this.rdb_shownumber.Location = new System.Drawing.Point(383, 359);
            this.rdb_shownumber.Name = "rdb_shownumber";
            this.rdb_shownumber.Size = new System.Drawing.Size(105, 22);
            this.rdb_shownumber.TabIndex = 42;
            this.rdb_shownumber.TabStop = true;
            this.rdb_shownumber.Text = "数值显示";
            this.rdb_shownumber.UseVisualStyleBackColor = true;
            this.rdb_shownumber.CheckedChanged += new System.EventHandler(this.Rdb_shownumber_CheckedChanged);
            // 
            // btn_defaultcommand
            // 
            this.btn_defaultcommand.Location = new System.Drawing.Point(383, 547);
            this.btn_defaultcommand.Name = "btn_defaultcommand";
            this.btn_defaultcommand.Size = new System.Drawing.Size(128, 34);
            this.btn_defaultcommand.TabIndex = 43;
            this.btn_defaultcommand.Text = "默认";
            this.btn_defaultcommand.UseVisualStyleBackColor = true;
            this.btn_defaultcommand.Click += new System.EventHandler(this.Btn_defaultcommand_Click);
            // 
            // btn_customcommand
            // 
            this.btn_customcommand.Location = new System.Drawing.Point(383, 613);
            this.btn_customcommand.Name = "btn_customcommand";
            this.btn_customcommand.Size = new System.Drawing.Size(128, 34);
            this.btn_customcommand.TabIndex = 44;
            this.btn_customcommand.Text = "自定义";
            this.btn_customcommand.UseVisualStyleBackColor = true;
            this.btn_customcommand.Click += new System.EventHandler(this.Btn_customcommand_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 705);
            this.Controls.Add(this.btn_customcommand);
            this.Controls.Add(this.btn_defaultcommand);
            this.Controls.Add(this.rdb_shownumber);
            this.Controls.Add(this.rdb_showstring);
            this.Controls.Add(this.btn_cleandetail);
            this.Controls.Add(this.btn_scancomm);
            this.Controls.Add(this.btn_opencomm);
            this.Controls.Add(this.groupBox_details);
            this.Controls.Add(this.groupBox_state);
            this.Controls.Add(this.groupBox_control);
            this.Controls.Add(this.cbCom);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "扫地机控制";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_control.ResumeLayout(false);
            this.groupBox_state.ResumeLayout(false);
            this.groupBox_details.ResumeLayout(false);
            this.groupBox_details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button btn_version;
        private System.Windows.Forms.Button btn_downsensor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCom;
        private System.Windows.Forms.Button btn_frontsensor;
        private System.Windows.Forms.Button btn_gyro;
        private System.Windows.Forms.Button btn_dust_etc;
        private System.Windows.Forms.Button btn_startbrush_weak;
        private System.Windows.Forms.Button btn_stopbrush;
        private System.Windows.Forms.Button btn_startwheel_left;
        private System.Windows.Forms.Button btn_startwheel_right;
        private System.Windows.Forms.Button btn_stopwheel_left;
        private System.Windows.Forms.Button btn_stopwheel_right;
        private System.Windows.Forms.Button btn_startbrush_strong;
        private System.Windows.Forms.Button btn_startfan;
        private System.Windows.Forms.Button btn_stopfan;
        private System.Windows.Forms.Button btn_startmainbrush;
        private System.Windows.Forms.Button btn_stopmainbrush;
        private System.Windows.Forms.Button btn_wheelspeed_left;
        private System.Windows.Forms.Button btn_wheelcurrent_left;
        private System.Windows.Forms.Button btn_wheelspeed_right;
        private System.Windows.Forms.Button btn_wheelcurrent_right;
        private System.Windows.Forms.GroupBox groupBox_control;
        private System.Windows.Forms.GroupBox groupBox_state;
        private System.Windows.Forms.Button btn_batterypara;
        private System.Windows.Forms.Button btn_fanspeed;
        private System.Windows.Forms.Button btn_mainbrushcurrent;
        private System.Windows.Forms.Button btn_brushcurrent;
        private System.Windows.Forms.TextBox tbx_detail;
        private System.Windows.Forms.GroupBox groupBox_details;
        private System.Windows.Forms.Button btn_opencomm;
        private System.Windows.Forms.Button btn_outtest;
        private System.Windows.Forms.Button btn_scancomm;
        private System.Windows.Forms.Button btn_cleandetail;
        private System.Windows.Forms.RadioButton rdb_showstring;
        private System.Windows.Forms.RadioButton rdb_shownumber;
        private System.Windows.Forms.Button btn_defaultcommand;
        private System.Windows.Forms.Button btn_customcommand;
    }
}

