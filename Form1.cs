using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO.Ports;

namespace 扫地机
{
    public partial class MainForm : Form
    {
        SerialPort sp = new SerialPort();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_opencomm.Text = "打开串口";
            scan_serialport(sp,cbCom);
            sp.BaudRate = 115200;
            Control.CheckForIllegalCrossThreadCalls = false;
            sp.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);//必须手动添加事件处理程序
            sp.ReadTimeout = 1000;
            rdb_showstring.Checked = true;
            rdb_shownumber.Checked = false;
            sp.Close();
        }

        //读串口函数
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //*******自发自收的写法
            //byte data;
            //for(int i = 0;i < 8;i++)
            //{
            //    data = (byte)serialPort.ReadByte();
            //    string str = Convert.ToString(data, 16).ToUpper();
            //    textBox2.AppendText("0x" + (str.Length == 1 ? "0" + str : str) + " ");
            //}   
            //*******自发自收的写法

            //int count = sp.BytesToRead;
            //string str = null;
            //byte[] buff = new byte[count];
            //sp.Read(buff, 0, count);
            //foreach (byte item in buff)    //读取Buff中存的数据，转换成显示的十六进制数  
            //{
            //    str += item.ToString("X2") + " ";
            //}
            //if (buff[0] == 0x40 && buff[1] == 0x5A)
            //{
            //    //表示有返回数据，对返回数据进行判断跳转处理函数
            //    tbx_detail.AppendText("收" + "<-" + str + "\r\n");
            //}
            if(rdb_shownumber.Checked)
            {
                int count = sp.BytesToRead;
                string str = null;
                byte[] buff = new byte[count];
                sp.Read(buff, 0, count);
                foreach (byte item in buff)    //读取Buff中存的数据，转换成显示的十六进制数  
                {
                    str += item.ToString("X2") + " ";
                }
                tbx_detail.AppendText("收" + "<-" + str + "\r\n");
            }
            else
            {
                string str = sp.ReadExisting();
                tbx_detail.AppendText("收" + "<-" + str + "\r\n");
            }            
        }

        //扫描串口函数
        private void scan_serialport(SerialPort myport,ComboBox mycombobox)
        {
            //串口扫描函数
            string buffer;
            string[] com_string = new string[15];
            int count = 0;
            mycombobox.Items.Clear();
            for (int i = 1; i < 15; i++)
            {
                try
                {
                    buffer = "COM" + i.ToString();
                    myport.PortName = buffer;
                    myport.Open();
                    myport.Close();
                    com_string[count] = buffer;
                    mycombobox.Items.Add(buffer);
                }
                catch { }
            }
            mycombobox.Text = com_string[0];
        }

        //打开串口函数
        private void Btn_opencomm_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                try
                {
                    sp.Close();
                    btn_opencomm.Text = "打开串口";
                    cbCom.Enabled = true;
                    btn_scancomm.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("关闭串口失败", "Error");
                }
            }
            else
            {
                try
                {
                    sp.PortName = cbCom.SelectedItem.ToString();
                    sp.Open();
                    cbCom.Enabled = false;
                    btn_scancomm.Enabled = false;
                    btn_opencomm.Text = "关闭串口";
                }
                catch
                {
                    MessageBox.Show("打开串口失败", "Error");
                }
            }
        }

        //写串口函数
        private void write_command_to_serialport(SerialPort myport, string command)
        {
            if (myport.IsOpen)
            {
                try
                {
                    myport.DiscardInBuffer();
                    myport.DiscardOutBuffer();
                    myport.Write(HexStrTobyte(command), 0, HexStrTobyte(command).Length);
                    if(rdb_shownumber.Checked)
                    {
                        tbx_detail.AppendText("发" + "->" + command + "\r\n");
                    }
                    else
                    {
                        tbx_detail.AppendText("发" + "->" + HexToString(command) + "\r\n");
                    }
                }
                catch
                {
                    MessageBox.Show("命令发送失败，请检查", "错误");
                }
            }
            else
                MessageBox.Show("串口未打开", "Error");
        }

        //十六进制转字符串
        private string HexToString(string hex)
        {
            if (hex == null)
            {
                //throw new ArgumentException("hex is null!");
            }
            if (hex.Length % 2 != 0)
            {
                hex += "20";//空格
                            //throw new ArgumentException("hex is not a valid number!", "hex");
            }
            // 需要将 hex 转换成 byte 数组。
            byte[] bytes = HexStrTobyte(hex);
            // 获得 GB2312，Chinese Simplified。
            Encoding chs = System.Text.Encoding.GetEncoding("GB2312");
            return chs.GetString(bytes);
        }

        //十六进制命令字符串转换为字节
        private byte[] HexStrTobyte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Trim(), 16);
            return returnBytes;
            //string[] strArr = hexString.Trim().Split(' ');
            //byte[] buff = new byte[strArr.Length];
            ////逐个字符变为16进制字节数据
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    buff[i] = Convert.ToByte(strArr[i], 16);
            //}
            ////按照指定编码将字节数组变为字符串
            //return buff;
        }

        //进入测试模式
        private void Btn_test_Click(object sender, EventArgs e)
        {
            string cmd = "40 53 41 2A";
            write_command_to_serialport(sp, cmd);
        }

        private void Btn_outtest_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 53 42 2A");
        }

        private void Btn_scancomm_Click(object sender, EventArgs e)
        {
            scan_serialport(sp, cbCom);
        }

        private void Btn_startbrush_weak_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 43 36 34 31 30 2A");
        }

        private void Btn_stopbrush_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 43 30 30 31 30 2A");
        }

        private void Btn_startbrush_strong_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 43 37 35 31 30 2A");
        }

        private void Btn_startwheel_left_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 41 30 31 30 31 31 34 30 36 2A");
        }

        private void Btn_startwheel_right_Click(object sender, EventArgs e)
        {
            //启动左边轮再启动右边轮将会使左边轮停转，加上以下命令不能解决
            //write_command_to_serialport(sp, "40 43 41 30 31 30 31 31 34 30 36 2A");
            write_command_to_serialport(sp, "40 43 41 30 32 30 31 31 34 30 36 2A");
        }

        private void Btn_stopwheel_left_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 41 30 31 30 31 30 30 30 36 2A");
        }

        private void Btn_stopwheel_right_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 41 30 32 30 31 30 30 30 36 2A");
        }

        private void Btn_startfan_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 47 37 38 2A");
        }

        private void Btn_stopfan_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 47 30 30 2A");
        }

        private void Btn_startmainbrush_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 45 36 34 31 30 2A");
        }

        private void Btn_stopmainbrush_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 45 30 30 31 30 2A");
        }

        private void Btn_version_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 6A 2A");
        }

        private void Btn_downsensor_Click(object sender, EventArgs e)
        {
            //显示接收数据会以两行显示
            write_command_to_serialport(sp, "40 43 49 2A");
        }

        private void Btn_frontsensor_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 4A 2A");
        }

        private void Btn_gyro_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 57 2A");
        }

        private void Btn_dust_etc_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 4B 2A");
        }

        private void Btn_wheelspeed_left_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 42 30 31 2A");
        }

        private void Btn_wheelcurrent_left_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 42 30 31 2A");
        }

        private void Btn_wheelspeed_right_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 42 30 32 2A");
        }

        private void Btn_wheelcurrent_right_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 42 30 32 2A");
        }

        private void Btn_brushcurrent_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 44 30 31 2A");
        }

        private void Btn_mainbrushcurrent_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 46 30 30 2A");
        }

        private void Btn_fanspeed_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 48 30 30 2A");
        }

        private void Btn_batterypara_Click(object sender, EventArgs e)
        {
            write_command_to_serialport(sp, "40 43 4F 30 31 2A");
        }

        private void Btn_cleandetail_Click(object sender, EventArgs e)
        {
            tbx_detail.Text = "";
        }

        private void Rdb_shownumber_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb_showstring.Checked)
            {
                //MessageBox.Show("切换显示模式将清空显示区域", "警告");
                tbx_detail.Text = "";
                rdb_showstring.Checked = false;
                //rdb_shownumber.Checked = true;
            }
            else
            {
                rdb_shownumber.Checked = true;
            }
        }

        private void Rdb_showstring_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_shownumber.Checked)
            {
                //MessageBox.Show("切换显示模式将清空显示区域", "警告");
                tbx_detail.Text = "";
                //rdb_showstring.Checked = true;
                rdb_shownumber.Checked = false;
            }
            else
            {
                rdb_showstring.Checked = true;
            }
        }

        private void Btn_defaultcommand_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该按钮功能暂时保留", "提示");
        }

        private void Btn_customcommand_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该按钮功能暂时保留", "提示");
        }
    }
}
