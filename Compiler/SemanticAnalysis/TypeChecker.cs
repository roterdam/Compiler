﻿namespace Compiler.SemanticAnalysis
{
    using System;

    using Compiler.SymbolTable;
    using Compiler.SyntaxTree;

    using Type = Compiler.Type;

    public class TypeChecker : Visitor<Type>
    {
        private readonly Logger logger;

        public TypeChecker(Logger logger)
        {
            this.logger = logger;
        }

        public void RunCheck(ProgramNode programNode)
        {
            programNode.Accept(this);
        }

        public override Type Visit(ArrayCreatorExpression node)
        {
            return new Type(node.Type, node.Sizes.Count);
        }

        public override Type Visit(WhileStatement node)
        {
            var type = node.Condition.Accept(this);
            if (type.Dimensions != 0)
            {
                this.logger.LogError(node.Condition.Location, "The condition in a while loop cannot be an array");
            }

            if (type.PrimitiveType != PrimitiveType.Boolean)
            {
                this.logger.LogError(node.Condition.Location, "The condition in a while loop must be a boolean");
            }

            return base.Visit(node);
        }

        public override Type Visit(AssignmentExpression node)
        {
            var leftType = node.LeftSide.Accept(this);
            var rightType = node.RightSide.Accept(this);

            return this.CheckAssigmentCompatability(node, leftType, rightType);
        }

        private Type CheckAssigmentCompatability(Node node, Type leftType, Type rightType)
        {
            if (Equals(leftType, Type.NoType) || Equals(rightType, Type.NoType))
            {
                return Type.NoType;
            }

            if (leftType.PrimitiveType == PrimitiveType.Object || rightType.PrimitiveType == PrimitiveType.Object)
            {
                this.logger.LogError(node.Location, "Cannot assign the result of a void function call");

                return Type.NoType;
            }

            if (leftType.Dimensions != rightType.Dimensions)
            {
                this.logger.LogError(
                    node.Location,
                    "The assignment required that both sides have the same number of dimensions");

                return Type.NoType;
            }

            if (leftType.Dimensions == 0 && leftType.PrimitiveType == PrimitiveType.Double
                && rightType.PrimitiveType == PrimitiveType.Int)
            {
                return leftType;
            }

            if (leftType.PrimitiveType != rightType.PrimitiveType)
            {
                this.logger.LogError(node.Location, "The assignment required that both sides have the same type");

                return Type.NoType;
            }

            return leftType;
        }

        public override Type Visit(BooleanConstant node)
        {
            return new Type(PrimitiveType.Boolean);
        }

        public override Type Visit(ReturnExpressionStatement node)
        {
            return node.Expression.Accept(this);
        }

        public override Type Visit(ConstantExpression node)
        {
            return node.Constant.Accept(this);
        }

        public override Type Visit(IntegerConstant node)
        {
            return new Type(PrimitiveType.Int);
        }

        public override Type Visit(StringConstant node)
        {
            return new Type(PrimitiveType.String);
        }

        public override Type Visit(DoubleConstant node)
        {
            return new Type(PrimitiveType.Double);
        }

        public override Type Visit(ForStatement node)
        {
            var conditionType = node.Condition.Accept(this);
            if (Equals(conditionType, Type.NoType))
            {
                return null;
            }

            if (conditionType.PrimitiveType != PrimitiveType.Boolean || conditionType.Dimensions != 0)
            {
                this.logger.LogError(node.Condition.Location, "The condition in the for loop must be a boolean");
            }

            return null;
        }

        public override Type Visit(IfStatement node)
        {
            var conditionType = node.Condition.Accept(this);
            if (Equals(conditionType, Type.NoType))
            {
                return null;
            }

            if (conditionType.PrimitiveType != PrimitiveType.Boolean || conditionType.Dimensions != 0)
            {
                this.logger.LogError(node.Condition.Location, "The condition in the if statement must be a boolean");
            }

            return null;
        }

        public override Type Visit(BinaryOperatorExpression node)
        {
            var leftType = node.Left.Accept(this);
            var rightType = node.Right.Accept(this);

            if (Equals(leftType, Type.NoType) || Equals(rightType, Type.NoType) || leftType == null || rightType == null)
            {
                return Type.NoType;
            }

            switch (node.Operator)
            {
                case BinaryOperator.Add:
                case BinaryOperator.Subtract:
                case BinaryOperator.Multiply:
                case BinaryOperator.Divide:
                case BinaryOperator.Exponensiation:
                case BinaryOperator.Mod:
                    if (leftType.Dimensions != 0 || rightType.Dimensions != 0)
                    {
                        this.logger.LogError(node.Location, "The operator '{0}' is not valid on arrays", node.Operator);
                        return Type.NoType;
                    }

                    if (!(leftType.PrimitiveType == PrimitiveType.Double || leftType.PrimitiveType == PrimitiveType.Int) ||
                        !(rightType.PrimitiveType == PrimitiveType.Double || rightType.PrimitiveType == PrimitiveType.Int))
                    {
                        this.logger.LogError(node.Location, "The operator '{0}' is only available on the types Int and double");
                        return Type.NoType;
                    }

                    var returnType = new Type(PrimitiveType.Int);
                    if (leftType.PrimitiveType == PrimitiveType.Double
                        || rightType.PrimitiveType == PrimitiveType.Double)
                    {
                        returnType = new Type(PrimitiveType.Double);
                    }

                    return returnType;
                case BinaryOperator.Less:
                case BinaryOperator.LessEqual:
                case BinaryOperator.Greater:
                case BinaryOperator.GreaterEqual:
                    if (leftType.Dimensions != 0 || rightType.Dimensions != 0)
                    {
                        this.logger.LogError(node.Location, "The operator '{0}' is not valid on arrays", node.Operator);
                        return Type.NoType;
                    }

                    if (!(leftType.PrimitiveType == PrimitiveType.Double || leftType.PrimitiveType == PrimitiveType.Int) ||
                       !(rightType.PrimitiveType == PrimitiveType.Double || rightType.PrimitiveType == PrimitiveType.Int))
                    {
                        this.logger.LogError(node.Location, "The operator '{0}' is only available on the types Int and double");
                        return Type.NoType;
                    }

                    return new Type(PrimitiveType.Boolean);
                case BinaryOperator.And:
                case BinaryOperator.Or:
                    if (leftType.Dimensions != 0 || rightType.Dimensions != 0)
                    {
                        this.logger.LogError(node.Location, "The operator '{0}' is not valid on arrays", node.Operator);
                        return Type.NoType;
                    }

                    if (leftType.PrimitiveType != PrimitiveType.Boolean || rightType.PrimitiveType != PrimitiveType.Boolean)
                    {
                        this.logger.LogError(node.Location, "The operator '{0}' is only available on booleans", node.Operator);
                    }

                    return new Type(PrimitiveType.Boolean);
                case BinaryOperator.Equal:
                case BinaryOperator.NotEqual:
                    return new Type(PrimitiveType.Boolean);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override Type Visit(IndexerExpression node)
        {
            var indexType = node.Index.Accept(this);
            if (!Equals(indexType, Type.NoType)
                && (indexType.Dimensions != 0 && indexType.PrimitiveType != PrimitiveType.Int))
            {
                this.logger.LogError(node.Index.Location, "The index must be an integer");
            }

            var nameType = node.Name.Accept(this);
            if (nameType.Equals(Type.NoType))
            {
                return Type.NoType;
            }

            if (nameType.Dimensions == 0)
            {
                this.logger.LogError(node.Location, "Indexer must match the number of dimensions of the type.");
                return Type.NoType;
            }

            return new Type(nameType.PrimitiveType, nameType.Dimensions - 1);
        }

        public override Type Visit(FunctionCallExpression node)
        {
            if (node.Symbol == null)
            {
                return Type.NoType;
            }

            var functionSymbol = (FunctionSymbol)node.Symbol;

            if (node.Arguments.Count != functionSymbol.Parameters.Length)
            {
                this.logger.LogError(node.Location, "The function {0} must be called with the correct number of arguments", node.Name);
            }

            for (int i = 0; i < node.Arguments.Count; i++)
            {
                var expressionNode = node.Arguments[i];
                var expressionType = expressionNode.Accept(this);
                var parameterType =
                    ((ITypedSymbol)functionSymbol.SymbolTable.GetSymbol(functionSymbol.Parameters[i], SymbolType.Variable)).Type;

                this.CheckAssigmentCompatability(expressionNode, parameterType, expressionType);
            }

            var symbol = node.Symbol as ITypedSymbol;
            return symbol != null ? symbol.Type : new Type(PrimitiveType.Object);
        }

        public override Type Visit(VariableExpression node)
        {
            return ((ITypedSymbol)node.VariableId.Symbol).Type;
        }

        public override Type Visit(UnaryExpression node)
        {
            var expType = node.Expression.Accept(this);
            if (expType.Equals(Type.NoType))
            {
                return Type.NoType;
            }

            if (expType.Dimensions != 0)
            {
                this.logger.LogError(node.Location, "The operator {0} cannot be applied to arrays", node.Operator);
                return Type.NoType;
            }

            switch (node.Operator)
            {
                case UnaryOperator.Not:
                    if (expType.PrimitiveType != PrimitiveType.Boolean)
                    {
                        this.logger.LogError(node.Location, "The operator {0} can only be applied to booleans", node.Operator);
                        return Type.NoType;
                    }

                    return new Type(PrimitiveType.Boolean);
                case UnaryOperator.Negation:
                    if (expType.PrimitiveType != PrimitiveType.Double && expType.PrimitiveType != PrimitiveType.Int)
                    {
                        this.logger.LogError(node.Location, "The operator {0} can only be applied to integers and doubles", node.Operator);
                        return Type.NoType;
                    }

                    return expType;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override Type Visit(InitializedVariableDecleration node)
        {
            var initType = node.Initialization.Accept(this);

            if (initType.Equals(Type.NoType))
            {
                return null;
            }

            if (!initType.Equals(node.Variable.Type.Type))
            {
                this.logger.LogError(node.Location, "The variable '{0}' can only be initialized with the same type", node.Variable.Name.Name);
            }

            return null;
        }
    }
}