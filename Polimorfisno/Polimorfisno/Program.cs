using System;
using Milhagem.Entities;
using Milhagem.Entities.Enums;
using Milhagem.Services;
using System.Collections.Generic;
using System.Globalization;

namespace Milhagem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Preencha os dados do cliente: ");
            //Dados da classe pessoa
            
            try
            {
                List<Pessoa> listPessoa = new List<Pessoa>();
                bool preencherDados = true;
                while (preencherDados)
                {
                    Console.Write("Digite o id da pessoa: ");
                    string id = Console.ReadLine();

                    Console.Write("Digite o nome da pessoa: ");
                    string nome = Console.ReadLine();

                    Console.Write("Digite o sobrenome da pessoa: ");
                    string sobrenome = Console.ReadLine();

                    Console.Write("Digite o endereço da pessoa: ");
                    string endereco = Console.ReadLine();

                    Console.Write("Digite o telefone da pessoa: ");
                    string telefone = Console.ReadLine();

                    Console.Write("Digite o saldo de pontos: ");
                    int pontos = int.Parse(Console.ReadLine());


                    Console.Write("Digite o tipo da pessoa: ");
                    string pessoa = Console.ReadLine();
                    TipoPessoa tipopessoa = Enum.Parse<TipoPessoa>(pessoa.ToString());

                    
                    Console.Write("Preencha o status: ");
                    int status = int.Parse(Console.ReadLine());

                    Console.Write("Escolha a moeda para pagamento: ");
                    string moeda = Console.ReadLine();
                    
                    Console.Write("Digite o valor da passagem: ");
                    double valorPassagem = double.Parse(Console.ReadLine().ToString(), CultureInfo.InvariantCulture);

                    CotacaoService service = null;
                   
                    switch (moeda)
                    {
                        case "Real":
                            CotacaoService cotacaoR = new CotacaoService(new CotacaoRealService());
                            service = cotacaoR;
                            break;

                        case "Peso":
                            CotacaoService cotacaoA = new CotacaoService(new CotacaoArgentinaService());
                            service = cotacaoA;
                            break;

                        case "Dolar":
                            CotacaoService cotacaoD = new CotacaoService(new CotacaoUsaService());
                            service = cotacaoD;
                            break;

                        default:
                            Console.WriteLine("Impossível aplicar desconto para a moeda selecionada.");
                            break;
                    }

                    if (service != null)
                    {
                        service.tipoMoeda(valorPassagem);
                        Console.WriteLine(service);
                    }

                    //Passamos a operação cliente vip e tamanho do cpf para o serviço
                    //OperationsService operationsService = new OperationsService();
                    //Usando a interface
                    IOperationsService iOperationsService = new OperationsService();
                    if (tipopessoa == TipoPessoa.Fisica)
                    {
                        Console.Write("Digite o cpf: ");
                        string cpf = Console.ReadLine();
                        
                        while (!iOperationsService.tamanhoCpf(cpf))
                        {
                            Console.WriteLine("O tamanho do cpf é inválido.");
                            cpf = Console.ReadLine();
                        }

                        PessoaFisica pessoaFisica = new PessoaFisica();
                        
                        Console.Write("É funcionário? ");
                        char func = char.Parse(Console.ReadLine());

                        if (iOperationsService.clienteVip(pontos))
                        {
                            if (iOperationsService.Funcionario(func))
                            {
                                pessoaFisica.Pontos += 50;
                            }
                        }
                       
                        listPessoa.Add(new PessoaFisica(cpf, id, nome, sobrenome, endereco, telefone, pessoa, pontos));
                        
                       
                    }
                    else if (tipopessoa == TipoPessoa.Juridica)
                    {
                        Console.Write("Digite o cnpj: ");
                        string cnpj = Console.ReadLine();
                        
                        listPessoa.Add(new PessoaJuridica(cnpj, id, nome, sobrenome, endereco, telefone, pessoa, pontos));
                       
                        
                    }
                    Console.Write("Incluir novo cliente? ");
                    char incluir = char.Parse(Console.ReadLine());
                    if (incluir == 'N')
                    {
                        preencherDados = false;
                    }

                }
                
                Console.WriteLine();
                Console.WriteLine("Imprimindo pessoas físicas da lista:");
                foreach (PessoaFisica item in listPessoa)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();
                
            }
            catch (Exception ex)
            {

                if (ex.Message == "Input string was not in a correct format.")
                {
                    Console.WriteLine("Tipo de dado inválido!");

                }
                else if (ex.Message.Contains("was not found."))
                {

                    Console.WriteLine("Tipo de dado inválido!");

                }

            }

            finally
            {
                Console.ReadLine();
            }



        }
    }
}
