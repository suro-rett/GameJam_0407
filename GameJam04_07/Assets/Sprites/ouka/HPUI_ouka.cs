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
        TargetObject_ouka target = spawner.currentTarget;

        if (target != null)
        {
            float ratio = (float)target.currentHP / target.maxHP;
            hpBar.fillAmount = ratio;
        }
        else
        {
            hpBar.fillAmount = 0;
        }
    }
}
