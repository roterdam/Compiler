﻿namespace Compiler.ControlFlowGraph
{
    using Compiler.SymbolTable;

    public class PointerArgument : Argument
    {
        public PointerArgument(VariableSymbol variable)
        {
            this.Variable = variable;
        }

        public VariableSymbol Variable { get; private set; }

        public override string ToString()
        {
            return "*(" + Variable.Name + ")";
        }
    }
}
