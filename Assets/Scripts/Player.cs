using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public List<Material> materiales = new List<Material>();

    //public GameObject jugador;

    public GameObject jugador;


    public GameObject [] jugadores = new GameObject[5];

    

    private Renderer rend;

   
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();

       
        
        StartCoroutine(Coroutine());

        StopCoroutine(Coroutine());
     
        //Invoke("LaunchJugador", 5.0f);
        
        //Instantiate(jugador,new Vector3(Random.Range(-5f, 5f),Random.Range(-5f, 5f),Random.Range(-5f, 5f)),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void AsignarColor()
        {

            rend.material = materiales[Random.Range(0, 10)];

          
        }





        IEnumerator Coroutine(){
     
            yield return new WaitForSeconds(5); 
            Instantiate(jugador,new Vector3(Random.Range(-5f, 5f),Random.Range(-5f, 5f),Random.Range(-5f, 5f)),Quaternion.identity);
            AsignarColor();
           
            
            yield break;
            

            
            
            /*for(int i =0; i < 5;i++){
                yield return new WaitForSeconds(5);
                jugadores[i] = Instantiate(jugador,new Vector3(Random.Range(-5f, 5f),Random.Range(-5f, 5f),Random.Range(-5f, 5f)),Quaternion.identity);
                AsignarColor();
        
            }*/
        
        }
        


        

        


             

            
           
            
            
            
            
            
            

        

        
   
}
