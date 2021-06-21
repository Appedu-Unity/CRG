using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// 枚舉(遊戲進行狀態)
/// </summary>
public enum Gamestate { 
    running,stop
}
/// <summary>
/// 枚舉(分數狀態)
/// </summary>
public enum Scorestate
{
    begin, cease
}
public class GameManager : MonoBehaviour
{
    public static GameManager _instance;
    public Gamestate gamestate = Gamestate.running;
    public Scorestate scorestate = Scorestate.begin;
    private void Update()
    {
        
    }
    private void Awake()
    {
        _instance = this;
    }
    /// <summary>
    /// 重製場景
    /// </summary>
    public void Replay(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    /// <summary>
    /// 遊戲狀態判斷
    /// </summary>
    public void transformGame() {
        if (gamestate == Gamestate.running) {
            StopGame();
        }
        else {
            KeepOn();
        }
    }
    public void StopGame() {
        Time.timeScale = 0;
        gamestate = Gamestate.stop;
    }
    public void KeepOn() {
        Time.timeScale = 1;
        gamestate = Gamestate.running;
    }
    private void SetUp() { 
    
    }
}
