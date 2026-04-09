using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class ResultManager_ouka : MonoBehaviour
{
    public int maxRank;

    // ▼ スコア追加
    public void AddScore(int newScore)
    {
        List<int> scores = new List<int>();

        // ▼ 既存スコア読み込み
        for (int i = 0; i < maxRank; i++)
        {
            int score = PlayerPrefs.GetInt("Score" + i, 0);
            scores.Add(score);
        }

        // ▼ 新しいスコア追加
        scores.Add(newScore);

        // ▼ 並び替え（降順）
        scores = scores.OrderByDescending(x => x).ToList();

        // ▼ 上位だけ残す
        for (int i = 0; i < maxRank; i++)
        {
            PlayerPrefs.SetInt("Score" + i, scores[i]);
        }

        PlayerPrefs.Save();
    }

    public List<int> GetRanking()
    {
        List<int> scores = new List<int>();

        for (int i = 0; i < maxRank; i++)
        {
            scores.Add(PlayerPrefs.GetInt("Score" + i, 0));
        }

        return scores;
    }
}
