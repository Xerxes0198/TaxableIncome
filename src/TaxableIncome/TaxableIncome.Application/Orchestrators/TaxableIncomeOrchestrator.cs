// <copyright file="TaxableIncomeOrchestrator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Orchestrators;

using Interfaces.IncomeTaxCalculator;
using FinancialYearModels;
using Interfaces;

/// <summary>
/// The main orchestrator.
/// </summary>
public class TaxableIncomeOrchestrator
{
    private readonly InputCollector inputCollector;
    private readonly InputValidator inputValidator;
    private readonly IncomeTaxCalculatorCommand incomeTaxCalculatorCommand;

    /// <summary>
    /// Initializes a new instance of the <see cref="TaxableIncomeOrchestrator"/> class.
    /// </summary>
    public TaxableIncomeOrchestrator()
    {
        this.inputCollector = new InputCollector();
        this.inputValidator = new InputValidator();
        this.incomeTaxCalculatorCommand = new IncomeTaxCalculatorCommand();
    }

    /// <summary>
    /// Instructs the orchestrator to execute a run for the year 2024.
    /// </summary>
    public void Execute2024Run()
    {
        var financialYear2024InputModel = new FinancialYear2024InputModel();

        // Loop until we get valid input.
        do
        {
            // Get input
            financialYear2024InputModel = this.inputCollector.Get2024Inputs();
        }
        while (!this.inputValidator.ValidateInputModel(financialYear2024InputModel));

        // At this point we have valid input. Call command
        var request = new IncomeTaxRequest(financialYear2024InputModel.ValidatedIncome, financialYear2024InputModel.ValidatedPayFrequency);
        var response = this.incomeTaxCalculatorCommand.Execute(request);
    }
}