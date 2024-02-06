using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class life : MonoBehaviour
{


    [SerializeField] private GameObject life1;
    [SerializeField] private GameObject life2;
    [SerializeField] private GameObject life3;
    public int lifeTotal = 3;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") || other.CompareTag("Enemy 2"))
        {
            if (lifeTotal == 3)
            {
                Destroy(life1);
                lifeTotal--;
            }
            else if (lifeTotal == 2)
            {
                Destroy(life2);
                lifeTotal--;
            }
            else if (lifeTotal == 1)
            {
                Destroy(life3);
                lifeTotal--;
            }
            
        }
       
    }

    private void Update()
    {
        if (lifeTotal == 0)
        {
            MainManager.Instance.score = gameObject.GetComponent<score>().scoreVal;
            SceneManager.LoadScene(2);

        }
        
    }
}
