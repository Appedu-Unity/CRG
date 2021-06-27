using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///聲音管理器
/// </summary>
public class SoundManager : MonoBehaviour
{
    //單例
    public static SoundManager Instance;
    //播放器
    public AudioSource aud;
    //播放片段 數組存儲
    public AudioClip[] aC;
 

    void Start()
    {
        //單例
        if (Instance == null)
        {
            Instance = this;
        }
    }

    ////跑 音效
    //public void PlayRun()
    //{
    //    aud.clip = aC[0];
    //    aud.Play();
    //}
    //跳 音效
    public void PlayJump()
    {
        aud.clip = aC[0];
        aud.Play();
    }
    //死亡 音效
    public void PlayDie()
    {
        aud.clip = aC[1];
        aud.Play();
    }
   

}
