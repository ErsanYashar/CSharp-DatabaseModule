﻿namespace Employees.App.Core.Commands.Contracts
{
    public interface ICommand
    {
        string Execute(string[] arguments);
    }
}