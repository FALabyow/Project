using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForm
{
    public partial class ProductModule : Form
    {
        //Part 3 of the tutorial
        //https://www.youtube.com/watch?v=9LdU5zA5agA&list=PLcDvtJ2MXvhy_YrXdO4VXqZBOADCRJhSc&index=4

        private TcpListener tcpListener;
        private const int Port = 12345; // You can choose any available port.

        public ProductModule()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            tcpListener = new TcpListener(IPAddress.Any, Port);
            tcpListener.Start();

            // Start a new thread to listen for incoming connections
            Thread listenerThread = new Thread(new ThreadStart(ListenForClients));
            listenerThread.Start();

            
        }

        private void ListenForClients()
        {
            while (true)
            {
                // Accept incoming client connections
                TcpClient tcpClient = tcpListener.AcceptTcpClient();

                // Get the stream for reading data
                NetworkStream networkStream = tcpClient.GetStream();

                byte[] buffer = new byte[1024]; // Buffer to store incoming data
                int bytesRead;

                while ((bytesRead = networkStream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    string barcodeData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    UpdateBarcodeDisplay(barcodeData);
                }

                tcpClient.Close();
            }
        }

        private void UpdateBarcodeDisplay(string barcodeData)
        {
            // Use Invoke to update UI elements on the main thread
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateBarcodeDisplay), barcodeData);
            }
            else
            {
                // Update the Label with the received barcode data
                txtBarcode.Text = "Scanned Barcode: " + barcodeData;
               
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the TCP listener when the form is closing
            if (tcpListener != null)
            {
                tcpListener.Stop();
            }
        }

        public void Clear()
        {
            txtPcode.Text = "";
            txtBarcode.Text = "";
            txtPrice.Text = "";
            txtDescription.Text = "";
            nudReorder.Value = 1;
        }

        private void ProductModule_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
