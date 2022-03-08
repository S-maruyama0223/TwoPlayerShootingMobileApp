using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private float newtonCoefficient = 7f;
    void Start()
    {
        Physics2D.gravity = new Vector2(0, -9.81f * newtonCoefficient);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        Debug.Log("ゲーム開始");
        Application.targetFrameRate = 60; //60FPSに設定
    }
}
