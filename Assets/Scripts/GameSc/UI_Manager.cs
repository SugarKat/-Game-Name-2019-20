using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public GameObject[] plUI;

    private void Start()
    {
        GameManager.instance.UIupdate += UpdateUI;
    }

    public void LoadLevel(int id)
    {
        SceneManager.LoadScene(id);
    }
    public void UpdateUI(int _size)
    {
        for (int i = 0; i < plUI.Length; i++)
        {
            plUI[i].SetActive(false);
        }
        for (int i = 0; i < _size; i++)
        {
            plUI[i].SetActive(true);
        }
    }
    private void OnDestroy()
    {
        GameManager.instance.UIupdate -= UpdateUI;
    }
}
