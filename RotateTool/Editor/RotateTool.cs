using UnityEngine;

public class RotateTool : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.rotation *= Quaternion.Euler(0, 45, 0);
        }
    }
}