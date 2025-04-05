using UnityEngine;

public abstract class InteractableObject : MonoBehaviour
{
    private Vector3 initialScale;
    public float scaleRate = 1.5f;
    public Sprite normal;
    public Sprite highlight;
    public abstract void Interact(); 

    void Awake()
    {
        initialScale = transform.localScale;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))  
        {
            RaycastHit2D hit; 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 

            hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                Debug.Log("ceva");
                Interact(); 
            }
        }
    }

    private void OnMouseEnter()
    {
        ScaleObject(true);
    }

    private void OnMouseExit()
    {
        ScaleObject(false);
    }

    private void ScaleObject(bool increase)
    {
        if (increase)
        {
            transform.localScale = initialScale * scaleRate;
            GetComponent<SpriteRenderer>().sprite = highlight;
        }
        else
        {
            transform.localScale = initialScale;
            GetComponent<SpriteRenderer>().sprite = normal;
        }
    }
}
