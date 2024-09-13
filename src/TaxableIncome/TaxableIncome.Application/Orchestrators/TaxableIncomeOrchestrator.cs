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
    }
}