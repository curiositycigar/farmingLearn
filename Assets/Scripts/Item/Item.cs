using UnityEngine;

public class Item : MonoBehaviour
{
    //[Range(10000, 10100)]
    [ItemCodeDescription]
    [SerializeField]
    private int _itemCode;

    private SpriteRenderer spriteRenderer;

    public int ItemCode
    {
        get { return _itemCode; }
        set { _itemCode = value; }
    }

    private void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        if (ItemCode != 0)
        {
            Init(ItemCode);
        }
    }

    public void Init(int ItemCodeParam)
    {

    }
}
