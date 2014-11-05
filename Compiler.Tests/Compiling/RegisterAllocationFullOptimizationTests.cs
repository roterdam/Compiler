﻿namespace Compiler.Tests.Compiling
{
    using Compiler.Optimization;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    [DeploymentItem("Assemble.bat")]
    public class RegisterAllocationFullOptimizationTests : CompilationTestBase
    {
        public RegisterAllocationFullOptimizationTests()
            : base("RegisterAllocationFullOptimization")
        {
        }

        [TestMethod]
        [DeploymentItem("Compiling/Programs/Program1.m")]
        [DeploymentItem("Compiling/Programs/Program1Result.txt")]
        public void TestProgram1()
        {
            this.TestProgram("Program1.m", "Program1Result.txt");
        }

        [TestMethod]
        [DeploymentItem("Compiling/Programs/Program2.m")]
        [DeploymentItem("Compiling/Programs/Program2Result.txt")]
        public void TestProgram2()
        {
            this.TestProgram("Program2.m", "Program2Result.txt");
        }

        [TestMethod]
        [DeploymentItem("Compiling/Programs/Program3.m")]
        [DeploymentItem("Compiling/Programs/Program3Result.txt")]
        public void TestProgram3()
        {
            this.TestProgram("Program3.m", "Program3Result.txt");
        }

        [TestMethod]
        [DeploymentItem("Compiling/Programs/Program4.m")]
        [DeploymentItem("Compiling/Programs/Program4Result.txt")]
        public void TestProgram4()
        {
            this.TestProgram("Program4.m", "Program4Result.txt");
        }

        [TestMethod]
        [DeploymentItem("Compiling/Programs/Program5.m")]
        [DeploymentItem("Compiling/Programs/Program5Result.txt")]
        public void TestProgram5()
        {
            this.TestProgram("Program5.m", "Program5Result.txt");
        }

        [TestMethod]
        [DeploymentItem("Compiling/Programs/Program6.m")]
        [DeploymentItem("Compiling/Programs/Program6Result.txt")]
        public void TestProgram6()
        {
            this.TestProgram("Program6.m", "Program6Result.txt");
        }

        [TestMethod]
        [DeploymentItem("Compiling/Programs/Program7.m")]
        [DeploymentItem("Compiling/Programs/Program7Result.txt")]
        public void TestProgram7()
        {
            this.TestProgram("Program7.m", "Program7Result.txt");
        }

        [TestMethod]
        [DeploymentItem("Compiling/Programs/Program8.m")]
        [DeploymentItem("Compiling/Programs/Program8Result.txt")]
        public void TestProgram8()
        {
            this.TestProgram("Program8.m", "Program8Result.txt");
        }

        [TestMethod]
        [DeploymentItem("Compiling/Programs/Program9.m")]
        [DeploymentItem("Compiling/Programs/Program9Result.txt")]
        public void TestProgram9()
        {
            this.TestProgram("Program9.m", "Program9Result.txt");
        }

        [TestMethod]
        [DeploymentItem("Compiling/Programs/Program10.m")]
        [DeploymentItem("Compiling/Programs/Program10Result.txt")]
        public void TestProgram10()
        {
            this.TestProgram("Program10.m", "Program10Result.txt");
        }

        protected override CompilerAssembly CreateCompilerAssembly()
        {
            return new CompilerAssembly
                       {
                           ActivatedOptimizations =
                               {
                                   Optimizations.AlgebraicOptimization,
                                   Optimizations.DeadCodeElimination,
                                   Optimizations.EliminateEqualAssignments,
                                   Optimizations.LocalCopyPropagation,
                               },
                           AllocateRegisters = true
                       };
        }
    }
}
