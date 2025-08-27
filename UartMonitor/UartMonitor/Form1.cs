using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace UartMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            serialPort1.Encoding = Encoding.GetEncoding("utf-8");
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort1.ReadExisting();
            this.Invoke(new MethodInvoker(delegate
            {
                ReceiveDataRichTextBox.AppendText(data);
            }));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SearchAndAddSerialToComboBox(serialPort1, PortComboBox);  // scan serial port initial
            BuadRateComboBox.Text = "115200";  // baud rate initial
            StopBitComboBox.Text = "1";  // stop bit initial
            DataBitsComboBox.Text = "8";  // data bits initial
            ParityComboBox.Text = "None";  // parity initial

            ReceiveDataRichTextBox.ReadOnly = true;
        }

        private string SearchAndAddSerialToComboBox(SerialPort MySerialPort, System.Windows.Forms.ComboBox MyComboBox)
        {
            // To get the list of serial port names and add them to the ComboBox
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();  // Get the string list of serial port numbers available on the computer
            MyComboBox.Items.Clear();  // clear ComboBox content
            foreach (string i in ports)
            {
                MyComboBox.Items.Add(i);
            }
            // if there is no serial port, return an empty string
            if (ports.Length == 0)
            {
                return "";
            }
            else
            {
                MyComboBox.Text = ports[0];  //initial with first serial port
                return ports[0];
            }
        }

        private void ReScanButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                MessageBox.Show("Please close serial port first");
            }
            else
            {
                SearchAndAddSerialToComboBox(serialPort1, PortComboBox);  // scan serial port and add to ComboBox
            }
        }

        private void OpenComPortButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch { }  // ensure serial port is closed
                OpenComPortButton.Text = "Open COM Port";
            }
            else
            {
                try
                {
                    // serial port name
                    serialPort1.PortName = PortComboBox.Text;

                    // string to int,judge whether the conversion is successful
                    int num1 = 0;
                    bool a = int.TryParse(BuadRateComboBox.Text, out num1);
                    if (a == true)
                    {
                        serialPort1.BaudRate = num1;  // serial port buad rate
                    }
                    else
                    {
                        MessageBox.Show("Baud rate error", "Error");
                    }

                    // StopBits:One, OnePointFive, Two
                    switch (StopBitComboBox.Text)
                    {
                        case "1":
                            serialPort1.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            serialPort1.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            serialPort1.StopBits = StopBits.Two;
                            break;
                        default:
                            MessageBox.Show("Error: StopBits parameter error", "Error");
                            break;
                    }

                    // DataBits. 5, 6, 7, 8
                    serialPort1.DataBits = Convert.ToInt32(DataBitsComboBox.Text);

                    // Parity.None, Parity.Odd, Parity.Even
                    switch (ParityComboBox.Text)
                    {
                        case "None":
                            serialPort1.Parity = Parity.None;
                            break;
                        case "Odd":
                            serialPort1.Parity = Parity.Odd;
                            break;
                        case "Even":
                            serialPort1.Parity = Parity.Even;
                            break;
                        default:
                            MessageBox.Show("Error:参数不正确", "Error");
                            break;
                    }

                    serialPort1.Open();
                    OpenComPortButton.Text = "Close COM Port";

                }
                catch
                {
                    MessageBox.Show("Open COM Port failed", "Error");
                }
            }
        }
        private void SendDataButton_Click(object sender, EventArgs e)
        {
            byte[] Data = new byte[1];  // Send data by one byte
            if (serialPort1.IsOpen)
            {
                if (SendDataRichTextBox.Text != "")
                {
                    try
                    {
                        serialPort1.Write(SendDataRichTextBox.Text);
                    }
                    catch
                    {
                        MessageBox.Show(" Serial port data write error", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter content", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please open serial port", "Error");
            }
        }

        private void ClearSendButton_Click(object sender, EventArgs e)
        {
            SendDataRichTextBox.Text = "";  // clear send data text box
        }

        private void ClearReceivedButton_Click(object sender, EventArgs e)
        {
            ReceiveDataRichTextBox.Text = "";  // clear received data text box
        }

        private void SaveReceivedButton_Click(object sender, EventArgs e)
        {
            SaveTextBoxToFile(ReceiveDataRichTextBox);
        }

        private void SaveTextBoxToFile(System.Windows.Forms.RichTextBox MyRichTextBox)
        {
            // Build a save file dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Select a save location";

            // Display the dialog and wait for the user to click OK
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;  // Use the selected file path
                string content = MyRichTextBox.Text;  // Get the content from the RichTextBox

                try
                {
                    // Write the content to the file
                    File.WriteAllText(filePath, content, Encoding.UTF8);
                    MessageBox.Show("File saved successfully", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save file failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
