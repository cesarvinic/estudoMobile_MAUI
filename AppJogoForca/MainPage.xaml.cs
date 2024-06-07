using AppJogoForca.Libraries.Text;
using AppJogoForca.Models;
using AppJogoForca.Repositories;
using System.Runtime.CompilerServices;

namespace AppJogoForca
{
    public partial class MainPage : ContentPage
    {
        private Word _word;
        private int _errors;
        public MainPage()
        {
            InitializeComponent();

            //Inicia uma nova partida.
            ResetScreen();
        }
        private async void OnButtonClicked(object sender, EventArgs e)
        {
            //Desabilita o botão clicado. 
            ((Button)sender).IsEnabled = false;

            //Obtém a letra do botão clicado
            string letter = ((Button)sender).Text;

            //Verifica se a letra existe na palavra e obtém a posição da letra.
            var positions = _word.Text.GetPositions(letter);

            //Se não encontrou a letra.
            if (positions.Count == 0)
            {
                _errors++;

                //Altera a imagem mediante o erro.
                this.ImgForca.Source = ImageSource.FromFile($"forca{_errors + 1}.png");

                if (_errors == 6)
                {
                    await DisplayAlert("Perdeu!", "Você foi enforcado!", "Novo jogo");

                    //Inicia uma nova partida.
                    ResetScreen();
                }

                return;
            }

            foreach (int position in positions)
            {
                //Se encontrar a letra, remove o caractere '_' e insere a letra na posição correta.
                this.lblText.Text = lblText.Text.Remove(position, 1).Insert(position, letter);
            }
        }

        private void ResetScreen()
        {
            //Reinicia o teclado
            ResetVirtualKeyboard();

            //Reinicia os erros
            ResetErrors();

            //Sorteia uma nova palavra.
            SortNewWord();
        }

        private void ResetErrors()
        {
            //Contador de erros.
            _errors = 0;

            //Imagem inicial.
            this.ImgForca.Source = ImageSource.FromFile($"forca1.png");
        }

        private void ResetVirtualKeyboard()
        {
            //Habilta todos os botões da tela. 
            ResetVirtualLines((HorizontalStackLayout)this.KeyboardContainer.Children[0]);
            ResetVirtualLines((HorizontalStackLayout)this.KeyboardContainer.Children[1]);
            ResetVirtualLines((HorizontalStackLayout)this.KeyboardContainer.Children[2]);
        }

        private void ResetVirtualLines(HorizontalStackLayout horizontal)
        {
            foreach (Button button in horizontal.Children)
            {
                button.IsEnabled = true;
            }
        }

        private void SortNewWord()
        {
            //Seleciona uma palavra aleatoreamente.
            var repository = new WordRepositories();
            _word = repository.GetRandomWord();

            this.lblTips.Text = _word.Tips;
            this.lblText.Text = new string('_', _word.Text.Length);
        }

    }
}
