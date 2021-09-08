# PortifolioTrades
Question 2
Answer : 
1 - Create IsPoliticallyExposed property at ITrade
2 - Implement property at Trade class
3 - Create a new class called CategoryPEP from ICategory and implement the rule IsPoliticallyExposed is true
4 - Analyse the new rule of category precedence and  add new instance of Category PEP on service constructor (Category Service)


Problema: categorizar as negociações na carteira de um banco
Um banco tem uma carteira de milhares de negócios e eles precisam ser categorizados. 
Um TRADE é uma negociação comercial
entre um banco e um cliente. Uma negociação tem muitas características, incluindo:

interface ITrade
{
 
 double Valor { get; } //Valor da transação
 string SetorCliente { get; } //Setor do cliente, 'Publico' ou  'Privado'
 DateTime ProximaDataPagamento { get; } //Indica quando será o proximo dia do pagamento do cliente ao banco
 
}

Atualmente, existem três categorias (em ordem de precedência):
1. INADIMPLENTE: Negociações cuja próxima data de pagamento está atrasada em mais de 30 dias com base em uma data de referência que
será dado.
2. ALTORISCO: Negócios com valor superior a 1.000.000 e cliente do Setor Privado.
3. MEDIORISCO: Negócios com valor superior a 1.000.000 e cliente do Setor Público

Pergunta 1: 

Escreva um aplicativo de console C # usando design orientado a objetos que classifica todas as negociações em um determinado portfólio.
Seu design deve ser extensível porque as categorias serão adicionadas / removidas / modificadas no futuro.

Input
A primeira linha da entrada é a data de referência. A segunda linha contém um inteiro n, o número de negociações
na carteira. As próximas n linhas contêm 3 elementos cada (separados por um espaço). Primeiro um double que
representa o valor da negociação, segundo uma string que representa o setor do cliente e terceiro uma data que representa
o próximo pagamento pendente. 

Todas as datas estão no formato mm / dd / aaaa.

Output
N linhas com a categoria de cada uma das n negociações.

Exemplo de entrada
11/12/2020
4
2000000 Privado 29/12/2025
400000 Público 01/07/2020
5000000 Público 01/02/2024
3000000 Público 26/10/2023

Saída
ALTO RISCO
PADRONIZADAS
RISCO MÉDIO
RISCO MÉDIO

Questão 2: 

Foi criada uma nova categoria chamada PEP (pessoa politicamente exposta). Além disso, uma nova propriedade bool
IsPoliticallyExposed foi criado na interface ITrade. 
Uma negociação deve ser categorizada como PEP se IsPoliticallyExposed é verdadeiro. 

Descreva em no máximo 1 parágrafo o que você deve fazer em seu projeto para dar conta deste
nova categoria.