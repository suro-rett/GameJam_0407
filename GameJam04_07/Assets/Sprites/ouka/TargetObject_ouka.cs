using UnityEngine;

public class TargetObject_ouka : MonoBehaviour
{
    public int maxHP = 10;
    public int currentHP;
    public float speed = 5f;

    Spawn_ouka spawner;

    TargetManager_ouka manager;
    bool isTarget = false;

    void Start()
    {
        currentHP = maxHP;
        manager = FindFirstObjectByType<TargetManager_ouka>();
        spawner = FindFirstObjectByType<Spawn_ouka>(); // ★追加
    }

    void Update()
    {
        // ターゲットじゃない時だけ動く
        if (!isTarget)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        // 中央に来たら止める
        if (!isTarget && Mathf.Abs(transform.position.x) < 0.5f)
        {
            Debug.Log("中央きた");

            isTarget = true;

            // ★ピタッと止める
            transform.position = new Vector3(0f, transform.position.y, transform.position.z);

            manager.SetTarget(this);
        }
    }

    public void Damage(int amount)
    {
        currentHP -= amount;

        if (currentHP <= 0)
        {
            currentHP = 0;

            manager.OnTargetDestroyed(this);

            spawner.OnTargetDestroyed(); // ★変更

            Destroy(gameObject);

            // 左へ流して消す or 演出
        }
    }
}
