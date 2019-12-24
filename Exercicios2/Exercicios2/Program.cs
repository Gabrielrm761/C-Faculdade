using System;

namespace Exercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*016 - Somar_DD_MM_AAAA: Faça um programa que receba uma data em uma variável
                  tipo string no formato “DD / MM / AAAA” e calcule a soma do DD + MM + AAAA e exiba na tela.
                  Exemplo: Entrada ➔“13 / 08 / 2018”
                           Saída ➔ 13 + 08 + 2018 = 2039 

            int dia = 0, mes = 0, ano = 0, soma = 0;
            string data = "";

            Console.Write("Informe a data DD/MM/AAAA: ");
            data = Console.ReadLine();

            dia = Convert.ToInt32(data.Substring(0, 2));
            mes = Convert.ToInt32(data.Substring(3, 2));
            ano = Convert.ToInt32(data.Substring(6, 4));
            soma = dia + mes + ano;

            Console.WriteLine($"{dia} + {mes} + {ano} = {soma}");
            Console.ReadLine();*/

            /*017 - PartesdeUmaFrase : Faça um algoritmo que receba uma frase qualquer informada
                    via teclado e escreva no vídeo o que se segue:
                    a) Os Primeiros 5(cinco) caracteres da frase;
                    b) Os últimos 5(cinco) caracteres da frase;
                    c) Os primeiros 5(cinco) caracteres da frase invertidos;
                    d) A quantidade de caracteres contidos na frase;

            string frase = "", caracter_a = "", caracter_b = "", caracter_c = "", invertido = "";
            int contador = 0, quantidade_caracter = 0;

            Console.Write("Informe uma frase: ");
            frase = Console.ReadLine();

            caracter_a = frase.Substring(0, 5);
            caracter_b = frase.Substring(frase.Length - 5, 5);
            for(contador = 0; contador <= frase.Length - 1; contador++)
            {
                invertido = frase.Substring(contador, 1) + invertido;
            }
            caracter_c = invertido.Substring(0, 5);
            quantidade_caracter = frase.Length;

            Console.WriteLine($"Os Primeiros 5(cinco) caracteres da frase: {caracter_a}");
            Console.WriteLine($"Os últimos 5(cinco) caracteres da frase: {caracter_b}");
            Console.WriteLine($"Os primeiros 5(cinco) caracteres da frase invertidos: {caracter_c}");
            Console.WriteLine($"A quantidade de caracteres contidos na frase: {quantidade_caracter}");
            Console.ReadLine();*/

            /*018 - InverterData: Escreva um programa para receber uma data no formato americano
                    (AAAA/ MM / DD) e mostrá-la no formato nacional(DD / MM / AAAA).

            string data_americano = "", data_nacional = "";            Console.Write("Informe a data em formato americano (AAAA/MM/DD): ");            data_americano = Console.ReadLine();            data_nacional = data_americano.Substring(8, 2)+ "/" + data_americano.Substring(5, 2) + "/" + data_americano.Substring(0, 4);            Console.WriteLine($"A data em formato nacional é: {data_nacional}");            Console.ReadLine();*/

            /*019 - Operações com Frases: Receber duas variáveis tipo string(FRASE e COMPLEMENTO) e exibir o que se segue:
                                a)Tamanho da Frase;
                                b)Tamanho do Complemento;
                                c) Dividir a frase ao meio e exibir a primeira parte;
                                d) Dividir a frase ao meio e exibir a segunda parte;
                                e) Exibir a frase concatenada com o complemento;
                                f) Exibir a frase com os primeiros bytes substituídos pelos bytes do complemento:
                                Ex: Frase: ABCDEFG Compl: @@@ -> @@@DEFG
                                g) Exibir a frase com os últimos bytes substituídos pelos bytes do complemento:
                                Ex: Frase: ABCDEFG Compl: @@@ -> ABCD@@@
                                h) Exibir a frase com o complemento inserido no meio separado por hífen.
                                Ex: Frase: ABCDEFG Compl: @@@ -> ABC -@@@-DEFG

            Console.Write("Informe a frase: ");            string frase = Console.ReadLine();            Console.Write("Informe o complemento: ");            string compl = Console.ReadLine();            int resp_a = frase.Length;            int resp_b = compl.Length;            int metade = resp_a / 2;            string resp_c = frase.Substring(0, metade);            string resp_d = frase.Substring(metade, resp_a - metade);            string resp_e = frase + compl;            string resp_f = compl + frase.Substring(resp_b);            string resp_g = frase.Substring(0, resp_a - resp_b) + compl;            string resp_h = frase.Substring(0, metade) + "-" +compl + "-" + frase.Substring(resp_a - metade - 1);            Console.WriteLine($"Tamanho da Frase: {resp_a}");            Console.WriteLine($"Tamanho do Complemento: {resp_b}");            Console.WriteLine($"Dividir a frase ao meio e exibir a primeira parte: {resp_c}");            Console.WriteLine($"Dividir a frase ao meio e exibir a segunda parte: {resp_d}");            Console.WriteLine($"Exibir a frase concatenada com o complemento: {resp_e}");            Console.WriteLine($"Exibir a frase com os primeiros bytes substituídos pelos bytes do complemento: {resp_f}");            Console.WriteLine($"Exibir a frase com os últimos bytes substituídos pelos bytes do complemento: {resp_g}");            Console.WriteLine($"Exibir a frase com o complemento inserido no meio separado por hífen: {resp_h}");            Console.ReadLine();*/

            /*020 - Ordem Crescente dois números: Faça um programa que
                    receba dois valores inteiros e exiba-os em ordem crescente;

            int valor1 = 0, valor2 = 0;            Console.Write("Informe o 1° valor: ");            valor1 = Convert.ToInt32(Console.ReadLine());            Console.Write("informe o 2° valor: ");            valor2 = Convert.ToInt32(Console.ReadLine());            if(valor1 > valor2)
            {
                Console.WriteLine($"Ordem Crescente: {valor2}, {valor1}");
            }            else
            {
                Console.WriteLine($"Ordem Crescente: {valor1}, {valor2}");
            }            Console.ReadLine();*/

            /*021 - Maior de três: Faça um programa
                    que receba três valores inteiros e informe
                    qual é o maior dentre eles;

            int valor1 = 0, valor2 = 0, valor3 = 0, maior = 0;

            Console.Write("Informe o 1° valor: ");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o 2° valor: ");
            valor2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o 3° valor: ");
            valor3 = Convert.ToInt32(Console.ReadLine());
            maior = valor1;
            if(valor2 > maior)
            {
                maior = valor2;
            }
            if(valor3 > maior)
            {
                maior = valor3;
            }
            Console.WriteLine($"O maior valor é: {maior}");
            Console.ReadLine();*/


            /*021 - Maior de três: Faça um programa que receba três valores
                    inteiros e informe qual é o maior dentre eles;

            int valor1 = 0, valor2 = 0, valor3 = 0;

            Console.Write("Informe o 1° valor: ");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o 2° valor: ");
            valor2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o 3° valor: ");
            valor3 = Convert.ToInt32(Console.ReadLine());

            if(valor1 > valor2 && valor1 > valor3)
            {
                Console.WriteLine($"O maior valor é: {valor1}");
            }
            else if(valor2 > valor1 && valor2 > valor3)
            {
                Console.WriteLine($"O maior valor é: {valor2}");
            }
            else
            {
                Console.WriteLine($"O maior valor é: {valor3}");
            }
            Console.ReadLine();*/

            /*022 - Ordem_Crescente_Três Números: Faça um programa que receba três valores
                    inteiros e exiba-os em ordem crescente;

            int valor1 = 0, valor2 = 0, valor3 = 0;

            Console.Write("Informe o 1° valor: ");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o 2° valor: ");
            valor2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o 3° valor: ");
            valor3 = Convert.ToInt32(Console.ReadLine());            if(valor1 > valor2 && valor2 > valor3)
            {
                Console.WriteLine($"Ordem Crescente: {valor3} , {valor2}, {valor1}");
            }            else if(valor1 > valor3 && valor3 > valor2)
            {
                Console.WriteLine($"Ordem Crescente: {valor2} , {valor3}, {valor1}");
            }            else if (valor2 > valor1 && valor1 > valor3 )
            {
                Console.WriteLine($"Ordem Crescente: {valor3} , {valor1}, {valor2}");
            }
            else if (valor2 > valor3 && valor3 > valor1)
            {
                Console.WriteLine($"Ordem Crescente: {valor1} , {valor3}, {valor2}");
            }
            else if (valor3 > valor1 && valor1 > valor2)
            {
                Console.WriteLine($"Ordem Crescente: {valor2} , {valor1}, {valor3}");
            }
            else if (valor3 > valor2 && valor2 > valor1)
            {
                Console.WriteLine($"Ordem Crescente: {valor1} , {valor2}, {valor3}");
            }
            Console.ReadLine();*/

            /*023 - Par ou Impar: Faça um programa que receba um valor inteiro e informe se o
                    mesmo é “Par” ou “Impar”;

            Console.Write("Informe um valor inteiro: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            if(valor % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é impar");
            }
            Console.ReadLine();*/

            /*024 - Pescador: João Papo-de - Pescador, homem de bem, comprou um
                    microcomputador para controlar o rendimento diário de seu trabalho.Toda vez que ele
                    traz um peso de peixes maior que o estabelecido pelo regulamento de pesca do estado
                    de São Paulo(50 quilos) deve pagar um multa de R$ 4,00 por quilo excedente.João
                    precisa que você faça um algoritmo que leia a variável P(peso de peixes) e verifique
                    se há excesso.Se houver, gravar na variável E(Excesso) e na variável M o valor da
                    multa que João deverá pagar. Caso contrário mostrar tais variáveis com o conteúdo
                    ZERO.

            double peso = 0, excesso = 0, multa = 0;

            Console.Write("Informe o peso total de peixes em Kg: ");
            peso = Convert.ToInt32(Console.ReadLine());
            excesso = peso - 50;
            multa = excesso * 4;

            if(peso > 50)
            {
                Console.WriteLine("Peso Excedido!");
                Console.WriteLine($"A multa é de R$ {multa}");
            }
            else
            {
                Console.WriteLine("Não houve excesso, portanto não há multa a pagar");
            }
            Console.ReadLine();*/

            /*025 - Triângulo: Receba três números inteiros representando os tamanhos dos lados de
                    um triângulo. Verifique se os números informados formam um triângulo, ou seja, cada
                    um dos lados informados tem que ser menor que a soma dos outros dois.Em caso
                    positivo informar qual tipo de triângulo seria formado
                    • Equilátero se os três lados forem iguais(3, 3, 3);
                    • Isósceles se dois lados forem iguais(3,2,3);
                    • Escaleno se os três lados forem diferentes(4, 2, 3);
                                (9, 1, 3)->Não forma um triângulo

            int a = 0, b = 0, c = 0;

            Console.Write("Informe o 1° lado do triângulo: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o 2° lado do triângulo: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o 3° lado do triângulo: ");
            c = Convert.ToInt32(Console.ReadLine());

            if((a > b + c) || (b > a + c) || (c > a + b))
            {
                Console.WriteLine("Esses valores não formam um triângulo");
                Console.ReadLine();
            }
            if ((a == b) || (b == c))
            {
                Console.WriteLine("O triângulo é Equilátero");
            }
            if ((a == b) && (a != c) || (a != b) && (a == c))
            {
                Console.WriteLine("O triângulo é Isóceles");
            }
            if ((a != b) && (a != c) && (b != c))
            {
                Console.WriteLine("O triângulo é  Escaleno");
            }
            Console.ReadLine();*/

            /*026 - ImpostodeRenda:Elabore um programa que permita calcular o imposto de renda
                    (IR) de um casal a partir das rendas do homem(RH) e da renda da mulher(RM). O
                    imposto é calculado sobre a renda conjunta(RC= RH + RM) de acordo com a tabela
                    abaixo:
                    Renda Conjunta Alíquota -IR
                    Até 900.00 Isento
                    De 900.01 até 1500.00   - 10 %
                    De 1500.01 até 2500.00  - 15 %
                    Acima de 2500.00        - 25 %
                    Exibir ao final na tela:
                    a) A renda conjunta(RC);
                    b) A alíquota Utilizada;
                    c) O Imposto de renda(IR) calculado
                    d) A renda líquida

            double rh = 0, rm = 0, rc = 0, ir = 0, rl = 0;

            Console.Write("Informe o valor da renda do homem: ");
            rh = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor da renda da mulher: ");
            rm = Convert.ToDouble(Console.ReadLine());

            rc = rh + rm;

            if(rc <= 900)
            {
                rl = rc - ir;
                Console.WriteLine("Isento de IR");
            }
            if((rc > 900.01) && (rc < 1500))
            {
                ir = rc * 10 / 100;
                rl = rc - ir;
                Console.WriteLine("A aliquota utilizada é de 10%");
                Console.WriteLine($"O imposto de renda calculada é de R$ {ir}");
            }
            if((rc > 1500.01) && (rc < 2500))
            {
                ir = rc * 15 / 100;
                rl = rc - ir;
                Console.WriteLine("A aliquota utilizada é de 15%");
                Console.WriteLine($"O imposto de renda calculada é de R$ {ir}");
            }
            if (rc > 2500.01)
            {
                ir = rc * 25 / 100;
                rl = rc - ir;
                Console.WriteLine("A aliquota utilizada é de 25%");
                Console.WriteLine($"O imposto de renda calculada é de R$ {ir}");
            }
            Console.WriteLine($"A renda conjunta é de {rc} e a renda liquida é de R$ {rl}");
            Console.ReadLine();*/

            /*027 - Diária do Hotel: Um hotel cobra R$ 300,00 por diária e mais uma taxa adicional de serviços
                    (para cada diária).Se o número de diárias for menor que 15 a taxa é de R$ 20, 00.Se o número
                    de diárias for igual a 15 a taxa é de R$ 14, 00 e se o número for maior que 15 a taxa é de R$
                    12, 00.Faça um programa que receba o número de diárias e imprima o total a pagar por uma
                    pessoa, de acordo com o número de diárias dessa pessoa.

            double diaria = 300, taxa = 0, numero_diaria = 0, valor_total = 0;            Console.Write("Informe o número de diarias: ");            numero_diaria = Convert.ToDouble(Console.ReadLine());            if(numero_diaria < 15)
            {
                taxa = 20;
            }            else
            {
                if(numero_diaria == 15)
                {
                    taxa = 14;
                }
                else
                {
                    taxa = 12;
                }
            }            valor_total = (diaria * numero_diaria) + (numero_diaria * taxa);            Console.WriteLine($"O valor total a ser pago é de R$ {valor_total}");
            Console.ReadLine();*/

            /*028 - SPA: Elabore um programa que permita receber o peso e a altura de uma pessoa adulta.O
                    programa deverá exibir uma das seguintes mensagens: “Parabéns peso ideal”, “Engorde XXX
                    Kg”,“Emagreça XXX Kg” de acordo com a tabela abaixo:
                    Altura Peso      -   Ideal
                    Até 1.50         -   50 Kg
                    De 1.50 até 1.90 -   70 Kg
                    Acima de 1.90    -   100 Kg

            double altura = 0, peso = 0, diferenca = 0;

            Console.Write("Informe a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            if(altura <= 1.50)
            {
                diferenca = peso - 50;
            }
            else if(altura <= 1.90)
            {
                diferenca = peso - 70;
            }
            else
            {
                diferenca = peso - 100;
            }

            if(diferenca == 0)
            {
                Console.WriteLine("Peso Ideal!!!");
            }
            else if(diferenca < 0)
            {
                Console.WriteLine($"Engorde {diferenca * (-1)}");
            }
            else
            {
                Console.WriteLine($"Emagreça {diferenca}");
            }
            Console.ReadLine();*/

            /*029 - A - Cálculo IR:
                    Faça um programa que calcule o Imposto de renda de uma pessoa, considerando:
                    a) Para cada pessoa tem-se: Número de Dependentes e a Renda Bruta Anual;
                    b) O imposto é calculado segundo a tabela abaixo:
                    Renda Bruta Anual - % IR
                    até R$ 10.000,00                - isento
                    > R$ 10.000,00 até R$ 30.000,00 - 5 %
                    > R$ 30.000,00 até R$ 60.000,00 - 10 %
                    > R$ 60.000,00                  - 15 %
                    c) Há um desconto efetuado na renda bruta anual de R$ 600,00 para cada
                    dependente antes de efetuar o enquadramento na tabela.

            double renda_bruta_anual = 0, numero_dependente = 0, dependente = 0, renda_liquida_anual = 0, calculo = 0;

            Console.Write("Informe sua renda bruta anual: ");
            renda_bruta_anual = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o número de dependentes: ");
            numero_dependente = Convert.ToDouble(Console.ReadLine());

            dependente = numero_dependente * 600;
            calculo = renda_bruta_anual - dependente;

            if(renda_bruta_anual <= 10000)
            {
                Console.WriteLine("Isento de IR");
            }
            else if((renda_bruta_anual > 10000) && (renda_bruta_anual < 30000))
            {
                renda_liquida_anual = calculo - calculo * 5 / 100;
                Console.WriteLine($"A renda liquida anual é de R$ {renda_liquida_anual.ToString("N2")} com 5% de IR");
            }
            else if ((renda_bruta_anual > 30000) && (renda_bruta_anual < 60000))
            {
                renda_liquida_anual = calculo - calculo * 10 / 100;
                Console.WriteLine($"A renda liquida anual é de R$ {renda_liquida_anual.ToString("N2")} com 10% de IR");
            }
            else
            {
                renda_liquida_anual = calculo - calculo * 15 / 100;
                Console.WriteLine($"A renda liquida anual é de R$ {renda_liquida_anual.ToString("N2")} com 15% de IR");
            }
            Console.ReadLine();*/

            /*030 - Equacaosegundograu: Elabore um programa que permita achar as raízes de
                    uma equação do segundo grau da forma: ax2 + bx + c = 0.Serão recebidos os
                    coeficientes da equaçao(a, b e c).
                    ∆ = b2 – 4ac
                    Se ∆ > 0->X1 = (-b + √∆ ) / 2a
                    X2 = (-b - √∆ ) / 2a
                    Se ∆ = 0->X = -b / 2a
                    Se ∆ < 0->X = Indeterminada

            double a = 0, b = 0, c = 0, x = 0, x1 = 0, x2 = 0, delta = 0;

            Console.Write("Informe o valor de A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor de B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor de C: ");
            c = Convert.ToDouble(Console.ReadLine());

            delta = Math.Pow(b, 2) - (4 * a * c);

            if (delta > 0)
            {
                x1 = (-b + (Math.Sqrt(delta))) / (2 * a);
                x2 = (-b - (Math.Sqrt(delta))) / (2 * a);

                Console.WriteLine($"O valor de x1 é {x1.ToString("N2")} e o valor de x2 é {x2.ToString("N2")}");
            }
            else if(delta == 0)
            {
                x = -b / 2 * a;
                Console.WriteLine($"O valor de x é {x.ToString("N2")}");
            }
            else
            {
                Console.WriteLine("x = inderteminada.");
            }
            Console.ReadLine();*/
        }
    }
}
