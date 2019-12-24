using System;

namespace Exercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*001-SomarDoisNúmeros : Faça um algoritmo para receber dois
            números inteiros quaisquer, via teclado do computador, operar a soma
            algébrica entre eles e ao final exibir resultado da soma calculada.

            int v1 = 0, v2 = 0, soma = 0;

            Console.WriteLine("****************************");
            try
            {
                Console.Write("Informe o Primeiro Valor: ");
                v1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o Segundo Valor ");
                v2 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("===>*********ATENÇÃO************");
                Console.WriteLine("===>*ERRO NO FORMATO DOS VALORES");
                Console.WriteLine("===>*PROGRAMA SERÁ ENCERRADO   *");
                Console.WriteLine("===>****************************");
                Console.ReadLine();
                return;
            }
            soma = v1 + v2;
            Console.WriteLine($"A Soma calculada foi: {soma}");
            Console.ReadLine();

            ------------------------------------------------------------------------------

            002-Média_Aritmética_de_Tres_ Notas: Faça um algoritmo para receber três
            notas do tipo Real, calcular a média aritmética entre as notas recebidas e ao final
            exibir a média aritmética calculada.*/

            /*double n1 = 0, n2 = 0, n3 = 0, soma = 0, media = 0;

            try
            {
                Console.Write("Informe a primeira nota: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a segunda nota: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a terceira nota: ");
                n3 = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERRO ==> Valor inválido");
                Console.ReadLine();
                return;
            }
            soma = n1 + n2 + n3;
            media = soma / 3;
            Console.WriteLine($"A média das notas foi: {media}");
            Console.ReadLine();*/

            /*003 - Multa_Biblioteca: Faça um algoritmo para calcular o valor da multa a ser paga
            decorrente do atraso na entrega de livros. Receber via teclado a quantidade de dias de
            atraso em uma variável do tipo inteiro e o valor da multa diária em reais.Ao final
            calcular e exibir o valor a ser pago à biblioteca pela pessoa.

            int dias_atrasado = 0;
            double multa_por_dia = 0, valor_a_pagar = 0;

            try
            {
                Console.Write("Informe a quantidade de dias em atraso: ");
                dias_atrasado = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o valor da multa diária: ");
                multa_por_dia = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERRO ==> Valor inválido");
                Console.ReadLine();
                return;
            }
            valor_a_pagar = dias_atrasado * multa_por_dia;
            Console.WriteLine($"O valor a ser pago é de: {valor_a_pagar}");
            Console.ReadLine();*/

            /*004 - Média_Ponderada: Faça um algoritmo que receba via teclado três notas de um aluno da
                  Unibratec. Ao final calcule a média ponderada deste aluno sabendo que os pesos
                  são: 2, 3 e 5 respectivamente, e que a fórmula da Média Ponderada é dada pela equação abaixo.

            double n1 = 0, n2 = 0, n3 = 0, media_ponderada = 0;

            try
            {
                Console.Write("Informe a primeira nota: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a segunda nota: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a terceira nota: ");
                n3 = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERRO ==> Valor inválido");
                Console.ReadLine();
                return;
            }
            media_ponderada = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / (2 + 3 + 5);
            Console.WriteLine($"A média das notas foi: {media_ponderada}");
            Console.ReadLine();*/

            /*005 - Calculo_Salário_Líquido: Faça um algoritmo para calcular e exibir ao final o
            salário líquido de um determinado funcionário. Sabe - se que será informado por
            intermédio do teclado o salário base, as vantagens e os descontos.O salário líquido é
            obtido somando-se as vantagens ao salário base e abatendo-se os descontos.

            double salario_base = 0, vantagens = 0, desconto = 0, salario_liquido = 0;

            try
            {
                Console.Write("Informe o salario base: ");
                salario_base = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe o valor das vantagens: ");
                vantagens = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe o desconto: ");
                desconto = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERRO ==> Valor inválido");
                Console.ReadLine();
                return;
            }
            salario_liquido = salario_base + vantagens - desconto;

            Console.WriteLine($"O Salário líquido do funcionario é de: {salario_liquido}");
            Console.ReadLine();*/

            /*006 - Consumo: Sabendo - se que um veículo partiu para uma viagem com o tanque de
                  combustível cheio e com o marcador de quilometragem zerado. Ao chegar ao destino
                  completou o tanque, anotou distância percorrida e a quantidade de litros abastecidos.
                  Faça um algoritmo para receber via teclado a distância percorrida e a quantidade de
                  litros abastecidos. Informar a quantidade de km que o veículo percorreu com um litro de
                  combustível.*/

            /*int distancia_percorrida = 0, litros_abastecidos;
            double km_por_litro;

            try
            {
                Console.Write("Informe a distância percorrida: ");
                distancia_percorrida = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe a quantidade de litros abastecidos: ");
                litros_abastecidos = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERRO ==> Valor inválido");
                Console.ReadLine();
                return;
            }
            km_por_litro = distancia_percorrida / litros_abastecidos;

            Console.WriteLine($"A quantidade de KM por litro foi de: {km_por_litro}");
            Console.ReadLine();*/

            /*007 - Conversão_de_Horas: Faça um algoritmo que receba via teclado o tempo de
                  duração de um evento em uma fábrica expressa em segundos e mostre-o expresso em
                  horas, minutos e segundos.

            int hora = 0, minuto = 0, segundo = 0, duracao_de_evento = 0;

            try
            {
                Console.Write("Insira o tempo do evento em segundos: ");
                duracao_de_evento = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("ERRO ==> Valor inválido");
                Console.ReadLine();
                return;
            }
            hora = duracao_de_evento / 3600;
            minuto = (duracao_de_evento / 60) / 60;
            segundo = (duracao_de_evento / 3600) / 60;

            Console.WriteLine($"O evento ocorreu em {hora}:{minuto}:{segundo}");
            Console.ReadLine();*/

            /*008 - Rateio : A energia da área comum e a água consumida pelos moradores do Edifício
                  Prata Nobre é rateado entre os apartamentos.Escreva um algoritmo que receba a
                  quantidade de apartamentos, valor da conta de energia e valor da conta de água, calcule e
                  mostre o valor total que cada apartamento deve pagar;

            int apto = 0;
            double energia = 0, agua = 0, total = 0;

            try
            {
                Console.Write("Informe a quantidade de apartamentos: ");
                apto = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o valor da conta de energia: ");
                energia = Convert.ToDouble(Console.ReadLine());
                Console.Write("informe o valor da conta de água: ");
                agua = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERRO ==> Valor inválido");
                Console.ReadLine();
                return;
            }
            total = (energia + agua) / apto;

            Console.WriteLine($"O valor total de rateio para cada apartamento é de: {total}");
            Console.ReadLine();*/

            /* 009 - FaturamentoOnibus : Todos os ônibus de uma empresa de transportes anotam ao
                   sair e ao chegar na garagem o número registrado na catraca.Elabore um programa que
                   receba o Número inicial e final da catraca e a quantidade de VEM Estudantil recebidos ao
                   longo do dia.Sabendo - se que a passagem é de R$ 3,50 e que o valor de cada VEM é 50 %
                   do valor da passagem, calcule o faturamento do ônibus naquele dia.

            double passagem = 3.50, vem = 1.75, quantidade_vem = 0, catraca_inicial = 0, catraca_final = 0,total_passagem = 0, faturamento_vem = 0,faturamento_dinheiro = 0, faturamento_total = 0;

            try
            {
                Console.Write("Informe o valor da catraca inicial: ");
                catraca_inicial = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe o valor da catraca final: ");
                catraca_final = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a quantidade de usuarios de vem estudantil: ");
                quantidade_vem = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERRO ==> Valor inválido");
                Console.ReadLine();
                return;
            }
            total_passagem = catraca_final - catraca_inicial;
            faturamento_vem = quantidade_vem * vem;
            faturamento_dinheiro = (total_passagem - quantidade_vem) * passagem;
            faturamento_total = faturamento_dinheiro + faturamento_vem;

            Console.WriteLine($"O valor do faturamento total no dia foi de: {faturamento_total}");
            Console.ReadLine();*/

            /*010 - Semáforo : Sabendo - se que o estado de um semáforo muda a cada 40 segundos,
                  receba a hora inicial e final de um período e mostre a quantidade de vezes que o estado
                  do semáforo mudou neste período.Hora inicial e final deverão ser recebidas
                  separadamente, ou seja, HH,MM,SS.

            int hora_inicial = 0, hora_final = 0, minuto_inicial = 0, minuto_final = 0, segundo_inicial = 0, segundo_final = 0, quant_seg_inic = 0, quant_seg_fin = 0, diferenca = 0, trocas = 0;

            try
            {
                Console.Write("Informe a hora inicial: ");
                hora_inicial = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o minuto inicial: ");
                minuto_inicial = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o segundo inicial: ");
                segundo_inicial = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe a hora final: ");
                hora_final = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o minuto final: ");
                minuto_final = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o segundo final: ");
                segundo_final = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERRO ==> Valor inválido");
                Console.ReadLine();
                return;
            }
            quant_seg_inic = (hora_inicial * 3600) + (minuto_inicial * 60) + segundo_inicial;
            quant_seg_fin = (hora_final * 3600) + (minuto_final * 60) + segundo_final;
            diferenca = quant_seg_fin - quant_seg_inic;
            trocas = diferenca / 40;

            Console.WriteLine($"A quantidade de trocas foi de: {trocas}");
            Console.ReadLine();*/

            /*011 - Salario Líquido - IR - INSS: Faça um programa que receba por intermédio do teclado
                    o salário bruto(SB) de um funcionário em uma variável do tipo real, ou seja, a soma de
                    todas as verbas recebidas pelo funcionário em um mês(Salario, Horas-Extras, Comissões,
                    etc). Após o recebimento calcule e exiba os valores solicitados a seguir:
                    a)Descontos:
                    1.Imposto de Renda(IR) ➔ 5 % do Salário Bruto;
                    2.INSS(INSS) ➔ 11 % do Salário Bruto;
                    b) Salário Líquido(SL) ➔ SL = SB – (IR + INSS)

            double salario_bruto = 0, commissao = 0, IR = 0, INSS = 0, salario_liquido = 0, hora_extra = 0, salario = 0, hora_trabalhada = 0;

            try
            {
                Console.Write("Informe o valor do salario: ");
                salario = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a quantidade de horas extra: ");
                hora_extra = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe o valor da comissão: ");
                commissao = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERRO ==> Valor inválido");
                Console.ReadLine();
                return;
            }
            hora_trabalhada = salario * hora_extra / 220;
            salario_bruto = salario + hora_trabalhada + commissao;
            IR = salario_bruto * 5 / 100;
            INSS = salario_bruto * 11 / 100;
            salario_liquido = salario_bruto - IR - INSS;

            Console.WriteLine($"O salario liquido é de R$ {salario_liquido.ToString("N2")}");
            Console.ReadLine();*/

            /*012 - Percentuais_HomensxMulheres: Em um determinado concurso público são
                  informados as quantidades de candidatos presentes do sexo masculino e do sexo feminino,
                  bem como o total dos ausentes. Estes dados serão informados via teclado. Pede - se,
                  Calcular e exibir os dados abaixo:
                  a)O Percentual de Homens presentes em relação ao total de candidatos inscritos;
                  b)O Percentual dos Ausentes em relação ao total dos presentes.

            int candidato_homem = 0, candidato_mulher = 0, candidato_ausente = 0, total_candidato = 0;
            double porcentagem_homem = 0, total_participante = 0, porcentagem_ausente = 0;

            try
            {
                Console.Write("Informe o numero de candidatos do sexo masculino: ");
                candidato_homem = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o numero de candidatos do sexo feminino: ");
                candidato_mulher = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o numero de candidatos ausentes: ");
                candidato_ausente = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("ERRO ==> Valor inválido");
                Console.ReadLine();
                return;
            }

            total_participante = candidato_homem + candidato_mulher;
            total_candidato = candidato_mulher + candidato_homem + candidato_ausente;
            porcentagem_homem = candidato_homem * 100 / total_candidato;
            porcentagem_ausente = candidato_ausente * 100 / total_participante;

            Console.WriteLine($"A porcentagem de homens presentes em relação ao total de candidatos é de: {porcentagem_homem}");
            Console.WriteLine($"A porcentagem de ausentes em relação ao total de presentes é de {porcentagem_ausente}");
            Console.ReadLine()*/

            /*013 - Calculo quilowatt: Sabe - se que o quilowatt de energia custa um centésimo do
                 salário mínimo. Faça um programa que receba via teclado o valor do salário mínimo e a
                 quantidade de quilowatt consumido por uma residência. Calcule e exiba:
                 • O valor em reais, de cada quilowatt;
                 • O valor, em reais , a ser pago por essa residência;
                 • O novo valor a ser pago por essa residência, a partir de um desconto de 15 %

            double salario_minimo = 0, quant_quilowatt = 0, valor_quilowatt = 0, conta = 0, conta_desconto = 0;

            try
            {
                Console.Write("Informe o valor do salario minimo: ");
                salario_minimo = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a quantidade de quilowatt consumida: ");
                quant_quilowatt = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERRO ==> Valor inválido");
                Console.ReadLine();
                return;
            }
            valor_quilowatt = salario_minimo * 1 / 100;
            conta = quant_quilowatt * valor_quilowatt;
            conta_desconto = conta - (conta * 15 / 100);

            Console.WriteLine($"O valor de cada quilowatt custa R$ {valor_quilowatt.ToString("N2")}");
            Console.WriteLine($"O valor da conta é de R$ {conta.ToString("N2")}");
            Console.WriteLine($"Com o desconto de 15% a conta custará R$ {conta_desconto.ToString("N2")}");
            Console.ReadLine();*/

            /*014 - Custo Funcionário: Uma empresa tem para um determinado funcionário uma
                  ficha contendo o nome, número de horas trabalhadas e o nº de dependentes de um
                  funcionário.
                  Considerando que: A empresa paga 30 reais por hora , 100 reais por dependentes e
                  que sobre o salário bruto são feitos descontos de 8,5 % para o INSS e 5 % para IR.
                  Faça um programa para receber o nome, número de horas trabalhadas e número de
                  dependentes de um funcionário.Após o recebimento, escreva: o Nome, o salário bruto,
                  os valores descontados para cada tipo de imposto e finalmente qual o salário líquido do
                  funcionário.

            string nome = "";
            double numero_horas = 0, numero_dependente = 0, INSS = 0, IR = 0, salario_bruto = 0, salario_liquido = 0;

            try
            {
                Console.Write("Informe o nome do funcionario: ");
                nome = Console.ReadLine();
                Console.Write("Informe a quantidade de horas trabalhadas: ");
                numero_horas = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a quantidade de dependentes: ");
                numero_dependente = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERRO ==> Valor inválido");
                Console.ReadLine();
                return;
            }
            salario_bruto = (30 * numero_horas) + (numero_dependente * 100);
            INSS = salario_bruto * 8.5 / 100;
            IR = salario_bruto * 5 / 100;
            salario_liquido = salario_bruto - INSS - IR;

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"O salario bruto é de R$ {salario_bruto.ToString("N2")}");
            Console.WriteLine($"O valor descontado do INSS é de R$ {INSS.ToString("N2")}");
            Console.WriteLine($"O valor descontado do IR é de R$ {IR.ToString("N2")}");
            Console.WriteLine($"O salario liquido a receber é de R$ {salario_liquido.ToString("N2")}");
            Console.ReadLine();*/

            /*015 - Show ao Vivo : A empresa Show Life apresenta show ao vivo em qualquer local
                   que for solicitado.Cada show é cobrado por hora de apresentação mais um valor
                   cobrado conforme a distância(R$ 50, 00 por quilometro).A Show Life paga ao veículo,
                   que faz o transporte dos equipamentos e de pessoal, uma comissão de 35 % sobre o
                   valor cobrado pela distância.
                   Elabore um programa para receber os dados necessários, calcular e mostrar o valor
                   cobrado por um show e a comissão do transportador;

            double distancia = 0, valor_hora = 0, comissao = 0, cobrado = 0, duracao = 0;

            try
            {
                Console.Write("Informe a distancia do show a ser percorrida: ");
                distancia = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe o valor por hora cobrado pelo show: ");
                valor_hora = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a duração do show: ");
                duracao = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERRO ==> Valor inválido");
                Console.ReadLine();
                return;
            }
            cobrado = (50 * distancia) + (valor_hora * duracao);
            comissao = (50 * distancia) * 35 / 100;

            Console.WriteLine($"O valor cobrado pelo show foi de R$ {cobrado.ToString("N2")}");
            Console.WriteLine($"O valor pago de comissão foi de R$ {comissao.ToString("N2")}");
            Console.ReadLine();*/
        }
    }
}
