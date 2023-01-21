using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] Texture2D _baseCursor;

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
    

    public void CursorChange(Texture2D texture)
    {
        Cursor.SetCursor(texture, Vector2.zero, CursorMode.Auto);
    }

    public void CursorReset()
    {
        Cursor.SetCursor(_baseCursor, Vector2.zero, CursorMode.Auto);
    }

    public void MouseHoverIn(GameObject go)
    {
        go.transform.localScale *= 1.2f;
    }

    public void MouseHoverOut(GameObject go)
    {
        go.transform.localScale = Vector3.one;
    }

}
