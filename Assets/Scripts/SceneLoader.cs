using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public AudioSource Hjälp;
    public void Menu()
    {
        SceneManager.LoadScene(1);
    }
    public void Game()
    {
        SceneManager.LoadScene(4);
    }
    public void Credits()
    {
        SceneManager.LoadScene(5);
    }
    public void Help()
    {
        Hjälp.Play();
    }
}
