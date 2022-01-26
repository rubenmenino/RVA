using System.Collections;
using System.Linq;
using UnityEngine;

public class fallCilinder3 : MonoBehaviour
{
    public Rigidbody[] cylinders;
    public float time = 1.3f;

    private void Start()
    {
        foreach (Rigidbody rigidbody in cylinders)
            rigidbody.useGravity = false;
        StartCoroutine(dropRandomly());
    }

    public IEnumerator dropRandomly()
    {
        foreach (var rigidbody in cylinders.OrderBy(r => Random.value))
        {
            Debug.Log($"Waiting {time:0.0} seconds...");
            yield return new WaitForSeconds(time);
            Debug.Log($"Dropping {rigidbody.name}...");
            rigidbody.useGravity = true;
        }
        Debug.Log("All dropped!");
    }

    

}
