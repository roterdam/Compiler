﻿namespace Compiler.Optimization
{
    using Compiler.ControlFlowGraph;

    public class EqualAssignmentEliminator : OptimizerBase
    {
        public override void VisitBlock(BasicBlock block)
        {
            if (block.Enter == block.Exit)
            {
                return;
            }

            bool remove = true;

            while (remove)
            {
                remove = false;
                Statement toRemove = null;

                foreach (var statement in block)
                {
                    var assignStatement = statement as AssignStatement;
                    if (assignStatement != null && (assignStatement.Argument is VariableArgument)
                        && ((VariableArgument)assignStatement.Argument).Variable == assignStatement.Return)
                    {
                        toRemove = statement;
                        remove = true;
                        this.SetSomethingChanged();
                        break;
                    }
                }

                if (toRemove != null)
                {
                    CFGUtilities.RemoveStatement(toRemove);
                }
            }
        }
    }
}
