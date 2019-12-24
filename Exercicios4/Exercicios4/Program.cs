using System;

namespace Exercicios4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*065 - Soma dos vetores: Elabore um programa que carregue um vetor com 5 ocorrências de números
                    inteiros e ao final exiba a soma dos números carregados; A = { 10,20,5, 1, 2}  Soma = 38

            double[] vetor = new double[5];
            double soma = 0;
            int contador = 0;

            for(contador = 0;contador < vetor.Length; contador++)
            {
                Console.Write($"Informe o {contador + 1}° valor do vetor: ");
                vetor[contador] = Convert.ToDouble(Console.ReadLine());
                soma = soma + vetor[contador];
            }
            Console.WriteLine($"A soma dos vetores é: {soma}");
            Console.ReadLine();*/

            /*066 - Media de notas: Elabore um programa que carregue um vetor com 5 notas de alunos e ao final
                    exiba a média das notas; A = { 9.00, 6.50, 5.00, 1.00, 0.00}  Soma = 4,30

            double[] vetor = new double[5];            double soma = 0, media = 0;            int contador = 0;            for (contador = 0; contador < vetor.Length; contador++)
            {
                Console.Write($"Informe a {contador + 1}° nota do aluno: ");
                vetor[contador] = Convert.ToDouble(Console.ReadLine());
                soma = soma + vetor[contador];
            }            media = soma / vetor.Length;

            Console.WriteLine($"A média do aluno é: {media.ToString("N2")}");
            Console.ReadLine();*/

            /*067 - Maior idade: Elabore um programa que carregue um vetor com 5 idades e ao final exiba qual a
                    maior idade carregada, suponha não existir idades iguais. A = { 10,20,50, 1, 23}  Maior Idade = 50

            double[] vetor = new double[5];
            double maior = 0;
            int contador = 0;

            for (contador = 0; contador < vetor.Length; contador++)
            {
                Console.Write($"Informe a {contador + 1}° idade: ");
                vetor[contador] = Convert.ToDouble(Console.ReadLine());
                if(vetor[contador] > maior)
                {
                    maior = vetor[contador];
                }
            }
            Console.WriteLine($"A maior idade é: {maior}");
            Console.ReadLine();*/

            /*068 - Soma dos conteúdos pares: Elabore um programa
                    que carregue um vetor com 10 valores e ao final exiba a
                    soma dos conteúdos pares

            double[] vetor = new double[10];
            double soma = 0;
            int contador = 0;

            for (contador = 0; contador < vetor.Length; contador++)
            {
                Console.Write($"Informe a {contador + 1}° número: ");
                vetor[contador] = Convert.ToDouble(Console.ReadLine());
                if (vetor[contador] % 2 == 0)
                {
                    soma = soma + vetor[contador];
                }
            }
            Console.WriteLine($"A soma dos números pares é: {soma}");
            Console.ReadLine();*/

            /*069 - Soma dos conteúdos das ocorrências impares:
                    Elabore um programa que carregue um vetor com 10
                    valores e ao final exiba a soma dos conteúdos que estão
                    armazenados nas ocorrências impares.

            double[] vetor = new double[10];
            double soma = 0;
            int contador = 0;

            for (contador = 0; contador < vetor.Length; contador++)
            {
                Console.Write($"Informe a {contador + 1}° número: ");
                vetor[contador] = Convert.ToDouble(Console.ReadLine());
                if (contador % 2 != 0)
                {
                    soma = soma + vetor[contador];
                }
            }
            Console.WriteLine($"A soma dos das ocorrências imppares é: {soma}");
            Console.ReadLine();*/

            /*070 – Ordem inversa de vetores: Elaborar um algoritmo que receba 10 números carregando-os em
                    um vetor de 10 ocorrências imprimindo ao final, os números na ordem inversa de entrada.

            string[] vetor = new string[10];
            string invertido = "";
            int contador = 0;

            for (contador = 0; contador < vetor.Length; contador++)
            {
                Console.Write($"Informe a {contador + 1}° número: ");
                vetor[contador] = Console.ReadLine();

                invertido = vetor[contador] + ", " + invertido;
            }
            Console.WriteLine($"A ordem invertida é:{invertido.Substring(0, invertido.Length - 1)}");
            Console.ReadLine();*/

            /*071 – Soma de Vetores: Faça um algoritmo que carregue dois vetores com 5 números inteiros. Ao final
                    exibir no vídeo um terceiro vetor que conterá o soma dos dois anteriores.

            double[] vetor = new double[5], vetor2 = new double[5], vetor3 = new double[5];
            int contador = 0;

            for (contador = 0; contador < vetor.Length; contador++)
            {
                Console.Write($"Informe a {contador + 1}° número do vetor 1: ");
                vetor[contador] = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Informe a {contador + 1}° número do vetor 2: ");
                vetor2[contador] = Convert.ToDouble(Console.ReadLine());

                vetor3[contador] = (vetor[contador] + vetor2[contador]);
            }
            for(contador = 0; contador < vetor.Length; contador++)
            {
                Console.WriteLine($"A soma da {contador + 1}° ocorrência do 1° e 2° vetor é: {vetor3[contador]}");
            }
            Console.ReadLine();*/

            /*072 - Nome Maior Idade: Faça um programa que carregue um vetor com 10 nomes e outro com 10
                    idades.Ao final exibir:
                    A) O nome e a Idade da pessoa que possui a maior idade;
                    B) O nome e a Idade da pessoa que possui a menor idade;
                    C) Quais as pessoas que têm Idade superior a média das idades

            string[] vetor = new string[10];
            int[] vetor2 = new int[10];
            double media = 0;
            int contador = 0, maior = 0, menor = 999, soma = 0;
            string nome = "", nomes = "", menor_nome = "";

            for (contador = 0; contador < vetor.Length; contador++)
            {
                Console.Write($"Informe o {contador + 1}° nome: ");
                vetor[contador] = Console.ReadLine();
                Console.Write($"Informe a {contador + 1}° idade: ");
                vetor2[contador] = Convert.ToInt32(Console.ReadLine());

                soma = soma + vetor2[contador];
                media = soma / vetor2.Length;
                if(vetor2[contador] > maior)
                {
                    maior = vetor2[contador];
                    nome = vetor[contador];
                }
                if(vetor2[contador] < menor)
                {
                    menor = vetor2[contador];
                    menor_nome = vetor[contador];
                }
            }
            for(contador = 0; contador < vetor.Length; contador++)
            {
                if(vetor2[contador] > media)
                {
                    nomes = nomes + " " + vetor[contador];
                }
            }
            Console.WriteLine($"A pessoa mais velha, nome: {nome} / idade: {maior}");
            Console.WriteLine($"A pessoa mais nova, nome: {menor_nome} / idade: {menor}");
            Console.WriteLine($"Nome das pessoas com idade acima da média de idade: {nomes}");
            Console.ReadLine();*/

            //Pesquisa sequencial:é o método para se encontrar um elemento particular dentro de um Vetor.
            /*073 - Busca no Vetor: Faça um programa que carregue um vetor com 5 nomes e em
                    seguida receba um nome qualquer e verifique se este nome informado existe ou não
                    em alguma ocorrência do vetor previamente digitado;

            string[] nomes = new string[5];
            string achei = "", nome = "";
            int contador = 0;

            for(contador = 0; contador < nomes.Length; contador++)
            {
                Console.WriteLine($"Informe aqui o {contador + 1}° nome: ");
                nomes[contador] = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Informe o nome a pesquisar: ");
            nome = Console.ReadLine().ToUpper();
            achei = "não";

            for(contador = 0; contador < nomes.Length; contador++)
            {
                if(nome == nomes[contador])
                {
                    achei = "sim"; break;
                }
            }
            if (achei == "sim")
            {
                Console.WriteLine("Nome encontrado.");
            }
            else
            {
                Console.WriteLine("Nome não encontrado.");
            }

            Console.ReadLine();*/

            /*074 – Pesquisa Vogal:
                    Elaborar um programa que receba uma frase e
                    verifique quantas vogais existem na frase digitada.

            string[] vogais = { "A", "E", "I", "O", "U" };
            string frase = "", letra = "";
            int contador = 0, contador2, quantidade_vogal = 0;

            Console.Write("Informe a frase: ");
            frase = Console.ReadLine().ToUpper();

            for(contador = 0; contador < frase.Length; contador++)
            {
                letra = frase.Substring(contador, 1);

                for(contador2 = 0; contador2 < vogais.Length; contador2++)
                {
                    if(letra == vogais[contador2])
                    {
                        quantidade_vogal++;
                    }
                }
            }
            Console.WriteLine($"{quantidade_vogal} vogais existem na frase.");
            Console.ReadLine();*/

            /*075 – Pesquisa Vetor:
                    Elaborar um programa em C# para receber 20 valores reais em um vetor com 20 posições.
                    Os números deverão ser armazenados no vetor na ordem em que foram
                    digitados, sendo que, caso o usuário digite um número que já tenha sido digitado
                    anteriormente, o programa deverá pedir para que o usuário digite um novo
                    número.Note que cada novo valor digitado deve ser pesquisado no vetor,
                    verificando se ele existe entre os números já armazenados anteriormente no vetor. Exiba
                    ao final os valores que foram armazenados no vetor.

            double[] numeros = new double[20];
            double numero = 0;
            string achei = "";
            int contador = 0, contador2 = 0;

            for (; contador < numeros.Length;)
            {
                Console.WriteLine($"Informe um número: ");
                numero = Convert.ToDouble(Console.ReadLine());
                achei = "não";
                for (contador2 = 0; contador2 < numeros.Length; contador2++)
                {
                    if (numero == numeros[contador2])
                    {
                        achei = "sim"; break;
                    }
                }
                if(achei == "sim")
                {
                    Console.WriteLine("número já cadastrado.");
                }
                else
                {
                    numeros[contador] = numero;
                    contador++;
                }
            }
            for(contador2 = 0; contador2 < numeros.Length; contador2++)
            {
                Console.WriteLine($"números[{contador2}] = {numeros[contador2]}");
            }
            Console.ReadLine();*/

            /*Ordena Vetor: Elaborar um programa em C# para receber 5 valores reais em
                            um vetor com 5 posições de reais.E ao final exibir os
                            elementos do vetor ordenados em ordem crerscente.

            double[] numeros = new double[5];
            double aux = 0;
            int i = 0, j = 0, k = 0, p = 0;

            for(i = 0; i < numeros.Length; i++)
            {
                Console.Write("Informe um número: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }
            for(j = 0; j < numeros.Length; j++)
            {
                for(k = j + 1; k < numeros.Length; k++)
                {
                    if(numeros[j] > numeros[k])
                    {
                        aux = numeros[j];
                        numeros[j] = numeros[k];
                        numeros[k] = aux;
                    }
                }
            }
            for(p = 0; p < numeros.Length; p++)
            {
                Console.WriteLine($"numeros[{p}] = {numeros[p]}");
            }
            Console.ReadLine();*/

            /*076 – Maiores que a média: Faça um algoritmo que carregue um vetor com 5 números
                    inteiros.Ao final exibir os valores armazenados que são superiores a média dos
                    armazenados

            double[] vetor = new double[5];
            double media = 0, soma = 0;
            int contador = 0;

            for(contador = 0; contador < vetor.Length; contador++)
            {
                Console.Write($"Informe o {contador + 1}° número: ");
                vetor[contador] = Convert.ToDouble(Console.ReadLine());
                soma = soma + vetor[contador];
            }
            media = soma / 5;
            for(contador = 0; contador < vetor.Length; contador++)
            {
                if(vetor[contador] > media)
                {
                    Console.WriteLine(vetor[contador]);
                }
            }
            Console.ReadLine();*/

            /*077 – Menor e sua posição: Faça um algoritmo que carregue um vetor N com 20
                    ocorrências e a seguir encontre o menor elemento do vetor N e a sua posição dentro do
                    vetor, mostrando: “O menor elemento de N é”, M, “e sua posição dentro do vetor é:”,P.            double[] vetor = new double[20];            double menor = 9999;            int contador = 0, indicador = 0;            for(contador = 0; contador < vetor.Length; contador++)
            {
                Console.Write($"Informe o {contador + 1}° número: ");
                vetor[contador] = Convert.ToDouble(Console.ReadLine());
                if(vetor[contador] < menor)
                {
                    menor = vetor[contador];
                    indicador = contador;
                }
            }            Console.WriteLine($"O menor número é: {menor} e sua posição está dentro do vetor[{indicador}]");            Console.ReadLine();*/

            /*078 – Inversão de um vetor: Escreva um algoritmo que carregue um vetor de 20
                    posições, em seguida, troque o primeiro elemento com o último, o segundo com o
                    penúltimo, o terceiro com o antepenúltimo, e assim sucessivamente. Mostre o novo vetor
                    depois da troca.

            double[] vetor = new double[20];            double aux = 0;            int contador = 0, contador2 = 0;            for(contador = 0; contador < vetor.Length; contador++)
            {
                Console.Write($"Informe o {contador + 1}° número: ");
                vetor[contador] = Convert.ToDouble(Console.ReadLine());
            }            for(contador = 0; contador < vetor.Length / 2; contador++)
            {
                aux = vetor[contador];
                vetor[contador] = vetor[19 - contador];
                vetor[19 - contador] = aux;
            }            for(contador2 = 0; contador2 < vetor.Length;contador2++)
            {
                Console.WriteLine(vetor[contador2]);
            }            Console.ReadLine();*/
        }
    }
}
