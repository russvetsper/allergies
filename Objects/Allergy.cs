using System;
using System.Collections.Generic;

namespace Allergies.Objects
{
  public class Allergy
  {

    private int _inputNumber;
    public string[] itemPicName= new string[8]{"eggs","peanuts","shellfish","strawberries","tomatoes","chocolate", "pollen","cats"   };
    public int[] itemPicValue= new int[8]{1,2,4,8,16,32,64,128};
    public Allergy(int amount)
    {
      _inputNumber=amount;
    }

    public int GetInputNum()
    {
      return _inputNumber;
    }
    public void SetInputNum(int newAmount)
    {
      _inputNumber=newAmount;
    }


    public List<string> TestCombination()
    {
      int inputNum=this.GetInputNum();
      string[] itemName= new string[8]{"eggs","peanuts","shellfish","strawberries","tomatoes","chocolate", "pollen","cats"   };
      int[] itemValue= new int[8]{1,2,4,8,16,32,64,128};
      List<string> resultCombination=new List<string>{};
      for (int i=7; i>=0; i--)
      {

        if(inputNum>=itemValue[i])
        {
          resultCombination.Add(itemName[i]);
          inputNum-=itemValue[i];
        }
      }

      return resultCombination;
    }

    }

  }
