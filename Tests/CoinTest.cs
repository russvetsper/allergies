using Xunit;
using System.Collections.Generic;
using System;

namespace CoinList.Objects
{
  public class CoinTest
  {

    [Fact]
    public void Test1_oneQuarter_returnCombination()
    {
      Coin myCoin = new Coin(25);
      double[] resultArray= new double[4]{1,0,0,0};
      Assert.Equal(resultArray,myCoin.TestCombination());
    }

    [Fact]
    public void Test2_ThreeQuarter_returnCombination()
    {
      Coin myCoin = new Coin(75);
      double[] resultArray= new double[4]{3,0,0,0};
      Assert.Equal(resultArray,myCoin.TestCombination());
    }

    [Fact]
    public void Test3_OneDimes_returnCombination()
    {
      Coin myCoin = new Coin(10);
      double[] resultArray= new double[4]{0,1,0,0};
      Assert.Equal(resultArray,myCoin.TestCombination());
    }

    [Fact]
    public void Test4_TwoDimes_returnCombination()
    {
      Coin myCoin = new Coin(20);
      double[] resultArray= new double[4]{0,2,0,0};
      Assert.Equal(resultArray,myCoin.TestCombination());
    }

    [Fact]
    public void Test5_Complex_returnCombination()
    {
      Coin myCoin = new Coin(95);
      double[] resultArray= new double[4]{3,2,0,0};
      Assert.Equal(resultArray,myCoin.TestCombination());
    }

    [Fact]
    public void Test6_TwoDimes_returnCombination()
    {
      Coin myCoin = new Coin(34);
      double[] resultArray= new double[4]{1,0,1,4};
      Assert.Equal(resultArray,myCoin.TestCombination());
    }
  }
}
