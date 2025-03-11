using UnityEngine;

public class TriggerSection : MonoBehaviour
{
    public GameObject trainPrefab;
    
   private void OnTriggerEnter(Collider other){
    if(other.gameObject.tag == "Trigger"){
        Instantiate(trainPrefab, new Vector3(-1.656637f,5.85555f, 30f), Quaternion.identity);
    }
    }
}
