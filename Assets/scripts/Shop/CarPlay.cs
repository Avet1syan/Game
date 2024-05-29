using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class CarPlay : MonoBehaviour
{
    public GameObject panelCard;
    public GameObject panelK;
   
    public TMP_Text statusText;


    public void PanelCard()
    {
        if (statusText.text == "куплено")
        {
            panelCard.SetActive(true);
        }
        if (statusText.text == "купить")
        {
            panelK.SetActive(true);
        }
    }
    public void Exit()
    {
        panelCard.SetActive(false);
    }
    public void ExitK()
    {
        panelK.SetActive(false);
    }

    
}
