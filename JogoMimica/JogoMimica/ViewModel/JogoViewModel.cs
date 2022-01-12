using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace JogoMimica.ViewModel
{
    public class JogoViewModel : INotifyPropertyChanged
    {
        private string _Palavra;
        public string Palavra { get { return _Palavra; } set { _Palavra = value; OnPropertyChanged("Palavra"); } }
        
        private short _PalavraPontuacao;
        public short PalavraPontuacao { get { return _PalavraPontuacao; } set { _PalavraPontuacao = value;OnPropertyChanged("PalavraPontuacao"); } }

        private short _TextoContagem;
        public short TextoContagem { get { return _TextoContagem; } set { _TextoContagem = value;OnPropertyChanged("TextoContagem"); } }

        private Boolean _IsContainerContagem;
        public Boolean IsContainerContagem { get { return _IsContainerContagem; } set { _IsContainerContagem = value;OnPropertyChanged("IsContainerContagem"); } }

        private Boolean _IsContainerIniciar;
        public Boolean IsContainerIniciar { get { return _IsContainerIniciar; } set { _IsContainerIniciar = value;OnPropertyChanged("IsContainerIniciar"); } }

        private Boolean _IsVisibleBtnMostrar;
        public Boolean IsVisibleBtnMostrar { get { return _IsVisibleBtnMostrar; } set { _IsVisibleBtnMostrar = value;OnPropertyChanged("IsVisibleBtnMostrar"); } }


        public Command MostrarPalavra { get; set; }
        public Command Acertou { get; set; }
        public Command Errou { get; set; }
        public Command Iniciar { get; set; }

        private void OnPropertyChanged(string nameProperty)
        {
            if (PropertyChanged != null)
            {
                PropertyChangedEventArgs e = new PropertyChangedEventArgs(nameProperty);
            }
        }

        public JogoViewModel()
        {
            IsContainerContagem = false;
            IsContainerIniciar = false;
            IsVisibleBtnMostrar = true;
            Palavra = "************";


            MostrarPalavra = new Command(MostrarPalavraAction);
            Acertou = new Command(MostrarPalavraAction);
            Errou = new Command(MostrarPalavraAction);
            Iniciar = new Command(MostrarPalavraAction);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void MostrarPalavraAction()
        {
            PalavraPontuacao = 3;
            Palavra = "Sentar";
            IsVisibleBtnMostrar = false;
            IsContainerIniciar = true;
        }
    }
}
