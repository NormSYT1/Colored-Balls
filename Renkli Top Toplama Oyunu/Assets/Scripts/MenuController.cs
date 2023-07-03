using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    void Start()
    {
        AudioListener.volume = 1;//Sesi �al
    }
    void Update()
    {
      
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//Bir sonraki sahneyi y�kler
    }
    public void QuitGame()
    {
        Application.Quit();//Oyunu kapat�r
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);//Bir �nceki sahneyi y�kler
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Mevcut sahneyi yeniden y�kler
    }
}
