using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{

    public GameObject panelZ;
    public int cost;
    public string ItemName;
    public TMP_Text status;

    public void buy()
    {
         if (status.text == "купить")
        {
            if (GetComponentInParent<Shop>().money >= cost)
            {
                status.text = "куплено";
                panelZ.SetActive(false);
                GetComponentInParent<Shop>().money -= cost;
                GetComponentInParent<Shop>().addItem(ItemName);
            }
        } else
        {

        }
            
        
   
        
    }
    

}
