using System;
using System.Collections.Generic;

namespace CoinList.Objects
{
  public class Coin
  {

    private double _inputMoney;
    public Coin(double amount)
    {
      _inputMoney=amount;
    }

    public double GetInputMoney()
    {
      return _inputMoney;
    }
    public void SetInputMoney(double newAmount)
    {
      _inputMoney=newAmount;
    }


    public double[] TestCombination()
    {
      string[] coinName= new string[4]{"Quarter","Dime","Nickel","Penny"};
      double[] coinValue= new double[4]{25,10,5,1};
      double money=this.GetInputMoney();
      double[] resultCombination=new double[4]{0,0,0,0};

      for (int i=0; i<4; i++) {
        if(money/coinValue[i]>=1)
        {
          Console.WriteLine(coinValue[i]+" divided into "+money);

          double remainder=money/coinValue[i];
          double index= Math.Floor( remainder);
          Console.WriteLine("number of " + coinName[i] + " in " + remainder + " is " + index);
          Console.WriteLine("after floor is "+Math.Floor( remainder));

          resultCombination[i]=index;
          money=money-(coinValue[i]*index);

        }
      }

      return resultCombination;
    }

    }

  }
