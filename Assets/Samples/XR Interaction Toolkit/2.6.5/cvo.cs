using UnityEngine;

public class SimpleAirplane : MonoBehaviour
{
    void Update()
    {
        Vector3 target = new Vector3(-2f, 12.5f, 20.5f);
        transform.position = Vector3.MoveTowards(transform.position, target, 5f *Time.deltaTime);
    }
}
