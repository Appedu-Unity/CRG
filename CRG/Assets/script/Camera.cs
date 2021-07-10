using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [Header("移動速度")]
    public float cspeed = 10;
    [Header("遊戲結束")]
    public GameObject gameclear;

    private Rigidbody2D rig;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Run();
    }
    private void Run()
    {
        rig.velocity = new Vector2(cspeed, 0); //水平加速度  

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "終點")
        {
            gameclear.SetActive(true);
            cspeed = 0;
        }
    }

}
