using Unity.VisualScripting;
using UnityEngine;

public class DestroyItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log("Item Kazana Atýldý ve Kayboldu");
        if (other.CompareTag("Item"))
        {
            Destroy(other.GameObject());
        }
    }

}
