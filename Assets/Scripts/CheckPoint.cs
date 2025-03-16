using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class CheckPoint : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
       
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
            // CheckPointController.instance.DesactivateCheckPoints();
            // // spriteRenderer.sprite=cpOn;

            // CheckPointController.instance.SetSpawnPoint(transform.position);


    }
}
