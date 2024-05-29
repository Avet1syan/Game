using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerGame : MonoBehaviour
{
    private int sec = 0;
    private int min = 0;
    public TMP_Text moneyText;
    public TMP_Text timerText;
    public TMP_Text timerTextRecord;
    public TMP_Text timerTextResult;
    

    private int m = 0;
    private int r = 0;

    [SerializeField] private GameObject panelwin;


    private void Start()
    {
        timerText = GameObject.Find("timer").GetComponent<TMP_Text>();
        StartCoroutine(TimeFlow());
    }

    IEnumerator TimeFlow()
    {
        while (true)
        {
            if(sec == 59)
            {
                min++;
                sec = -1;
            }
            sec++;
            timerText.text = min.ToString("D2") + " : " + sec.ToString("D2");
            yield return new WaitForSeconds(1);
        }
    }
    


    private void OnTriggerEnter(Collider other)
    {
        if (sec > 20 | min > 0)
        {
            if (other.tag == "Player")
            {
                panelwin.SetActive(true);
                Time.timeScale = 0;
                timerTextResult.text = timerText.text;
                moneyText.text = "1000";

                r = sec + (min * 60);
                m = 1000 - r * 11;
                moneyText.text = m.ToString();

                
            }
        }
        


    }





}
