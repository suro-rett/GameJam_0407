using UnityEngine;
using UnityEngine.SceneManagement;

public class resultController : MonoBehaviour
{
    // Start is called once before the first execution of Update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onClickRestartButton()
    {
        SceneManager.LoadScene("Game_ouka");
    }
    // スタートボタンが押されたときに呼ばれる関数
    public void onClickTitleButton()
    {
        SceneManager.LoadScene("Title");
    }
}

