using UnityEngine;
using System.Collections.Generic;

public class PuzzleManager : MonoBehaviour
{
    GameObject pieceHold = null;
    public List<Piece> allPieces = new List<Piece>();

    void Update()
    {
        if (Input.GetMouseButtonDown(0))  
        {
            RaycastHit2D hit; 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 

            hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null)
            {
                if (pieceHold == null && hit.collider.gameObject.GetComponent<Piece>() != null)
                {
                    pieceHold = hit.collider.gameObject;
                    pieceHold.GetComponent<Piece>().Selected();
                    Debug.Log("plaplaspdlasd  11");
                }
                else if (pieceHold != null && hit.collider.gameObject.GetComponent<Piece>() != null && pieceHold == hit.collider.gameObject)
                {

                }
                else if (pieceHold != null && hit.collider.gameObject.GetComponent<Piece>() != null)
                {
                    pieceHold.GetComponent<Piece>().Selected();
                    pieceHold = hit.collider.gameObject;
                    pieceHold.GetComponent<Piece>().Selected();
                    Debug.Log("plaplaspdlasd  2222");
                } else if (pieceHold != null && hit.collider.gameObject.GetComponent<Position>() != null)
                {
                    Vector3 positionSelected = hit.collider.gameObject.transform.position;
                    pieceHold.GetComponent<Piece>().Selected();
                    pieceHold.transform.position = new Vector3(positionSelected.x, positionSelected.y, pieceHold.transform.position.z);
                    pieceHold = null;
                    Debug.Log("plaplaspdlasd  3333");
                } 
            }
        }

        bool solved = true;
        foreach (Piece obj in allPieces)
        {
            if(!obj.IsMatch())
            {
                solved = false;
            }
        }

        if (!solved)
        {
            Debug.Log("Ma cac\n");
        }
        else
        {
            Debug.Log("Bravooooooooooo\n");
        }
    }

    public void ResetPieces()
    {
        foreach (Piece obj in allPieces)
        {
            if(!obj.IsMatch())
            {
                obj.ResetPosition();
            }
        }
    }
}
