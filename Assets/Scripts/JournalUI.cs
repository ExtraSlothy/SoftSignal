using UnityEngine;
using TMPro;

public class JournalUI : MonoBehaviour
{
    public GameObject journalPanel;
    public TextMeshProUGUI fragmentText;

    public int mainFragments = 0;
    public int sideFragments = 0;

    public void ToggleJournal()
    {
        journalPanel.SetActive(!journalPanel.activeSelf);
        UpdateFragmentText();
    }

    public void AddFragment(bool isMain)
{
    if (isMain)
        mainFragments++;
    else
        sideFragments++;

    UpdateFragmentText(); // update UI immediately
}

    void UpdateFragmentText()
    {
        fragmentText.text = 
            "Main Quest Fragments: " + mainFragments + "\n" +
            "Side Quest Fragments: " + sideFragments;
    }
}

