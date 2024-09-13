// <copyright file="IncomeTaxCalculatorTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.UnitTests.Interfaces;

using TaxableIncome.Application.Interfaces;

/// <summary>
/// Tests for the <see cref="InputValidator"/> class.
/// </summary>
public class IncomeTaxCalculatorTests : BaseUnitTests
{
    /// <summary>
    /// Take in the data from the assignment sheet and use them as unit test input data.
    /// </summary>
    /// <param name="income">The example income.</param>
    /// <param name="expectedTax">The expected payable tax for that income.</param>
    [Theory]
    [InlineData(155.00, 0.00)]
    [InlineData(25000.00, 1292.00)]
    [InlineData(95000.00, 22782.00)]
    [InlineData(200000.00, 63632.00)]
    public void IncomeTaxCalculator_Get2018IncomeTax_ReturnsExpectedAmounts(decimal income, decimal expectedTax)
    {
        var result = this.IncomeTaxCalculator.Get2018IncomeTax(income);
        Assert.Equal(expectedTax, result);
    }
}