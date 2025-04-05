using UnityEngine;

public class Piece : MonoBehaviour
{
    bool selected = false;
    private Vector3 initialScale;
    public Vector3 initialPosition;
    public float scaleRate = 1.5f;
    public GameObject matchSpace = null;

    void Awake()
    {
        initialScale = transform.localScale;
        initialPosition = transform.position;
    }

    void Update()
    {
        if (IsMatch())
        {
            Destroy(GetComponent<Collider2D>());
        }
    }

    public void Selected()
    {
        selected = !selected;
        ScaleObject(selected);
    }

    private void ScaleObject(bool increase)
    {
        if (increase)
        {
            transform.localScale = initialScale * scaleRate;
        }
        else
        {
            transform.localScale = initialScale;
        }
    }

    public bool IsMatch()
    {
        return transform.position.x == matchSpace.transform.position.x && transform.position.y == matchSpace.transform.position.y;
    }

    public void ResetPosition()
    {
        transform.position = initialPosition;
    }
}
