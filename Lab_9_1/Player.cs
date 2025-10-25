using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    internal class Player
    {
        public void Main(string[] args)
        {
            Player player = new Player();
            player.OnDeath += () => Console.WriteLine("Враги празднуют победу!");
            player.OnDeath += ShowGameOver;
            player.TakeDamage(100);
        }
        static void ShowGameOver() => Console.WriteLine("GAME OVER");

        public event Action OnDeath;
        private int health = 100;

        private void Die()
        {
            Console.WriteLine("Игрок погиб!");
            OnDeath?.Invoke();
        }
        public void TakeDamage(int damage)
        {
            health -= damage;
            if (health <= 0)
            {
                Die();
            }
        }
    }
}
