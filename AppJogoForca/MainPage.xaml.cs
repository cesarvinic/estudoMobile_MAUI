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

        #region [Button]
        private async void OnButtonClicked(object sender, EventArgs e)
        {
            //Pega o objeto da ação e obtém todas as propriedades dele, depois converte no botão
            Button button = (Button)sender;

            //Desabilita o botão clicado. 
            button.IsEnabled = false;

            //Obtém a letra do botão clicado
            string letter = button.Text;

            //Verifica se a letra existe na palavra e obtém a posição da letra.
            var positions = _word.Text.GetPositions(letter);

            //Se não encontrou a letra.
            if (positions.Count == 0)
            {
                ErroHandler(button);
                await IsGameOver();
                return;
            }

            ReplaceLetter(letter, positions);

            //Caso tudo tenha dado certo, atera o style para Success
            button.Style = App.Current.Resources.MergedDictionaries.ElementAt(1)["Success"] as Style;

            await HasWinner();
        }

        private void OnButtonClickedResetGame(object sender, EventArgs e)
        {
            ResetScreen();
        }
        #endregion

        #region [Handler Success]
        private void ReplaceLetter(string letter, List<int> positions)
        {
            foreach (int position in positions)
            {
                //Se encontrar a letra, remove o caractere '_' e insere a letra na posição correta.
                this.lblText.Text = lblText.Text.Remove(position, 1).Insert(position, letter);
            }
        }

        private async Task HasWinner()
        {
            if (!this.lblText.Text.Contains("_"))
            {
                await DisplayAlert("Parabéns!", "Você ganhou!", "Novo jogo");

                //Inicia uma nova partida.
                ResetScreen();
            }
        }


        #endregion

        #region [Handler Fail]
        private void ErroHandler(Button button)
        {
            _errors++;

            //Altera o style do botão para erro
            button.Style = App.Current.Resources.MergedDictionaries.ElementAt(1)["Fail"] as Style;

            //Altera a imagem mediante o erro.
            this.ImgForca.Source = ImageSource.FromFile($"forca{_errors + 1}.png");
        }

        private async Task IsGameOver()
        {
            if (_errors == 6)
            {
                await DisplayAlert("Perdeu!", "Você foi enforcado!", "Novo jogo");

                //Inicia uma nova partida.
                ResetScreen();
            }
        }
        #endregion

        #region [Helper Methods]
        private void SortNewWord()
        {
            //Seleciona uma palavra aleatoreamente.
            var repository = new WordRepositories();
            _word = repository.GetRandomWord();

            this.lblTips.Text = _word.Tips;
            this.lblText.Text = new string('_', _word.Text.Length);
        }
        #endregion

        #region [Reset_Screen]
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

                //Remove o style explicito e mantém o implicito. 
                button.Style = null;
            }
        }
        #endregion
    }
}
