// <copyright file="TaxableIncomeOrchestrator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Orchestrators;

using Interfaces.IncomeTaxQuery;
using FinancialYearModels;
using Interfaces;

/// <summary>
/// The main orchestrator.
/// </summary>
public class TaxableIncomeOrchestrator
{
    private readonly InputCollector inputCollector;
    private readonly InputValidator inputValidator;
    private readonly IncomeQuery incomeQuery;

    /// <summary>
    /// Initializes a new instance of the <see cref="TaxableIncomeOrchestrator"/> class.
    /// </summary>
    public TaxableIncomeOrchestrator()
    {
        this.inputCollector = new InputCollector();
        this.inputValidator = new InputValidator();
        this.incomeQuery = new IncomeQuery();
    }

    /// <summary>
    /// Instructs the orchestrator to execute a run for the year 2024.
    /// </summary>
    public void Execute2024Run()
    {
        FinancialYear2024InputModel financialYear2024InputModel;

        // Get input and validate it.
        do
        {
            financialYear2024InputModel = this.inputCollector.Get2024Inputs();
        }
        while (!this.inputValidator.ValidateInputModel(financialYear2024InputModel));

        // At this point we know have valid input.

        // Assemble request.
        var request = new IncomeQueryRequest(financialYear2024InputModel.ValidatedIncome, financialYear2024InputModel.ValidatedPayFrequency);

        // Send request to command.
        var response = this.incomeQuery.Execute(request);

        // Log the output.
        this.LogOutput(response);
    }

    /// <summary>
    /// Takes in a response and logs all output.
    /// </summary>
    /// <param name="incomeQueryResponse">An instance of a <see cref="IncomeQueryResponse"/>.</param>
    private void LogOutput(IncomeQueryResponse incomeQueryResponse)
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"Gross Package: ${incomeQueryResponse.GrossPackage:0,000.00}");
        Console.WriteLine($"Super: ${incomeQueryResponse.SuperContribution:0,000.00}");
        Console.WriteLine($"Taxable income: ${incomeQueryResponse.TaxableSalary:0,000.00}");

        Console.WriteLine(incomeQueryResponse.MedicareLevyChargeRequired
            ? $"Medicare Levy: ${incomeQueryResponse.MedicareLevy:0,000.00}"
            : $"Medicare Levy not charged.");

        Console.WriteLine(incomeQueryResponse.BudgetRepairLevyRequired
            ? $"Budget Repair Levy: ${incomeQueryResponse.BudgetRepairLevy:0,000.00}"
            : $"Budget Repair Levy not charged.");

        Console.WriteLine($"Income Tax: ${incomeQueryResponse.IncomeTax:0,000.00}");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"Net income: ${incomeQueryResponse.NetIncome:0,000.00}");
        Console.WriteLine($"Net income: ${incomeQueryResponse.PayPacket:0,000.00} {incomeQueryResponse.PayFrequency}");
        Console.WriteLine("-----------------------------------------");
    }
}