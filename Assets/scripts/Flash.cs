using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using UniRx;

public class Flash : MonoBehaviour
{
    [SerializeField]
    private float angularFrequency = 6f;
    // 30FPS
    static readonly float deltaTime = 0.0333f;
    private Text text;

    void Start()
    {
        float time = 0.0f;
        text = GetComponent<Text>();
        Observable.Interval(TimeSpan.FromSeconds(deltaTime)).Subscribe(_ =>
        {
            time += angularFrequency * deltaTime;
            var color = text.color;
            color.a = Mathf.Sin(time) * 0.5f + 0.5f;
            text.color = color;
        }).AddTo(this);
    }
}