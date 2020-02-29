using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;

namespace ReconhecimentoFacial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        VideoCaptureDevice device;

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("");

        private void Form1_Load(object sender, EventArgs e)
        {      
            foreach(FilterInfo device in filterInfoCollection)
            {
                comboDevice.Items.Add(device.Name);//adicionando um item ao combobox
                comboDevice.SelectedIndex = 0;//verifica o índice do combobox
            }
        }
        
        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(device.IsRunning)
            {
                //if para verificar se a webcam está capturando imagens
                device.Stop();//para o funcionamento da webcam em caso de fechamento da tela
            }
        }

        private void Detect_Click(object sender, EventArgs e)
        {
            device = new VideoCaptureDevice(filterInfoCollection[comboDevice.SelectedIndex].MonikerString);
            device.NewFrame += Device_NewFrame;//cria um evento para abertura de uma nova janela
            device.Start();//inicia a captura da imagem da webcam ao clicar no botão capturar
        }
    }
}
