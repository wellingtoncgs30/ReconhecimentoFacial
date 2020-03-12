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
using Emgu.CV.Structure;

namespace ReconhecimentoFacial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly FilterInfoCollection filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        VideoCaptureDevice device;

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");

        private void Form1_Load(object sender, EventArgs e)
        {      
            foreach(FilterInfo device in filterInfoCollection)
            {
                comboDevice.Items.Add(device.Name);//adicionando um item ao combobox
            }
            comboDevice.SelectedIndex = 0;//verifica o índice do combobox
            device = new VideoCaptureDevice();
        }
        
        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);
            foreach(Rectangle rectangle in rectangles)
            {
                using(Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using(Pen pen = new Pen(Color.Red, 1))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                }
            }
            pictureWebCam.Image = bitmap;
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

        private void Capture_Click(object sender, EventArgs e)
        {
            
        }
    }
}
