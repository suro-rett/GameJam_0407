using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    // Start is called once before the first execution of Update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // スタートボタンが押されたときに呼ばれる関数
    public void onClickStartButton()
    {
        SceneManager.LoadScene("Game_ouka");
    }
}
