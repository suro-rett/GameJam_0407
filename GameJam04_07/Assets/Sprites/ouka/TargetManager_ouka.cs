using UnityEngine;

public class TargetManager_ouka : MonoBehaviour
{
    public TargetObject_ouka currentTarget;

    public void SetTarget(TargetObject_ouka target)
    {
        currentTarget = target;
    }

    public void OnTargetDestroyed(TargetObject_ouka target)
    {
        if (currentTarget == target)
        {
            currentTarget = null;
        }
    }
}
