using MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MVVM.UnitTests.ViewModels
{
    public class MainViewModelTests
    {
        [Fact]
        public void Recalculate_should_return_120_when_subtotal_equals_100_and_tip_equals_20()
        {
            var mainViewModel = new MainViewModel();

            mainViewModel.SubTotal = 100;
            mainViewModel.Generosity = 0.2;

            Assert.Equal(120, mainViewModel.Total);
        }
    }
}
