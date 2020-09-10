using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextSummary;
    public float scoreAmount;
    public float pointIncreasedPersecond;

    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0f;
        pointIncreasedPersecond = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)scoreAmount + " Seconds";
        scoreTextSummary.text = (int)scoreAmount + " Seconds";
        scoreAmount += pointIncreasedPersecond * Time.deltaTime;
    }
}
