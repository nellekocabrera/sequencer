using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace Nico.Sequencing
{
    public class Sequence : MonoBehaviour
    {
        private int sequenceCheckInterval = 1000;
        protected bool sequenceComplete = false;

        internal async Task BeginSequence()
        {
            while( !sequenceComplete )
            {
                await Task.Delay( sequenceCheckInterval );
            }
        }
    }
}