using System.Collections;
using Assets.Scripts.Enemies.Bullets;
using UnityEngine;

namespace Assets.Scripts.Enemies
{
    public class EnemyAttacker : Attacker<EnemyBullet>
    {
        private void OnEnable() =>
            StartCoroutine(CooldownAttack());

        private void OnDisable() =>
            StopAllCoroutines();

        protected override Vector2 GetDirection() =>
            -transform.right;

        protected override IEnumerator CooldownAttack()
        {
            yield return Wait;

            Attack();
        }
    }
}