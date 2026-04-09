using UnityEngine;

public class Spawn_ouka : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform spawnPoint;

    public TargetObject_ouka currentTarget; // š‚±‚ê’Ç‰Á

    void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        int index = Random.Range(0, prefabs.Length);
        GameObject obj = Instantiate(prefabs[index], spawnPoint.position, Quaternion.identity);

        currentTarget = obj.GetComponent<TargetObject_ouka>(); // š‚±‚±d—v
    }

    public void OnTargetDestroyed()
    {
        currentTarget = null;
        Invoke(nameof(Spawn), 0.5f);
    }

}
