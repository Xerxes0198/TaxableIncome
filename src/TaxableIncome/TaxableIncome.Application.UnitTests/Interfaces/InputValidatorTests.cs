// <copyright file="InputValidatorTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.UnitTests.Interfaces;

using TaxableIncome.Application.Interfaces;

/// <summary>
/// Tests for the <see cref="InputValidator"/> class.
/// </summary>
public class InputValidatorTests : BaseUnitTests
{
    /// <summary>
    /// Ensures that any instance of a value provided as a string is properly converted into the expected float.
    /// </summary>
    /// <param name="expectedValue">The value we expect for the given string.</param>
    /// <param name="currencyString">The string from which we expect the above value.</param>
    [Theory]
    [InlineData(0.50, "$000.500")]
    [InlineData(5.50, "$5.50.22")]
    [InlineData(5.20, "$5.2000.22.55")]
    [InlineData(123.99, "$000,123.99")]
    [InlineData(123.99, "000,123.99")]
    [InlineData(9999.01, "9999.01")]
    [InlineData(12.55, "Monies $$12.55cents")]
    public void InputValidationTest_StrippedCurrencyString_ReturnsExpectedFloat(decimal expectedValue, string currencyString)
    {
        var strippedValue = this.InputValidator.StrippedCurrencyString(currencyString);
        Assert.Equal(expectedValue, strippedValue);
    }

    /// <summary>
    /// When passed gibberish, we expect a format exception.
    /// </summary>
    [Fact]
    public void InputValidationTest_StrippedCurrencyString_ThrowsException()
    {
        Assert.Throws<FormatException>(() => this.InputValidator.StrippedCurrencyString("dgdbcvbxcfg"));
    }
}