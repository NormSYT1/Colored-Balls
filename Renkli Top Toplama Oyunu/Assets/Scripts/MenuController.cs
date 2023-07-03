using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    void Start()
    {
        AudioListener.volume = 1;//Sesi çal
    }
    void Update()
    {
      
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//Bir sonraki sahneyi yükler
    }
    public void QuitGame()
    {
        Application.Quit();//Oyunu kapatýr
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);//Bir önceki sahneyi yükler
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Mevcut sahneyi yeniden yükler
    }
}
