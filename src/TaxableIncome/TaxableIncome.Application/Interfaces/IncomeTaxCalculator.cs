// <copyright file="IncomeTaxCalculator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Interfaces;

using System.Data;

/// <summary>
/// This class holds some basic income tax functions.
/// </summary>
public class IncomeTaxCalculator
{
    private DataTable incomeTaxTable;

    public IncomeTaxCalculator()
    {
        this.incomeTaxTable = new DataTable();

        this.incomeTaxTable.Columns.Add("IncomeRange", typeof(decimal));
        this.incomeTaxTable.Columns.Add("MinTaxAmount", typeof(decimal));
        this.incomeTaxTable.Columns.Add("TaxPercentage", typeof(decimal));
        this.incomeTaxTable.Columns.Add("Excess", typeof(decimal));

        // Populate the tax table. The final row is 0 income range as it is the final row and has no upper limit.
        this.incomeTaxTable.Rows.Add(18201M,   0.00M,   0.00M,    0.00M);
        this.incomeTaxTable.Rows.Add(37001M,   0.00M,   0.19M,   18200M);
        this.incomeTaxTable.Rows.Add(87001M,   3572M,  0.325M,   37000M);
        this.incomeTaxTable.Rows.Add(180001M, 19822M,   0.37M,   87000M);
        this.incomeTaxTable.Rows.Add(0.00M,   54232M,   0.47M,  180000M);
    }

    /// <summary>
    /// Get the calculated income tax payable from an income for the financial year 2018.
    /// </summary>
    /// <param name="income">The income.</param>
    /// <returns>The calculated return.</returns>
    public decimal Get2018IncomeTax(decimal income)
    {
        decimal currentTaxPercentage = 0.00M;
        decimal currentExcess = 0.00M;
        decimal currentMinTaxAmount = 0.00M;

        // Get current tax bracket:
        for (var i = 0; i < this.incomeTaxTable.Rows.Count; i++)
        {
            if (income < (decimal)this.incomeTaxTable.Rows[i]["IncomeRange"])
            {
                currentTaxPercentage = (decimal)this.incomeTaxTable.Rows[i]["TaxPercentage"];
                currentExcess = (decimal)this.incomeTaxTable.Rows[i]["Excess"];
                currentMinTaxAmount = (decimal)this.incomeTaxTable.Rows[i]["MinTaxAmount"];
                break;
            }

            // If we get here, we know the user must be in the last tax bracket.
            currentTaxPercentage = (decimal)this.incomeTaxTable.Rows[this.incomeTaxTable.Rows.Count - 1]["TaxPercentage"];
            currentExcess = (decimal)this.incomeTaxTable.Rows[this.incomeTaxTable.Rows.Count - 1]["Excess"];
            currentMinTaxAmount = (decimal)this.incomeTaxTable.Rows[this.incomeTaxTable.Rows.Count - 1]["MinTaxAmount"];
        }

        Console.WriteLine($"Income of {income} gets taxed at {currentTaxPercentage} every dollar over {currentExcess}");

        return decimal.Round(currentMinTaxAmount + ((income - currentExcess) * currentTaxPercentage));
    }
}
