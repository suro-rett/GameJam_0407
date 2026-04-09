using UnityEngine;

public class Effect : MonoBehaviour
{
    float time = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        time = Time.time;
        gameObject.transform.position = new Vector3((float)UnityEngine.Random.Range(-15, 15) / 10, (float)UnityEngine.Random.Range(-15, 15) / 10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //int a = ItemMgr.instance.NowItem.GetComponent<BreakItem>().HP;
        if(Time.time - time>0.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
