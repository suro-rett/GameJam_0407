using UnityEngine;
using UnityEngine.UI;
public class HPUI_ouka : MonoBehaviour
{
    public Image hpBar;
    public Spawn_ouka spawner; // ÅöïœçX

    void Start()
    {
        spawner = FindFirstObjectByType<Spawn_ouka>();
    }

    void Update()
    {

        if (ItemMgr.instance != null)
        {
            float ratio = (float)ItemMgr.instance.NowItem.GetComponent<BreakItem>().HP / (float)ItemMgr.instance.NowItem.GetComponent<BreakItem>().MAXHP;
            hpBar.fillAmount = ratio;
        }
        
    }
}
