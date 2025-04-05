using UnityEngine;
using UnityEngine.UI;

public class ChangeTimeImage : MonoBehaviour
{
    private Image image;
    
    public Sprite doctor;
    public Sprite patient;
    public Sprite visitor;


    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            image.sprite = doctor;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            image.sprite = patient;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            image.sprite = visitor;
        }

    }
}