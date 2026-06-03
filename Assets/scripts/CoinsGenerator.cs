using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsGenerator : MonoBehaviour
{

    public ObjectPooler coinPooler;

    public void SpawnCoins(Vector3 position, float groundWidth)
    {


        int numberOfCoins = (int)Random.Range(3f, groundWidth);
        

        for (int i = 0; i < numberOfCoins; i++)
        {
            GameObject coin = coinPooler.GetPooledGameObject();
            
            coin.transform.position = new Vector3(
                position.x-(groundWidth/2)+i+1,
                position.y+2,
                0
            ); 

            coin.SetActive(true);
        }



    }


}
