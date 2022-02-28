using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Electrophorus
{
    public partial class JanelaArduino : StandardWindow

    {
        SerialPort _serialPort;
        string message;


        public JanelaArduino(MainWindow mainWindow)
        {
            InitializeComponent();
            timerCOM.Enabled = true;
            _serialPort = new SerialPort();
        }
        private void AtualizaListaCOMs()
        {
            int i;
            bool quantDiferente;
            i = 0;
            quantDiferente = false;


            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }
            if (quantDiferente == false)
            {
                return;
            }

            comboBox1.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void TimerCOM_Tick(object sender, EventArgs e)
        {
            AtualizaListaCOMs();
            Read();
        }

        private void BtConectar_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen == false)
            {
                try
                {
                    _serialPort.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    _serialPort.Open();
                }
                catch
                {
                    return;
                }
                if (_serialPort.IsOpen)
                {
                    btConectar.Text = "Desconectar";
                    comboBox1.Enabled = false;
                }
            }
            else
            {
                try
                {
                    _serialPort.Close();
                    comboBox1.Enabled = true;
                    btConectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }
            }
        }
        private void JanelaArduino_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_serialPort.IsOpen == true)
            {
                _serialPort.Close();
            }
        }

        private void BtEnviar_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen == true)
            {
                _serialPort.Write(textBoxEnviar.Text);
            }
        }
        private void TrataDadoRecebido(object sender, EventArgs e)
        {
            if (message!="")
            {
                textBoxReceber.AppendText(message);
                textBoxReceber.AppendText(Environment.NewLine);
            }
        }

        private void BtReceber_Click(object sender, EventArgs e)
        {
            message = _serialPort.ReadExisting();
            this.Invoke(new EventHandler(TrataDadoRecebido));
        }
        private void Read()
        {
            if (_serialPort.IsOpen == true)
            {
                message = _serialPort.ReadExisting();
                
                _ = Invoke(new EventHandler(TrataDadoRecebido));
            }
            
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            textBoxReceber.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Salva arquivo textBoxReceber em Texto
            ClassArqText arquivoTXT = new ClassArqText();
            arquivoTXT.FU_Salvar(textBoxReceber.Text);
        }
    }
}
