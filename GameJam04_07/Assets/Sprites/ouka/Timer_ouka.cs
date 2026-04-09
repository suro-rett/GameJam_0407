using UnityEngine;
using UnityEngine.UI;

public class Timer_ouka : MonoBehaviour
{
    public float time;
    private float resetTime;//初期設定値記憶用

    [SerializeField] Text timerText; //テキスト表示

    [SerializeField] sceneSelect_ouka sceneChanger; //シーン切り替え

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resetTime = time;
    }

    // Update is called once per frame
    void Update()
    {
        if(time > 0)    //timeが0以上ならカウントダウン
        {
            time -= Time.deltaTime;
            UpdateText();
        }
        else    //0以下ならリセット、画面移動
        {
            time = 0;
            UpdateText();
            if (Input.GetKeyDown(KeyCode.Return))
            {
                sceneChanger.ButtonClick();
            }
        }
    }
    void UpdateText()
    {
        timerText.text = "Time："+ time.ToString("F2");//小数点2以上.
    }
    private void ResetTimer()
    {
        time = resetTime;
    }


}
