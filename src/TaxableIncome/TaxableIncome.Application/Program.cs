// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application;

using Orchestrators;

/// <summary>
/// Main program.
/// </summary>
public class Program
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Program"/> class.
    /// </summary>
    public Program()
    {
        var taxableIncomeOrchestrator = new TaxableIncomeOrchestrator();
        taxableIncomeOrchestrator.Execute2018Run();
    }

    /// <summary>
    /// The Main entry point of the application.
    /// </summary>
    /// <param name="args">Input arguments for the console app.</param>
    public static void Main(string[] args)
    {
        var p = new Program();
    }
}