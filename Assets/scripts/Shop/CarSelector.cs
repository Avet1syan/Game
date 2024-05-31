using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class CarSelector : MonoBehaviour
{
    

    [SerializeField] private Button prevButton;
    [SerializeField] private Button nextButton;
    private int currentCar; //текущая машина
    public Text statusText;



    private void Start()
    {
        currentCar = SaveManager.instance.currentCar;
        SelectCar(currentCar);
    }
    private void SelectCar(int _index) //метод
    {
        prevButton.interactable = (_index != 0);
        nextButton.interactable = (_index != transform.childCount -1);
        for (int i = 0; i < transform.childCount; i++) // для выбора и активации автомобиля
        {
            transform.GetChild(i).gameObject.SetActive(i == _index);
        }
    }

    public void ChangeCar(int _change) //переключение автомобиля на необходимый
    {
        currentCar += _change;
        SaveManager.instance.currentCar = currentCar;
        SaveManager.instance.Save();
        SelectCar(currentCar);
    }

    
}

