using System.Threading.Tasks;
using UnityEngine;

namespace Nico.Sequencing
{
    public abstract class Sequence : MonoBehaviour
    {
        /// <summary>
        ///     The interval in which the asynchonous method will check if the sequence has completed, in miliseconds.
        /// </summary>
        protected int sequenceCheckInterval = 1000;


        /// <summary>
        ///     The flag to check whenever the sequence is complete or not
        /// </summary>
        private bool sequenceComplete = false;


        /// <summary>
        ///     The first method to be called as the sequence begins. Put everything you need here before the waiting starts like
        ///     event listeners.
        /// </summary>
        internal abstract void InitializeSequence();


        /// <summary>
        ///     This method will be called after the sequence ends. Anything you need to clean-up, put it here. Feel free to leave it blank
        /// </summary>
        internal abstract void ExitSequence();
        

        /// <summary>
        ///     Call this method when your sequence has completed
        /// </summary>
        internal void CompleteSequence()
        {
            sequenceComplete = true;
        }


        /// <summary>
        ///     Simple async method that waits for the sequence to complete.
        /// </summary>
        internal async Task BeginSequence()
        {
            while( !sequenceComplete )
            {
                await Task.Delay( sequenceCheckInterval );
            }
        }
    }
}