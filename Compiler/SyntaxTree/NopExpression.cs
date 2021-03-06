﻿namespace Compiler.SyntaxTree
{
    using System.Collections.Generic;

    public class NopExpression : ExpressionNode
    {
        public NopExpression(Location location)
            : base(location)
        {
        }

        public override T Accept<T>(IVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override IEnumerable<Node> Children
        {
            get
            {
                return new Node[0];
            }
        }
    }
}
