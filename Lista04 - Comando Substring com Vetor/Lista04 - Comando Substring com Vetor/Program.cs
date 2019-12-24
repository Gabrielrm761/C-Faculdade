using System;

namespace Lista04___Comando_Substring_com_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.Elaborar um algoritmo que leia um NOME com no máximo 30 posições e ao
                final coloque cada uma das letras deste NOME em uma das posições de um
                vetor do tipo caracter declarado também com 30 posições.

            string[] vetor = new string[30];
            string nome = "";
            int contador = 0;

            Console.Write("Informe o nome: ");
            nome = Console.ReadLine();

            if(nome.Length <= 30)
            {
                for(contador = 0;contador < nome.Length ; contador++)
                {
                    vetor[contador] = nome.Substring(contador, 1);
                    Console.WriteLine(vetor[contador]);
                }
            }
            Console.ReadLine();*/

            /*2.Elabore um algoritmo que receba 5 frases em um vetor de 5 ocorrências
                tipo caracter e no final exiba o total de letras “A” existentes em todas as
                frases armazenadas no vetor.

            string[] vetor = new string[5];
            string frase = "";
            int posicao = 0, contador = 0, quantidade_a = 0;

            for(contador = 0; contador < vetor.Length; contador++)
            {
                Console.Write("Informe a frase: ");
                frase = Console.ReadLine().ToUpper();
                vetor[contador] = frase;

                for(posicao =0;posicao < frase.Length; posicao++)
                {
                    if(vetor[contador].Substring(posicao,1) == "A")
                    {
                        quantidade_a++;
                    }
                }
            }
            Console.WriteLine($"A quantidade de letras 'A' é de: {quantidade_a}");
            Console.ReadLine();*/

            /*3.Elabore um algoritmo que receba em um vetor com 5 posições do tipo
                caracter 5 frases.Ao final exibir qual é a maior frase e em que ocorrência
                do vetor ela está armazenada.

            string[] vetor = new string[5];
            string frase = "", maior_frase = "";
            int contador = 0, maior = 0, posicao = 0;

            for(contador = 0; contador < vetor.Length; contador++)
            {
                Console.Write("Informe a frase: ");
                frase = Console.ReadLine();
                vetor[contador] = frase;
                if(frase.Length > maior)
                {
                    maior = frase.Length;
                    maior_frase = frase;
                    posicao = contador;
                }
            }
            Console.WriteLine($"A maior fraseé: {maior_frase}");
            Console.WriteLine($"A maior frase está na {posicao + 1}° ocorrência");
            Console.ReadLine();*/

            /*4.Elabore um algoritmo que receba em um vetor com 5 posições do tipo
                caracter 5 Nomes de alunos de uma turma. Ao final gere outro vetor
                também de 5 posições que deverá conter todos os nomes anteriormente
                digitados invertidos.

            string[] vetor = new string[5], vetor_inv = new string[5];
            int contador = 0, posicao = 0;

            for(contador = 0;contador < vetor.Length; contador++)
            {
                Console.Write($"Informe o nome do {contador + 1}° aluno: ");
                vetor[contador] = Console.ReadLine();

                for(posicao = vetor[contador].Length-1;posicao >= 0; posicao--)
                {
                    vetor_inv[contador] = vetor_inv[contador] + vetor[contador].Substring(posicao, 1);
                }
            }
            for(contador = 0; contador < vetor_inv.Length; contador++)
            {
                Console.WriteLine(vetor_inv[contador]);
            }
            Console.ReadLine();*/

            /*5.Elabore um algoritmo que receba via teclado vários números entre 1 e 100,
                observe que os números poderão se repetir várias vezes, considere que o
                operador digitará 999 para encerrar o processamento. Ao final informe
                quantas vezes cada um dos números apareceu. 

            int[] vetor = new int[99];
            int numero = 0, contador = 0;

            for(; ; )
            {
                Console.Write("Informe um número entre 1 e 100 (999 para encerrar): ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero == 999) break;
                if(numero >=1 && numero <= 99)
                {
                    vetor[numero] = vetor[numero] + 1;
                }
            }
            for(contador = 1; contador < vetor.Length; contador++)
            {
                if(vetor[contador] != 0)
                {
                    Console.WriteLine(contador + "=>" + vetor[contador]);
                }
            }
            Console.ReadLine();*/

            /*6.A Cidade de São Paulo precisará acrescentar um algarismo 9 na frente de
                cada um dos números de celulares informado em um vetor de 100
                ocorrência no formato 011NNNN - NNNN.Elabore um algoritmo que receba
                o vetor com os números originais e escreva com a modificação sugerida, ou
                seja, 0119NNNN - NNNN.

            string[] vetor = new string[3];
            int contador = 0, posicao = 0;

            for(contador = 0; contador < vetor.Length; contador++)
            {
                Console.Write($"Informe o {contador + 1}° telefone: ");
                vetor[contador] = "0119" + Console.ReadLine();
            }
            for(posicao = 0;posicao < vetor.Length; posicao++)
            {
                Console.WriteLine(vetor[posicao]);
            }
            Console.ReadLine();*/

            /*7.Elabore um algoritmo que receba 10 placas de automóveis em um vetor do
                tipo caracter e ao final calcule a média aritmética dos números de cada
                uma das placas recebidas e armazene as médias em outro vetor de reais
                também de 10 ocorrências.

            string[] placa = new string[10];
            double[] media = new double[10];
            int contador = 0;
            double soma = 0;

            for(contador = 0;contador < placa.Length; contador++)
            {
                Console.Write("Informe a placa do carro: ");
                placa[contador] = Console.ReadLine();
                soma = Convert.ToDouble(placa[contador].Substring(4, 1)) +
                       Convert.ToDouble(placa[contador].Substring(5, 1)) +
                       Convert.ToDouble(placa[contador].Substring(6, 1)) +
                       Convert.ToDouble(placa[contador].Substring(7, 1));

                media[contador] = soma / 4;
            }
            for(contador = 0;contador < media.Length; contador++)
            {
                Console.WriteLine($"A média da {contador + 1}° ocorrência é: {media[contador]}");
            }
            Console.ReadLine();*/

            /*8.Elabore um algoritmo que leia um conjunto de 10 notas em um vetor e em
                seguida exiba todas que são maiores que a média do conjunto.

            double[] nota = new double[10];            double media = 0, soma = 0;            int contador = 0;            for(contador = 0;contador < nota.Length; contador++)
            {
                Console.Write($"Informe a {contador + 1}° nota: ");
                nota[contador] = Convert.ToDouble(Console.ReadLine());

                soma = nota[contador] + soma;
                media = soma / nota.Length;
            }            for(contador =0;contador < nota.Length; contador++)
            {
                if(nota[contador] >= media)
                {
                    Console.WriteLine($"A nota {nota[contador]} da {contador + 1}° ocorrência está acima da média do conjunto");
                }
            }            Console.ReadLine();*/
        }
    }
}
