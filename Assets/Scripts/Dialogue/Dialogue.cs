using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Dialogue : MonoBehaviour
{
    public TMP_Text dialogueText;  // Uncomment if you're using TextMesh Pro\
    [SerializeField] public Image playerImage;
    [SerializeField] public Image npcImage;
    [SerializeField] public Image backgroundImage;

    private int currentDialogueIndex = 0;
    private bool isDialogueActive = false;
    private string[] currentDialogue;

    private string[] introductionDialogue = {
        "Narrator: Welcome to the game!",
        "Narrator: Here, you'll begin your adventure."
    };

    private string[] wife1Dialogue = {
        "Jake: How have you been?",
        "Crissy: Let's play a game.",
        "Jake: Of course."
    };

    private string[] nurseDialogue = {
        "Nurse Mary: Leave your wife",
        "Jake: I will"
    };

    private string[] wife2Dialogue = {
        "Crissy: You cheated on me!",
        "Jake: It's your fault!"
    };

    void StartDialogue(string[] dialogue)
    {
        // Initialize the dialogue sequence
        currentDialogueIndex = 0;
        isDialogueActive = true;
        ShowDialogue(dialogue);
    }

    void ShowDialogue(string[] dialogue)
    {
        if (currentDialogueIndex < dialogue.Length)
        {
            dialogueText.text = dialogue[currentDialogueIndex];
        }
        else
        {
            isDialogueActive = false;
            dialogueText.text = "";
            DialogueUIVisibility(0, 0, 0); // Hide all UI elements

        }
    }

    void DialogueUIVisibility(int player, int npc, int background)
    {
        playerImage.color = new Color(1, 1, 1, player);
        npcImage.color = new Color(1, 1, 1, npc);
        backgroundImage.color = new Color(1, 1, 1, background);
    }

    void Start()
    {
        DialogueUIVisibility(1, 0, 1);
        currentDialogue = introductionDialogue;
        StartDialogue(currentDialogue);
    }

    void Update()
    {
        if (isDialogueActive && Input.GetKeyDown(KeyCode.Space))
        {
            currentDialogueIndex++;
            ShowDialogue(currentDialogue);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            DialogueUIVisibility(1, 1, 1);
            currentDialogue = wife1Dialogue;
            StartDialogue(currentDialogue);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            DialogueUIVisibility(1, 1, 1);
            currentDialogue = nurseDialogue;
            StartDialogue(currentDialogue);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            DialogueUIVisibility(1, 1, 1);
            currentDialogue = wife2Dialogue;
            StartDialogue(currentDialogue);
        }
    }


}
