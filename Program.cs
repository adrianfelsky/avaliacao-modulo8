void PausaParaLer()
{
    Console.Write("\nDigite ENTER para continuar...");
    Console.ReadLine();
}

bool sair = false;
while (!sair)
{
    Console.Clear();
    Console.WriteLine("1 - Listar Todos ");
    Console.WriteLine("2 - Buscar por Id");
    Console.WriteLine("3 - Buscar por Autor");
    Console.WriteLine("4 - Listar Disponíveis (async) ");
    Console.WriteLine("5 - Busca na API");
    Console.WriteLine("6 - Salvar Acervo - R9");
    Console.WriteLine("0 - sair");
    Console.Write("Escolha uma opção do Menu: ");
    string entrada = Console.ReadLine();

    Console.Clear();
    switch (entrada)
    {
        case "1":
            //IMPLEMENTAR 
            PausaParaLer();
            break;
        case "2":
            //IMPLEMENTAR 
            PausaParaLer();
            break;
        case "3":
            //IMPLEMENTAR 
            PausaParaLer();
            break;
        case "4":
            //IMPLEMENTAR 
            PausaParaLer();
            break;
        case "5":
            //IMPLEMENTAR 
            PausaParaLer();
            break;
        case "6":
            //IMPLEMENTAR 
            PausaParaLer();
            break;
        case "0":
            sair = true;
            break;
        default:
            Console.WriteLine("Digite uma opção válida!");
            break;
    }
}