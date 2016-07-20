using Xunit;
using System.Collections.Generic;
using System;

namespace Allergies.Objects
{
  public class AllergyListTest
  {

    [Fact]
    public void Test1_singleItem_returnCombination()
    {
      Allergy newAllergy = new Allergy(128);
      List<string> result = new List<string>{};
      result.Add("cats");
      Assert.Equal(result,newAllergy.TestCombination());
    }
    [Fact]
    public void Test2_singleItem_returnCombination()
    {
      Allergy newAllergy = new Allergy(64);
      List<string> result = new List<string>{};
      result.Add("pollen");
      Assert.Equal(result,newAllergy.TestCombination());
    }
    [Fact]
    public void Test3_singleItem_returnCombination()
    {
      Allergy newAllergy = new Allergy(32);
      List<string> result = new List<string>{};
      result.Add("chocolate");
      Assert.Equal(result,newAllergy.TestCombination());
    }
    [Fact]
    public void Test4_singleItem_returnCombination()
    {
      Allergy newAllergy = new Allergy(16);
      List<string> result = new List<string>{};
      result.Add("tomatoes");
      Assert.Equal(result,newAllergy.TestCombination());
    }
    [Fact]
    public void Test5_singleItem_returnCombination()
    {
      Allergy newAllergy = new Allergy(8);
      List<string> result = new List<string>{};
      result.Add("strawberries");
      Assert.Equal(result,newAllergy.TestCombination());
    }
    [Fact]
    public void Test6_singleItem_returnCombination()
    {
      Allergy newAllergy = new Allergy(4);
      List<string> result = new List<string>{};
      result.Add("shellfish");
      Assert.Equal(result,newAllergy.TestCombination());
    }
    [Fact]
    public void Test7_singleItem_returnCombination()
    {
      Allergy newAllergy = new Allergy(2);
      List<string> result = new List<string>{};
      result.Add("peanuts");
      Assert.Equal(result,newAllergy.TestCombination());
    }
    [Fact]
    public void Test8_singleItem_returnCombination()
    {
      Allergy newAllergy = new Allergy(1);
      List<string> result = new List<string>{};
      result.Add("eggs");
      Assert.Equal(result,newAllergy.TestCombination());
    }
    [Fact]
    public void Test9_twoItem_returnCombination()
    {
      Allergy newAllergy = new Allergy(129);
      List<string> result = new List<string>{"cats","eggs"};
      Assert.Equal(result,newAllergy.TestCombination());
    }
    [Fact]
    public void Test10_twoItem_returnCombination()
    {
      Allergy newAllergy = new Allergy(132);
      List<string> result = new List<string>{"cats","shellfish"};
      Assert.Equal(result,newAllergy.TestCombination());
    }
    [Fact]
    public void Test11_threeItem_returnCombination()
    {
      Allergy newAllergy = new Allergy(133);
      List<string> result = new List<string>{"cats","shellfish","eggs"};
      Assert.Equal(result,newAllergy.TestCombination());
    }
    [Fact]
    public void Test11_FourItem_returnCombination()
    {
      Allergy newAllergy = new Allergy(29);
      List<string> result = new List<string>{"tomatoes","strawberries","shellfish","eggs"};
      Assert.Equal(result,newAllergy.TestCombination());
    }
    [Fact]
    public void Test12_FiveItem_returnCombination()
    {
      Allergy newAllergy = new Allergy(93);
      List<string> result = new List<string>{"pollen","tomatoes","strawberries","shellfish","eggs"};
      Assert.Equal(result,newAllergy.TestCombination());
    }

    [Fact]
    public void Test13_FiveItem_returnCombination()
    {
      Allergy newAllergy = new Allergy(94);
      List<string> result = new List<string>{"pollen","tomatoes","strawberries","shellfish","peanuts"};
      Assert.Equal(result,newAllergy.TestCombination());
    }

    [Fact]
    public void Test14_FiveItem_returnCombination()
    {
      Allergy newAllergy = new Allergy(89);
      List<string> result = new List<string>{"pollen","tomatoes","strawberries","eggs"};
      Assert.Equal(result,newAllergy.TestCombination());
    }
  }
}
