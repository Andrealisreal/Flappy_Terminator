using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Enemies
{
    public class Enemy : MonoBehaviour, IDamageable
    {
        public void Die()
        {
            throw new System.NotImplementedException();
        }
    }
}
