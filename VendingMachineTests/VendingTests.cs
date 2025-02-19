using VendingMachines;

namespace VendingMachineTests
{
    public class VendingTests
    {
        [Fact]
        public void Money_ShouldHaveCorrectValues()
        {
            Assert.Equal(.05m, Money.Nickel.Value);
            Assert.Equal(.10m, Money.Dime.Value);
            Assert.Equal(.25m, Money.Quarter.Value);
        }

        [Fact]
        public void VendingMachine_ReturnsSoda_WhenRespectiveCodeAndCorrectAmountOfMoneyIsEntered()
        {
            //Arrange
            var vendingMachine = new VendingMachine();

            //Act
            var productCode = "A01";
            var productPrice = 1.00m;
            var result = vendingMachine.SelectProduct(productCode, productPrice);
            var expectedResult = "Vending Soda";

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void VendingMachine_ReturnsChips_WhenRespectiveCodeAndCorrectAmountOfMoneyIsEntered()
        {
            var vendingMachine = new VendingMachine();

            var productCode = "A02";
            var productPrice = .65m;
            var result = vendingMachine.SelectProduct(productCode, productPrice);
            var expectedResult = "Vending Chips";

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void VendingMachine_ReturnsCandy_WhenRespectiveCodeAndCorrectAmountOfMoneyIsEntered()
        {
            var vendingMachine = new VendingMachine();

            var productCode = "A03";
            var productPrice = .85m;
            var result = vendingMachine.SelectProduct(productCode, productPrice);
            var expectedResult = "Vending Candy";

            Assert.Equal(expectedResult, result);
        }

        [Fact] 
        public void VendingMachine_ReturnsGum_WhenRespectiveCodeAndCorrectAmountOfMoneyIsEntered()
        {
            var vendingMachine = new VendingMachine();

            var productCode = "A04";
            var productPrice = .40m;
            var result = vendingMachine.SelectProduct(productCode, productPrice);
            var expectedResult = "Vending Gum";

            Assert.Equal(expectedResult, result);
        }
    }
}