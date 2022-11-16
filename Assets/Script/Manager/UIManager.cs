using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    private float seconde;
    private int score;
    [SerializeField] private Text timeText;
    [SerializeField] private Text scoreText;
    [SerializeField] private Button homeButton;
    // Start is called before the first frame update
    void Start()
    {
        seconde = 0;
        homeButton.onClick.AddListener(() => UpScore());
    }

    // Update is called once per frame
    void Update()
    {
        seconde += (float)Time.deltaTime;
        timeText.text = seconde.ToString() ;
    }

    private void UpScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
