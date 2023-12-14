﻿using UnityEngine;

namespace TheColorsMod_C21341.Kamiyo
{
    public class AuraColor : MonoBehaviour
    {
        private void Start()
        {
            var ps = GetComponentInChildren<ParticleSystem>();
            var col = ps.colorOverLifetime;
            col.enabled = true;
            col.color = new Color(0, 0, 0, 0.321f);
        }
    }
}