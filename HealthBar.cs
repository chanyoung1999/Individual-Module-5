using UnityEngine;
public class HealthBar : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Gradient gradient;

    public Image PlayerHealthBar;
    public Text Fraction;
    public Text Percent;


 
     // Use t$$anonymous$$s for initialization
     
     // Update is called once per frame


    void Start()
    {
        currentHealth = maxHealth;
	    Fraction.text = curHealth + "/" + maxHealth;
        Percent.text = (curHealth/maxHealth) * 100 + "%";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
    }


    void TakeDamage(int damage)
    {
        currentHealth -= damage;








    }
}
