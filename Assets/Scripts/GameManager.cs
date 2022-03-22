using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Material> materiales = new List<Material>();

    public List<Material> materialesUsados = new List<Material>();

    public GameObject jugador;

    public Renderer rend;

    void Start()
    {
        rend = jugador.GetComponent<MeshRenderer>();       
        StartCoroutine(SpawnPlayerCoroutine());
  
    }

    public void AsignarColor()
        {
            rend.sharedMaterial = materiales[Random.Range(0, 9)];
            materialesUsados.Add(rend.sharedMaterial); 
            materiales.Remove(rend.sharedMaterial);      
        }



        
        IEnumerator SpawnPlayerCoroutine(){

            int limit = 0;
            while(limit < 6){
                yield return new WaitForSeconds(5);   
                AsignarColor();
                Instantiate(jugador,new Vector3(Random.Range(-5f, 5f),3,Random.Range(-5f, 5f)),Quaternion.identity);
                limit ++;         
            }
        }   
}
