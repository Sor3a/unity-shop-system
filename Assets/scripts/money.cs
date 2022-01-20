using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money : MonoBehaviour
{
    [SerializeField] int MyMoney = 500;

    public bool getMoney(int number)
    {
        if (MyMoney > number)
        {
            MyMoney -= number;
            return true;
        }
        else
        {
            Debug.Log("you don't have money");
            return false;
        }
    }


}
