// <copyright file="IncomeTaxCalculatorCommand.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Interfaces.IncomeTaxCalculator;

/// <summary>
/// The income tax calculator command.
/// </summary>
public class IncomeTaxCalculatorCommand
{
    /// <summary>
    /// Executes this command.
    /// </summary>
    /// <param name="incomeTaxRequest">The given <see cref="IncomeTaxRequest"/> object for this tax calculations.</param>
    /// <returns>A populated version of <see cref="IncomeTaxResponse"/>.</returns>
    public IncomeTaxResponse Execute(IncomeTaxRequest incomeTaxRequest)
    {
        return new IncomeTaxResponse();
    }
}