using UnityEngine;
using System.Collections;
using UnityEngine.UI; // ←※これを忘れずに入れる

public class RendaBarCtrl : MonoBehaviour
{

    Slider _slider;
    void Start()
    {
        // スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    public float renda = 1;
    void Update()
    {
        if (renda < 0)
        {
            // ゲージもとに戻す
            renda = 1;
        }

        // 連打ゲージに値を設定
        _slider.value = renda;
    }
}