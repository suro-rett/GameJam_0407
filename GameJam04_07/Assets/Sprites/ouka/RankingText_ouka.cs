using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class RankingText_ouka : MonoBehaviour
{
    public Text rankingText;

    void Start()
    {
        ResultManager_ouka manager = FindFirstObjectByType<ResultManager_ouka>();
        List<int> scores = manager.GetRanking();
        string result = "";

        for (int i = 0; i < scores.Count; i++)
        {
            result += (i + 1) + "ˆÊ : " + scores[i] + "\n";
        }

        rankingText.text = result;
    }
}
