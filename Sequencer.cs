using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nico.Sequencing
{
    public class Sequencer : MonoBehaviour
    {
        [ SerializeField ] private List< Sequence > sequences = new List< Sequence >();

        void Start()
        {
            StartSequence();
        }

        public async void StartSequence()
        {
            foreach( Sequence s in sequences )
            {
                await s.BeginSequence();
            }
        }
    }
}