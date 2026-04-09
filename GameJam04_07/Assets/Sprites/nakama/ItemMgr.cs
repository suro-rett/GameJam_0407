using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class ItemMgr : MonoBehaviour
{
    public static ItemMgr instance { get; private set; }

    public List<GameObject> prefabBreakItem;
    public GameObject prefabEffect;
    public GameObject NowItem = null;
    GameObject beforeItem = null;
    GameObject afterItem = null;
    public float MoveSpeed = 50f;
    public int score = 0;


    [SerializeField] public GameObject Item;          // アイテムを生成する場所
    [SerializeField] public GameObject effect;        // エフェクトを生成する場所
    [SerializeField] public GameObject time;

    /*    [Serializable]
        public enum ItemName
        {
            school,
            watermelon,
            bard,
            tile,
            cake,
            balloon
        }*/

    /*    [SerializeField]
        public Dictionary<ItemName, string> ItemData = new Dictionary<ItemName, string>()
        {
            {ItemName.school,"school" },
            {ItemName.watermelon,"watermelon" },
            {ItemName.bard,"bard" },
            {ItemName.tile,"tile" },
            {ItemName.cake,"cake" },
            {ItemName.balloon,"balloon" },
        };
    */
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else { instance = this; }

        NowItem = RandomItem();
        beforeItem = RandomItem();
        NowItem.transform.position = new Vector3(0, 0, 0); 
    }

    // Update is called once per frame
    void Update()
    {
        if (NowItem.GetComponent<BreakItem>().HP == 0)
        {
            NowItem.GetComponent<BreakItem>().HP--;
            score += NowItem.GetComponent<BreakItem>().Score;
        }
        if (NowItem.GetComponent<BreakItem>().HP <= 0)
        {
            NowItem.transform.position += new Vector3(-Time.deltaTime * MoveSpeed,0.0f, 0.0f);
        }

        if(NowItem.transform.position.x < -11.0f)
        {
            NowItem.transform.position = new Vector3(-11.0f, 0.0f, 0.0f);
            if (beforeItem) { beforeItem.transform.position = new Vector3(NowItem.transform.position.x + 11, NowItem.transform.position.y, 0); }
            if (afterItem) { afterItem.transform.position = new Vector3(NowItem.transform.position.x - 11, NowItem.transform.position.y, 0); }

            Destroy(afterItem);
            afterItem = NowItem;
            NowItem = beforeItem;
            beforeItem = RandomItem();
        }

        if (Input.GetKeyDown(KeyCode.Space) && NowItem.GetComponent<BreakItem>().HP >= 1 && NowItem.transform.position == new Vector3(0, 0, 0) && time.GetComponent<Timer_ouka>().time>0)
        {
            RandomEffect();
            NowItem.GetComponent<BreakItem>().HP--;
        }

        if (beforeItem) { beforeItem.transform.position = new Vector3(NowItem.transform.position.x + 11, NowItem.transform.position.y, 0); }
        if (afterItem) { afterItem.transform.position   = new Vector3(NowItem.transform.position.x - 11, NowItem.transform.position.y, 0); }
    } 

    GameObject RandomItem()
    {
        return Instantiate(prefabBreakItem[UnityEngine.Random.Range(0, prefabBreakItem.Count)],Item.transform);
    }

    GameObject RandomEffect()
    {
        return Instantiate(prefabEffect, effect.transform);
    }
}
