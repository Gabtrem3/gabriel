using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static string csvFile = "usuarios.csv";

    static void Main()
    {
        VerificaECriaArquivo();

        while (true)
        {

            Console.WriteLine("=== SISTEMA DE LOGIN ===");
            Console.Write("Usuário: ");
            string usuario = Console.ReadLine();
            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            if (LoginValido(usuario, senha))
            {
                Console.WriteLine($"\nBem-vindo, {usuario}!\n");
                if (usuario == "admin")
                {
                    MenuAdmin();
                }
                else
                {
                    MenuUsuario(usuario);
                }
            }
            else
            {
                Console.WriteLine("Login inválido. Pressione qualquer tecla para tentar novamente...");
                Console.ReadKey();
            }
        }
    }

    static void VerificaECriaArquivo()
    {
        if (!File.Exists(csvFile))
        {
            using (StreamWriter sw = File.CreateText(csvFile))
            {
                sw.WriteLine("usuario,senha");
                sw.WriteLine("admin,123");
            }
        }
    }

    static Dictionary<string, string> CarregarUsuarios()
    {
        return File.ReadAllLines(csvFile)
            .Skip(1)
            .Select(linha => linha.Split(','))
            .ToDictionary(campos => campos[0], campos => campos[1]);
    }

    static void SalvarUsuarios(Dictionary<string, string> usuarios)
    {
        using (StreamWriter sw = new StreamWriter(csvFile))
        {
            sw.WriteLine("usuario,senha");
            foreach (var kvp in usuarios)
            {
                sw.WriteLine($"{kvp.Key},{kvp.Value}");
            }
        }
    }

    static bool LoginValido(string usuario, string senha)
    {
        var usuarios = CarregarUsuarios();
    
    }

    static void MenuAdmin()
    {
        while (true)
        {
            Console.WriteLine("\n[1] Cadastrar novo usuário");
            Console.WriteLine("[2] Excluir usuário");
            Console.WriteLine("[3] Alterar minha senha");
            Console.WriteLine("[4] Sair");
            Console.Write("Escolha: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarUsuario();
                    break;
                case "2":
                    ExcluirUsuario();
                    break;
                case "3":
                    AlterarSenha("admin");
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    static void MenuUsuario(string usuario)
    {
        while (true)
        {
            Console.WriteLine("\n[1] Alterar minha senha");
            Console.WriteLine("[2] Sair");
            Console.Write("Escolha: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AlterarSenha(usuario);
                    break;
                case "2":
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    static void CadastrarUsuario()
    {
        var usuarios = CarregarUsuarios();
        Console.Write("Novo nome de usuário: ");
        string novoUsuario = Console.ReadLine();
        if (usuarios.ContainsKey(novoUsuario))
        {
            Console.WriteLine("Usuário já existe.");
            return;
        }

        Console.Write("Senha: ");
        string novaSenha = Console.ReadLine();
        usuarios[novoUsuario] = novaSenha;
        SalvarUsuarios(usuarios);
        Console.WriteLine("Usuário cadastrado com sucesso.");
    }

    static void ExcluirUsuario()
    {
        var usuarios = CarregarUsuarios();
        Console.Write("Usuário a ser excluído: ");
        string usuario = Console.ReadLine();

        if (usuario == "admin")
        {
            Console.WriteLine("Não é possível excluir o usuário admin.");
            return;
        }

        if (usuarios.ContainsKey(usuario))
        {
            usuarios.Remove(usuario);
            SalvarUsuarios(usuarios);
            Console.WriteLine("Usuário excluído com sucesso.");
        }
        else
        {
            Console.WriteLine("Usuário não encontrado.");
        }
    }

    static void AlterarSenha(string usuario)
    {
        var usuarios = CarregarUsuarios();
        Console.Write("Nova senha: ");
        string novaSenha = Console.ReadLine();
        usuarios[usuario] = novaSenha;
        SalvarUsuarios(usuarios);
        Console.WriteLine("Senha alterada com sucesso.");
    }
}

