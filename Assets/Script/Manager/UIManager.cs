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
    [SerializeField] private SceneManager sceneManager;
    // Start is called before the first frame update
    void Start()
    {
        seconde = 0;
        homeButton.onClick.AddListener(() => UpScore());
        homeButton.onClick.AddListener(() => rotateCube());
    }

    // Update is called once per frame
    void Update()
    {
        seconde += (float)Time.deltaTime;
        timeText.text = seconde.ToString() ;
    }

    public void UpScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void DownScore()
    {
        score--;
        scoreText.text = score.ToString();
    }

    public void UpdateScore(bool increment)
    {
        if (increment)
            score++;
        else
            score--;
        scoreText.text = score.ToString();
    }

    private void rotateCube()
    {
        sceneManager.RotateCube();
    }
}
