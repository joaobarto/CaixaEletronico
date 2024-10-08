// See https://aka.ms/new-console-template for more information
using System;


    
    
        bool termino = false;
        double depositoC, depositoP, saqueC, saqueP, transC, transP;
        double saldoC = 0;
        double saldoP = 0;
        string extratoC = "";
        string extratoP = "";

        while (!termino)
        {
            Console.Clear();
            Console.WriteLine("-----CAIXA ELETRONICO-----");
            Console.WriteLine("Selecione o Tipo de conta");
            Console.WriteLine("1 - Conta Corrente");
            Console.WriteLine("2 - Conta Poupança");
            Console.WriteLine("3 - Sair");

            if (!double.TryParse(Console.ReadLine(), out double tipoconta))
            {
                Console.WriteLine("Valor Inválido! Tente Novamente.");
                continue;
            }

            switch (tipoconta)
            {
                case 1: 
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Escolha uma opção:");
                        Console.WriteLine("1 - Depósito");
                        Console.WriteLine("2 - Saque");
                        Console.WriteLine("3 - Saldo");
                        Console.WriteLine("4 - Extrato");
                        Console.WriteLine("5 - Transferência");
                        Console.WriteLine("6 - Sair");

                        if (!double.TryParse(Console.ReadLine(), out double opçãoC))
                        {
                            Console.WriteLine("Valor Inválido! Tente Novamente.");
                            continue;
                        }

                        switch (opçãoC)
                        {
                            case 1:
                                Console.WriteLine("Valor do Depósito:");
                                if (!double.TryParse(Console.ReadLine(), out depositoC))
                                {
                                    Console.WriteLine("Valor Inválido! Tente Novamente.");
                                    continue;
                                }
                                saldoC += depositoC;
                                extratoC += $"Depósito: R${depositoC}\n";
                                break;

                            case 2:
                                Console.WriteLine("Valor do Saque:");
                                if (!double.TryParse(Console.ReadLine(), out saqueC))
                                {
                                    Console.WriteLine("Valor Inválido! Tente Novamente.");
                                    continue;
                                }
                                if (saqueC > saldoC)
                                {
                                    Console.WriteLine("Saldo Insuficiente! Tente Novamente.");
                                }
                                else
                                {
                                    saldoC -= saqueC;
                                    extratoC += $"Saque: R${saqueC}\n";
                                }
                                break;

                            case 3:
                                Console.WriteLine($"Saldo da Conta Corrente: R${saldoC}");
                                break;

                            case 4:
                                Console.WriteLine("Extrato:");
                                Console.WriteLine(extratoC);
                                break;

                            case 5:
                                Console.WriteLine("Valor da Transferência:");
                                if (!double.TryParse(Console.ReadLine(), out transC))
                                {
                                    Console.WriteLine("Valor Inválido! Tente Novamente.");
                                    continue;
                                }
                                if (transC > saldoC)
                                {
                                    Console.WriteLine("Saldo Insuficiente para Transferência! Tente Novamente.");
                                }
                                else
                                {
                                    saldoC -= transC;
                                    extratoC += $"Transferência: R${transC}\n";
                                }
                                break;

                            case 6:
                                goto case 3; // Sair do gerenciamento da conta corrente

                            default:
                                Console.WriteLine("Opção Inválida! Tente Novamente.");
                                break;
                        }
                    }

                case 2:
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Escolha uma opção:");
                        Console.WriteLine("1 - Depósito");
                        Console.WriteLine("2 - Saque");
                        Console.WriteLine("3 - Saldo");
                        Console.WriteLine("4 - Extrato");
                        Console.WriteLine("5 - Transferência");
                        Console.WriteLine("6 - Sair");

                        if (!double.TryParse(Console.ReadLine(), out double opçãoP))
                        {
                            Console.WriteLine("Valor Inválido! Tente Novamente.");
                            continue;
                        }

                        switch (opçãoP)
                        {
                            case 1:
                                Console.WriteLine("Valor do Depósito:");
                                if (!double.TryParse(Console.ReadLine(), out depositoP))
                                {
                                    Console.WriteLine("Valor Inválido! Tente Novamente.");
                                    continue;
                                }
                                saldoP += depositoP;
                                extratoP += $"Depósito: R${depositoP}\n";
                                break;

                            case 2:
                                Console.WriteLine("Valor do Saque:");
                                if (!double.TryParse(Console.ReadLine(), out saqueP))
                                {
                                    Console.WriteLine("Valor Inválido! Tente Novamente.");
                                    continue;
                                }
                                if (saqueP > saldoP)
                                {
                                    Console.WriteLine("Saldo Insuficiente! Tente Novamente.");
                                }
                                else
                                {
                                    saldoP -= saqueP;
                                    extratoP += $"Saque: R${saqueP}\n";
                                }
                                break;

                            case 3:
                                Console.WriteLine($"Saldo da Conta Poupança: R${saldoP}");
                                break;

                            case 4:
                                Console.WriteLine("Extrato:");
                                Console.WriteLine(extratoP);
                                break;

                            case 5:
                                Console.WriteLine("Valor da Transferência:");
                                if (!double.TryParse(Console.ReadLine(), out transP))
                                {
                                    Console.WriteLine("Valor Inválido! Tente Novamente.");
                                    continue;
                                }
                                if (transP > saldoP)
                                {
                                    Console.WriteLine("Saldo Insuficiente para Transferência! Tente Novamente.");
                                }
                                else
                                {
                                    saldoP -= transP;
                                    extratoP += $"Transferência: R${transP}\n";
                                }
                                break;

                            case 6:
                                goto case 3; // Sair do gerenciamento da conta poupança

                            default:
                                Console.WriteLine("Opção Inválida! Tente Novamente.");
                                break;
                        }
                    }

                case 3:
                    Console.WriteLine("Obrigado!");
                    termino = true;
                    break;

                default:
                    Console.WriteLine("Opção Inválida! Tente Novamente.");
                    break;
            }
        }
    
