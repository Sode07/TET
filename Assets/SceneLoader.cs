using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene(1);
    }
    public void Game()
    {
        SceneManager.LoadScene(4);
    }
}
