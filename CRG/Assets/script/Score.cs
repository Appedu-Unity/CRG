using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    [Header("分數")]
    static public float score;
    [Header("分數文字")]
    public Text text;

    private void Awake()
    {
        score = 0;
    }
    
    void Update()
    {
        AddScore(Mathf.Ceil(Time.time*0.1f));
    }

    public void AddScore(float add)
    {
        score += add;
        text.text = "分數 : " + score;
    }
    public void ClickButton()
    {
        GameManager._instance.transformGame();
    }
}
