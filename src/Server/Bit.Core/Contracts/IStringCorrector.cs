﻿using System.Diagnostics.CodeAnalysis;

namespace Bit.Core.Contracts
{
    /// <summary>
    /// You can register as many as <see cref="IStringCorrector"/> as you want.
    /// Their <see cref="CorrectString(string)"/> will be called when data is submitted from client to server.
    /// </summary>
    public interface IStringCorrector
    {
        [return: NotNullIfNotNull("input")]
        string CorrectString(string? input);
    }
}