using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSelect_ouka : MonoBehaviour
{
    [SerializeField] string changeScene; //unity側でシーンを入力する
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ButtonClick()
    {

        SceneManager.LoadScene(changeScene);//入力されたシーンにジャンプ
    }
}
