using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Score_ouka : MonoBehaviour
{
    [SerializeField] Text scoreText;
    public int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) //左クリックで
        {
            score += 100;
            UpdateScoreText();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score：" + score.ToString();
    }
}
