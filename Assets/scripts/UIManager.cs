using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public Image[] stars;

    public Sprite fullStar;
    
    private int index = 0;
    
    public void addStar()
    {
        stars[index].sprite = fullStar;
        index++;
    }


    private void Awake()
    {
        if(Instance == null) Instance = this;
        else gameObject.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
