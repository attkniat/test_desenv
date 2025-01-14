﻿namespace TesteLogica.Factory
{
    public class FactoryEngine
    {
        public static IFibonacci CreateFibonacciSequence()
        {
            return new Fibonacci();
        }

        public static ITriangulo ValidaTriangulo()
        {
            return new Triangulo();
        }

        public static IMenuInicialOpcoes CriaMenuOpcoesIniciais()
        {
            return new MenuInicialOpcoes();
        }

        public static IMenuDadosTrianguloCalculo ObtemDadosCalculoTriangulo()
        {
            return new MenuDadosTrianguloCalculo();
        }

        public static ICalculaCasa RetornaCasaComParQdtJanelasComodos()
        {
            return new CalculaCasa();
        }
    }
}