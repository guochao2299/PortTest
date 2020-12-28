using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace PortTest
{
    public partial class frmMain : Form
    {
        private Action<string, int> m_checker = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(m_checker!=null)
            {
                m_checker(txtIP.Text, Int32.Parse(txtPort.Text));
            }
        }

        private void TcpClientCheck(string ip, int port)
        {
            IPAddress ipa = IPAddress.Parse(ip);
            IPEndPoint point = new IPEndPoint(ipa, port);
            TcpClient tcp = null;

            try
            {
                tcp = new TcpClient();
                tcp.Connect(point);
                MessageBox.Show("端口打开");
            }
            catch (Exception ex)
            {
                MessageBox.Show("计算机端口检测失败，错误消息为："+ex.Message);
            }
            finally
            {
                if(tcp!=null)
                {
                    tcp.Close();                    
                }
            }
        }

        private void SocketCheck(string ip, int port)
        {
            Socket sock = null;

            try
            {
                IPAddress ipa = IPAddress.Parse(ip);
                IPEndPoint point = new IPEndPoint(ipa, port);
                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sock.Connect(point);
                MessageBox.Show("端口打开");
            }
            catch (SocketException ex)
            {
                MessageBox.Show("计算机端口检测失败，错误消息为：" + ex.Message);
            }
            finally
            {
                if (sock != null)
                {
                    sock.Close();
                    sock.Dispose();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTcpClient.Checked)
            {
                m_checker = TcpClientCheck;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSocket.Checked)
            {
                m_checker = SocketCheck;
            }
        }
    }
}
