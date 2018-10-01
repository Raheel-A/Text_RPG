using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour {

    public bool hasSword = false;
    public bool hasequationBook = false;
    public bool hasWand = false;
    public bool hasKey = false;
    public bool hasHoney = false;
    public int moneyAmount = 0;

    public void getSword()
    {
        hasSword = true;
        Debug.Log("Sword Get");
    }

    public void getequationBook()
    {
        hasequationBook = true;
        Debug.Log("Equation Book Get");
    }

    public void getWand()
    {
        hasWand = true;
        Debug.Log("Wand Get");
    }

    public void getKey()
    {
        hasKey = true;
        Debug.Log("Key Get");
    }

    public void getHoney()
    {
        hasHoney = true;
        Debug.Log("Honey Get");
    }

    public void gainMoney(int gain)
    {
        moneyAmount += gain;
    }

    public void loseMoney(int cost)
    {
        moneyAmount -= cost;
    }

}
