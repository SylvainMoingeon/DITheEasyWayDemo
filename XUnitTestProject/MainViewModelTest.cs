using DITheEasyWayDemo.ViewModels;
using System;
using Xunit;

namespace XUnitTestProject
{
    public class MainViewModelTest
    {
        [Fact]
        public void InjectingCharacterServiceProvidesCategory()
        {
            //Arrange
            var characterService = new FakeCharacterService();

            //Act
            var viewModel = new MainViewModel(characterService);

            //Assert
            Assert.Equal(characterService.Category, viewModel.Category);
        }
    }
}
