using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    
    public int health;
    public GameObject[] HealthUI ;
    void takedamage(){
    health--;
    if (health <= 0){
        health = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    HealthUI[health].SetActive(false);
}
private void OnTriggerEnter2D(Collider2D collision) {
    if (collision.CompareTag("enemy")){
        takedamage();
    }
    else if(collision.CompareTag("spike")){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
private void OnCollisionEnter2D(Collision2D other) {
    if (other.collider.CompareTag("spike"))
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
}
