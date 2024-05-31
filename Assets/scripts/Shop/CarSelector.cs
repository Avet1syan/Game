using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class CarSelector : MonoBehaviour
{
    

    [SerializeField] private Button prevButton;
    [SerializeField] private Button nextButton;
    private int currentCar; //������� ������
    public Text statusText;



    private void Start()
    {
        currentCar = SaveManager.instance.currentCar;
        SelectCar(currentCar);
    }
    private void SelectCar(int _index) //�����
    {
        prevButton.interactable = (_index != 0);
        nextButton.interactable = (_index != transform.childCount -1);
        for (int i = 0; i < transform.childCount; i++) // ��� ������ � ��������� ����������
        {
            transform.GetChild(i).gameObject.SetActive(i == _index);
        }
    }

    public void ChangeCar(int _change) //������������ ���������� �� �����������
    {
        currentCar += _change;
        SaveManager.instance.currentCar = currentCar;
        SaveManager.instance.Save();
        SelectCar(currentCar);
    }

    
}

