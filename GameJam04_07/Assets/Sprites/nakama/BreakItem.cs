using UnityEngine;

public class BreakItem : MonoBehaviour
{
    public int HP;
    public int MAXHP;
    public int Score;
    public Sprite Image;
    public Sprite BreakImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = MAXHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O) || HP <= 0)
        {
            GetComponent<SpriteRenderer>().sprite = BreakImage;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = Image;
        }
    }
}
