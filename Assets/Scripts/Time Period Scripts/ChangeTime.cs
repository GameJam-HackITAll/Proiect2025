using UnityEngine;

public class ChangeTime : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private Color doctor = new Color(1, 0.5f, 0, 0.02f);
    private Color patient = new Color(0, 0.5f, 1, 0.02f);
    private Color visitor = new Color(1, 1, 1, 0);

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            spriteRenderer.color = doctor;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spriteRenderer.color = patient;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            spriteRenderer.color = visitor;
        }

    }
}