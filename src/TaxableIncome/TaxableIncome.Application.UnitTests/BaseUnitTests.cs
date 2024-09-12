// <copyright file="BaseUnitTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.UnitTests;

using TaxableIncome.Application.Interfaces;

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
        this.LevyCalculator = new LevyCalculator();
    }

    /// <summary>
    /// Gets the instance of the input validation class for these tests.
    /// </summary>
    public InputValidator InputValidator { get; }

    /// <summary>
    /// Gets the levy calculator for tests.
    /// </summary>
    public LevyCalculator LevyCalculator { get; }
}