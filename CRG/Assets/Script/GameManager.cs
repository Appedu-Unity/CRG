using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    /// <summary>
    /// 重製場景
    /// </summary>
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
