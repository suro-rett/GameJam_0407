using UnityEngine;
using UnityEngine.UI;

public class ResultPanelouka : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject time;

    bool isFinished = false; // šˆê‰ñ‚¾‚¯Às

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isFinished && time.GetComponent<Timer_ouka>().time <= 0f)
        {
            isFinished = true;
            Panel.SetActive(true);
            scoreHolder_ouka.score = ItemMgr.instance.score;
        }
    }
}
