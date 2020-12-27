using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectScript : MonoBehaviour
{
    public List<string> items;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Can"))
        {
            string itemType = collision.gameObject.GetComponent<CollectSriptForItem>().itemType;
            print("COLLECTED A "+ itemType);
            Destroy(collision.gameObject);
            items.Add(itemType);
            print("Item length: "+ items.Count);

            if (items.Count == 3)
            {
                SceneManager.ShowNextLevelScreen("NextLevelScene");
            }
            
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        items = new List<string>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
