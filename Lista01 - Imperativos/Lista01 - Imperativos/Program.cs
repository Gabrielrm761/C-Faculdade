using System;

namespace Lista01___Imperativos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.Faça um algoritmo que receba dois números e ao final mostre a soma,
                subtração, multiplicação e a divisão dos números lidos. 

            double a = 0, b = 0, soma = 0, sub = 0, mult = 0, div = 0;

            Console.Write("Informe o valor de A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor de B: ");
            b = Convert.ToDouble(Console.ReadLine());

            soma = a + b;
            sub = a - b;
            mult = a * b;
            div = a / b;

            Console.WriteLine($"soma: {soma} / subtração: {sub} / multiplicação: {mult} / divisão: {div}");
            Console.ReadLine();*/

            /*2.Ler dois valores para as variáveis A e B, e efetuar as trocas dos valores
                de forma que a variável A passe a possuir o valor da variável B e a
                variável B passe a possuir o valor da variável A. Apresentar os valores
                trocados.

            double a = 0, b = 0, aux = 0;

            Console.Write("Informe o valor de A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor de B: ");
            b = Convert.ToDouble(Console.ReadLine());

            aux = a;
            a = b;
            b = aux;

            Console.WriteLine($"A = {a} e B = {b}");
            Console.ReadLine();*/

            /*3.Ler uma temperatura em graus Celsius e apresentá - la convertida em
                graus Fahrenheit. A fórmula de conversão é: F = (9 * C + 160) / 5, sendo F a
                temperatura em Fahrenheit e C a temperatura em Celsius. 
            double c = 0, f = 0;

            Console.Write("Informe a temperatura em Celsius: ");
            c = Convert.ToDouble(Console.ReadLine());

            f = (9 * c + 100) / 5;

            Console.WriteLine($"{c} °C convertido fica {f} °F");
            Console.ReadLine();*/

            /*4.Elaborar um algoritmo que efetue a apresentação do valor da conversão
                em real(R$) de um valor lido em dólar(US$). O algoritmo deverá solicitar
                o valor da cotação do dólar e também a quantidade de dólares disponíveis
                com o usuário. 

            double cotacao_dolar = 0, quantidade_dolar = 0, real = 0;

            Console.Write("Informe a contação do Dolar: ");
            cotacao_dolar = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a quantidade de Dolares: ");
            quantidade_dolar = Convert.ToDouble(Console.ReadLine());

            real = cotacao_dolar * quantidade_dolar;

            Console.WriteLine($"A conversão resultou em R$ {real.ToString("N2")}");
            Console.ReadLine();*/

            /*5.Faça um algoritmo que receba um valor que foi depositado e exiba o valor
                com rendimento após um mês. Considere fixo o juro da poupança em
                0,50 % a.m

            double deposito = 0, rendimento = 0;

            Console.Write("Informe o valor depositado: ");
            deposito = Convert.ToDouble(Console.ReadLine());

            rendimento = deposito + (deposito * 0.5 / 100);

            Console.WriteLine($"O rendimento é de R$ {rendimento.ToString("N2")} ao mês.");
            Console.ReadLine();*/

            /*6.A Loja Mamão com Açúcar está vendendo seus produtos em 5(cinco)
                prestações sem juros.Faça um algoritmo que receba um valor de uma
                compra e mostre o valor das prestações. 

            double valor_da_compra = 0, valor_da_pretacao = 0;

            Console.Write("Informe o valor da compra: ");
            valor_da_compra = Convert.ToDouble(Console.ReadLine());

            valor_da_pretacao = valor_da_compra / 5;

            Console.WriteLine($"O valor do produto fica R$ {valor_da_pretacao.ToString("N2")} por mês.");
            Console.ReadLine();*/

            /*7.Faça um algoritmo que receba o preço de custo de um produto e mostre o
                valor de venda.Sabe - se que o preço de custo receberá um acréscimo de
                acordo com um percentual informado pelo usuário.

            double custo_produto = 0, acrescimo = 0, valor_Venda = 0;            Console.Write("Informe o preço de custo do produto: ");
            custo_produto = Convert.ToDouble(Console.ReadLine());            Console.Write("Informe o valor de acréscimo: ");
            acrescimo = Convert.ToDouble(Console.ReadLine());            valor_Venda = custo_produto + (custo_produto * acrescimo / 100);            Console.WriteLine($"O reajuste ficará em R$ {valor_Venda.ToString("N2")}");            Console.ReadLine();*/

            /*8.Escrever um algoritmo que leia o nome de um vendedor, o seu salário fixo
                e o total de vendas efetuadas por ele no mês(em dinheiro). Sabendo que
                este vendedor ganha 15 % de comissão sobre suas vendas efetuadas,
                informar o seu nome, o salário fixo e salário no final do mês.

            string nome = "";            double salario_fixo = 0, total_venda_em_dinheiro = 0, total_venda = 0, salario_final, comissao = 0;            Console.Write("Informe o nome do vendedor: ");
            nome = Console.ReadLine();            Console.Write("Informe o salário fixo: ");
            salario_fixo = Convert.ToDouble(Console.ReadLine());            Console.Write("Informe o total de vendas em dinheiro: ");
            total_venda_em_dinheiro = Convert.ToDouble(Console.ReadLine());            Console.Write("Informe o total de vendas: ");
            total_venda = Convert.ToDouble(Console.ReadLine());

            comissao = total_venda * 15 / 100;
            salario_final = salario_fixo + comissao;

            Console.WriteLine($"O salário de {nome} é R$ {salario_fixo.ToString("N2")} + a comissão de R$ {comissao.ToString("N2")} torna o salário final de R$ {salario_final.ToString("N2")}");
            Console.ReadLine();*/

            /*10.O custo ao consumidor de um carro novo é a soma do custo de fábrica
                com a percentagem do distribuidor e dos impostos(aplicados, primeiro
                os impostos sobre o custo de fábrica, e depois a percentagem do
                distribuidor sobre o resultado). Supondo que a percentagem do
                distribuidor seja de 28 % e os impostos 45 %.Escrever um algoritmo
                que leia o custo de fábrica de um carro e informe o custo ao
                consumidor do mesmo.

            double custo_fabrica = 0, custo_carro = 0, imposto = 0.45, distribuidor = 0.28;

            Console.Write("Informe o custo de fábrica: ");
            custo_fabrica = Convert.ToDouble(Console.ReadLine());

            custo_carro = custo_fabrica + (custo_fabrica * imposto * distribuidor);

            Console.WriteLine($"O valor do carro é de R$ {custo_carro.ToString("N2")}");
            Console.ReadLine();*/

            /*11.Faça um algoritmo que leia a idade de uma pessoa expressa em dias e
                mostre - a expressa em anos, meses e dias.

            int idade = 0, ano = 0, mes = 0, dia = 0;

            Console.Write("Informe o salário fixo: ");
            idade = Convert.ToInt32(Console.ReadLine());

            ano = idade * 1;
            mes = idade * 12;
            dia = idade * 365;

            Console.Write($"Anos: {ano} / Mêses: {mes} / Dias: {dia} ");
            Console.ReadLine();*/

            /*12.Dado um número inteiro, positivo, menor do que 1000 obter a
                 quantidade de centenas, dezenas e unidades desse número.
                 Exemplo: Dado o nº 764, obter Centena = 7, Dezena = 6 e Unidade = 4

            string numero = "", centena = "", dezena = "", unidade = "";

            Console.Write("Informe um número: ");
            numero = Console.ReadLine();

            centena = numero.Substring(0,1);
            dezena = numero.Substring(1,1);
            unidade = numero.Substring(2, 1);

            Console.WriteLine($"Centena: {centena} / Dezena: {dezena} / Unidade = {unidade} ");
            Console.ReadLine();*/

        }
    }
}
