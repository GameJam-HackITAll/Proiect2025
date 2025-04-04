using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArtifactUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI artifactText;
    [SerializeField] Image artifactImage;

    private Color hammerOrange = new Color(1, 0.5f, 0);
    private Color bowGreen = new Color(0.66f, 1, 0);
    private Color wingsYellow = new Color(1, 1, 0.33f);
    private Color torchRed = new Color(1, 0, 0);
    private Color tridentBlue = new Color(0.33f, 0.66f, 1);

    // Start is called before the first frame update
    void Start()
    {
        artifactText.text = "No artifact";
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            artifactImage.color = hammerOrange;
            artifactText.text = "Hammer";
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            artifactImage.color = bowGreen;
            artifactText.text = "Bow";
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            artifactImage.color = wingsYellow;
            artifactText.text = "Wings";
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            artifactImage.color = torchRed;
            artifactText.text = "Torch";
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            artifactImage.color = tridentBlue;
            artifactText.text = "Trident";
        }
    }
}