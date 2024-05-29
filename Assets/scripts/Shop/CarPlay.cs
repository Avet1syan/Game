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
        if (statusText.text == "�������")
        {
            panelCard.SetActive(true);
        }
        if (statusText.text == "������")
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
