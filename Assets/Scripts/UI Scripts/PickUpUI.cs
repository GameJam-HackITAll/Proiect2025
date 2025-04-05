using UnityEngine;
using UnityEngine.UI;

public class PickUpUI : MonoBehaviour
{
    private Image image;
    
    public Sprite key;
    public Sprite card;

    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        // de integrat pick ups
    }
}