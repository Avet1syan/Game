using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{


    public int money = 1500;
    public Text inventory;
    public TMP_Text moneyText;

    public void addItem(string item)
    {
        while (money >= 0)
        {
            moneyText.text = money.ToString();
            inventory.text += "\n" + item;
        }
    }

    
}
