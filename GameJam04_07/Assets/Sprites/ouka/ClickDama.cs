using UnityEngine;

public class ClickDama : MonoBehaviour
{
    public TargetManager_ouka manager;
    public int damage = 1;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ƒNƒŠƒbƒN
        {
            if (manager.currentTarget != null)
            {
                manager.currentTarget.Damage(damage);
            }
        }
    }
}
