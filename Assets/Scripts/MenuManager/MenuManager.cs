using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jouer()
    {
        SceneManager.LoadScene("lvl1");
    }

    public void Quitter()
    {
        Application.Quit();
        Debug.Log("quitter");
    }
}
