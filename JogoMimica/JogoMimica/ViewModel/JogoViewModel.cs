using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace JogoMimica.ViewModel
{
    public class JogoViewModel
    {
        public string Palavra { get; set; }
        public short PalavraPontuacao { get; set; }
        public short TextoContagem { get; set; }
        public Boolean ContainerContagem { get; set; }
        public Boolean ContainerIniciar { get; set; }


        public Command MostrarPalavra { get; set; }
        public Command Acertou { get; set; }
        public Command Errou { get; set; }
        public Command Iniciar { get; set; }
        

        public JogoViewModel()
        {
            ContainerContagem = false;
            MostrarPalavra = new Command();
            Acertou = new Command();
            Errou = new Command();
            Iniciar = new Command();
        }
    }
}
