using System;

namespace Exercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*031 - Elabore um programa que escreva no vídeo os números de 10 a 70

            int contador = 10;

            while (contador <= 70)
            {
                Console.WriteLine(contador);
                contador = contador + 1;
            }
            Console.ReadLine();*/

            /*032 - Elabore um programa que escreva no vídeo os números de 150 a
                    100 utilizando qualquer das estruturas de repetição;

            int contador = 150;

            while (contador >= 100)
            {
                Console.WriteLine(contador);
                contador = contador - 1;
            }
            Console.ReadLine();*/

            /*033 - Elabore um programa que escreva no vídeo os números pares
                    existentes entre 10 e 50, utilize qualquer uma das estruturas de repetição
                    conhecidas;

            int contador = 10;

            while (contadore <= 50)
            {
                Console.WriteLine(contador);
                contador = contador + 2;
            }
            Console.ReadLine();*/

            /*034 - Obter a série de Fibonacci até o termo N informado por teclado.A
                    Série de Fibonacci é assim definida: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...

            int N = 0, contador = 0, numeroAnterior = 0, numeroAtual = 1, fibonacci = 0;

            Console.Write("Informe o valor de N: ");
            N = Convert.ToInt32(Console.ReadLine());

            for(contador = 1; fibonacci < N; contador++)
            {
                fibonacci = numeroAnterior + numeroAtual;
                Console.WriteLine(fibonacci);
                numeroAnterior = numeroAtual;
                numeroAtual = fibonacci;
            }
            Console.ReadLine();*/

            /*035 - Tabuada:Elabore um algoritmo que permita exibir na tela a tabuada de um
                    número inteiro informado via teclado – Observe o formato abaixo: a tabuada deverá
                    respeitar o formato abaixo;
                    7 x 1 = 7
                    7 x 2 = 14
                    7 x 3 = 21
                    7 x 4 = 28
                    7 x 5 = 35
                    7 x 6 = 42
                    7 x 7 = 49
                    7 x 8 = 56
                    7 x 9 = 63
                    7 x 10 = 70

            int numero = 0, contador = 0, tabuada = 1, resposta = 0;

            Console.Write("Informe o valor do número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for(contador = 0; tabuada <= 10; contador++)
            {
                resposta = numero * tabuada; ;
                Console.WriteLine(resposta);
                tabuada = tabuada + 1;
            }
            Console.ReadLine();*/

            /*036 - Soma_dos_inteiros: Elabore um programa que permita receber um número
                    inteiro via teclado e exibir no vídeo a soma dos números contidos de 1 até o numero
                    recebido.
                    Ex.: Se for recebido o número 5, exibir 1 + 2 + 3 + 4 + 5 ➔ 15

            int soma = 0, parcela = 0, numero = 0;

            Console.Write("Informe o número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for(parcela = 1; parcela <= numero; parcela++)
            {
                soma = soma + parcela;
            }
            Console.WriteLine($"A soma foi {soma}");
            Console.ReadLine();*/

            /*037 - Números_impares_inferiores: Elabore um programa que receba um número
                    inteiro via teclado e exiba todos os números impares inferiores a ele.
                    Ex.: Se for recebido o número 7, exibir os números 1, 3 e 5.

            int numero = 0, contador = 0;
            string  sequencia = "";

            Console.Write("Informe o número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for(contador = 1;contador < numero; contador = contador + 2)
            {
                sequencia = sequencia + contador.ToString() + ",";
            }
            Console.WriteLine("Resultado: " + sequencia.Substring(0, sequencia.Length - 1));
            Console.ReadLine();*/

            /*038 - Soma_dos_pares_inferiores: Elabore um programa que receba um número
                    inteiro via teclado e exiba no vídeo a soma dos números pares inferiores a ele.
                    Ex.: Se for recebido o número 9, exibir 2 + 4 + 6 + 8 ➔ 20
            int numero = 0, contador = 0, soma = 0;

            Console.Write("Informe um número inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for(contador = 0;contador <= numero; contador++)
            {
                if ((contador % 2)== 0)
                {
                    soma = soma + contador;
                }
            }
            Console.WriteLine($"A soma é de {soma}");
            Console.ReadLine();*/

            /*039 - Soma_e_Média: Elabore um programa que receba 5(cinco) números digitados
                    via teclado, valores aleatórios.Ao final exibir no vídeo a soma e a média aritmética
                    dos mesmos;

            double soma = 0, media = 0, numero = 0, contador = 0;

            for(contador = 1;contador <= 5; contador++)
            {
                Console.Write("Informe o " + contador + "número: ");
                numero = Convert.ToDouble(Console.ReadLine());
                soma = soma + numero;
            }
            media = soma / 5;

            Console.WriteLine($"A soma foi {soma.ToString("N2")} e a média é {media.ToString("N2")}");
            Console.ReadLine();*/

            /*040 - Totalizadores: Elabore um algoritmo que receba números aleatórios via
                    teclado.Encerrar o recebimento quando receber o número com valor igual a 999, este
                    não deverá entrar nos cálculos.
                    Ao final exibir o que se segue:
                    a) A quantidade de números digitados ➔ (6)
                    b) A soma dos valores digitados ➔ (162)
                    c) A média dos números pares digitados ➔ ((18 + 70 + 10 + 50) / 4)

            double valor = 0, quantidade_termo = 0, valor_par = 0, quantidade_termo_par = 0, soma = 0, media_par = 0;
            

            while(valor != 999)
            {
                Console.Write("Informe um número de valor inteiro, o número 999 encerrará o processo: ");
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor == 999) break;
                else if((valor % 2) == 0)
                {
                    valor_par = valor_par + valor;
                    quantidade_termo_par++;
                }
                soma = soma + valor;
                quantidade_termo++;
            }
            media_par = valor_par / quantidade_termo_par;

            Console.WriteLine($"A quantidade de números digitados foi {quantidade_termo}");
            Console.WriteLine($"A soma dos valores digitados é de: {soma}");
            Console.WriteLine($"A média dos números pares é de: {media_par.ToString("N2")}");
            Console.ReadLine();*/

            /*041 - Verificação_de_número_primo: Elabore um algoritmo que permita
                    receber um número inteiro via teclado e exibir no vídeo se o número recebido é
                    primo.Sabe - se que um número é primo quando é apenas divisível por 1 e por ele
                    mesmo.

            int numero = 0, quantidade_divisores = 0, contador = 0, resto = 0;

            Console.Write("Informe um valor inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for(contador = 1; contador <= numero; contador++)
            {
                resto = numero % contador;
                if(resto == 0)
                {
                    quantidade_divisores++;
                }
            }
            if(quantidade_divisores == 2)
            {
                Console.WriteLine($"{numero} é primo");
            }
            else
            {
                Console.WriteLine($"{numero} não é primo");
            }
            Console.ReadLine();*/

            /*042 - Operações_com_frases: Elabore um programa que permita receber uma frase
                    via teclado e exibir no vídeo o que segue:
                                Ex.:Nossa primeira avaliação será em 05 / 04 / 2018
                    a) A Quantidade de letras “a” ➔ 5
                    b) A Quantidade de palavras ➔ 6

            int tamanho = 0, posicao = 0, contador_a = 0, quantidade_palavra = 0;
            string frase = "";

            Console.Write("Informe a Frase: ");
            frase = Console.ReadLine().ToUpper();
            tamanho = frase.Length;
            int ContaA = 0, Qtd_Pal = 0;
            for (posicao = 0; posicao < tamanho; posicao++)
            {
                if (frase.Substring(posicao, 1) == "A") ContaA++;//A)

                if (posicao == tamanho - 1) break; // b)
                if ((frase.Substring(posicao, 1) != " " && frase.Substring(posicao + 1, 1) == " "))
                    Qtd_Pal++;

            }
            Console.WriteLine("Quantidade de letras A: " + contador_a);
            Console.WriteLine("Quantidade de Palavras: " + quantidade_palavra);
            Console.Read();*/

            /*043 - População_Países:Supondo que a população de um país A seja da ordem de
                    90.000 de habitantes com uma taxa anual de crescimento de 3 % e que a população de
                    um país B seja, aproximadamente, de 200.000 de habitantes com uma taxa anual de
                    crescimento de 1,5 %, fazer um programa que calcule e escreva o número de anos
                    necessários para que a população do país A ultrapasse ou iguale a população do país B,
                    mantida essas taxas de crescimento.

            double PopA = 90000, PopB = 200000, Qtd_Anos = 0;

            for (; PopA <= PopB;)
            {
                PopA = PopA + (PopA * 3 / 100); // PopA = PopA * 1.03
                PopB = PopB + (PopB * 1.5 / 100); // PopA = PopA * 1.015
                Console.WriteLine("PopA: " + PopA + " - " + "PopB: " + PopB);
                Qtd_Anos++;
            }
            Console.WriteLine("Qtd de Anos: " + Qtd_Anos);
            Console.Read();*/

            /*044 - Maior de uma lista de idades: Elabore um algoritmo que receba idades aleatórias
                    via teclado.Encerrar o recebimento quando receber uma idade com valor igual a 100,
                    esta não deverá entrar nos cálculos. Ao final exibir a maior idade recebida;

            int idade = 0, maior_idade = 0;

            for(; ; )
            {
                Console.Write("Informe a idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                if (idade >= 100) break;
                if(idade >= maior_idade)
                {
                    maior_idade = idade;
                }
            }
            Console.WriteLine($"A maior idade é {maior_idade}");
            Console.ReadLine();*/

            /*045 - Menor de uma lista de pesos: Elabore um algoritmo que receba pesos
                    aleatórios via teclado.Encerrar o recebimento quando receber um peso com valor
                    superioa a 200 kilos, este não deverá entrar nos cálculos. Ao final exibir o menos peso
                    recebido;

            int peso = 0, menor_peso = 999;

            for(; ; )
            {
                Console.Write("Informe o peso: ");
                peso = Convert.ToInt32(Console.ReadLine());
                if (peso >= 200) break;
                if(peso <= menor_peso)
                {
                    menor_peso = peso;
                }
                Console.WriteLine($"O menor peso é: {menor_peso}");
                Console.ReadLine();
            }*/

            /*047 - Estatísticas:Tem - se um conjunto de dados contendo a altura e o sexo(”M”,
                    “F”) de pessoas. Fazer um algoritmo que receba via teclado este conjunto de dados,
                    o último registro terá o valor do sexo = “FIM”, calcule e escreva:
                    a) a maior e a menor altura do grupo;
                    b) a média de altura das mulheres;
                    c) a quantidade de pessoas do sexo masculino;

            double altura = 0, m = 0, f = 0, menor_altura = 999, maior_altura = 0, altura_f = 0, media = 0;
            string sexo = "";

            for(; ; )
            {
                Console.Write("Informe o sexo(M/F)(FIM para finalizar): ");
                sexo = Console.ReadLine().ToUpper();
                if (sexo == "FIM") break;

                Console.Write("informe a altura(0,00): ");
                altura = Convert.ToDouble(Console.ReadLine());
                if (sexo == "FIM") break;
                else if(sexo == "M")
                {
                    m++;
                }
                else
                {
                    f++;
                    altura_f = altura_f + altura;
                }
                if(altura >= maior_altura)
                {
                    maior_altura = altura;
                }
                else if(altura <= menor_altura)
                {
                    menor_altura = altura;
                }
                media = altura_f / f;

                Console.WriteLine($"A maior altura é: {maior_altura} e a menor altura é: {menor_altura}");
                Console.WriteLine($"A média da altura entre as mulheres é: {media.ToString("N2")}");
                Console.WriteLine($"A quantidade de pessoas do sexo masculino é: {m}");
                Console.ReadLine();*/

            /*049 - Estatisticas: Fazer um programa que receba a altura e sexo de 30 pessoas e
                    escreva ao final:
                    a) a menor altura do grupo;
                    b) a média da altura dos meninos;
                    c) identificar a posição da pessoa mais alta e dizer se é menino ou menina.

            double m = 0, f = 0, altura = 0, menor_altura = 999, maior_altura = 0, media = 0, altura_m = 0;
            string sexo = "", sexo_altura = "";

            for(; ; )
            {
                Console.Write("Informe o sexo(M/F)(FIM para finalizar): ");
                sexo = Console.ReadLine().ToUpper();

                if (sexo == "FIM") break;

                Console.Write("Informe a altura: ");
                altura = Convert.ToDouble(Console.ReadLine());

                if (sexo == "M")
                {
                    m++;
                    altura_m = altura_m + altura;
                }
                else f++;

                if(altura <= menor_altura)
                {
                    menor_altura = altura;
                }
                if (maior_altura == altura || sexo == "M") sexo_altura = "M";
                else sexo_altura = "F";
            }
            media = altura_m / m;

            Console.WriteLine($"A menor altura do grupo é: {menor_altura}");
            Console.WriteLine($"A média da altura entre os meninos é: {media}");
            Console.WriteLine($"A maior altura do grupo é do sexo: {sexo_altura}");
            Console.ReadLine();*/
        }
    }
}
