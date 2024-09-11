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

    /// <summary>
    /// Initializes a new instance of the <see cref="TaxableIncomeOrchestrator"/> class.
    /// </summary>
    public TaxableIncomeOrchestrator()
    {
        this.inputCollector = new InputCollector();
    }
}