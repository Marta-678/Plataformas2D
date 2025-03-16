// using UnityEngine;

// public class CheckPointController : MonoBehaviour
// {
//    public  static CheckPointController instance;
//    public CheckPoint[] checkPoints;

//    public Vector2 spawnPoint;
//     void Awake()
//     {
//         instance=this;
//     }
//     void Start()
//     {
//         checkPoints= FindObjectsOfType<CheckPoint>();
//         // spawnPoint= PlayerController.instance.transform.position;
//     }

//     public void DesactivateCheckPoints(){
//         for(int i=0; i<checkPoints.Length;i++){
//             checkPoints[i].ResetCheckPoint();
//         }
//     }

//     public void SetSpawnPoint(Vector3 newSpawnPoint){
//         spawnPoint= newSpawnPoint;
//     }
// }

