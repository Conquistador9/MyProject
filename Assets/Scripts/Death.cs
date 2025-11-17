using UnityEngine;

public class Death : MonoBehaviour
{
    private void Update()
    {
        if((transform.position.y < -10.2f) || (transform.position.z < -26.7f))
            Destroy(gameObject);
    }
}