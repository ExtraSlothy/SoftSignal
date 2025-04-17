using UnityEngine;

public class FragmentPickup : MonoBehaviour
{
    public bool isMainQuest = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Call the JournalUI and pass whether it’s a main fragment
            FindObjectOfType<JournalUI>().AddFragment(isMainQuest);

            Destroy(gameObject); // remove the fragment after collection
        }
    }
}

