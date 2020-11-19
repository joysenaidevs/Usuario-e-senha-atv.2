using System;

namespace Usuario_e_senha_atv._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 - Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.

            // string usuario = "";
            // string senha = "";
            // string usuarioSenha = "";
            
            // do{     
            //     Console.WriteLine("Digite seu nome de usuario: ");
            //     usuario = Console.ReadLine();
            // }while(usuario != "senaidevs"); 

            // Console.WriteLine("Usuario confirmado");

            // do{
            //     Console.WriteLine("Digite sua senha");
            //     senha = Console.ReadLine();
            // }while(senha != "senai");

            // Console.WriteLine("Senha Confirmada");

            Console.WriteLine("Usuario e senha precisam ser distintos");

            string usuario = (Console.ReadLine());
            string senha = (Console.ReadLine());

            while(usuario != "joysenaidevs")
            {
                Console.WriteLine("Tente senha distinta");
                Console.WriteLine("Utilize outra senha");
            }
            while(senha != "joysenai")
            {
                Console.WriteLine("senha incorreta");
                Console.WriteLine("Utilize senha distinta");
            }
            Console.WriteLine("Usuario e senha confirmados");

            


            
        }
    }
}
