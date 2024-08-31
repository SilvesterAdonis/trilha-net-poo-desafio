namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            List<string> instalacao = new List<string>();

            instalacao.Add("1 - Abra o Google Play Store do Nokia");
            instalacao.Add($"2 - Pesquise na barra de pesquisa {nomeApp}");
            instalacao.Add("3 - Toque na opção instalar");

            Console.WriteLine("Apareceu o botão Abrir ? True/False ");
            bool confirmacao = Convert.ToBoolean(Console.ReadLine());

            if(confirmacao)
            {
                instalacao.Add($"5 - Instalação do {nomeApp} Concluída \n");
            }
            else
            {
                instalacao.Add($"5 - Falha na Instalação do {nomeApp} \n");
            }

            foreach(string instalado in instalacao)
            {
                Console.WriteLine(instalado);
            }
        }
    }
}