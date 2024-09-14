// <copyright file="BaseUnitTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.UnitTests;

using TaxableIncome.Application.Interfaces;
using TaxableIncome.Application.Interfaces.IncomeTaxQuery;

/// <summary>
/// The base class for unit tests in this project.
/// </summary>
public abstract class BaseUnitTests
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseUnitTests"/> class.
    /// </summary>
    protected BaseUnitTests()
    {
        this.InputValidator = new InputValidator();
        this.MedicareLevyCalculator = new MedicareLevyCalculator();
        this.IncomeTaxCalculator = new IncomeTaxCalculator();
        this.IncomeTaxCalculator = new IncomeTaxCalculator();
        this.IncomeQuery = new IncomeQuery();
    }

    /// <summary>
    /// Gets the instance of the input validation class for these tests.
    /// </summary>
    public InputValidator InputValidator { get; }

    /// <summary>
    /// Gets the levy calculator for tests.
    /// </summary>
    public MedicareLevyCalculator MedicareLevyCalculator { get; }

    /// <summary>
    /// Gets the IncomeTaxCalculator calculator for tests.
    /// </summary>
    public IncomeTaxCalculator IncomeTaxCalculator { get; }

    /// <summary>
    /// Gets the IncomeQuery instance for tests.
    /// </summary>
    public IncomeQuery IncomeQuery { get; }
}