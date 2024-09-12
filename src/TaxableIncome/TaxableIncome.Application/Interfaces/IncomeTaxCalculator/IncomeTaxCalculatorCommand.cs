// <copyright file="IncomeTaxCalculatorCommand.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Interfaces.IncomeTaxCalculator;

using TaxableIncome.Application.Constants.TaxConstants;

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
        // Calculate Super
        var taxableSalary = incomeTaxRequest.Income / (1 + FinancialYear2018Constants.SuperPercentage);
        var superContribution = taxableSalary * FinancialYear2018Constants.SuperPercentage;

        // Calculate medicare levy
        var medicareLevy = LevyCalculator.Get2018Levy(taxableSalary);

        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"Gross Package: ${incomeTaxRequest.Income:0,000.00}");
        Console.WriteLine($"Super: ${superContribution:0,000.00}");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"Taxable income: ${taxableSalary:0,000.00}");
        Console.WriteLine($"Medicare Levy: ${medicareLevy:0,000.00}");

        return new IncomeTaxResponse();
    }
}