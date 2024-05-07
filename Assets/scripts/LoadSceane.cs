using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadSceane : MonoBehaviour
{
    public void LoadLevel(int _index)
    {
        SceneManager.LoadScene(_index);
    }
}
