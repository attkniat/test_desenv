﻿using System;

namespace TesteLogica
{
    public class MenuInicialOpcoes : IMenuInicialOpcoes
    {
        public int CriaMenuResposta()
        {
            Console.WriteLine("Selecione uma das opções");
            Console.WriteLine("\n\n(0) Desenvolva um código permitindo ao usuário digitar os 3 lados de um triângulo." +
                              " Baseado nos 3 valores digitados, deverá ser exibido se o triangulo é “inválido”," +
                              " “equilátero”, “isósceles” ou “escaleno”.");

            Console.WriteLine("\n\n(1) Desenvolva uma aplicação para exibir na tela, com o uso de " +
                              "recursividade, " + "os 30 primeiros resultados da “Sequência de Fibonacci”");

            Console.WriteLine("\n\n(2) Considerando o diagrama de classes abaixo, temos um objeto “List<Casa> casas” " +
                              "que pode conter N elementos. Exiba para o usuário o “Endereço”, “Metragem” e a quantidade " +
                              "de “Comodos” apenas das casas que possuam pelo menos 1 comodo com numero par de janelas.");

            Console.WriteLine("\n\n\n");
            var respostaOpcao = Int16.Parse(Console.ReadLine());

            return respostaOpcao;
        }
    }
}
