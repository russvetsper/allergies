using System;
using System.Collections.Generic;

namespace CoinList.Objects
{
  public class Coin
  {
    string[] coinName= new string[4]{"Quarter","Dime","Nickel","Penny"};
    double[] coinValue= new double[4]{0.25,0.1,0.05,0.01};
    private double _inputMoney;
    private int[] _result;
    public Coin(double amount)
    {
      _inputMoney=amount;
    _result= new int[4]{0,0,0,0};
    }

    public double GetInputMoney()
    {
      return _inputMoney;
    }
    public void SetInputMoney(double newAmount)
    {
      _inputMoney=newAmount;
    }
    public int[] GetResultArray()
    {
      return _result;
    }
    public void SetResultArray(int[] newArray)
    {
      _result=newArray;
    }


    }

  }
