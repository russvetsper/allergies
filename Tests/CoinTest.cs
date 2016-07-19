using Xunit;
using System.Collections.Generic;
using System;

namespace CoinList.Objects
{
  public class CoinTest
  {
    [Fact]
    public void Test1_Get_Result_array_returnCombination()
    {
      int[] newArray= new int[4]{3,4,3,4};
      Coin myCoin = new Coin(0.34);
      myCoin.SetResultArray(newArray);
      Console.WriteLine(myCoin.GetResultArray());
      Console.WriteLine(newArray);
      Assert.Equal(newArray,myCoin.GetResultArray());
    }
  }
}
