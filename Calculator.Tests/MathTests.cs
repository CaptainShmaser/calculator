using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator.BusinessLogic;
using Calculator.Types;
using System.Collections.Generic;

namespace Calculator.Tests
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void TestSimpleAddition()
        {
            //Arrange
            List<ArithmaticOperation> operations = new List<ArithmaticOperation>();
            operations.Add(new AdditionOperation(new List<double> { 12, 8 }));
            ArithmaticProcessor processor = new ArithmaticProcessor(operations.ToArray());


            //Act
            processor.ProcessOperations();

            //Assert
            Assert.IsTrue(processor.OperationResult == 20);
        }
        [TestMethod]
        public void TestChainedAddition()
        {
            //Arrange
            List<ArithmaticOperation> operations = new List<ArithmaticOperation>();
            operations.Add(new AdditionOperation(new List<double> { 12, 8 }));
            operations.Add(new AdditionOperation(new List<double> { 7, 3 }));
            ArithmaticProcessor processor = new ArithmaticProcessor(operations.ToArray());


            //Act
            processor.ProcessOperations();

            //Assert
            Assert.IsTrue(processor.OperationResult == 30);
        }
        [TestMethod]
        public void TestAdditionSubtraction()
        {
            //Arrange
            List<ArithmaticOperation> operations = new List<ArithmaticOperation>();
            operations.Add(new AdditionOperation(new List<double> { 12, 8 }));
            operations.Add(new SubtractionOperation(new List<double> { 7, 3 }));
            ArithmaticProcessor processor = new ArithmaticProcessor(operations.ToArray());


            //Act
            processor.ProcessOperations();

            //Assert
            Assert.IsTrue(processor.OperationResult == 10);
        }
        [TestMethod]
        public void TestSubtractionDoubleNegative()
        {
            //Arrange
            List<ArithmaticOperation> operations = new List<ArithmaticOperation>();
            operations.Add(new AdditionOperation(new List<double> { 12, 8 }));
            operations.Add(new SubtractionOperation(new List<double> { 5, -3 }));
            ArithmaticProcessor processor = new ArithmaticProcessor(operations.ToArray());


            //Act
            processor.ProcessOperations();

            //Assert
            Assert.IsTrue(processor.OperationResult == 12);
        }
    }
}
