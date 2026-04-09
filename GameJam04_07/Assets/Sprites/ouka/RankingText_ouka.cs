using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class RankingText_ouka : MonoBehaviour
{
    public Text rankingText;

    void Start()
    {
        ResultManager_ouka manager = FindFirstObjectByType<ResultManager_ouka>();

        // ★ 今回のスコアを追加
        manager.AddScore(scoreHolder_ouka.score);

        // ★ ランキング取得
        List<int> scores = manager.GetRanking();

        string result = "";

        for (int i = 0; i < scores.Count; i++)
        {
            result += (i + 1) + "位 : " + scores[i] + "\n";
        }

        rankingText.text = result;
    }
}
