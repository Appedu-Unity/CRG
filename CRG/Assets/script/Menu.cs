using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject PassMenu;
    public Button button;


    //void Update()
    //{
    //    if (Input.GetMouseButton(0))
    //    {
    //        Application.Quit();
    //    }
    //}

    //開始遊戲
    public void PlayGame()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //離開遊戲
    public void QuitGame()
    {
        //Debug.Log("退出遊戲");
        Application.Quit();
    }

    //暫停遊戲
    public void PassGame()
    {
       PassMenu.SetActive(true);
       Time.timeScale = 0f;
    }

    //繼續遊戲
    public void StartGame()
    {
        PassMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    //設置
    public void MuseGame()
    {


    }
   










}
