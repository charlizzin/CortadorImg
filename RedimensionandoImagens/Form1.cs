using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Collections;

namespace RedimensionandoImagens
{
    public partial class Form1 : Form
    {
        public Size tamanhoOriginalImagem { get; set; }        //Store original image size.
        public Size novoTamanhoImagem { get; set; }             //Store new image size.

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcurarImagem_Click(object sender, EventArgs e)
        {
            string destinoImg = @"C:\Users\Charles\AppData\Roaming\Spark\xtra\emoticons\WhatsApp\Imagens\PNG 16px\";
            txtDestinoImagem.Text = "";
            lblTamanhoOriginal.Text = "";
            lblNovoTamanhoImagem.Text = "";
            txtOrigemImagem.Text = @"C:\Users\Charles\AppData\Roaming\Spark\xtra\emoticons\WhatsApp\Imagens\PNG Baixa";

            OpenFileDialog abrirImagem = new OpenFileDialog
            {
                Multiselect = true
            };
            DialogResult resultado = abrirImagem.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                //Carrega imagem no picture box e define a propriedade size da imagem como normal
                //picImagem.Load(abrirImagem.FileName);
                //picImagem.SizeMode = PictureBoxSizeMode.CenterImage;

                String[] a = abrirImagem.FileNames;
                String[] b = abrirImagem.SafeFileNames;
                int i = 0;

                foreach (var item in a)
                {
                    txtOrigemImagem.Text = item;
                    txtDestinoImagem.Text = destinoImg + b[i];

                    picImagem.Load(item);
                    picImagem.SizeMode = PictureBoxSizeMode.CenterImage;

                    //Retorna a altura e lagurada da imagem e armazena na varivavel tamanhoOriginalImagem
                    int imgWidth = picImagem.Image.Width;
                    int imgHeight = picImagem.Image.Height;
                    tamanhoOriginalImagem = new Size(imgWidth, imgHeight);

                    string imgSize = "Width " + imgWidth + " px  Height " + imgHeight + " px";
                    lblTamanhoOriginal.Text = imgSize;

                    Image imagemEscalonada = EscalaPercentual(picImagem.Image, 23);
                    //Exibe a imagem no picture box.
                    picImagem.Image = imagemEscalonada;

                    //Retorna a lagura e altura da imagem
                    string imagemSize = "Width " + imagemEscalonada.Width + " px  Height " + imagemEscalonada.Height + " px";
                    lblNovoTamanhoImagem.Text = imgSize;
                    string nomeArquivo = txtDestinoImagem.Text;
                    Bitmap imgImage = new Bitmap(picImagem.Image);  //Cria um objeto do tipo Bitmap
                    imgImage.Save(nomeArquivo);      //Chama o método Save da classe Bitmap

                    i++;

                    //txtOrigemImagem.Text = item;
                    //txtDestinoImagem.Text = destinoImg + abrirImagem.SafeFileNames;

                    //picImagem.Load(abrirImagem.FileName);
                    //picImagem.SizeMode = PictureBoxSizeMode.CenterImage;

                    ////Retorna a altura e lagurada da imagem e armazena na varivavel tamanhoOriginalImagem
                    //int imgWidth = picImagem.Image.Width;
                    //int imgHeight = picImagem.Image.Height;
                    //tamanhoOriginalImagem = new Size(imgWidth, imgHeight);

                    //string imgSize = "Width " + imgWidth + " px  Height " + imgHeight + " px";
                    //lblTamanhoOriginal.Text = imgSize;

                    //Image imagemEscalonada = EscalaPercentual(picImagem.Image, 23);
                    ////Exibe a imagem no picture box.
                    //picImagem.Image = imagemEscalonada;

                    ////Retorna a lagura e altura da imagem
                    //string imagemSize = "Width " + imagemEscalonada.Width + " px  Height " + imagemEscalonada.Height + " px";
                    //lblNovoTamanhoImagem.Text = imgSize;
                    //string nomeArquivo = txtDestinoImagem.Text;
                    //Bitmap imgImage = new Bitmap(picImagem.Image);  //Cria um objeto do tipo Bitmap
                    //imgImage.Save(nomeArquivo);      //Chama o método Save da classe Bitmap
                }
                //Armazena o local da origem no textbox.
                //txtOrigemImagem.Text = abrirImagem.FileName;
                //txtDestinoImagem.Text = destinoImg + abrirImagem.SafeFileName;

                ////Retorna a altura e lagurada da imagem e armazena na varivavel tamanhoOriginalImagem
                //int imgWidth = picImagem.Image.Width;
                //int imgHeight = picImagem.Image.Height;
                //tamanhoOriginalImagem = new Size(imgWidth, imgHeight);

                //string imgSize = "Width " + imgWidth + " px  Height " + imgHeight + " px";
                //lblTamanhoOriginal.Text = imgSize;

                //Image imagemEscalonada = EscalaPercentual(picImagem.Image, 23);
                ////Exibe a imagem no picture box.
                //picImagem.Image = imagemEscalonada;

                ////Retorna a lagura e altura da imagem
                //string imagemSize = "Width " + imagemEscalonada.Width + " px  Height " + imagemEscalonada.Height + " px";
                //lblNovoTamanhoImagem.Text = imgSize;
                //string nomeArquivo = txtDestinoImagem.Text;
                //Bitmap imgImage = new Bitmap(picImagem.Image);  //Cria um objeto do tipo Bitmap
                //imgImage.Save(nomeArquivo);      //Chama o método Save da classe Bitmap
            }
        }

        static Image EscalaPercentual(Image imgPhoto, int Percent)
        {
            float nPorcentagem = ((float)Percent / 100);

            int fonteLargura = imgPhoto.Width;     //armazena a largura original da imagem origem
            int fonteAltura = imgPhoto.Height;   //armazena a altura original da imagem origem
            int origemX = 0;        //eixo x da imagem origem
            int origemY = 0;        //eixo y da imagem origem

            int destX = 0;          //eixo x da imagem destino
            int destY = 0;          //eixo y da imagem destino
            //Calcula a altura e largura da imagem redimensionada
            int destWidth = (int)(fonteLargura * nPorcentagem);
            int destHeight = (int)(fonteAltura * nPorcentagem);

            //Cria um novo objeto bitmap
            Bitmap bmImagem = new Bitmap(destWidth, destHeight,
                                     PixelFormat.Format24bppRgb);
            //Define a resolução do bitmap.
            bmImagem.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);
            //Crima um objeto graphics e defina a qualidade
            Graphics grImagem = Graphics.FromImage(bmImagem);
            grImagem.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //Desenha a imge usando o método DrawImage() da classe grafica
            grImagem.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(origemX, origemY, fonteLargura, fonteAltura),
                GraphicsUnit.Pixel);

            grImagem.Dispose();  //libera o objeto grafico
            return bmImagem;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Chama o método EscalaPercentual  que retorna a imagem 
            //redimensionada e armazena-a em uma varivael do tipo Image
            //Image imagemEscalonada = EscalaPercentual(picImagem.Image, (int)nupImagem.Value);
            Image imagemEscalonada = EscalaPercentual(picImagem.Image, 23);
            //Exibe a imagem no picture box.
            picImagem.Image = imagemEscalonada;

            //Retorna a lagura e altura da imagem
            string imgSize = "Width " + imagemEscalonada.Width + " px  Height " + imagemEscalonada.Height + " px";
            lblNovoTamanhoImagem.Text = imgSize;
        }

        private void btnSalvarImagem_Click(object sender, EventArgs e)
        {
            //Image imagemEscalonada = EscalaPercentual(picImagem.Image, 23);
            ////Exibe a imagem no picture box.
            //picImagem.Image = imagemEscalonada;

            ////Retorna a lagura e altura da imagem
            ////string imgSize = "Width " + imagemEscalonada.Width + " px  Height " + imagemEscalonada.Height + " px";
            //lblNovoTamanhoImagem.Text = imgSize;
            //string nomeArquivo = txtDestinoImagem.Text;
            //Bitmap imgImage = new Bitmap(picImagem.Image);  //Cria um objeto do tipo Bitmap
            //imgImage.Save(nomeArquivo);      //Chama o método Save da classe Bitmap
        }
        //private void btnSalvarImagem_Click(object sender, EventArgs e)
        //{
        //    SaveFileDialog sfd = new SaveFileDialog();   //Cria um objeto SaveFileDialog
        //    sfd.DefaultExt = "png";                     //Define a extensão padrão
        //    if (DialogResult.OK == sfd.ShowDialog())
        //    {
        //        string nomeArquivo = sfd.FileName;                 //Armazena o nome da arquivo na varivael
        //        txtDestinoImagem.Text = nomeArquivo;               //Exibe o local de destino no TextBox
        //        Bitmap imgImage = new Bitmap(picImagem.Image);  //Cria um objeto do tipo Bitmap
        //        imgImage.Save(nomeArquivo, ImageFormat.Png);      //Chama o método Save da classe Bitmap
        //    }
        //}
    }
}
