using AppJogoForca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Maui.ApplicationModel.Permissions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppJogoForca.Repositories
{
    public class WordRepositories
    {
        private List<Word> _words;

        public WordRepositories() { 
            _words =
            [
                new Word("Nome", "Maria".ToUpper()),
                new Word("Animal", "Elefante".ToUpper().ToUpper()),
                new Word("Animal", "Leão".ToUpper()),
                new Word("Animal", "Tigre".ToUpper()),
                new Word("Animal", "Girafa".ToUpper()),
                new Word("Animal", "Zebra".ToUpper()),
                new Word("Animal", "Canguru".ToUpper()),
                new Word("Animal", "Urso".ToUpper()),
                new Word("Animal", "Coelho".ToUpper()),
                new Word("Animal", "Rato".ToUpper()),
                new Word("Animal", "Macaco".ToUpper()),
                new Word("Animal", "Gorila".ToUpper()),
                new Word("Animal", "Hipopótamo".ToUpper()),
                new Word("Animal", "Rinoceronte".ToUpper()),
                new Word("Animal", "Crocodilo".ToUpper()),
                new Word("Animal", "Flamingo".ToUpper()),
                new Word("Animal", "Pinguim".ToUpper()),
                new Word("Animal", "Golfinho".ToUpper()),
                new Word("Animal", "Tubarão".ToUpper()),
                new Word("Animal", "Baleia".ToUpper()),
                new Word("Animal", "Foca".ToUpper()),
                new Word("Fruta", "Abacaxi".ToUpper()),
                new Word("Fruta", "Acerola".ToUpper()),
                new Word("Fruta", "Amora".ToUpper()),
                new Word("Fruta", "Banana".ToUpper()),
                new Word("Fruta", "Caju".ToUpper()),
                new Word("Fruta", "Cereja".ToUpper()),
                new Word("Fruta", "Coco".ToUpper()),
                new Word("Fruta", "Figo".ToUpper()),
                new Word("Fruta", "Goiaba".ToUpper()),
                new Word("Fruta", "Jaca".ToUpper()),
                new Word("Fruta", "Kiwi".ToUpper()),
                new Word("Fruta", "Laranja".ToUpper()),
                new Word("Fruta", "Limão".ToUpper()),
                new Word("Fruta", "Maçã".ToUpper()),
                new Word("Fruta", "Mamão".ToUpper()),
                new Word("Fruta", "Manga".ToUpper()),
                new Word("Fruta", "Maracujá".ToUpper()),
                new Word("Fruta", "Melancia".ToUpper()),
                new Word("Fruta", "Morango".ToUpper()),
                new Word("Fruta", "Pêssego".ToUpper()),
                new Word("País", "Brasil".ToUpper()),
                new Word("País", "Argentina".ToUpper()),
                new Word("País", "Canadá".ToUpper()),
                new Word("País", "Estados Unidos".ToUpper()),
                new Word("País", "México".ToUpper()),
                new Word("País", "França".ToUpper()),
                new Word("País", "Alemanha".ToUpper()),
                new Word("País", "Itália".ToUpper()),
                new Word("País", "Espanha".ToUpper()),
                new Word("País", "Japão".ToUpper()),
                new Word("País", "China".ToUpper()),
                new Word("País", "Índia".ToUpper()),
                new Word("País", "Austrália".ToUpper()),
                new Word("País", "Rússia".ToUpper()),
                new Word("País", "África do Sul".ToUpper()),
                new Word("País", "Egito".ToUpper()),
                new Word("País", "Noruega".ToUpper()),
                new Word("País", "Suécia".ToUpper()),
                new Word("País", "Finlândia".ToUpper()),
                new Word("País", "Portugal".ToUpper()),
                new Word("Profissão", "Médico".ToUpper()),
                new Word("Profissão", "Engenheiro".ToUpper()),
                new Word("Profissão", "Professor".ToUpper()),
                new Word("Profissão", "Advogado".ToUpper()),
                new Word("Profissão", "Enfermeiro".ToUpper()),
                new Word("Profissão", "Arquiteto".ToUpper()),
                new Word("Profissão", "Jornalista".ToUpper()),
                new Word("Profissão", "Contador".ToUpper()),
                new Word("Profissão", "Psicólogo".ToUpper()),
                new Word("Profissão", "Dentista".ToUpper()),
                new Word("Profissão", "Programador".ToUpper()),
                new Word("Profissão", "Farmacêutico".ToUpper()),
                new Word("Profissão", "Cozinheiro".ToUpper()),
                new Word("Profissão", "Piloto".ToUpper()),
                new Word("Profissão", "Veterinário".ToUpper()),
                new Word("Profissão", "Fisioterapeuta".ToUpper()),
                new Word("Profissão", "Eletricista".ToUpper()),
                new Word("Profissão", "Bombeiro".ToUpper()),
                new Word("Profissão", "Mecânico".ToUpper()),
                new Word("Profissão", "Designer".ToUpper()),
                new Word("Nome pessoa", "Ana".ToUpper()),
                new Word("Nome pessoa", "João".ToUpper()),
                new Word("Nome pessoa", "Pedro".ToUpper()),
                new Word("Nome pessoa", "Maria".ToUpper()),
                new Word("Nome pessoa", "Lucas".ToUpper()),
                new Word("Nome pessoa", "Laura".ToUpper()),
                new Word("Nome pessoa", "Gabriel".ToUpper()),
                new Word("Nome pessoa", "Juliana".ToUpper()),
                new Word("Nome pessoa", "Matheus".ToUpper()),
                new Word("Nome pessoa", "Sofia".ToUpper()),
                new Word("Nome pessoa", "Rafael".ToUpper()),
                new Word("Nome pessoa", "Beatriz".ToUpper()),
                new Word("Nome pessoa", "Felipe".ToUpper()),
                new Word("Nome pessoa", "Carolina".ToUpper()),
                new Word("Nome pessoa", "Gustavo".ToUpper()),
                new Word("Nome pessoa", "Amanda".ToUpper()),
                new Word("Nome pessoa", "Leonardo".ToUpper()),
                new Word("Nome pessoa", "Mariana".ToUpper()),
                new Word("Nome pessoa", "Bruno".ToUpper()),
                new Word("Nome pessoa", "Fernanda".ToUpper()),
                new Word("Vegetal", "Alface".ToUpper()),
                new Word("Vegetal", "Espinafre".ToUpper()),
                new Word("Vegetal", "Couve".ToUpper()),
                new Word("Vegetal", "Brócolis".ToUpper()),
                new Word("Vegetal", "Cenoura".ToUpper()),
                new Word("Vegetal", "Beterraba".ToUpper()),
                new Word("Vegetal", "Abobrinha".ToUpper()),
                new Word("Vegetal", "Berinjela".ToUpper()),
                new Word("Vegetal", "Pimentão".ToUpper()),
                new Word("Vegetal", "Pepino".ToUpper()),
                new Word("Vegetal", "Rúcula".ToUpper()),
                new Word("Vegetal", "Agrião".ToUpper()),
                new Word("Vegetal", "Tomilho".ToUpper()),
                new Word("Vegetal", "Nabo".ToUpper()),
                new Word("Vegetal", "Rabanete".ToUpper()),
                new Word("Vegetal", "Ervilha".ToUpper()),
                new Word("Vegetal", "Vagem".ToUpper()),
                new Word("Vegetal", "Aipo".ToUpper()),
                new Word("Vegetal", "Tomate".ToUpper()),
                new Word("Vegetal", "Cebola".ToUpper()),
            ];
        }

        public Word GetRandomWord()
        {
            Random rand = new Random();
            var number = rand.Next(0, _words.Count);
            return _words[number];
        }
    }
}
