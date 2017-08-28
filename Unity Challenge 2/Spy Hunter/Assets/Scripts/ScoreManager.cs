using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text score;

    public static int myScore;

    void Awake()
    {
        GameObject.DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        score.text = "Score: " + myScore;
    }
}
