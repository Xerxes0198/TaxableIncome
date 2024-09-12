// <copyright file="IncomeTaxRequest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Interfaces.IncomeTaxCalculator;

using Classes;

/// <summary>
/// The request object for the <see cref="IncomeTaxCalculatorCommand"/> command.
/// </summary>
public class IncomeTaxRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IncomeTaxRequest"/> class.
    /// </summary>
    /// <param name="income">The income for this request.</param>
    /// <param name="payFrequency">The pay frequency for this request.</param>
    public IncomeTaxRequest(decimal income, PayFrequency payFrequency)
    {
        this.Income = income;
        this.PayFrequency = payFrequency;
    }

    /// <summary>
    /// Gets the income for this request.
    /// </summary>
    public decimal Income { get; private set; }

    /// <summary>
    /// Gets the pay frequency for this request.
    /// </summary>
    public PayFrequency PayFrequency { get; private set; }
}