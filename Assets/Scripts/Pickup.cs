using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class Pickup : MonoBehaviour
{

    // public bool isItem, isCollected;
    [SerializeField] private float heigth, speed;
    [SerializeField] private LayerMask whatIsGround;
    
    private Vector2 initPosition;
    private bool collision;

    void Start()
    {
        initPosition=transform.position;
    }

    void Update()
    {
        float yPos = Mathf.Sin(Time.time * speed) * heigth;
        transform.position = initPosition + new Vector2(0, yPos);
        // collision= isCollected();
        // if(collision){
        //     Debug.Log("Objeto recogido, eliminando...");
        //     Destroy(this);
        // }
    }

    // private bool isCollected(){
    //    // Physics.OverlapSphere
    //    return Physics.CheckSphere(transform.position, 0.3f,whatIsGround);

    // }

    private void OnTriggerEnter2D(Collider2D other){
        // if(other.CompareTag("Player"))
        // {
            // if(isItem)
            // {
                // LevelManager.instance.itemCollected++;
                // actualizar el menú con los items

                // isCollected = true;
                Debug.Log("Objeto recogido, eliminando...");
                Destroy(gameObject);
            // }
            // else
            // {
            //     Debug.Log("No es un item");
            // }
        // }
        // else
        // {
        //     Debug.Log("No colisionó con el jugador o ya fue recogido");
        // }
    }

}
