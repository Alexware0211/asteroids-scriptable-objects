using UnityEngine;

namespace Ship
{
    public class Health : MonoBehaviour
    {
        public PlayerSettings playerStats;

        private int _health = 10;
        
        private const int MIN_HEALTH = 0;

        private void Start()
        {
            SetHealth();
        }

        public void SetHealth()
        {
            _health = playerStats.PHealth;
        }
        public void TakeDamage(int damage)
        { 
            Debug.Log("Took some damage");
            _health = Mathf.Max(MIN_HEALTH, _health - damage);
        }
    }
}
