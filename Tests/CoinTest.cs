using Xunit;
using System.Collections.Generic;
using System;

namespace CoinList.Objects
{
  public class CoinTest
  {
    // [Fact]
    // public void Test1_Get_Result_array_returnArray()
    // {
    //   int[] newArray= new int[4]{3,4,3,4};
    //   Coin myCoin = new Coin(0.34);
    //   myCoin.SetResultArray(newArray);
    //   Console.WriteLine(myCoin.GetResultArray());
    //   Console.WriteLine(newArray);
    //   Assert.Equal(newArray,myCoin.GetResultArray());
    // }
    // [Fact]
    // public void Test1_oneQuarter_returnCombination()
    // {
    //   Coin myCoin = new Coin(0.25);
    //   int[] resultArray= new int[4]{1,0,0,0};
    //   Assert.Equal(resultArray,myCoin.TestCombination());
    // }
    //
    // [Fact]
    // public void Test2_ThreeQuarter_returnCombination()
    // {
    //   Coin myCoin = new Coin(0.75);
    //   int[] resultArray= new int[4]{3,0,0,0};
    //   Assert.Equal(resultArray,myCoin.TestCombination());
    // }

    // [Fact]
    // public void Test3_OneDimes_returnCombination()
    // {
    //   Coin myCoin = new Coin(0.10);
    //   int[] resultArray= new int[4]{0,1,0,0};
    //   Assert.Equal(resultArray,myCoin.TestCombination());
    // }
    //
    // [Fact]
    // public void Test4_TwoDimes_returnCombination()
    // {
    //   Coin myCoin = new Coin(0.20);
    //   int[] resultArray= new int[4]{0,2,0,0};
    //   Assert.Equal(resultArray,myCoin.TestCombination());
    // }

    [Fact]
    public void Test5_Complex_returnCombination()
    {
      Coin myCoin = new Coin(0.95);
      double[] resultArray= new double[4]{3,2,0,0};
      Assert.Equal(resultArray,myCoin.TestCombination());
    }
    //
    // [Fact]
    // public void Test6_TwoDimes_returnCombination()
    // {
    //   Coin myCoin = new Coin(0.34);
    //   int[] resultArray= new int[4]{1,0,1,4};
    //   Assert.Equal(resultArray,myCoin.TestCombination());
    // }
  }
}
