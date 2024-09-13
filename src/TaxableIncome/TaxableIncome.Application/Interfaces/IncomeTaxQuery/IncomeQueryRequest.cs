// <copyright file="IncomeQueryRequest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Interfaces.IncomeTaxQuery;

using Enums;

/// <summary>
/// The request object for the <see cref="IncomeQuery"/> command.
/// </summary>
public class IncomeQueryRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IncomeQueryRequest"/> class.
    /// </summary>
    /// <param name="income">The income for this request.</param>
    /// <param name="payFrequency">The pay frequency for this request.</param>
    public IncomeQueryRequest(decimal income, PayFrequency payFrequency)
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