// <copyright file="TaxableIncomeOrchestrator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Orchestrators;

using TaxableIncome.Application.Interfaces;

/// <summary>
/// The main orchestrator.
/// </summary>
public class TaxableIncomeOrchestrator
{
    private readonly InputCollector inputCollector;
    private readonly InputValidator inputValidator;

    /// <summary>
    /// Initializes a new instance of the <see cref="TaxableIncomeOrchestrator"/> class.
    /// </summary>
    public TaxableIncomeOrchestrator()
    {
        this.inputCollector = new InputCollector();
        this.inputValidator = new InputValidator();
    }

    /// <summary>
    /// Instructs the orchestrator to execute a run for the year 2024.
    /// </summary>
    public void Execute2024Run()
    {
        // Get input
        var userInput = this.inputCollector.Get2024Inputs();

        // Validate Input
        var inputValid = this.inputValidator.ValidateInputModel(userInput);
    }
}