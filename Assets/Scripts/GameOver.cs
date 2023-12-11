using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void Playgame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Main()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
}
