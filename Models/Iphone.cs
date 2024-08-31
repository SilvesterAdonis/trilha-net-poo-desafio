namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            List<string> instalacao = new List<string>();

            instalacao.Add("1 - Abra a AppStore do Iphone");
            instalacao.Add($"2 - Pesquise {nomeApp}");
            instalacao.Add("3 - Toque na opção obter");

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