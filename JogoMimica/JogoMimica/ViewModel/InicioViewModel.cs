using JogoMimica.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using JogoMimica.Armazenamento;

namespace JogoMimica.ViewModel
{
    public class InicioViewModel : INotifyPropertyChanged
    {
        public Jogo Jogo { get; set; }
        public Command IniciarCommand { get; set; }
        public InicioViewModel()
        {
            IniciarCommand = new Command(IniciarJogo);
        }
        private void IniciarJogo()
        {
            Armazenamento.Armazenamento.Jogo = this.Jogo;
            Armazenamento.Armazenamento.RodadaAtual = 1;
            App.Current.MainPage = new View.Jogo();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string NameProperty)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NameProperty));
            }
        }
    }
}
